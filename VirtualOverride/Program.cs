using System;


namespace VirtualOverride {
    class Program {
        static void Main() {

            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelThief jewelThief = new JewelThief();
            jewelThief.OpenSafe(safe, owner);
            



            Console.ReadKey();
        }
    }
}
