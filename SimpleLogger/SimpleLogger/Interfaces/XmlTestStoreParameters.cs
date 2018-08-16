// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SimpleLogger.ObjectModel
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Optional parameters to the persistence process. A class implementing IPersistable can 
    /// use the parameter values to alter its load/save behavior.
    /// </summary>
    /// <example>
    /// Example: a class has a summary and details fields. Details are large, so they're only 
    /// saved when 'MyClass.SaveDetails' parameter is set to 'true'.
    /// </example>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    internal sealed class XmlTestStoreParameters : Dictionary<string, object>
    {
        private XmlTestStoreParameters()
        {
        }

        /// <summary>
        /// To create XmlTestStoreParameters object
        /// </summary>
        /// <returns>
        /// The <see cref="XmlTestStoreParameters"/>.
        /// </returns>
        public static XmlTestStoreParameters GetParameters()
        {
            return new XmlTestStoreParameters();
        }

        /// <summary>
        /// Check for the parameter
        /// </summary>
        /// <param name="parameter">
        /// The parameter.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Contains(string parameter)
        {
            return this.ContainsKey(parameter);
        }
    }
}
