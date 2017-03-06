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
    public partial class formText : Form, IObserver
    {
        private Main parent;
        public formText(Main m)
        {
            InitializeComponent();
            parent = m;
        }

        public void UpdateObs()
        {
            setText(parent.Subject.GetState());
        }
        private void setText(int count)
        {
            lblText.Text = count.ToString();
        }

        private void formText_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.obsClosing((IObserver)this);
        }
    }
}
