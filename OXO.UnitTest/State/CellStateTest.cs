// <copyright file="CellStateTest.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-09</date>
// <summary>
// A suite of unit tests for the CellState class.
// </summary>

namespace GavinGreig.OXO.UnitTest.State
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GavinGreig.OXO.State;
    using NUnit.Framework;

    /// <summary>
    /// A suite of unit tests for the CellState class.
    /// </summary>
    [TestFixture]
    public static class CellStateTest
    {
        /// <summary>
        /// Checks that the <see cref="CellState"/> has the expected character value.
        /// </summary>
        [Test]
        public static void CellState_HasExpectedValue()
        {
            // Considered using a parametrised test with test cases here, but overkill for checking three values.

            // Arrange

            // Act
            char theEmptyValue = CellState.Empty.Value;
            char theXValue = CellState.X.Value;
            char theOValue = CellState.O.Value;

            // Assert
            Assert.That(theEmptyValue, Is.EqualTo(' '));
            Assert.That(theXValue, Is.EqualTo('X'));
            Assert.That(theOValue, Is.EqualTo('O'));
        }

        /// <summary>
        /// Checks that the <see cref="CellState"/> converts to a string as expected.
        /// </summary>
        [Test]
        public static void CellState_ToString_HasExpectedValue()
        {
            // Considered using a parametrised test with test cases here, but overkill for checking three values.

            // Arrange

            // Act
            string theEmptyValue = CellState.Empty.ToString();
            string theXValue = CellState.X.ToString();
            string theOValue = CellState.O.ToString();

            // Assert
            Assert.That(theEmptyValue, Is.EqualTo(" "));
            Assert.That(theXValue, Is.EqualTo("X"));
            Assert.That(theOValue, Is.EqualTo("O"));
        }
    }
}
