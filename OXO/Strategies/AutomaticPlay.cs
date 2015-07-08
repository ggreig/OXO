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

    /// <summary>
    /// A concrete strategy implementing a <see cref="GameMode"/>  where the computer plays against itself.
    /// </summary>
    internal class AutomaticPlay : GameMode
    {
        /// <summary>
        /// Gets "Player 1" for the game.
        /// </summary>
        internal override void GetPlayer1()
        {
        }

        /// <summary>
        /// Gets "Player 2" for the game.
        /// </summary>
        internal override void GetPlayer2()
        {
        }
    }
}
