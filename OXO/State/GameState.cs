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
        /// A character used to display a vertical bar.
        /// </summary>
        /// <remarks>
        /// This is the standard "pipe" character on the keyboard.
        /// </remarks>
        private const char VerticalBar = '|';

        /// <summary>
        /// A character used to display a horizontal bar.
        /// </summary>
        /// <remarks>
        /// Tried an em dash character here (not found on the standard keyboard),
        /// but there were display problems, so reverted to a hyphen.
        /// </remarks>
        private const char HorizontalBar = '-';

        /// <summary>
        /// The square grid of 9 cells used in noughts and crosses.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Performance", 
            "CA1814:PreferJaggedArraysOverMultidimensional", 
            MessageId = "Member",
            Justification = "With fixed sizes, a jagged array would yield no benefit.")]
        private readonly Cell[,] myGrid = new Cell[Constant.GridDimension, Constant.GridDimension];

        /// <summary>
        /// A collection of possible winning paths across the noughts and crosses grid.
        /// </summary>
        private readonly List<Path> myPaths;

        /// <summary>
        /// Initialises a new instance of the <see cref="GameState"/> class.
        /// </summary>
        internal GameState()
        {
            // Wanted to refactor the multiple nested "for" loops in this class away into a 
            // single method that would accept a lambda as the action to take inside 
            // the loops, but had to back out due to lack of time when problems arose 
            // and reinstate the multiple loops .
            for (int i = 0; i < Constant.GridDimension; i++)
            {
                for (int j = 0; j < Constant.GridDimension; j++)
                {
                    Grid[i, j] = new Cell();
                }
            }

            myPaths = new List<Path>
                {
                    // Horizontal Paths
                    new Path(Grid[0, 0], Grid[0, 1], Grid[0, 2]),
                    new Path(Grid[1, 0], Grid[1, 1], Grid[1, 2]),
                    new Path(Grid[2, 0], Grid[2, 1], Grid[2, 2]),

                    // Vertical Paths
                    new Path(Grid[0, 0], Grid[1, 0], Grid[2, 0]),
                    new Path(Grid[0, 1], Grid[1, 1], Grid[2, 1]),
                    new Path(Grid[0, 2], Grid[1, 2], Grid[2, 2]),

                    // Diagonal Paths
                    new Path(Grid[0, 0], Grid[1, 1], Grid[2, 2]),
                    new Path(Grid[2, 0], Grid[1, 1], Grid[0, 2])
                };

            // Register an event handler for when any Path is completed.
            foreach (Path aPath in myPaths)
            {
                aPath.PathComplete += GameState_PathComplete;
            }
        }

        /// <summary>
        /// Gets the winning symbol. Null if no winner exists yet.
        /// </summary>
        /// <value>
        /// The winning symbol.
        /// </value>
        internal CellState WinningSymbol { get; private set; }

        /// <summary>
        /// Gets the grid containing the game cells.
        /// </summary>
        /// <value>
        /// The grid.grid containing the game cells.
        /// </value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Performance", 
            "CA1814:PreferJaggedArraysOverMultidimensional", 
            MessageId = "Member",
            Justification = "With fixed sizes, a jagged array would yield no benefit.")]
        internal Cell[,] Grid
        {
            get { return myGrid; }
        } 

        /// <summary>
        /// Resets the state of the game, so that another game can be played.
        /// </summary>
        /// <remarks>
        /// Sets all game cells to Empty.
        /// </remarks>
        internal void Reset()
        {
            for (int i = 0; i < Constant.GridDimension; i++)
            {
                for (int j = 0; j < Constant.GridDimension; j++)
                {
                    Grid[i, j].State = CellState.Empty;
                }
            }

            WinningSymbol = null;
        }

        /// <summary>
        /// Displays the state of this game on the console.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Temporary")]
        internal void Display()
        {
            Console.WriteLine(Resource.GameBoardIntroduction);
            Console.WriteLine();

            DisplayRow(0);
            DisplayHorizontalDivider();
            DisplayRow(1);
            DisplayHorizontalDivider();
            DisplayRow(2);
        }

        /// <summary>
        /// Displays the horizontal divider.
        /// </summary>
        private static void DisplayHorizontalDivider()
        {
            Console.Write(HorizontalBar);
            Console.Write(VerticalBar);
            Console.Write(HorizontalBar);
            Console.Write(VerticalBar);
            Console.WriteLine(HorizontalBar);
        }

        /// <summary>
        /// Displays the specified row of the noughts and crosses grid.
        /// </summary>
        /// <param name="inRowIndex">Index of the row to display.</param>
        private void DisplayRow(int inRowIndex)
        {
            StringBuilder theFirstRow = new StringBuilder();
            theFirstRow.Append(Grid[inRowIndex, 0].State);
            theFirstRow.Append(VerticalBar);
            theFirstRow.Append(Grid[inRowIndex, 1].State);
            theFirstRow.Append(VerticalBar);
            theFirstRow.Append(Grid[inRowIndex, 2].State);
            Console.WriteLine(theFirstRow);
        }

        /// <summary>
        /// Handles the PathComplete event of the GameState control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void GameState_PathComplete(object sender, PathCompleteEventArgs e)
        {
            // Set the winning symbol.
            WinningSymbol = e.WinningSymbol;
        }
    }
}
