// <copyright file="Cell.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-09</date>
// <summary>
// A class representing a single cell of the noughts and crosses grid.
// </summary>

namespace GavinGreig.OXO.State
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class representing a single cell of the noughts and crosses grid.
    /// </summary>
    internal sealed class Cell
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Cell"/> class.
        /// </summary>
        internal Cell()
        {
            State = CellState.Empty;
        }

        /// <summary>
        /// Gets or sets the state of the Cell.
        /// </summary>
        /// <value>
        /// The state of the Cell.
        /// </value>
        internal CellState State { get; set; }
    }
}
