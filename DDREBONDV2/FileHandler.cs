using System.Security;
using System;
using System.IO;
using PlayerData;

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


        // quick formatter for player stats
        public static string format(Player player){

            string result = "";

            result += "Players Name: " + player.Name + "\n" + "Class: " + player.PlayerClass + "\n" + 
                "Level: " + player.Level + "\n" + "HP: " + player.HitPoints + "\n" +
                "Strength: " + player.Stats[0] + "\n" + "Dexterity: " + player.Stats[1] + "\n" + "Constitution: " + player.Stats[2] + "\n" +
                "Intelligence: " + player.Stats[3] + "\n" + "Wisdom: " + player.Stats[4] + "\n" + "Initiative: " + player.Stats[5] + "\n" + 
                "Proficiency: " + player.Stats[6] + "\n" + "Charisma: " + player.Stats[7] + "\n" + "\n";

            return result;
        }

    }

}