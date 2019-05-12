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
using System.Collections;
using System.Threading;
namespace Project1_282_Final
{
    public partial class SuperUserForm : Form
    {
        User userObj = null;
        public SuperUserForm(User user)
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            userObj = user;
            textBoxCurrentUser.Text = user.Name + " " + user.Surname;
        }


        List<User> userlist = null;
        BindingSource bs = new BindingSource();
        private void PeopleDetailsForm_Load(object sender, EventArgs e)
        {
            GetAllUser();

        }

 private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            /*  

           User selecteduser = (User)bs.Current;
           txtIdnumber.Text = selecteduser.Idnumber.ToString();
           txtname.Text = selecteduser.Name;
           txtage.Text = selecteduser.Age.ToString();
           txtsurrname.Text = selecteduser.Surname;
           txtusername.Text = selecteduser.Username;
           txtrank.Text = selecteduser.Rank;
           txtpassword.Text = selecteduser.Password;*/
        }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {

            string idnumber = txtIdnumber.Text;
            string name = txtname.Text;
            string surname = txtsurrname.Text;
            int age = int.Parse(txtage.Text);
            string rank = txtrank.Text;
            string username = txtsurrname.Text;
            string pasword = txtpassword.Text;
            User inserteduser = new User();
            UserDataModel.InsertUser(idnumber, name, surname, age, rank, pasword, username);
            GetAllUser();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ArrayList dataparms = new ArrayList();
            string idnumber = ((User)bs.Current).Idnumber;
            dataparms.Add(txtname.Text);
            dataparms.Add(txtsurrname.Text);
            dataparms.Add(txtage.Text);
            dataparms.Add(txtrank.Text);
            dataparms.Add(txtpassword.Text);
            dataparms.Add(txtusername.Text);

            UserDataModel.UpdateUser(idnumber.ToString(),dataparms);
            GetAllUser();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User deleteselected = (User)bs.Current;
            UserDataModel.DeleteUser( deleteselected.Idnumber);
            GetAllUser();
            txtIdnumber.Clear();
            txtname.Clear();
            txtage.Clear();
            txtsurrname.Clear();
            txtusername.Clear();
            txtrank.Clear();
            txtpassword.Clear();
        }

        private void btnCommunicationForm_Click(object sender, EventArgs e)
        {

            UserCommunicationForm cf = new UserCommunicationForm(userObj);
            cf.Show();

            MessageBox.Show("Welcome to the communication form");
          //  Thread.Sleep(10000);

            this.Hide();
        }
        public void GetAllUser()
        {
            User u = new User();
            userlist = UserDataModel.GetUsers();
            bs.DataSource = userlist;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bs;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                
                txtIdnumber.Text = row.Cells[4].Value.ToString();
                txtname.Text = row.Cells[0].Value.ToString();
                txtage.Text = row.Cells[2].Value.ToString();
                txtsurrname.Text = row.Cells[1].Value.ToString();
                txtusername.Text = row.Cells[6].Value.ToString();
                txtrank.Text = row.Cells[3].Value.ToString();
                txtpassword.Text = row.Cells[5].Value.ToString();


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdnumber.Clear();
            txtname.Clear();
            txtage.Clear();
            txtsurrname.Clear();
            txtusername.Clear();
            txtrank.Clear();
            txtpassword.Clear();
        }


     
    }
}
