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
    public partial class Main : Form
    {
        public Counter subject;
        public Counter Subject { get { return subject; } }
        public Main()
        {
            subject = new Counter();
            InitializeComponent();
            subject.RegisterObserver(new formText(this));
            subject.RegisterObserver(new formRectangle(this));
            subject.RegisterObserver(new formCircle(this));
            foreach(Form obs in subject.GetObservers())
            {
                obs.Show();
            }
        }

        public void obsClosing(IObserver obs)
        {
            subject.UnregisterObserver(obs);
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            subject.Increment();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            subject.Decrement();
        }

        private void btnNewTextObs_Click(object sender, EventArgs e)
        {
            formText temp = new formText(this);
            subject.RegisterObserver(temp);
            temp.Show();
        }

        private void btnNewRectangleObs_Click(object sender, EventArgs e)
        {
            formRectangle temp = new formRectangle(this);
            subject.RegisterObserver(temp);
            temp.Show();
        }

        private void btnNewCircleObs_Click(object sender, EventArgs e)
        {
            formCircle temp = new formCircle(this);
            subject.RegisterObserver(temp);
            temp.Show();
        }
    }
}
