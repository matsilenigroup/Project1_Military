using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Collections;
namespace BusinessLogicLayer
{

  
    public static class UserDataModel
    {
        private static DatabaseConnection dbAccess = DatabaseConnection.GetInstance();

        public static  List<User>  LoginUser(string Username, string Password)
        {
            string qry = string.Format(" select * from  tblUser"+ 
                                       " where Username= '"+Username+"'"+
                                       " and Password ='" + Password + "'");
            Console.WriteLine(qry);
            DataSet data =  dbAccess.SelectFromDataBase("tblUser", qry);
            List<User> userData = (
                                 from DataRow row in data.Tables["tblUser"].Rows
                                 select new User()
                                 {
                                     Idnumber = row["Idnumber"].ToString(),
                                     Name = row["Name"].ToString(),
                                     Age = int.Parse(row["Age"].ToString()),
                                     Surname = row["Surname"].ToString(),
                                     Rank =  row["Rank"].ToString(),
                                     Password= row["Password"].ToString(),
                                     Username=  row["Username"].ToString()
                    
                                 }).ToList();


            return userData;
        }
        public static List<User> GetUsers()
        {
            string qry = string.Format(" select * from  tblUser" );
            DataSet data = dbAccess.SelectFromDataBase("tblUser", qry);
            List<User> userData = (
                                 from DataRow row in data.Tables["tblUser"].Rows
                                 select new User()
                                 {
                                     Idnumber = row["Idnumber"].ToString(),
                                     Name = row["Name"].ToString(),
                                     Age =  int.Parse(row["Age"].ToString()),
                                     Surname = row["Surname"].ToString(),
                                     Rank = row["Rank"].ToString(),
                                     Password = row["Password"].ToString(),
                                     Username = row["Username"].ToString()

                                 }).ToList();


            return userData;
        }
        public static int InsertUser(string Idnumber, string Name, string Surname, int Age, string Rank, string Password, string Username)
        {
                string qry = string.Format("INSERT INTO " + "tblUser"+
                "(Idnumber,Name,Surname,Age,Rank,Password,Username)" +
                " VALUES('{0}','{1}','{2}',{3},'{4}','{5}','{6}')",
                 Idnumber, Name, Surname, Age, Rank, Password, Username);
               int  rows =  dbAccess.InsertDataIntoDatabase(qry);
               Console.WriteLine(" UserDataModel:InsertUser Rows Inserted | " + rows);
               return rows;
        }
        public static int UpdateUser(String IdNumber ,ArrayList list)
        {
                string qry = string.Format("UPDATE tblUser SET Name = '{0}' ,Surname ='{1}',Age = {2},Rank = '{3}',Password = '{4}', Username = '{5}'"+
                       "Where IdNumber ='" + IdNumber + "'",
                list[0], list[1], list[2], list[3], list[4], list[5]);
                Console.WriteLine("UpdateUser :" + qry);

                int rows = dbAccess.UpdateDataInDatabse(qry);
                Console.WriteLine(" UserDataModel:UpdateUser Rows Update | " + rows);
                return rows;
        }
        public static int DeleteUser(String id)
        {
               string qry = string.Format("DELETE FROM tblUser WHERE IdNumber ='{0}'", id);
               int rows = dbAccess.DeleteDataInDatabase(qry);
               Console.WriteLine(" UserDataModel:DeleteUser Rows Update | " + rows);
               return rows;
        }
   
    
    }
}
