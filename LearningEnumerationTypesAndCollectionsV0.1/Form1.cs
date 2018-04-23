using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEnumerationTypesAndCollectionsV0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Worker nanny = new Worker(Job.NectarCollector); //Now we can use special values which are included in enum Job.

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = (int)TrickScore.Fetch * 3; //Fetch = 10, so our variable "value" will be 30.
            MessageBox.Show(value.ToString());
            TrickScore score = (TrickScore)value; //In this way we are projecting on TrickScore and our value 30 is speak. That's why we gonna get message "speak".
            MessageBox.Show(score.ToString());
        }
    }
}
