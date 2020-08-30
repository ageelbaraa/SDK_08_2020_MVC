using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpCodes
{
    class Proprities
    {

        private string UserName;
        private string FullName;
        private string Password;
        private bool? Gender = null;

        private int Age;
        public void SetAge(int age)
        {
            if (age > 0 && age < 100)
            {
                Age = age;
            }
        }
        public int GetAge() { return Age; }

        public bool SetUserName(string username)
        {
            if (IsValidUserName(username))
            {
                UserName = username;
                return true;
            }
            return false;
        }

        public string GetUserName() { return UserName; }

        public bool SetFullName(string fullName)
        {
            if (IsValidName(fullName))
            {
                FullName = fullName;
                return true;
            }
            return false;
        }

        public bool SetFullName(string fn, string sn, string ln)
        {
            string name = fn + " " + sn + " " + ln;
            return SetFullName(name);
        }

        public string GetName() { return FullName; }
        public bool SetPassword(string password)
        {
            if (IsValidPassword(password))
            {
                Password = password;
                return true;
            }
            return false;
        }

        public string GetPassword() { return Password; }
        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) ||
                string.IsNullOrWhiteSpace(password) ||
                password.Length < 7)
                return false;

            bool HasDigit = false;
            bool HasUpper = false;
            bool HasLower = false;
            int letters = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (!HasDigit && char.IsDigit(password[i]))
                    HasDigit = true;
                else if (!HasUpper && char.IsUpper(password[i]))
                    HasUpper = true;
                else if (!HasLower && char.IsLower(password[i]))
                    HasLower = true;

                if (char.IsLetterOrDigit(password[i]))
                    letters++;
            }

            return (HasDigit && HasUpper && HasLower && letters >= 6);
        }
        private bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name) || name.Length < 7)
                return false;

            bool HasSpace = false;
            int Letters = 0;

            // Loop to all the charters of fn 
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsDigit(name[i]))
                    return false;

                if (char.IsLetter(name[i]))
                    Letters++;

                if (char.IsWhiteSpace(name[i]))
                    HasSpace = true;
            }

            if (Letters < 6)
                return false;

            if (!HasSpace)
                return false;

            return true;
        }
        private bool IsValidUserName(string username)
        {
            return !string.IsNullOrEmpty(username) && !string.IsNullOrWhiteSpace(username) && username.Length <= 8;
        }

        public bool CheckPassword(string password) { return Password.Equals(password); }

        public bool SetGender(string gender)
        {
            if (gender.ToLower().Equals("male") || gender.ToLower().Equals("m"))
            {
                Gender = true;
                return true;
            }
            if (gender.Equals("female", StringComparison.InvariantCultureIgnoreCase) || gender.Equals("f", StringComparison.InvariantCultureIgnoreCase))
            {
                Gender = false;
                return true;
            }
            return false;
        }


        public void SetGender(bool gender)
        {
            Gender = gender;
        }

        public bool? GetGender() { return Gender; }

        public string GetGenderName()
        {
            if (Gender == null)
                return "Not specified";
            else if (Gender == true)
                return "Male";
            else
                return "Female";
        }


    }

    class User
    {
        static void Main(string[] args)
        {
            Proprities user = new Proprities();

            
            user.SetFullName("Bara'a Aqeel");
            user.SetUserName("bera96");
            user.SetAge(23);
            user.SetPassword("ayaz1234");
            user.SetGender("m");

            Console.WriteLine(user.GetName());
            Console.WriteLine(user.GetUserName());
            Console.WriteLine(user.GetPassword());
            Console.WriteLine(user.GetAge());
            Console.ReadKey();
        }
    }
}