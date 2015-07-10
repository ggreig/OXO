// <copyright file="GameTest.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-08</date>
// <summary>
// A suite of unit tests for the Game class.
// </summary>

namespace GavinGreig.OXO.UnitTest
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GavinGreig.OXO.State;
    using GavinGreig.OXO.Strategies;
    using GavinGreig.OXO.UnitTest.Utility;
    using NUnit.Framework;

    /// <summary>
    /// A suite of unit tests for the Game class.
    /// </summary>
    [TestFixture]
    public static class GameTest
    {
        /// <summary>
        /// Tests that the game introduction segment displays correctly.
        /// </summary>
        [Test]
        public static void GameIntroduction_DisplaysCorrectly()
        {
            using (ConsoleCapture theConsole = new ConsoleCapture())
            {
                // Arrange
                string theExpectedOutput = 
                    "***********************\r\n" + 
                    "* Noughts and Crosses *\r\n" +
                    "***********************\r\n" +
                    "\r\n" +
                    "Two computer players will compete for your amusement.\r\n" +
                    "\r\n";

                // Act
                Game.DisplayGameIntroduction();

                // Assert
                Assert.That(theConsole.Output, Is.EqualTo(theExpectedOutput));
            }
        }
    }
}
