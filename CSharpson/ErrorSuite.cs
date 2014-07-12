// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ErrorSuite.cs" company="Ryxai">
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
//   TODO The error suite.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CSharpson
{
    /// <summary>
    /// TODO The error suite.
    /// </summary>
    internal class ErrorSuite
    {
        #region Enums

        /// <summary>
        /// TODO The warning bitwise exponents.
        /// </summary>
        private enum WarningBitwiseExponents
        {
            /// <summary>
            /// TODO The mid rule values.
            /// </summary>
            MidRuleValues, 

            /// <summary>
            /// TODO The yacc.
            /// </summary>
            Yacc, 

            /// <summary>
            /// TODO The confilcts sr.
            /// </summary>
            ConfilctsSR, 

            /// <summary>
            /// TODO The conflicts rr.
            /// </summary>
            ConflictsRR, 

            /// <summary>
            /// TODO The empty rule.
            /// </summary>
            EmptyRule, 

            /// <summary>
            /// TODO The deprecated.
            /// </summary>
            Deprecated, 

            /// <summary>
            /// TODO The precedence.
            /// </summary>
            Precedence, 

            /// <summary>
            /// TODO The other.
            /// </summary>
            Other, 

            /// <summary>
            /// TODO The size.
            /// </summary>
            Size
        }

        /// <summary>
        /// TODO The warning codes.
        /// </summary>
        private enum WarningCodes
        {
            /// <summary>
            /// TODO The none.
            /// </summary>
            None = 0, 

            /// <summary>
            /// TODO The mid rule values.
            /// </summary>
            MidRuleValues = 1 << WarningBitwiseExponents.MidRuleValues, 

            /// <summary>
            /// TODO The yacc.
            /// </summary>
            Yacc = 1 << WarningBitwiseExponents.Yacc, 

            /// <summary>
            /// TODO The conflicts sr.
            /// </summary>
            ConflictsSR = 1 << WarningBitwiseExponents.ConfilctsSR, 

            /// <summary>
            /// TODO The conflict rr.
            /// </summary>
            ConflictRR = 1 << WarningBitwiseExponents.ConflictsRR, 

            /// <summary>
            /// TODO The deprecated.
            /// </summary>
            Deprecated = 1 << WarningBitwiseExponents.Deprecated, 

            /// <summary>
            /// TODO The precedence.
            /// </summary>
            Precedence = 1 << WarningBitwiseExponents.Precedence, 

            /// <summary>
            /// TODO The other.
            /// </summary>
            Other = 1 << WarningBitwiseExponents.Other, 

            /// <summary>
            /// TODO The complaint.
            /// </summary>
            Complaint = 1 << 11, 

            /// <summary>
            /// TODO The fatal.
            /// </summary>
            Fatal = 1 << 12, 

            /// <summary>
            /// TODO The silent.
            /// </summary>
            Silent
        }

        #endregion
    }
}