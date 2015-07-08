// <copyright file="ConsoleCapture.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-08</date>
// <summary>
// A utility class that captures console output for testing purposes.
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

    /// <summary>
    /// A utility class that captures console output for testing purposes.
    /// </summary>
    /// <remarks>
    /// A modification of 
    /// <a href="http://stackoverflow.com/questions/2139274/grabbing-the-output-sent-to-console-out-from-within-a-unit-test">a Stack Overflow solution</a>.
    /// </remarks>
    internal class ConsoleCapture : IDisposable
    {
        /// <summary>
        /// A <see cref="StringWriter"/> that captures the console output. This class
        /// encapsulates it and minimises the amount of code required to use it in a
        /// test. Just wrap the test in a "using" statement that instantiates this 
        /// class, and use the <see cref="Ouput"/> property to access what it captures.
        /// </summary>
        private readonly StringWriter myWriter;

        /// <summary>
        /// Initialises a new instance of the <see cref="ConsoleCapture"/> class.
        /// </summary>
        internal ConsoleCapture()
        {
            myWriter = new StringWriter(CultureInfo.CurrentCulture);
            Console.SetOut(myWriter);
        }

        /// <summary>
        /// Gets the console output.
        /// </summary>
        /// <value>
        /// The output.
        /// </value>
        internal string Output
        {
            get
            {
                return myWriter.ToString();
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Might need the following line for proper tidy-up: to be determined.
            // Console.SetOut(new StreamWriter(Console.OpenStandardError()));
            myWriter.Dispose();
        }
    }
}
