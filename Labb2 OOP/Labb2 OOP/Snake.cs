using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_OOP
{
    public class Snake : Reptile
    {
        public string Diet { get; set; }
        public string FreeTime { get; set; }

        public override string Information()
        {
            return String.Format("This animal is a {0} and is {1}. {2} It eats {3} and likes to {4}",
                                  Breed,
                                  Poisonous,
                                  base.Information(),
                                  Diet,
                                  FreeTime);
        }
       

    }
}