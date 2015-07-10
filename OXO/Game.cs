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
    using GavinGreig.OXO.State;
    using GavinGreig.OXO.Strategies;

    /// <summary>
    /// A class representing the entire game.
    /// </summary>
    internal sealed class Game
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
        /// The current state of the game.
        /// </summary>
        private readonly GameState myGameState;

        /// <summary>
        /// Initialises a new instance of the <see cref="Game"/> class.
        /// </summary>
        /// <param name="inGameMode">The mode selected for this game.</param>
        internal Game(GameMode inGameMode)
        {
            myGameMode = inGameMode;
            myGameState = new GameState();
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
            theProgramBanner.Display();
            Console.WriteLine();
            Console.WriteLine(Resource.GameIntroduction);
            Console.WriteLine();
        }

        /// <summary>
        /// Runs this instance of the Game. Defines the flow of the Game.
        /// </summary>
        internal void Run()
        {
            DisplayGameIntroduction();
            DisplayGameBoard();

            GetPermissionToContinue(Resource.EnterToStart);

            myGameMode.GetPlayer1();
            myGameMode.GetPlayer2();
        }

        /// <summary>
        /// Displays an introduction to the Game.
        /// </summary>
        internal void DisplayGameBoard()
        {
            myGameState.Display();
            Console.WriteLine();
            Thread.Sleep(OneSecond);
        }

        /// <summary>
        /// Requests the user's permission to continue, with the specified prompt.
        /// </summary>
        /// <param name="inPrompt">A prompt, which should ask the user for permission to proceed.</param>
        private static void GetPermissionToContinue(string inPrompt)
        {
            Console.WriteLine(inPrompt);
            Console.ReadLine();
        }
    }
}
