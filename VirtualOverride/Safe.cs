using System;


namespace VirtualOverride {
    class Safe {
        private Jewels contents = new Jewels();
        private string safeCombination = "123456";
        public Jewels Open(string combination) {
            if (combination.Equals(safeCombination)) {
                return contents;
            } else {
                return null;
            }
        }
        public void PickLock(Locksmith lockpicker) {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
}
