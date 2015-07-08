// <copyright file="ValidatedNotNullAttribute.cs" company="Gavin Greig">
//      Copyright (c) Dr. Gavin T.D. Greig, 2015.
// </copyright>
// <author>Dr. Gavin T.D. Greig</author>
// <date>2012-04-24</date>
// <summary>
// An attribute that requires that a parameter be validated as not null.
// </summary>

namespace GavinGreig.Validation
{
    /// <summary>
    /// An attribute that requires that a parameter be validated as not null.
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Parameter, AllowMultiple = false)]
    internal sealed class ValidatedNotNullAttribute : global::System.Attribute
    {
    }
}