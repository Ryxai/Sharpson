// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArgumentMatcherTests.cs" company="">
//   
// </copyright>
// <summary>
//   Test suite for the <see cref="ArgumentMatcher"/> class
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Sharpson;

    /// <summary>
    /// Test for the <see cref="ArgumentMatcher" /> class
    /// </summary>
    [TestClass]
    public class ArgumentMatcherTests
    {
        #region Public Methods and Operators

        /// <summary>
        /// Backup test found in the original argument matcher file.
        /// </summary>
        [TestMethod]
        public void BackupTest()
        {
            var argumentList = new[]
                                   {
                                      "no", "none", "off", "simple", "never", "existing", "nil", "numbered", "t" 
                                   };
            var valueList = new[]
                                {
                                    "no_backups", "no_backups", "no_backups", "simple_backups", "simple_backups", 
                                    "numbered_existing_backups", "numbered_existing_backups", "numbered_backups", 
                                    "numbered_backups"
                                };
            var testMatcher = new ArgumentMatcher(argumentList, valueList);
            var testListSucceed = new[] { "no", "no", "never", "exist", "numbered", "nil" };
            var testAmbiguous = new[] { "n" };
            var testIncorrect = new[] { "bad", "none", "redds" };
            var resultsSuccess = new[]
                                     {
                                         "no_backups", "no_backups", "simple_backups", "numbered_existing_backups", 
                                         "numbered_backups", "numbered_existing_backups"
                                     };
            for (var i = 0; i < testListSucceed.Length; i++)
            {
                Assert.IsTrue(resultsSuccess[i].Equals(testMatcher.MatchArgument(testListSucceed[i], string.Empty)));
            }

            try
            {
                testMatcher.MatchArgument(testAmbiguous[0], string.Empty);
            }
            catch (FormatException e)
            {
                Assert.IsTrue(e.Message.Substring(0, 1).Equals("A"));
            }

            for (var i = 0; i < testIncorrect.Length; i++)
            {
                try
                {
                    testMatcher.MatchArgument(testIncorrect[i], string.Empty);
                }
                catch (FormatException e)
                {
                    Assert.IsTrue(e.Message.Substring(0, 1).Equals("I"));
                }
            }
        }

        #endregion
    }
}