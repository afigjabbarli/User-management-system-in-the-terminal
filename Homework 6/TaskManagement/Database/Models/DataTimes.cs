using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Database.Models
{
    public class DataTimes
    {
        public DataTimes(int year, int month, int day, int hour, int minute, int second)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
            Second = second;
            
        }

        public int Year { get; set; }
        public int Month { get; set; }  
        public int Day { get; set; }
        public int Hour { get; set; }  
        public int Minute { get; set; }
        public int Second { get; set; }
       
        
    }
}
