// <copyright file="ArgumentTypeException.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2013-08-30</date>
// <summary>
// An exception that indicates the use of an unexpected type.
// </summary>

namespace GavinGreig.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// An exception that indicates the use of an unexpected type.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Microsoft.Design", 
        "CA1032:ImplementStandardExceptionConstructors",
        Justification = "Class copied from a PCL library; extension beyond scope of this exercise.")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Microsoft.Usage", 
        "CA2237:MarkISerializableTypesWithSerializable",
        Justification = "Class copied from a PCL library; extension beyond scope of this exercise.")]
    internal sealed class ArgumentTypeException : System.ArgumentException
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ArgumentTypeException"/> class.
        /// </summary>
        public ArgumentTypeException() : base()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ArgumentTypeException"/> class.
        /// </summary>
        /// <param name="inMessage">The error message.</param>
        public ArgumentTypeException(string inMessage) : base(inMessage)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ArgumentTypeException" /> class.
        /// </summary>
        /// <param name="inMessage">The error message.</param>
        /// <param name="inException">The inner exception.</param>
        public ArgumentTypeException(string inMessage, System.Exception inException)
            : base(inMessage, inException)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ArgumentTypeException" /> class.
        /// </summary>
        /// <param name="inMessage">The error message.</param>
        /// <param name="inParameterName">The name of the parameter with the unexpected type.</param>
        public ArgumentTypeException(string inMessage, string inParameterName)
            : base(inMessage, inParameterName)
        {
        }
    }
}
