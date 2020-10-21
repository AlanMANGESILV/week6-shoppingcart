using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6AppleOrange
{
    class Cart
    {
        List<double> cart { get; set; }

        public Cart()
        {
            cart = new List<double>();
        }

        public void Buy(string O)
        {
            Objet objet1 = new Objet();
            if (O=="apple")
            {
                cart.Add(objet1.Apple);
            }
            if(O=="orange")
            {
                cart.Add(objet1.Orange);
            }
            if (O == "chair")
            {
                cart.Add(objet1.Chair);
            }
            if (O == "banana")
            {
                cart.Add(objet1.Banana);
            }

        }

        public double Addition()
        {

            int NbApple = 0;
            double total=0;
            for (int i =0;i<cart.Count;i++)
            {
                if (cart[i]==0.60)
                {
                    NbApple++;
                }
                if(NbApple==3)
                {
                    NbApple = 0;
                    total = total - 0.60;
                }






                total += cart[i];
            }
            return total;

        }
    }
}
