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
        /// The state of the Cell.
        /// </summary>
        private CellState myState;

        /// <summary>
        /// Initialises a new instance of the <see cref="Cell"/> class.
        /// </summary>
        internal Cell()
        {
            State = CellState.Empty;
        }

        /// <summary>
        /// Occurs when the state of the cell is changed.
        /// </summary>
        internal event EventHandler StateChanged;

        /// <summary>
        /// Gets or sets the state of the Cell.
        /// </summary>
        /// <value>
        /// The state of the Cell.
        /// </value>
        internal CellState State 
        { 
            get
            {
                return myState;
            }

            set
            {
                if (value != myState)
                {
                    myState = value;
                    OnStateChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Raises the <see cref="E:StateChanged"/> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void OnStateChanged(EventArgs eventArgs)
        {
            EventHandler theHandler = StateChanged;
            
            if (theHandler != null)
            {
                theHandler(this, eventArgs);
            }
        }
    }
}
