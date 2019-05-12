using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CustomFile
    {
        string fileName;
        string message;

    

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }


        public CustomFile(string fileName)
        {
            this.fileName = fileName;
        }
        public CustomFile()
        {

        }

    

    }
}
