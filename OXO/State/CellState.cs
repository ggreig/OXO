// http://stackoverflow.com/questions/424366/c-sharp-string-enums
namespace GavinGreig.OXO.State
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal sealed class CellState
    {
        private readonly string myName;
        private readonly int myValue;

        private CellState(string inName, int inValue)
        {
            myName = inName;
            myValue = inValue;
        }

        internal static readonly CellState Empty = new CellState("Empty", 0);
        internal static readonly CellState X = new CellState("X", 1);
        internal static readonly CellState O = new CellState("O", 2);

        public override string ToString()
        {
            return myName;
        }
    }
}
