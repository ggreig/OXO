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
        /// The Cell's grid coordinates within the game board.
        /// </summary>
        private readonly Tuple<int, int> myGridCoordinates;

        /// <summary>
        /// The state of the Cell.
        /// </summary>
        private CellState myState;

        /// <summary>
        /// Initialises a new instance of the <see cref="Cell" /> class.
        /// </summary>
        /// <param name="inRowIndex">The index of the grid row the cell is in.</param>
        /// <param name="inColumnIndex">The index of the grid column the cell is in.</param>
        /// <remarks>
        /// Letting the cell know where it is by telling it its row and column indices
        /// would be a risky design decision if there was any possibility that they 
        /// could change. However, we know that the noughts and crosses grid is not
        /// likely to change(!), so we'll take that risk - it gives the cell the ability
        /// to feed back that information itself, which is very helpful.
        /// </remarks>
        internal Cell(int inRowIndex, int inColumnIndex)
        {
            State = CellState.Empty;
            myGridCoordinates = new Tuple<int, int>(inRowIndex, inColumnIndex);
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="Cell"/> class from being created.
        /// </summary>
        private Cell()
        {
        }

        /// <summary>
        /// Occurs when the state of the cell is changed.
        /// </summary>
        internal event EventHandler StateChanged;

        /// <summary>
        /// Gets the grid coordinates.
        /// </summary>
        /// <value>
        /// The grid coordinates.
        /// </value>
        internal Tuple<int, int> GridCoordinates
        {
            get
            {
                return myGridCoordinates;
            }
        }

        /// <summary>
        /// Gets the index of the row the cell is in.
        /// </summary>
        /// <value>
        /// The index of the row the cell is in.
        /// </value>
        internal int RowIndex
        {
            get
            {
                return myGridCoordinates.Item1;
            }
        }

        /// <summary>
        /// Gets the index of the column the cell is in.
        /// </summary>
        /// <value>
        /// The index of the column the cell is in.
        /// </value>
        internal int ColumnIndex
        {
            get
            {
                return myGridCoordinates.Item2;
            }
        }

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
