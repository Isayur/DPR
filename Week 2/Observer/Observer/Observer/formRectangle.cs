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
    public partial class formRectangle : Form, IObserver
    {
        private Main parent;
        public formRectangle(Main m)
        {
            InitializeComponent();
            parent = m;
        }

        public void UpdateObs()
        {
            updateRectangle(parent.Subject.GetState());
        }
        private void updateRectangle(int count)
        {
            CreateGraphics().Clear(this.BackColor);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = CreateGraphics();

            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, count * 10, count * 10));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void formRectangle_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.obsClosing((IObserver)this);
        }
    }
}
