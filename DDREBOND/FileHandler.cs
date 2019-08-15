using System;
using System.IO;

// TODO: Make sure to update the outmost namespace to match the solution / project!

namespace ClassPractice
{
    public static class FileHandler
    {

        public static void CreateFile(string fileName, string fileContent) {

            // Get the user specific home directory path
            string homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            try {

                // Generate the file path programatically
                string filePath = Path.Combine(homeDirectory, fileName);

                // Attempt to create a file
                using (StreamWriter sw = File.CreateText(filePath)) {

                    sw.Write(fileContent);

                }

            }
            catch (ArgumentException ae) {

                // TODO: What would be the best way to handle it?
                // This exception is handling the creation of file path
                Console.WriteLine(ae.Message);

            }
            catch (IOException ioe) {

                // TODO: Clarify how to efficiently handle this exception?
                // This exception handles errors in relation to actual
                // operations of the writing of the file
                Console.WriteLine(ioe.Message);

            }

        }

    }

}
