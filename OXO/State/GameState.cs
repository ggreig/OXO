// <copyright file="GameState.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2015-07-09</date>
// <summary>
// A class containing the state of the noughts and crosses game.
// </summary>

namespace GavinGreig.OXO.State
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class containing the state of the noughts and crosses game.
    /// </summary>
    internal sealed class GameState
    {
        /// <summary>
        /// The dimension, or size, of the square grid of <see cref="Cell"/>s.
        /// </summary>
        private const int GridDimension = 3;

        /// <summary>
        /// The square grid of 9 cells used in noughts and crosses.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Performance", 
            "CA1814:PreferJaggedArraysOverMultidimensional", 
            MessageId = "Member",
            Justification = "With fixed sizes, a jagged array would yield no benefit.")]
        private readonly Cell[,] myGrid = new Cell[GridDimension, GridDimension];

        /// <summary>
        /// Initialises a new instance of the <see cref="GameState"/> class.
        /// </summary>
        internal GameState()
        {
            ForAllCells(x => x = new Cell());
        }

        /// <summary>
        /// Displays the state of this game on the console.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Temporary")]
        internal void Display()
        {
        }

        /// <summary>
        /// Resets the state of the game, so that another game can be played.
        /// </summary>
        internal void Reset()
        {
            ForAllCells(x => x.State = CellState.Empty);
        }

        /// <summary>
        /// Applies an action to all the <see cref="Cell"/>s in the grid.
        /// </summary>
        /// <param name="inMethod">The action to apply to the cells.</param>
        /// <remarks>
        /// This method saves having to iterate through both dimensions
        /// of the array in-line when an action has to be applied to all cells.
        /// </remarks>
        private void ForAllCells(Action<Cell> inMethod)
        {
            for (int i = 0; i < GridDimension; i++)
            {
                for (int j = 0; j < GridDimension; j++)
                {
                    inMethod(myGrid[i, j]);
                }
            }
        }
    }
}
