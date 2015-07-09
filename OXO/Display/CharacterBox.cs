// <copyright file="CharacterBox.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-08</date>
// <summary>
// A class containing the entry point of the program.
// </summary>

namespace GavinGreig.OXO.Display
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class for drawing a box around a string, with the box being written
    /// using a specified character.
    /// </summary>
    internal sealed class CharacterBox
    {
        /// <summary>
        /// A constant representing the space character. This exists for readability.
        /// </summary>
        private const char Space = ' ';

        /// <summary>
        /// The character with which to draw the box.
        /// </summary>
        private readonly char myCharacter;

        /// <summary>
        /// The text to put inside the box.
        /// </summary>
        private readonly string myText;

        /// <summary>
        /// Initialises a new instance of the <see cref="CharacterBox"/> class.
        /// </summary>
        /// <param name="inCharacter">The character with which to draw the box.</param>
        /// <param name="inText">The text to put inside the box.</param>
        internal CharacterBox(char inCharacter, string inText)
        {
            myCharacter = inCharacter;
            myText = inText;
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="CharacterBox"/> class from being created.
        /// </summary>
        private CharacterBox()
        {
        }

        /// <summary>
        /// Renders the box to the console.
        /// </summary>
        internal void Display()
        {
            WriteAsteriskHorizontal();
            WriteLeftMargin();
            WriteText();
            WriteRightMargin();
            WriteAsteriskHorizontal();
        }

        /// <summary>
        /// Writes a horizontal line of asterisks that's slightly (4 characters) longer than the given text.
        /// </summary>
        private void WriteAsteriskHorizontal()
        {
            for (int i = 0; i < myText.Length + 4; i++)
            {
                Console.Write('*');
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Writes the left margin.
        /// </summary>
        private void WriteLeftMargin()
        {
            Console.Write(myCharacter);
            Console.Write(Space);
        }

        /// <summary>
        /// Writes the right margin.
        /// </summary>
        private void WriteRightMargin()
        {
            Console.Write(Space);
            Console.WriteLine(myCharacter);
        }

        /// <summary>
        /// Writes the text.
        /// </summary>
        private void WriteText()
        {
            Console.Write(myText);
        }
    }
}
