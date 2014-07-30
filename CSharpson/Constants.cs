// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Constants.cs" company="Ryxai">
//   The MIT License (MIT)
//   
//   Copyright (c) 2014 Ryxai
//   
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//   of this software and associated documentation files (the "Software"), to deal
//   in the Software without restriction, including without limitation the rights
//   to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//   copies of the Software, and to permit persons to whom the Software is
//   furnished to do so, subject to the following conditions:
//   
//   The above copyright notice and this permission notice shall be included in
//   all copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//   AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//   LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//   OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//   THE SOFTWARE.
// </copyright>
// <summary>
//   TODO The constants.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Sharpson
{
    /// <summary>
    /// A class of static constants
    /// </summary>
    internal static class Constants
    {
        #region Constants
        #endregion

        #region Enums

        /// <summary>
        /// Used in argument matching, arguments if entered incorrectly 
        /// can have no match or match more than one. This enum provides
        /// an interface for that purpose.  
        /// </summary>
        public enum ArgMatchResult
        {
            /// <summary>
            /// There is no match result
            /// </summary>
            NoMatch = -1, 

            /// <summary>
            /// The match is ambiguous
            /// </summary>
            Ambigious = -2
        }

        /// <summary>
        /// TODO The priority args.
        /// </summary>
        public enum PriorityArgs
        {
            /// <summary>
            /// TODO The command line.
            /// </summary>
            CommandLine, 

            /// <summary>
            /// TODO The grammar.
            /// </summary>
            Grammar, 

            /// <summary>
            /// TODO The default.
            /// </summary>
            Default
        }

        public enum HasArguments
        {
            NoArgument = 0,
            RequiredArgument = 1,
            OptionalArgument = 2
        }

        public enum ArgumentEnumerationMode
        {
            RequireOrder = 0,
            ReturnInOrder = 1,
            Permute = 2
        }

        #endregion

    }
}