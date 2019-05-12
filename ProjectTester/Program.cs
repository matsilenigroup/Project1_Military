using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using BusinessLogicLayer;
using FileHandler;

namespace ProjectTester
{
    class Program
    {
        private static DatabaseConnection dbAccess = DatabaseConnection.GetInstance();
        static void Main(string[] args)
        {

            //Console.WriteLine("Database");

            //dbAccess.OpenConnection();

            ////DataSet data = dbAccess.SelectFromDataBase("tblUser", "select * from tblUser");
            //List<User> userData = (
            //                       from DataRow row in data.Tables["tblUser"].Rows
            //                       select new User() 
            //                       { Idnumber = Convert.ToInt64(row["Idnumber"].ToString()),
            //                         Name = row["Name"].ToString(),
            //                         Surname = row["Surname"].ToString()
            //                       }).ToList();

            //foreach (User item in userData)
            //{
            //    Console.WriteLine("Name : " + item.Name);
            //}

            //write to file
            string[] data = new string[] { "I John Major", "I Jane Major","We Welcome the Defeat of this error Major" };
            Console.Write("Enter your Key: \t");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Encrypted Data:");
            string[] dataEncrypt = new string[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                dataEncrypt[i] = CustomFileCypher.Encipher(data[i], key);
            }
            CustomFileHandler.CustomWriter("NewData", dataEncrypt);





            

            //read from file 
              List<string>   readData = CustomFileHandler.CustomReader("NewData");






            
              foreach (string item in readData)
              {

                  for (int i = 1; i < 9; i++)
                  {
                      if (CustomFileCypher.Decipher(item, i).Contains("Major"))
                      {
                          Console.WriteLine("Decrypted : " + CustomFileCypher.Decipher(item, i));
                          break;
                      }
                      else
                      {
                          Console.WriteLine("Not Decrypted : " + item);
                      }
                    
                  }

                 
              }



            Console.ReadLine();
        }
    }
}
