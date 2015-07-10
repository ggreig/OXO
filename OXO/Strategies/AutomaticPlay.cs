// <copyright file="AutomaticPlay.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-08</date>
// <summary>
// A concrete strategy implementing a mode where the computer plays against itself.
// </summary>

namespace GavinGreig.OXO.Strategies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GavinGreig.OXO.Players;
    using GavinGreig.OXO.State;

    /// <summary>
    /// A concrete strategy implementing a <see cref="GameMode"/>  where the computer plays against itself.
    /// </summary>
    internal sealed class AutomaticPlay : GameMode
    {
        /// <summary>
        /// Gets "Player 1" for the game.
        /// </summary>
        /// <returns>Player 1 for the game.</returns>
        internal override Player GetPlayer1()
        {
            return new AutomaticPlayer("Player 1", CellState.X);
        }

        /// <summary>
        /// Gets "Player 2" for the game.
        /// </summary>
        /// <returns>Player 2 for the game.</returns>
        internal override Player GetPlayer2()
        {
            return new AutomaticPlayer("Player 2", CellState.O);
        }
    }
}
