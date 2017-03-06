using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1DPR
{
    public partial class Form1 : Form
    {
        List<int> currentQueue;                         //stores the current queue
        List<int> currentList = new List<int>();        //list from which to search for items in the queue
        int startingPosition;                           //stores the starting head position
        int totalTraveled;                              //stores the total distance traveled using the selected algorithm
        ISeek seekInstance;                             //creates an ISeek interface instance for all 3 classes that implement it
        
        public void Reset()             //re-assigns the values of currentList, currentQueue and startingPosition
        {
            currentList.Clear();
            for (int i = 0; i < 100; i++)
            {
                currentList.Add(i);
            }
            currentQueue = new List<int>(new int[] { 60, 10, 41 });
            startingPosition = 50;
        }

        public Form1()                  //initializes the form and assigns values to the currentList, currentQueue and currentPosition variables, then adds info about the assigned values in the form
        {
            InitializeComponent();
            this.Reset();
            label1.Text = "Starting head position: " + startingPosition;
            label2.Text = "Queue: " + string.Join(", ", currentQueue.ToArray());
            label3.Text = "Searching from all numbers between " + currentList[0] + " and " + currentList[currentList.Count-1];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                totalTraveled = 0;                          //resets the value of totalTraveled

                this.seekInstance = new FCFS();             //assigns the First Come First Serve implementation to seekInstance
                totalTraveled = this.seekInstance.seek(currentList, currentQueue, startingPosition);
                this.Reset();

                if (totalTraveled != 0) { listBox1.Items.Add("FCFS travel distance: " + totalTraveled); }       //checks if the method has been completed and returned a non-null value for the travel distance
                else { MessageBox.Show("An error occured when using FCFS"); }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                totalTraveled = 0;                          //resets the value of totalTraveled

                this.seekInstance = new SSTF();             //assigns the Shortest Seek Time First implementation to seekInstance
                totalTraveled = this.seekInstance.seek(currentList, currentQueue, startingPosition);
                this.Reset();

                if (totalTraveled != 0) { listBox1.Items.Add("SSTF travel distance: " + totalTraveled); }       //checks if the method has been completed and returned a non-null value for the travel distance
                else { MessageBox.Show("An error occured when using SSTF"); }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                totalTraveled = 0;                          //resets the value of totalTraveled

                this.seekInstance = new Elevator();         //assigns the Elevator implementation to seekInstance
                totalTraveled = this.seekInstance.seek(currentList, currentQueue, startingPosition);
                this.Reset();

                if (totalTraveled != 0) { listBox1.Items.Add("Elevator travel distance: " + totalTraveled); }   //checks if the method has been completed and returned a non-null value for the travel distance
                else { MessageBox.Show("An error occured when using Elevator"); }
            }
        }
    }
}
