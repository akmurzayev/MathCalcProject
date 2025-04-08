using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream_Team
{
    internal class Users
    {
        // Method to check if a user already exists in the file
        public static bool IsExistUsers(string userName)
        {
            // Check if the UsersList file exists
            if (File.Exists("UsersList.txt"))
            {
                // Read all lines from the UsersList file
                string[] lines = File.ReadAllLines("UsersList.txt");

                // Loop through each line and check if the username exists
                for (int i = 0; i < lines.Length; i+= 2)
                {
                    // If the username matches a line, return true (user exists)
                    if (lines[i] == userName)
                    {
                        return true;
                    }
                }
            }
            
            // Return false if no matching username is found
            return false;
        }

        // Method to create a new user and save their username and password to the file
        public static void CreateNewUsers(string userName, string password)
        {
            // Open the UsersList.txt file in append mode to add new data at the end
            FileStream fs = new FileStream("UsersList.txt", FileMode.Append, FileAccess.Write);

            // Create a StreamWriter to write to the file
            StreamWriter sw = new StreamWriter(fs);
            // Write the username and password to the file (each on a new line)
            sw.WriteLine(userName);
            sw.WriteLine(password);

            // Close the StreamWriter and FileStream after writing
            sw.Close();
            fs.Close();
        }

        // Method to get the password of a user by their username
        public static string GetPasswordByUserName(string userName)
        {
            // Check if the UsersList file exists
            if (File.Exists("UsersList.txt"))
            {
                // Read all lines from the UsersList file
                string[] lines = File.ReadAllLines("UsersList.txt");
                // Loop through each line to find the username
                for (int i = 0; i < lines.Length; i++)
                {
                    // If the username matches a line, return the next line (the password)
                    if (lines[i] == userName)
                    {
                        return lines[i + 1]; // The password is on the next line
                    }
                }
            }
            // Return null if the username is not found
            return null;
        }

        public static bool CorrectPass(string userName, string password)
        {
            if (File.Exists("UsersList.txt"))
            {
                string[] lines = File.ReadAllLines("UsersList.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == userName && lines[i + 1] == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

}
