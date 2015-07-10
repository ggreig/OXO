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
            // Need a method of randomly choosing a cell from those that are still blank.
            throw new NotImplementedException();
        }
    }
}
