using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandler
{
    public static class CustomFileHandler
    {

        public static string pathNew = @"C:/Users/SEMOSA M/Desktop/Project 1 282 Final/Project 1 282 Final/Project1_282_Final/TextFiles/New/";
        public static string pathOld = @"C:/Users/SEMOSA M/Desktop/Project 1 282 Final/Project 1 282 Final/Project1_282_Final/TextFiles/Old/";
       
        public static List<string> CustomReader(String fileName)
        {
            List<string> data = new List<string>();
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(pathNew + fileName + ".txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        data.Add(line);
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return data;
        }
        public static void CustomWriter(string fileName, string[] data)
        {
          //clear file
            using (FileStream fs = new FileStream(pathNew + fileName+".txt", FileMode.Truncate, FileAccess.Write))
                {  
                  fs.Close();
                }

            //write new data
            using (StreamWriter sw = new StreamWriter(pathNew + fileName + ".txt"))
            {

                foreach (string s in data)
                {
                    sw.WriteLine(s);
                }
            }
        }
   

        public static void MoveFile()
        {
            System.IO.File.Move(pathNew, pathOld);
        }
    
    }
}
