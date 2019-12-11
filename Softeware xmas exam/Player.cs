using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softeware_xmas_exam
{

    public enum Position {Goalkeeper, Defender, Midfilder, Forward }

   public class Player
    {

        //props
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Position PreferredPossition { get; set; }
        public DateTime DoB { get; set; }

        private int _age;
        public int Age
        {
            get
            {
                _age = DateTime.Now.Year - DoB.Year;
                if (DoB.DayOfYear > DateTime.Now.DayOfYear)
                    _age--;
                return _age;
            }
        }
        //ctor
        public Player(string fname, string lname, Position position, DateTime dateofbirth )
        {
            FirstName = fname;
            Surname = lname;
            PreferredPossition = position;
            DoB = dateofbirth;

        }

        public override string ToString()
        {
            return $"{FirstName} - {Surname}");
        }

    }
}
