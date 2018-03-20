using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample_3B_Coercion
{
    class Dessert
    {
    }

    class Pie : Dessert
    {
    }

    class ApplePie : Pie
    {
    }

    class Cake : Dessert
    {
    }

    class ChocolateCake : Cake
    {
    }

    public class Sample3C
    {
        void Order(Dessert d, Cake c)
        {
        }

        void Order(Pie p, Dessert d)
        {
        }

        void Order(ApplePie a, Cake c)
        {
        }

        Dessert dessert = new Dessert();
        Pie pie = new Pie();
        ApplePie applePie = new ApplePie();
        Cake cake = new Cake();
        ChocolateCake chocolateCake = new ChocolateCake();

        public Sample3C()
        {
            //Order(dessert, cake);
            //Order(applePie, dessert);
            //Order(dessert, dessert);
            //Order(applePie, chocolateCake);
            //Order(pie, cake);
        }
    }
}