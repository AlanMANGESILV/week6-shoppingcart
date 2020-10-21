using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6AppleOrange
{
    class Objet
    {
        public double Apple { get; set; }
        public double Orange { get; set; }
        public double Chair { get; set; }
        public double Banana { get; set; }
        public Objet()
        {
            Apple = 0.60;
            Orange = 0.25;
            Chair = 25;
            Banana = 0.15;
        }
    }
}
