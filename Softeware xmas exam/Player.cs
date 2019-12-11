using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softeware_xmas_exam
{

    public enum Position {Goalkeeper, Defender, Midfilder, Forward }

    class Player
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

    }
}
