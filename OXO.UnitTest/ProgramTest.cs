// <copyright file="ProgramTest.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-08</date>
// <summary>
// A class containing the entry point of the program.
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
    using GavinGreig.OXO.Strategies;
    using NUnit.Framework;

    /// <summary>
    /// A suite of unit tests for the Program class.
    /// </summary>
    [TestFixture]
    public static class ProgramTest
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        [Test]
        public static void Test()
        {
            using (ConsoleCapture theConsole = new ConsoleCapture())
            {
                // Arrange
                string theExpectedOutput = 
                    "***********************\r\n" + 
                    "* Noughts and Crosses *\r\n" +
                    "***********************\r\n";
                GameMode theGameMode = new AutomaticPlay();
                Game theGame = new Game(theGameMode);

                // Act
                theGame.Run();

                // Assert
                Assert.That(theConsole.Output, Is.EqualTo(theExpectedOutput));
            }
        }
    }
}
