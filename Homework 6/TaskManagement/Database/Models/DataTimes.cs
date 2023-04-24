using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Database.Models
{
    public class DataTimes
    {
        public DataTimes(int year, int month, int day, int weekDay, int hour, int minute, int second)
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            WeekDay = (int)DateTime.Now.DayOfWeek;
            Hour = DateTime.Now.Hour;
            Minute = DateTime.Now.Minute;
            Second = DateTime.Now.Second;
            

            

            
        }

        public int Year { get; set; }
        public int Month { get; set; }  
        public int Day { get; set; }
        public int WeekDay { get; set; }    
        public int Hour { get; set; }  
        public int Minute { get; set; }
        public int Second { get; set; }
        

    }
}
