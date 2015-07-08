// <copyright file="GameMode.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-08</date>
// <summary>
// A base class allowing the implementation of different game
// modes in future. Initially, only one concrete implementation of
// this strategy will exist.
// </summary>

namespace GavinGreig.OXO.Strategies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    ///  A base class allowing the implementation of different game
    /// modes in future. Initially, only one concrete implementation of
    /// this strategy will exist.
    /// </summary>
    internal abstract class GameMode
    {
        /// <summary>
        /// Gets "Player 1" for the game.
        /// </summary>
        internal abstract void GetPlayer1();

        /// <summary>
        /// Gets "Player 2" for the game.
        /// </summary>
        internal abstract void GetPlayer2();
    }
}
