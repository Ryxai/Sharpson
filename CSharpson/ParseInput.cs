// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParseInput.cs" company="">
//   
// </copyright>
// <summary>
//   TODO The parse input.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Sharpson
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

        public void GetArguments(string[] arguments)
        {
            
        }
        #endregion

        /// <summary>
        /// Information container for output languages for bison
        /// </summary>
        public struct BisonLanguage
        {
            #region Fields

            /// <summary>
            /// Boolean flag whether tabs should be added
            /// </summary>
            public bool AddTab;

            /// <summary>
            /// Extension for header files of the given language
            /// </summary>
            public string HeaderExtension;

            /// <summary>
            /// Name of the output language
            /// </summary>
            public string Language;

            /// <summary>
            /// Filename for structural file representing the given language. Consumed to produce output.
            /// </summary>
            public string Skeleton;

            /// <summary>
            /// Extension for given code files
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