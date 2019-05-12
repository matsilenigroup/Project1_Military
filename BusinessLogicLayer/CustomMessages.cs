using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
   public class CustomMessages
    {

        int messageID;
        DateTime ecryptedDateTime;
        string message;
        string decryptionStatus;
        string lastReadUserID;
        string emailUserEnrypted;
        string durationofDecryption;
       public int MessageID
        {
            get { return messageID; }
            set { messageID = value; }
        }
       public DateTime EcryptedDateTime
        {
            get { return ecryptedDateTime; }
            set { ecryptedDateTime = value; }
        }
       public string Message
        {
            get { return message; }
            set { message = value; }
        }
       public string DecryptionStatus
       {
           get { return decryptionStatus; }
           set { decryptionStatus = value; }
       }
       public string LastReadUserID
       {
           get { return lastReadUserID; }
           set { lastReadUserID = value; }
       }
       public string EmailUserEnrypted
       {
           get { return emailUserEnrypted; }
           set { emailUserEnrypted = value; }
       }
       public string DurationofDecryption
       {
           get { return durationofDecryption; }
           set { durationofDecryption = value; }
       }

      public CustomMessages()
      {

      }
    

    }
}
