using System;
using System.IO;
using System.Windows.Forms;

namespace Logic
{
    public class ErrorHandler //Class to handle all the errors thrown in the application
    {
        private string path = "log.txt";

        //A singelton pattern to optimize overhead
        private static ErrorHandler instance;

        private ErrorHandler() { }

        public static ErrorHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ErrorHandler();
                }
                return instance;
            }
        }

        //Function to show and log the error
        public void HandleError(string message, string title, Exception e)
        {
            //Show the error as a popup
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Try to log the error to a file
            try
            {
                //Check if the file exists
                if (!File.Exists(path))
                    File.Create(path).Dispose();

                //Write the error to the file
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Error Time: " + DateTime.Now);
                    sw.WriteLine("Error Message: " + e.Message);
                    sw.WriteLine("Stack Trace: " + e.StackTrace);
                    sw.WriteLine();
                }
            }
            catch (Exception) //If there is an error while writing or creating the log file
            {
                MessageBox.Show("De error kon helaas niet in een log gezet worden", "Loggen mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
