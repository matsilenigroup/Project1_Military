using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer 
{
    public class User
    {
        
        private string name;
        private string surname;
        private int age;
        private string rank;
        private string idnumber;
        private string password;
        private string username;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public string Idnumber
        {
            get { return idnumber; }
            set { idnumber = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        public User()
        {

        }
        public User(string Idnumber, string Name, string Surname, int Age, string Rank, string Password, string Username)
        {
            this.name = Name;
            this.surname = Surname;
            this.age = Age;
            this.rank = Rank;
            this.idnumber = Idnumber;
            this.password = Password;
            this.username = Username;
        }




      


    }
}
