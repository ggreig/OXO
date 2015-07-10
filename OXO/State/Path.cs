// <copyright file="Path.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-09</date>
// <summary>
// A class representing a possible winning path across the noughts and crosses grid.
// </summary>

namespace GavinGreig.OXO.State
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GavinGreig.Validation;

    /// <summary>
    /// A class representing a possible winning path across the noughts and crosses grid.
    /// </summary>
    internal sealed class Path
    {
        /// <summary>
        /// The cells included in the path.
        /// </summary>
        private readonly Cell[] myCells = new Cell[Constant.GridDimension];

        /// <summary>
        /// Initialises a new instance of the <see cref="Path"/> class.
        /// </summary>
        /// <param name="inCell0">The in cell1.</param>
        /// <param name="inCell1">The in cell2.</param>
        /// <param name="inCell2">The in cell3.</param>
        internal Path(Cell inCell0, Cell inCell1, Cell inCell2)
        {
            ParameterValidation.EnsureNotNull(inCell0, "inCell0");
            ParameterValidation.EnsureNotNull(inCell1, "inCell1");
            ParameterValidation.EnsureNotNull(inCell2, "inCell2");

            if (inCell0 == inCell1)
            {
                ThrowDuplicateCellException("inCell0", "inCell1");
            }

            if (inCell1 == inCell2)
            {
                ThrowDuplicateCellException("inCell1", "inCell2");
            }

            if (inCell0 == inCell2)
            {
                ThrowDuplicateCellException("inCell0", "inCell2");
            }

            // Record the cells in the path.
            myCells[0] = inCell0;
            myCells[1] = inCell1;
            myCells[2] = inCell2;

            // Register an event handler for when any Cell in the Path changes.
            foreach (Cell aCell in myCells)
            {
                aCell.StateChanged += Path_CellStateChanged;
            }
        }

        /// <summary>
        /// Occurs when either X or O has completed the path.
        /// </summary>
        internal event EventHandler<PathCompleteEventArgs> PathComplete;

        /// <summary>
        /// Throws a duplicate cell exception with a well-formatted message identifying
        /// the (first) duplicate found.
        /// </summary>
        /// <param name="inParameterName1">The parameter name referring to one instance of the duplicate cell.</param>
        /// <param name="inParameterName2">The parameter name referring to the second instance of the duplicate cell.</param>
        /// <exception cref="System.ArgumentException">Thrown when any two cells match.</exception>
        private static void ThrowDuplicateCellException(string inParameterName1, string inParameterName2)
        {
            string theExceptionMessage = string.Format(
                CultureInfo.CurrentCulture,
                Resource.DuplicateCellsInPath,
                inParameterName1,
                inParameterName2);
            throw new ArgumentException(theExceptionMessage);
        }

        /// <summary>
        /// Handles the event of a <see cref="Cell"/>' state changing. If all cells in the
        /// Path now have either the <see cref="CellState"/> X or the <see cref="CellState"/> Y,
        /// that player has won.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Path_CellStateChanged(object sender, EventArgs e)
        {
            DetectAWinFor(CellState.X);
            DetectAWinFor(CellState.O);
        }

        /// <summary>
        /// Detects whether the specified symbol has won.
        /// </summary>
        /// <param name="inContender">The contender.</param>
        private void DetectAWinFor(CellState inContender)
        {
            if (myCells.Count(x => x.State == inContender) == Constant.GridDimension)
            {
                // The specified contender has won.
                PathCompleteEventArgs thePathCompletionData = new PathCompleteEventArgs { WinningSymbol = inContender };
                OnPathComplete(thePathCompletionData);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:PathComplete" /> event.
        /// </summary>
        /// <param name="inPathCompletionData">The <see cref="PathCompleteEventArgs"/> instance containing the event data.</param>
        private void OnPathComplete(PathCompleteEventArgs inPathCompletionData)
        {
            EventHandler<PathCompleteEventArgs> theHandler = PathComplete;
            
            if (theHandler != null)
            {
                theHandler(this, inPathCompletionData);
            }
        }
    }
}
