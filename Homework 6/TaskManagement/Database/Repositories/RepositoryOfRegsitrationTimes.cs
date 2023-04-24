using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;

namespace TaskManagement.Database.Repositories
{
    public class RepositoryOfRegsitrationTimes
    {
        public static void RegistrationTimes()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int dayOfWeek = (int)DateTime.Now.DayOfWeek; 
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            

            DataTimes dataTimes = new DataTimes(year, month, day, dayOfWeek, hour, minute, second);  
            DataContext.DataTimes.Add(dataTimes);

            Console.WriteLine("Your registration is successful. Thanks...");
            Console.WriteLine();
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Local registration date: {0}", dateTime);
            Console.WriteLine("Universal registration date: {0}", dateTime.ToUniversalTime());


        }





       
    
    
    
    
    
    
    
    
    
    
    }
}
