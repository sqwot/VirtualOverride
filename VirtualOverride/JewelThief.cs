using System;

namespace VirtualOverride {
    class JewelThief: Locksmith {
        private Jewels stolenJewels = null;
        override internal void ReturnContents(Jewels safeContents, Owner owner) {
            stolenJewels = safeContents;
            Console.WriteLine("I'm stealing the contenst " + stolenJewels.Sparkle());
        }
    }

}
