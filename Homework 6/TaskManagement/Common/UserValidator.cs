using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;
using TaskManagement.Utilities;


namespace TaskManagement.Common
{
    public class UserValidator
    {
        
        private StringUtility _utility = new StringUtility();


        #region First name

        public string GetAndValidateFirstName()
        {
            while (true)
            {
                Console.Write("Pls enter first name : ");
                string firstName = Console.ReadLine()!;

                if (IsValidFirstName(firstName))
                    return firstName;
                    


                Console.WriteLine("Some information is not correnct");
            }
        }
        private bool IsValidFirstName(string firstName)
        {
            int MIN_LENGTH = 3;
            int MAX_LENGTH = 30;

            return IsValidName(firstName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Last name

        public string GetAndValidateLastName()
        {
            while (true)
            {
                Console.Write("Pls enter last name : ");
                string lastName = Console.ReadLine()!;

                if (IsValidLastName(lastName))
                    return lastName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        private bool IsValidLastName(string lastName)
        {
            int MIN_LENGTH = 5;
            int MAX_LENGTH = 20;

            return IsValidName(lastName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Password

        public string GetAndValidatePassword()
        {
            while (true)
            {
                Console.Write("Pls enter password : ");
                string password = Console.ReadLine()!;

                Console.WriteLine("Pls enter confirm password : ");
                string confirmPassword = Console.ReadLine()!;

                if (password == confirmPassword)
                    return password;

                Console.WriteLine("Some information is not correnct");
            }
        }

        #endregion

        #region Email

        public string GetAndValidateEmail()
        {
            //char AT_SIGN = '@';

            while (true)
            {

                Console.Write("Pls enter email : ");
                string email = Console.ReadLine()!;
                //Way 1
                //if (_utility.Contains(email, AT_SIGN) && !IsEmailExists(users, email))
                //    return email;

                //Way2
                //bool isValidFormat = false;
                //bool isUnique = false;

                //if (_utility.Contains(email, AT_SIGN))
                //    isValidFormat = true;
                //else
                //{
                //    isValidFormat = false;
                //    Console.WriteLine("Ensure that your email contains @ characheter");
                //}

                //if (!IsEmailExists(users, email))
                //    isUnique = true;
                //else
                //{
                //    isUnique = false;
                //    Console.WriteLine("Your email is already used in system, pls try another email");
                //}

                //if (isValidFormat && isUnique)
                //    return email;

                //Way 3
                //if (_utility.Contains(email, AT_SIGN))
                //{
                //    if (!IsEmailExists(email))
                //        return email;
                //    else
                //        Console.WriteLine("Your email is already used in system, pls try another email");
                //}
                //else
                //    Console.WriteLine("Ensure that your email contains @ characheter");





                    
                if (!IsEmailExists(email))
                {
                    Regex compatible = new Regex("\\S+@\\S+\\.\\S+\\.\\S+");
                    compatible.IsMatch(email);
                    if (compatible.IsMatch(email))
                    {

                    string[] splitString = Regex.Split(email, @"@");
                    string receipent = splitString[0];
                    //Console.WriteLine($"Email receipent: {receipent}");
                    Regex regex = new Regex(@"^[a-zA-Z0-9]{10,30}$");
                    Match match = regex.Match(receipent);
                      if (match.Success)
                      {
                        //string[] splitStrings = Regex.Split(email, @"@");
                        //Console.WriteLine(splitString[0]);
                        Console.WriteLine(splitString[1]);
                        string inputDomain = splitString[1];
                        string domain = "code.edu.az";
                        char AT_SIGN = '@';
                        //string AT_SIGN = "@";
                        Console.WriteLine(Regex.Equals(inputDomain, domain));
                        if(Regex.Equals(inputDomain, domain))
                        {
                            Console.WriteLine(Regex.Equals(email, AT_SIGN));
                            
                            if(Regex.Equals(email, AT_SIGN))
                            {
                                Console.WriteLine("end");
                                return email;
                            }
                        }
                        else
                        {
                          Console.WriteLine($"The email domain <<{inputDomain}>> you entered is invalid!!! The email must end with the <<{domain}>> domain...Please re-enter it.");
                        }
                      }
                        if(!match.Success)
                        {
                         Console.WriteLine($"The information <<{email}>> you entered is incorrect");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"The entered <<{email}>>e-mail address does not match the <<text/@/code.edu.az>> format!!! Please re-enter...");
                    }

                }
                else
                Console.WriteLine("Your email is already used in system, pls try another email");
                        

                        
                        
                        

                        
                        


                        


                
                    


                
                



            }
        }
        public bool IsEmailExists(string email)
        {
            UserRepository userRepository = new UserRepository();
            List<User> users = userRepository.GetAll();
            foreach (User user in users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Common

        private bool IsValidName(string name, int minLength, int maxLenght)
        {
            if (!_utility.IsLengthBetween(name, minLength, maxLenght))
            {
                return false;
            }

            char firstLetter = name[0];

            if (!_utility.IsUpperLetter(firstLetter))
            {
                return false;
            }

            for (int i = 1; i < name.Length; i++)
            {
                if (_utility.IsUpperLetter(name[i]))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
