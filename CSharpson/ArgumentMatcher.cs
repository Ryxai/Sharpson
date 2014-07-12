// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArgumentMatcher.cs" company="">
//   
// </copyright>
// <summary>
//   Matches the input arguments to a list of predefined options
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CSharpson
{
    using System;
    using System.Text;

    /// <summary>
    /// Matches the input arguments to a list of predefined options
    /// </summary>
    public class ArgumentMatcher
    {
        #region Fields

        /// <summary>
        /// The list of potential arguments
        /// </summary>
        private readonly string[] argumentList;

        /// <summary>
        /// A list of mappable values for arguments
        /// </summary>
        private readonly string[] valueList;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentMatcher"/> class.
        /// </summary>
        /// <param name="initArgumentList">
        /// A list of arguments
        /// </param>
        /// <param name="initValueList">
        /// A mappable list of values for arguments 
        /// </param>
        public ArgumentMatcher(string[] initArgumentList, string[] initValueList)
        {
            this.argumentList = initArgumentList;
            this.valueList = initValueList;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// A pubic interface to match arguments. If a successful match is found it returns the matched string, otherwise
        /// it throws a format exception and terminates execution (the program cannot proceed without the arguments being correct)
        /// </summary>
        /// <param name="argument">
        /// The argument to be matched
        /// </param>
        /// <param name="contextOfArgument">
        /// The context of the argument being called.
        /// </param>
        /// <returns>
        /// Returns the value matching the provided argument.
        /// </returns>
        /// <exception cref="FormatException">
        /// An exception to be thrown if the 
        /// </exception>
        public string MatchArgument(string argument, string contextOfArgument)
        {
            int result = this.getClosestArgumentIndex(argument);
            if (result >= 0)
            {
                return this.valueList[result];
            }

            throw this.OutputError(argument, result, contextOfArgument);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Builds an exception and message to throw.
        /// </summary>
        /// <param name="argument">
        /// The argument provided that could not be matched
        /// </param>
        /// <param name="matchedIndex">
        /// The index matched by the matcher, is either unmatched or ambiguous 
        /// </param>
        /// <param name="contextOfArgument">
        /// The context in which the argument has been called.
        /// </param>
        /// <exception cref="FormatException">
        /// </exception>
        /// <returns>
        /// Returns a format exception representing the fault of the program to match the provided argument, should not be caught
        /// </returns>
        private Exception OutputError(string argument, int matchedIndex, string contextOfArgument)
        {
            var errorMessageBuilder = new StringBuilder();
            errorMessageBuilder.Append(
                ((matchedIndex == (int)Constants.ArgMatchResult.NoMatch) ? "Invalid argument " : "Ambiguous argument ")
                + string.Format("{0} for {1}", argument, contextOfArgument));
            var lastValue = string.Empty;

            // Appending a list of suggested arguments
            for (int i = 0; i < this.argumentList.Length; i++)
            {
                if (i == 0 || lastValue.Equals(this.valueList[i]))
                {
                    errorMessageBuilder.AppendLine(string.Format(" - {0}", this.argumentList[i]));
                    lastValue = this.valueList[i];
                }
                else
                {
                    errorMessageBuilder.Append(string.Format(", {0}", this.argumentList[i]));
                }
            }

            errorMessageBuilder.Append("\n");
            return new FormatException(errorMessageBuilder.ToString());
        }

        /// <summary>
        /// Matches the argument to a predefined list returning the matching index
        /// </summary>
        /// <param name="argument">
        /// The argument to be matched
        /// </param>
        /// <returns>
        /// Returns the matched index in the form of an <see cref="int"/>
        /// </returns>
        private int getClosestArgumentIndex(string argument)
        {
            var matchIndex = (int)Constants.ArgMatchResult.NoMatch;
            var ambiguous = false;
            for (var i = 0;
                 i < this.argumentList.Length && (this.argumentList[i] != string.Empty || this.argumentList[i] != null);
                 i++)
            {
                if (string.Compare(argument, 0, this.argumentList[i], 0, argument.Length) == 0)
                {
                    if (argument.Length == this.argumentList[i].Length)
                    {
                        return i;
                    }
                    else if (matchIndex == (int)Constants.ArgMatchResult.NoMatch)
                    {
                        // First potentially ambiguous match
                        matchIndex = i;
                    }
                    else
                    {
                        // Second potentially ambiguous match
                        if (this.valueList == null || this.valueList.Length == 0
                            || this.valueList[matchIndex].Equals(this.valueList[i]))
                        {
                            ambiguous = true;
                        }
                    }
                }
            }

            if (ambiguous)
            {
                return (int)Constants.ArgMatchResult.Ambigious;
            }

            return matchIndex;
        }

        #endregion
    }
}