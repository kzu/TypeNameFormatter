﻿// Copyright (c) 2018 stakx
// License available at https://github.com/stakx/TypeNameFormatter/blob/master/LICENSE.md.

namespace TypeNameFormatter
{
    using System;

    /// <summary>
    ///   An enumeration of available options when a <see cref="Type"/> name's string representation is requested.
    /// </summary>
    [Flags]
    public enum TypeNameFormatOptions
    {
        /// <summary>
        ///   The default type name formatting options.
        /// </summary>
        Default = 0,

        /// <summary>
        ///   Specifies that a open generic type's parameter names should be included.
        ///   <example>
        ///     For example, the open generic type <see cref="IEquatable{T}"/> is formatted as <c>"IEquatable&lt;&gt;"</c> by default.
        ///     When this flag is specified, it will be formatted as <c>"IEquatable&lt;T&gt;"</c>.
        ///   </example>
        /// </summary>
        GenericParameterNames = 1,

        /// <summary>
        ///   Specifies that a type's namespace should be included.
        ///   <example>
        ///     For example, the type <see cref="Action"/> is formatted as <c>"Action"</c> by default.
        ///     When this flag is specified, it will be formatted as <c>"System.Action"</c>.
        ///   </example>
        /// </summary>
        Namespaces = 2,

        /// <summary>
        ///   Specifies that primitive types should not be mapped to their corresponding C# language keywords.
        ///   <example>
        ///     For example, the type <see cref="Int32"/> is formatted as <c>"int"</c> by default.
        ///     When this flag is specified, it will be formatted as <c>"Int32"</c>.
        ///   </example>
        /// </summary>
        NoKeywords = 4,
    }
}
