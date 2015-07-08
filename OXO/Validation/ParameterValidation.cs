// <copyright file="ParameterValidation.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2012-04-24</date>
// <summary>
// Contains parameter validation methods.
// </summary>

namespace GavinGreig.Validation
{
    using System.Collections.Generic;
    using System.Linq;
    using GavinGreig.Portable;

    /// <summary>
    /// Contains parameter validation methods.
    /// </summary>
    internal static class ParameterValidation
    {
        /// <summary>
        /// Ensures the specified value is not null; otherwise throws an ArgumentNullException.
        /// </summary>
        /// <typeparam name="T">The type of the object being checked.</typeparam>
        /// <param name="inValue">The value to check for null.</param>
        /// <param name="inName">The name of the value being checked, as a string.</param>
        /// <returns>The successfully checked value is returned.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if the object value is null.</exception>
        public static T EnsureNotNull<T>([ValidatedNotNull]T inValue, string inName)
        {
            if (inValue == null)
            {
                throw new System.ArgumentNullException(inName);
            }

            return inValue;
        }

        /// <summary>
        /// Ensures the GUID is not null or empty.
        /// </summary>
        /// <param name="inValue">The GUID to be checked.</param>
        /// <param name="inName">The parameter name of the GUID.</param>
        /// <returns>The validated GUID.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if the GUID is null.</exception>
        /// <exception cref="System.ArgumentException">Thrown if the GUID is non-null, but empty.</exception>
        public static System.Guid EnsureNotNullOrEmpty([ValidatedNotNull] System.Guid inValue, string inName)
        {
            if (inValue == null)
            {
                throw new System.ArgumentNullException(inName);
            }

            if (inValue == System.Guid.Empty)
            {
                throw new System.ArgumentException(inName);
            }

            return inValue;
        }

        /// <summary>
        /// Ensures the string is not null or empty.
        /// </summary>
        /// <param name="inValue">The string to be checked.</param>
        /// <param name="inName">The parameter name of the string.</param>
        /// <returns>The validated string.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if the string is null.</exception>
        /// <exception cref="System.ArgumentException">Thrown if the string is non-null, but empty.</exception>
        public static string EnsureNotNullOrEmpty([ValidatedNotNull] string inValue, string inName)
        {
            if (inValue == null)
            {
                throw new System.ArgumentNullException(inName);
            }

            if (string.IsNullOrEmpty(inValue))
            {
                throw new System.ArgumentException(inName);
            }

            return inValue;
        }

        /// <summary>
        /// Ensures a collection is non-empty.
        /// </summary>
        /// <typeparam name="TCollection">The type of the collection.</typeparam>
        /// <param name="inValue">The collection.</param>
        /// <param name="inName">Name of the collection.</param>
        /// <returns>The validated collection.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if the collection is null.</exception>
        /// <exception cref="System.ArgumentException">Thrown if the collection is non-null, but empty.</exception>
        public static TCollection EnsureNotNullOrEmpty<TCollection>([ValidatedNotNull] TCollection inValue, string inName)
            where TCollection : System.Collections.IEnumerable
        {
            if (inValue == null)
            {
                throw new System.ArgumentNullException(inName);
            }

            if (!inValue.GetEnumerator().MoveNext())
            {
                throw new System.ArgumentException(inName);
            }

            return inValue;
        }

        /// <summary>
        /// Ensures the specified value is of the expected type; otherwise throws an ArgumentException.
        /// </summary>
        /// <typeparam name="T">The type of the object being checked.</typeparam>
        /// <param name="inExpectedType">The expected type of the value..</param>
        /// <param name="inValue">The value to check for an expected type.</param>
        /// <param name="inName">The name of the value being checked, as a string.</param>
        /// <returns>The successfully checked value is returned.</returns>
        /// <exception cref="System.ArgumentException">Thrown if the object type is not as expected.</exception>
        public static T EnsureOfType<T>(System.Type inExpectedType, [ValidatedOfType]T inValue, string inName)
        {
            ParameterValidation.EnsureNotNull(inExpectedType, "inExpectedType");

            if (!IsOfType(inExpectedType, inValue))
            {
                string theMessage = string.Format(
                    System.Globalization.CultureInfo.CurrentCulture,
                    "An argument of type {0} was provided (expected {1}).",
                    inValue.GetType().GetGenericAwareFullTypeName(),
                    inExpectedType.GetGenericAwareFullTypeName());
                throw new ArgumentTypeException(theMessage, inName);
            }

            return inValue;
        }

        /// <summary>
        /// Determines whether the specified value is of the expected type.
        /// </summary>
        /// <param name="inExpectedType">The expected type of the value..</param>
        /// <param name="inValue">The value to check for an expected type.</param>
        /// <returns>
        /// Value is <see langword="true"/> if the specified value is of the expected type; otherwise <see langword="false"/>.
        /// </returns>
        public static bool IsOfType(System.Type inExpectedType, object inValue)
        {
            ParameterValidation.EnsureNotNull(inValue, "inValue");

            return inValue.GetType().IsInstanceOfType(inExpectedType);
        }
    }
}