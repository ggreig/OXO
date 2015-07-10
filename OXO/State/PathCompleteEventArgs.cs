// <copyright file="PathCompleteEventArgs.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-10</date>
// <summary>
// An event arguments class that allows notification of which player completed 
// a path across the noughts and crosses grid.
// </summary>

namespace GavinGreig.OXO.State
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// An event arguments class that allows notification of which player completed 
    /// a path across the noughts and crosses grid.
    /// </summary>
    internal class PathCompleteEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets the winning symbol.
        /// </summary>
        /// <value>
        /// The winning symbol.
        /// </value>
        internal CellState WinningSymbol { get; set; }
    }
}
