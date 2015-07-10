// <copyright file="Player.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-08</date>
// <summary>
// A base class allowing the implementation of different types of
// player in future. Initially, only one concrete implementation of
// this strategy will exist.
// </summary>

namespace GavinGreig.OXO.Players
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GavinGreig.OXO.State;
    using GavinGreig.Validation;

    /// <summary>
    /// A base class allowing the implementation of different types of
    /// player in future. Initially, only one concrete implementation 
    /// will exist.
    /// </summary>
    internal abstract class Player
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Player" /> class.
        /// </summary>
        /// <param name="inName">Name of the player.</param>
        /// <param name="inSymbol">The symbol the player will be using, X or O.</param>
        protected Player(string inName, CellState inSymbol)
        {
            ParameterValidation.EnsureNotNull(inName, "inName");
            ParameterValidation.EnsureNotNull(inSymbol, "inSymbol");

            if (inSymbol == CellState.Empty)
            {
                throw new ArgumentException("Invalid value. A player must choose X or O.", "inSymbol");
            }

            Name = inName;
            Symbol = inSymbol;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Player"/> class.
        /// </summary>
        protected Player()
        {
        }

        /// <summary>
        /// Gets the name of the player.
        /// </summary>
        /// <value>
        /// The name of the player.
        /// </value>
        internal string Name { get; private set; }

        /// <summary>
        /// Gets the symbol the player is using.
        /// </summary>
        /// <value>
        /// The symbol the player is using.
        /// </value>
        internal CellState Symbol { get; private set; }

        /// <summary>
        /// Handles the user taking a turn.
        /// </summary>
        /// <param name="myGameState">The current state of the game.</param>
        internal abstract void TakeTurn(GameState myGameState);
    }
}
