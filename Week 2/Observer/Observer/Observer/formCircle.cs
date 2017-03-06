using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class formCircle : Form, IObserver
    {
        private Main parent;
        public formCircle(Main m)
        {
            InitializeComponent();
            parent = m;
        }

        public void UpdateObs()
        {
            updateCircle(parent.Subject.GetState());
        }
        private void updateCircle(int count)
        {
            CreateGraphics().Clear(BackColor);
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Red);
            g.DrawEllipse(pen, 10, 10, count * 10, count * 10);
        }

        private void formCircle_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.obsClosing((IObserver)this);
        }
    }
}
