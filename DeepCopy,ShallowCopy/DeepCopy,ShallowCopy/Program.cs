using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy_ShallowCopy
{
    class CreditCard
    {
        public string name;

    }

    class Customer
    {
        public int age;
        public CreditCard card;
        public object ShallowCopy()
        {
            return this.MemberwiseClone();

        }
    }
    class Customer2 :ICloneable
    {
        public int age;
        public CreditCard card;

        public object Clone()
        {
            Customer2 c = new Customer2();
            c.age = this.age;
            c.card = new CreditCard();
            c.card.name = this.card.name;
            return c;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.age = 20;
            c1.card = new CreditCard();
            c1.card.name = "비씨카드";
            Customer c2 = (Customer)c1.ShallowCopy();
            c2.card.name = "BC카드";
            Console.WriteLine("c1.card.name = " + c1.card.name);
            Console.WriteLine("c2.card.name = " + c2.card.name);

            ////////////////////////////////////////////////////
            Customer2 c3 = new Customer2();
            c3.age = 20;
            c3.card = new CreditCard();
            c3.card.name = "비씨카드";
            Customer2 c4 = (Customer2)c3.Clone();
            c4.card.name = "BC카드";
            Console.WriteLine("c3.card.name = " + c3.card.name);
            Console.WriteLine("c4.card.name = " + c4.card.name);

        }
    }
}
