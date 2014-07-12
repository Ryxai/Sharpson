// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParseInput.cs" company="Ryxai">
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
//   TODO The parse input.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CSharpson
{
    using System.Collections.Generic;

    /// <summary>
    /// TODO The parse input.
    /// </summary>
    internal class ParseInput
    {
        #region Constants

        /// <summary>
        /// TODO The skeleton.
        /// </summary>
        public const string skeleton = null;

        #endregion

        #region Static Fields

        /// <summary>
        /// TODO The valid languages.
        /// </summary>
        private static readonly List<BisonLanguage> ValidLanguages = new List<BisonLanguage>()
                                                                         {
                                                                             new BisonLanguage(
                                                                                 "c", 
                                                                                 "c-skel.m4", 
                                                                                 ".c", 
                                                                                 ".h", 
                                                                                 true), 
                                                                             new BisonLanguage(
                                                                                 "c++", 
                                                                                 "c++-skel.m4", 
                                                                                 "cc", 
                                                                                 ".hh", 
                                                                                 true), 
                                                                             new BisonLanguage(
                                                                                 "java", 
                                                                                 "java-skel.m4", 
                                                                                 ".java", 
                                                                                 ".java", 
                                                                                 false), 
                                                                             new BisonLanguage(
                                                                                 "c#", 
                                                                                 "c#-skel.m4", 
                                                                                 ".cs", 
                                                                                 ".cs", 
                                                                                 false), 
                                                                             new BisonLanguage(
                                                                                 string.Empty, 
                                                                                 string.Empty, 
                                                                                 string.Empty, 
                                                                                 string.Empty, 
                                                                                 false)
                                                                         };

        #endregion

        #region Fields

        /// <summary>
        /// TODO The define flag.
        /// </summary>
        public bool DefineFlag;

        /// <summary>
        /// TODO The glr parse.
        /// </summary>
        public bool GLRParse = false;

        /// <summary>
        /// TODO The graph flag.
        /// </summary>
        public bool GraphFlag;

        /// <summary>
        /// TODO The language priority.
        /// </summary>
        public int LanguagePriority = (int)Constants.PriorityArgs.Default;

        /// <summary>
        /// TODO The no lines flag.
        /// </summary>
        public bool NoLinesFlag;

        /// <summary>
        /// TODO The nondeterministic parser.
        /// </summary>
        public bool NondeterministicParser = false;

        /// <summary>
        /// TODO The skeleton priority.
        /// </summary>
        public int SkeletonPriority = (int)Constants.PriorityArgs.Default;

        /// <summary>
        /// TODO The token table flag.
        /// </summary>
        public bool TokenTableFlag;

        /// <summary>
        /// TODO The xml flag.
        /// </summary>
        public bool XmlFlag;

        /// <summary>
        /// TODO The yacc flag.
        /// </summary>
        public bool YaccFlag;

        /// <summary>
        /// TODO The language.
        /// </summary>
        public BisonLanguage language = ValidLanguages[0];

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// TODO The match flag arguments.
        /// </summary>
        /// <param name="option">
        /// TODO The option.
        /// </param>
        /// <param name="keys">
        /// TODO The keys.
        /// </param>
        /// <param name="values">
        /// TODO The values.
        /// </param>
        /// <param name="all">
        /// TODO The all.
        /// </param>
        /// <param name="arg">
        /// TODO The arg.
        /// </param>
        /// <param name="prefixLength">
        /// TODO The prefix length.
        /// </param>
        public static void MatchFlagArguments(
            string option, 
            string[] keys, 
            int[] values, 
            int all, 
            string arg, 
            int prefixLength)
        {
        }

        #endregion

        /// <summary>
        /// TODO The bison language.
        /// </summary>
        public struct BisonLanguage
        {
            #region Fields

            /// <summary>
            /// TODO The add tab.
            /// </summary>
            public bool AddTab;

            /// <summary>
            /// TODO The header extension.
            /// </summary>
            public string HeaderExtension;

            /// <summary>
            /// TODO The language.
            /// </summary>
            public string Language;

            /// <summary>
            /// TODO The skeleton.
            /// </summary>
            public string Skeleton;

            /// <summary>
            /// TODO The source extension.
            /// </summary>
            public string SourceExtension;

            #endregion

            #region Constructors and Destructors

            /// <summary>
            /// Initializes a new instance of the <see cref="BisonLanguage"/> struct.
            /// </summary>
            /// <param name="language">
            /// TODO The language.
            /// </param>
            /// <param name="skeleton">
            /// TODO The skeleton.
            /// </param>
            /// <param name="sourceExtension">
            /// TODO The source extension.
            /// </param>
            /// <param name="headerExtension">
            /// TODO The header extension.
            /// </param>
            /// <param name="addTab">
            /// TODO The add tab.
            /// </param>
            public BisonLanguage(
                string language, 
                string skeleton, 
                string sourceExtension, 
                string headerExtension, 
                bool addTab)
            {
                this.Language = language;
                this.Skeleton = skeleton;
                this.SourceExtension = sourceExtension;
                this.HeaderExtension = headerExtension;
                this.AddTab = addTab;
            }

            #endregion
        }
    }
}