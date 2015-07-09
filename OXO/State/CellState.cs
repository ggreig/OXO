// <copyright file="CellState.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-09</date>
// <summary>
// An enum-like class containing possible states of a noughts and crosses cell.
// Modified from http://stackoverflow.com/questions/424366/c-sharp-string-enums
// </summary>

namespace GavinGreig.OXO.State
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// An enum-like class identifying possible states of a noughts and crosses <see cref="Cell"/>,
    /// and containing character values used to represent them.
    /// </summary>
    internal sealed class CellState
    {
        /// <summary>
        /// The Empty state of a <see cref="Cell"/>.
        /// </summary>
        internal static readonly CellState Empty = new CellState(' ');

        /// <summary>
        /// The "X" state of a <see cref="Cell"/>.
        /// </summary>
        internal static readonly CellState X = new CellState('X');

        /// <summary>
        /// The "O" state of a <see cref="Cell"/>.
        /// </summary>
        internal static readonly CellState O = new CellState('O');

        /// <summary>
        /// Initialises a new instance of the <see cref="CellState"/> class.
        /// </summary>
        /// <param name="inValue">The character that will be used to display the state of the <see cref="Cell"/>.</param>
        private CellState(char inValue)
        {
            Value = inValue;
        }

        /// <summary>
        /// Gets the character value of the <see cref="Cell"/>.
        /// </summary>
        /// <value>
        /// The character value of the <see cref="Cell"/>.
        /// </value>
        public char Value { get; private set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
