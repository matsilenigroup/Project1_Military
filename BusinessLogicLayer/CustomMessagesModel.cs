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
   public static class  CustomMessagesModel
    {
       private static DatabaseConnection dbAccess = DatabaseConnection.GetInstance();

        public static int InsertNewMessage(CustomMessages message)
        {
            string qry = string.Format("INSERT INTO " + "tblDecryptedMessageDetails" +
           "(EcryptedDateTime,Message,DecryptionStatus,LastReadUserID,EmailUserEnrypted,DurationofDecryption)" +
           " VALUES('{0}','{1}','{2}',{3},'{4}','{5}')",
            message.EcryptedDateTime, message.Message, message.DecryptionStatus, message.LastReadUserID, message.EmailUserEnrypted,
            message.DurationofDecryption);
            int rows = dbAccess.InsertDataIntoDatabase(qry);
            Console.WriteLine(" CustomMessagesModel:InsertNewMessage Rows Inserted | " + rows);
            return rows;
        }
  
        public static List<CustomMessages> ReadAllMesages()
        {

            string qry = string.Format(" select * from  tblDecryptedMessageDetails where DecryptionStatus='Read'");
                         
            Console.WriteLine(qry);
            DataSet data = dbAccess.SelectFromDataBase("tblDecryptedMessageDetails", qry);
            List<CustomMessages> messagesData = (
                                 from DataRow row in data.Tables["tblDecryptedMessageDetails"].Rows
                                 select new CustomMessages()
                                 {
                                     MessageID = int.Parse(row["MessageID"].ToString()),
                                     EcryptedDateTime = DateTime.Parse( row["EcryptedDateTime"].ToString()),
                                     Message = row["Message"].ToString(),
                                     DecryptionStatus = row["DecryptionStatus"].ToString(),
                                     LastReadUserID = row["LastReadUserID"].ToString(),
                                     EmailUserEnrypted = row["EmailUserEnrypted"].ToString(),
                                     DurationofDecryption = row["DurationofDecryption"].ToString()

                                 }).ToList();


            return messagesData;

        }
    }
}
