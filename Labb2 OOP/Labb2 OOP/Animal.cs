using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_OOP
{
    public abstract class Animal

    {
        public int Age { get; set; }
        public string Weight { get; set; }
        public string Sound { get; set; }



        public virtual string Information()
        {
            return String.Format("It is {0} years old, weights {1} and makes sounds like: {2}.",
                              Age,
                              Weight,
                              Sound);
        }


    }
}