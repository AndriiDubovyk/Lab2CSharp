using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp.Models
{
    class Person
    {
        #region Constructors
        public Person(string firstName, string lastName, string email, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthdate = birthdate;
            IsAdult = (GetAge() >= 18);
            SunSign = GetSunSign();
            ChineseSign = GetChineseSign();
            IsBirthday = (DateTime.Today.Month == Birthdate.Month && DateTime.Today.Day == Birthdate.Day);
        }

        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthdate = DateTime.Today;
            IsAdult = (GetAge() >= 18);
            SunSign = GetSunSign();
            ChineseSign = GetChineseSign();
            IsBirthday = (DateTime.Today.Month == Birthdate.Month && DateTime.Today.Day == Birthdate.Day);
        }

        public Person(string firstName, string lastName, DateTime bitrhdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = "";
            Birthdate = DateTime.Today;
            IsAdult = (GetAge() >= 18);
            SunSign = GetSunSign();
            ChineseSign = GetChineseSign();
            IsBirthday = (DateTime.Today.Month == Birthdate.Month && DateTime.Today.Day == Birthdate.Day);
        }
        #endregion


        #region Properties
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public DateTime Birthdate { get; }
        public bool IsAdult { get; }
        public string SunSign { get; }
        public string ChineseSign { get; }
        public bool IsBirthday { get; }
        #endregion

        public int GetAge()
        {
            int yearsDifference = DateTime.Today.Year - Birthdate.Year;
            int monthDifference = DateTime.Today.Month - Birthdate.Month;
            int daysDifference = DateTime.Today.Day - Birthdate.Day;
            if (monthDifference > 0 || (monthDifference == 0 && daysDifference >= 0))
            {
                return yearsDifference; // already celebrated the birthday in this year
            }
            return yearsDifference - 1; // will celebrate the birthday
        }

        private string GetSunSign()
        {
            double monthDotDay = Birthdate.Month + Birthdate.Day / 100.0;
            if (monthDotDay < 1.20) return "Capricorn";
            if (monthDotDay < 2.19) return "Aquarius";
            if (monthDotDay < 3.21) return "Pisces";
            if (monthDotDay < 4.20) return "Aries";
            if (monthDotDay < 5.21) return "Taurus";
            if (monthDotDay < 6.22) return "Gemini";
            if (monthDotDay < 7.23) return "Cancer";
            if (monthDotDay < 8.23) return "Leo";
            if (monthDotDay < 9.23) return "Virgo";
            if (monthDotDay < 10.23) return "Libra";
            if (monthDotDay < 11.23) return "Scorpio";
            if (monthDotDay < 12.22) return "Sagittarius";
            return "Capricorn";
        }

        private static String[] ChineseZodiacSignsNames = {
            "Monkey",
            "Rooster",
            "Dog",
            "Pig",
            "Rat",
            "Ox",
            "Tiger",
            "Rabbit",
            "Dragon",
            "Snake",
            "Horse",
            "Goat"
        };

        private string GetChineseSign()
        {
            return ChineseZodiacSignsNames[Birthdate.Year % 12];
        }
    }
}
