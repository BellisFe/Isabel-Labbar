using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_OOP
{
    public class Crow : Birds
    {
        public string Diet { get; set; }
        public string FreeTime { get; set; }

        public override string Information()
        {
            return String.Format("This animal is a {0} and has a wing lenght of {1}cm. {2} It eats {3} and likes to {4}",
                                Breed,
                                LenghtOfWings,
                                base.Information(),
                                Diet,
                                FreeTime);
        }
    }
}