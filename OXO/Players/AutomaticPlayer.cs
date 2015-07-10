// <copyright file="AutomaticPlayer.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-08</date>
// <summary>
// A player whose actions are controlled by the computer.
// </summary>

namespace GavinGreig.OXO.Players
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GavinGreig.OXO.State;

    /// <summary>
    /// A player whose actions are controlled by the computer.
    /// </summary>
    internal sealed class AutomaticPlayer : Player
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="AutomaticPlayer"/> class.
        /// </summary>
        /// <param name="inName">Name of the player.</param>
        /// <param name="inSymbol">The symbol the player will be using, X or O.</param>
        internal AutomaticPlayer(string inName, CellState inSymbol)
            : base(inName, inSymbol)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="AutomaticPlayer"/> class.
        /// </summary>
        internal AutomaticPlayer() : base()
        {
        }

        /// <summary>
        /// Handles the user taking a turn.
        /// </summary>
        /// <param name="myGameState">The current state of the game.</param>
        internal override void TakeTurn(GameState myGameState)
        {
            // Pick a random index into the collection of currently empty cells.
            Random theRandomNumberGenerator = new Random();
            int theRandomCellIndex = theRandomNumberGenerator.Next(0, myGameState.EmptyCells.Count - 1);

            // Retrieve the row and column indices.
            int theRowIndex = myGameState.EmptyCells[theRandomCellIndex].Item1;
            int theColumnIndex = myGameState.EmptyCells[theRandomCellIndex].Item2;

            // Set the state of the cell identified by the indices to this player's symbol.
            myGameState.Grid[theRowIndex, theColumnIndex].State = Symbol;
        }
    }
}
