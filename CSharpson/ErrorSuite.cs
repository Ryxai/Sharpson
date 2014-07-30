// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ErrorSuite.cs" company="">
//   
// </copyright>
// <summary>
//   TODO The error suite.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Sharpson
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