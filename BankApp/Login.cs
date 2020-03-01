using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Login : Form
    {




        static int attempt = 3;
        public Login()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usrtxt.Text;
            string password = passtxt.Text;

            if ((this.usrtxt.Text == "Admin") && (this.passtxt.Text == "admin"))
            {
                attempt = 0;

                MessageBox.Show("you are granted with access");


            }
            else if ((attempt == 3) && (attempt > 0))
            {

                label3.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                --attempt;
            }
            else
            {

                MessageBox.Show("you are not granted with access");
            }







        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
