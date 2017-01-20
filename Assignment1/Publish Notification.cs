using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{ 
    
    
    public partial class Publish_Notification : Form
    {
        public Publish_Notification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }


    }
    class Publisher
    {

        //Declare Delegate
        public delegate void PublishMessageDel(string msg);

        //Declare an instance variable which is a Delegate object 
        public PublishMessageDel publishmsg = null;

        //Method used to Invoke Delegate
        public void PublishMessage(string message)
        {

            publishmsg.Invoke(message);
        }
    }
}
