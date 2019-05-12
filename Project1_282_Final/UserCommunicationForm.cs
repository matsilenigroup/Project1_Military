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
using System.Globalization;
namespace Project1_282_Final
{
    public partial class UserCommunicationForm : Form
    {
        User userObj = null;
        public UserCommunicationForm(User user)
        {
            InitializeComponent();
            userObj = user;
            uctextBoxCurrentUser.Text = user.Name + " " + user.Surname;
            dataGridViewOldMessages.DataSource = CustomMessagesModel.ReadAllMesages();
            dgvNewMessages.AllowUserToAddRows = false;
            dataGridViewOldMessages.AllowUserToAddRows = false;

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(txtpath.Text);
          

            //bind data to data grid

            dgvNewMessages.DataSource = CustomFileModel.ReadFileData(txtpath.Text);

        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(richTextBoxEncryptedMessage.Text);

        List<string> dataMessages=CustomFileModel.DecryptData(richTextBoxEncryptedMessage.Text);
            if (dataMessages.Count>0)
            {
                richTextBoxDecryptedMessage.Text = dataMessages[0];
                textBoxStatus.Text = dataMessages[1];
                decryptDurationTxt.Text = dataMessages[2];
               
            }
        }

        private void saveInfoBtn_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(richTextBoxDecryptedMessage.Text);

            //string [] data =  new string[1]{decryptDurationTxt.Text};
            //CustomFileModel.WriteFileData(txtpath.Text, data);4
            string dateTimeDatastr = richTextBoxDecryptedMessage.Text.Substring(0, 19);
            string[] dateTimeData = dateTimeDatastr.Split(' ');
            string msg = richTextBoxDecryptedMessage.Text.ToString();
            int count = msg.Length-19;
            string extractedMsg = msg.Substring(19, count);
            string[] messageArray = extractedMsg.Split('-');

            string newDate = dateTimeData[1] + " " + dateTimeData[0];

            string[] timeDataExtr = dateTimeData[0] .Split(':');


            IFormatProvider culture = new CultureInfo("en-US", true);
            DateTime dateCal = DateTime.ParseExact(dateTimeData[1], "dd/MM/yyyy", culture);

            Console.WriteLine(dateCal.ToLongDateString());
            Console.WriteLine(dateCal.ToLongTimeString());


            dateCal.AddHours(int.Parse(timeDataExtr[0]));
            dateCal.AddMinutes(int.Parse(timeDataExtr[1]));
            dateCal.AddSeconds(int.Parse(timeDataExtr[2]));

            Console.WriteLine(dateCal.ToLongDateString());
            Console.WriteLine(dateCal.ToLongTimeString());


            if (textBoxStatus.Text.Equals("Decrypted"))
            {
            
                    CustomMessages messageObj = new CustomMessages()
                    {
                        Message = messageArray[0],
                        DecryptionStatus = "Read",
                        EcryptedDateTime = dateCal,
                        EmailUserEnrypted = messageArray[1],
                        DurationofDecryption = decryptDurationTxt.Text,
                        LastReadUserID = userObj.Idnumber
                    };

                    CustomMessagesModel.InsertNewMessage(messageObj);
            }
            else
            {
            
                    CustomMessages messageObj = new CustomMessages()
                    {
                        Message = messageArray[0],
                        DecryptionStatus = "Message Incomplete Transmission Recieved",
                        EcryptedDateTime = dateCal,
                        EmailUserEnrypted = messageArray[1],
                        DurationofDecryption = decryptDurationTxt.Text,
                        LastReadUserID = userObj.Idnumber
                    };

                    CustomMessagesModel.InsertNewMessage(messageObj);
             }





            dataGridViewOldMessages.DataSource = CustomMessagesModel.ReadAllMesages();
          

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvNewMessages.SelectedRows)
            {


              //  txtname.Text = row.Cells[0].Value.ToString();
                richTextBoxEncryptedMessage.Text = row.Cells[1].Value.ToString();



            }
        }

        private void datavg_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewOldMessages.SelectedRows)
            {

                richTextBoxMessage.Text = row.Cells[2].Value.ToString();
                textBoxDuration.Text = row.Cells[6].Value.ToString();
                textBoxLastReader.Text = row.Cells[4].Value.ToString();
              


            }
        }


     
    }
}
