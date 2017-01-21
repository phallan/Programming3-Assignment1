using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment1
{
    public partial class SubscribeForm : Form
    {
        
       
        Publisher publisher = new Publisher();

        ArrayList emails =new ArrayList();
        ArrayList phones = new ArrayList();

        public SubscribeForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendViaMobile send2Mobile = new SendViaMobile(textBox2.Text);
            SendViaEmail send2Email = new SendViaEmail(textBox1.Text);

            if (checkBox1.Checked == true)
            {
                send2Email.UnSubscribe(publisher);
            }

            if (checkBox2.Checked == true)
            { send2Mobile.UnSubscribe(publisher); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendViaMobile send2Mobile = new SendViaMobile(textBox2.Text);
            SendViaEmail send2Email = new SendViaEmail(textBox1.Text);
            //email checkbox
            if (checkBox1.Checked == true)
            {
                // Check the email is already existed in the list, emails.
                foreach (string x in emails)
                {
                    if (x.Contains(textBox1.Text))
                    {
                        MessageBox.Show("You have alredy subscribed for emails!");
                    }
                }
                // If not subcribe;
               send2Email.Subscribe(publisher);
                //add email to the email collection
                emails.Add(textBox1.Text);
                send2Email.sendEmail("You are subscribed.");
            }
            //mobile checkbox
            if (checkBox2.Checked == true)
            {
                // mobile already existed
                foreach (string x in emails)
                {
                    if (x.Contains(textBox1.Text))
                    {
                        MessageBox.Show("You have alredy subscribed for phone notification!");
                    }
                }
                //if not subscribe
                send2Mobile.Subscribe(publisher);
                //add to phone collection
                phones.Add(textBox2.Text);
                send2Mobile.setMobile("You are subscribed.");
            }
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

       
                string email = textBox1.Text;

                            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

                if (expr.IsMatch(email))
                                MessageBox.Show("valid");

                            else MessageBox.Show("invalid");
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"\+[0-9]{3}\s+[0-9]{3}\s+[0-9]{5}\s+[0-9]{3}");
            if (phoneNumpattern.IsMatch(textBox2.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
        }
    }
}
