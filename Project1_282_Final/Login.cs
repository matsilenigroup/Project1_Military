using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.Threading;
namespace Project1_282_Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        List<User> userlist = null;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //User u = new User();
            string username = txtusername.Text;
            string password = txtpassword.Text;
            bool valid = false;
            bool ranking = false;
           

            userlist = UserDataModel.LoginUser(username, password);

            foreach (User item in userlist)
            {
                if (username == item.Username && password == item.Password && item.Rank == "highranking")
                {
                    ranking = true;
                  
                }
                else if (username == item.Username && password == item.Password && item.Rank != "highranking")
                {
                    valid = true;
                }
            }
            if (ranking)
            {
                 
                MessageBox.Show("Welcome : " + username);
                this.Hide();
                SuperUserForm pf = new SuperUserForm(userlist[0]);
                pf.Show();



            }
            else if (valid)
            {

                MessageBox.Show("Welcome : " + username);



                this.Hide();
                UserCommunicationForm cf = new UserCommunicationForm(userlist[0]);
                cf.Show();



            }
            else
            {
                MessageBox.Show("Incorrect cridentials");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }




        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
            SendKeys.SendWait("{Enter}");//or Esc
        }
    }
}
