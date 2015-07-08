// <copyright file="Game.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-08</date>
// <summary>
// A class containing the entry point of the program.
// </summary>

namespace GavinGreig.OXO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using GavinGreig.OXO.Display;
    using GavinGreig.OXO.Strategies;

    /// <summary>
    /// A class representing the entire game.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Microsoft.Performance", 
        "CA1812:AvoidUninstantiatedInternalClasses",
        Justification = "Temporary suppression during development - remove if found.")]
    internal class Game
    {
        /// <summary>
        /// One second in milliseconds.
        /// </summary>
        private const short OneSecond = 1000;

        /// <summary>
        /// The mode selected for this game.
        /// </summary>
        private readonly GameMode myGameMode;

        /// <summary>
        /// Initialises a new instance of the <see cref="Game"/> class.
        /// </summary>
        /// <param name="inGameMode">The mode selected for this game.</param>
        internal Game(GameMode inGameMode)
        {
            myGameMode = inGameMode;
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="Game"/> class from being created.
        /// </summary>
        private Game()
        {
        }

        /// <summary>
        /// Displays an introduction to the Game.
        /// </summary>
        internal static void DisplayGameIntroduction()
        {
            CharacterBox theProgramBanner = new CharacterBox('*', Resource.ProgramBanner);
            theProgramBanner.Render();
            Thread.Sleep(OneSecond);
        }

        /// <summary>
        /// Runs this instance of the Game. Defines the flow of the Game.
        /// </summary>
        internal void Run()
        {
            DisplayGameIntroduction();
            myGameMode.GetPlayer1();
            myGameMode.GetPlayer2();
        }
    }
}
