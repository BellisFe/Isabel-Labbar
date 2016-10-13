using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_OOP
{
    public class Dog : Mammals
    {
        public string Diet { get; set; }
        public string FreeTime { get; set; }

        public override string Information()
        {
            return String.Format("This animal is a {0} and likes to {1}. {2} It eats {3} and likes to {4}",
                                  Breed,
                                  CanRun,
                                  base.Information(),
                                  Diet,
                                  FreeTime);
        }

    }
}