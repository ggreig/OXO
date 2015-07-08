// <copyright file="Program.cs" company="Gavin Greig">
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

    /// <summary>
    /// This class contains the static method Main, which is the entry point of the program.
    /// </summary>
    /// <remarks>
    /// The Program class is public by default, but can be made internal without affecting program functionality.
    /// A class at namespace scope cannot be restricted further.
    /// </remarks>
    internal class Program
    {
        /// <summary>
        /// This is the main entry point of the program. Further information about Main
        /// can be found in <a href="https://msdn.microsoft.com/en-us/library/acy3edy3.aspx">MSDN documentation</a>.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <remarks>
        /// The Main method is private by default, but we've made that explicit for clarity.
        /// </remarks>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Usage", 
            "CA1801:ReviewUnusedParameters", 
            MessageId = "args",
            Justification = "'args' is a standard parameter for this method and shouldn't be removed even if unused.")]
        private static void Main(string[] args)
        {
            ////Console.WriteLine("Hello World");
            ////Thread.Sleep(1000);
            ////Console.WriteLine("Goodbye Cruel World");
            ////Thread.Sleep(1000);
        }
    }
}
