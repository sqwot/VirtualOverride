using System;

namespace VirtualOverride {
    public class Locksmith {
        private string writtenDownCombination;

        internal void OpenSafe(Safe safe, Owner owner) {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        internal virtual void ReturnContents(Jewels safeContents, Owner owner) {
            owner.ReceiveContents(safeContents);
        }

        internal void WriteDownCombination(string combination) {
            writtenDownCombination = combination;
        }
    }
}