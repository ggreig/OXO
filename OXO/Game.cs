﻿// <copyright file="Game.cs" company="Gavin Greig">
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
    using GavinGreig.OXO.Players;
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
        /// A collection of players taking part in the game.
        /// </summary>
        /// <remarks>
        /// Although there are only two players in this game, a more
        /// abstract list-based model could be developed that would allow a rota
        /// of players taking turns. This approach would work for one to many players.
        /// </remarks>
        private List<Player> myPlayers;

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
            // Introduction to game
            DisplayGameIntroduction();
            DisplayGameBoard(doPause: false);

            // Gather information needed to play.
            GetPermissionToEndPause(Resource.EnterToStart);
            myPlayers = new List<Player> 
                { 
                    myGameMode.GetPlayer1(), 
                    myGameMode.GetPlayer2()
                };

            // Start playing.
            do
            {
                // Play until someone wins.
                do
                {
                    myPlayers[0].TakeTurn(myGameState);
                    DisplayGameBoard();

                    if (myGameState.WinningSymbol == null)
                    {
                        myPlayers[1].TakeTurn(myGameState);
                        DisplayGameBoard();
                    }
                } 
                while (myGameState.WinningSymbol == null);

                // Announce the winner, and ask for another game.
            } 
            while (UserWishesToContinue());
        }

        /// <summary>
        /// Displays an introduction to the Game.
        /// </summary>
        internal void DisplayGameBoard()
        {
            DisplayGameBoard(doPause: true);
        }

        /// <summary>
        /// Displays an introduction to the Game.
        /// </summary>
        /// <param name="doPause">A value indicating whether a one second pause is required.</param>
        internal void DisplayGameBoard(bool doPause)
        {
            if (doPause)
            {
                Thread.Sleep(OneSecond);
            }

            myGameState.Display();
            Console.WriteLine();
        }

        /// <summary>
        /// Requests the user's permission to end pause, with the specified prompt.
        /// </summary>
        /// <param name="inPrompt">A prompt, which should ask the user for permission to proceed.</param>
        private static void GetPermissionToEndPause(string inPrompt)
        {
            Console.WriteLine(inPrompt);
            Console.ReadLine();
        }

        /// <summary>
        /// Indicates whether the user wishes to continue playing more games.
        /// </summary>
        /// <returns>A value indicating whether the user wishes to continue playing more games.</returns>
        /// <exception cref="System.NotImplementedException">Thrown because this method has not yet been implemented.</exception>
        private static bool UserWishesToContinue()
        {
            // Default implementation stops after one game.
            // TODO: Implement a method here that actually asks the user and returns their preference.
            throw new NotImplementedException();
        }
    }
}
