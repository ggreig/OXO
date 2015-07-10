// <copyright file="GameStateTest.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-09</date>
// <summary>
// A suite of unit tests for the GameState class.
// </summary>

namespace GavinGreig.OXO.UnitTest.State
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GavinGreig.OXO.State;
    using GavinGreig.OXO.UnitTest.Utility;
    using NUnit.Framework;

    /// <summary>
    /// A suite of unit tests for the GameState class.
    /// </summary>
    [TestFixture]
    public static class GameStateTest
    {
        /// <summary>
        /// Tests that the game grid initialises correctly with non-null values.
        /// </summary>
        [Test]
        public static void GameState_InitialisesCorrectly()
        {
            // Arrange

            // Act
            GameState theGameState = new GameState();

            // Assert
            // Ideally a test should only contain a single Assert, but sometimes it's
            // sensible to ignore that guideline.
            Assert.That(theGameState.Grid[0, 0], Is.Not.Null);
            Assert.That(theGameState.Grid[0, 1], Is.Not.Null);
            Assert.That(theGameState.Grid[0, 2], Is.Not.Null);
            Assert.That(theGameState.Grid[1, 0], Is.Not.Null);
            Assert.That(theGameState.Grid[1, 1], Is.Not.Null);
            Assert.That(theGameState.Grid[1, 2], Is.Not.Null);
            Assert.That(theGameState.Grid[2, 0], Is.Not.Null);
            Assert.That(theGameState.Grid[2, 1], Is.Not.Null);
            Assert.That(theGameState.Grid[2, 2], Is.Not.Null);

            Assert.That(theGameState.Grid[0, 0].State, Is.EqualTo(CellState.Empty));
            Assert.That(theGameState.Grid[0, 1].State, Is.EqualTo(CellState.Empty));
            Assert.That(theGameState.Grid[0, 2].State, Is.EqualTo(CellState.Empty));
            Assert.That(theGameState.Grid[1, 0].State, Is.EqualTo(CellState.Empty));
            Assert.That(theGameState.Grid[1, 1].State, Is.EqualTo(CellState.Empty));
            Assert.That(theGameState.Grid[1, 2].State, Is.EqualTo(CellState.Empty));
            Assert.That(theGameState.Grid[2, 0].State, Is.EqualTo(CellState.Empty));
            Assert.That(theGameState.Grid[2, 1].State, Is.EqualTo(CellState.Empty));
            Assert.That(theGameState.Grid[2, 2].State, Is.EqualTo(CellState.Empty));
        }

        /// <summary>
        /// Tests that the game board displays correctly when first initialised.
        /// </summary>
        /// <remarks>
        /// This is testing the requirement that the game board can be correctly 
        /// displayed at the start of play.
        /// </remarks>
        [Test]
        public static void GameState_WhenFirstInitialised_DisplaysCorrectly()
        {
            using (ConsoleCapture theConsole = new ConsoleCapture())
            {
                // Arrange
                string theExpectedOutput =
                    "Here's the current state of the game board:\r\n" +
                    "\r\n" +
                    " | | \r\n" +
                    "-|-|-\r\n" +
                    " | | \r\n" +
                    "-|-|-\r\n" +
                    " | | \r\n";
                GameState theGameState = new GameState();

                // Act
                theGameState.Display();

                // Assert
                Assert.That(theConsole.Output, Is.EqualTo(theExpectedOutput));
            }
        }
    }
}
