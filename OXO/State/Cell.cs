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
    internal class Cell
    {
        internal CellState State { get; set; }
    }
}
