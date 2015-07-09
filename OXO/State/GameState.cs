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
    internal class GameState
    {
        const int GridDimension = 3;
        private readonly Cell[,] myGrid = new Cell[GridDimension, GridDimension];

        GameState()
        {
            ForAllCells((i, j) => myGrid[i, j] = new Cell());
        }

        /// <summary>
        /// Displays the state of this game on the console.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Temporary")]
        internal void Display()
        {
        }

        internal void Reset()
        {
            ForAllCells((i, j) => myGrid[i, j].State = CellState.Empty);
        }

        private void ForAllCells<T>(Func<int, int, T> inFunction)
        {
            for (int i = 0; i < GridDimension; i++)
            {
                for (int j = 0; j < GridDimension; j++)
                {
                    inFunction(i, j);
                }
            }
        }
    }
}
