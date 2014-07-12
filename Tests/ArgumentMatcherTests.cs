using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    using CSharpson;

    [TestClass]
    public class ArgumentMatcherTests
    {
        [TestMethod]
        public void BackupTest()
        {
            var argumentList = new string[]{"no", "none", "off", "simple", "never", "existing", "nil", "numbered", "t"};
            var valueList = new string[] {"no_backups", "no_backups", "no_backups", "simple_backups", "simple_backups", "numbered_existing_backups", "numbered_existing_backups", "numbered_backups", "numbered_backups" };
            var testMatcher = new ArgumentMatcher(argumentList, valueList);
            var testListSucceed = new string[] { "no", "no", "never", "exist", "numbered", "nil" };
            var testAmbiguous = new string[] { "n" };
            var testIncorrect = new string[] { "bad", "none", "redds" };
            var resultsSuccess = new string[]
                                     {
                                         "no_backups", "no_backups", "simple_backups", "numbered_existing_backups",
                                         "numbered_backups", "numbered_existing_backups"
                                     };
            for (var i = 0; i < testListSucceed.Length; i++)
            {
                Assert.IsTrue(resultsSuccess[i].Equals(testMatcher.MatchArgument(testListSucceed[i],"")));
            }
            try
            {
                testMatcher.MatchArgument(testAmbiguous[0],"");
            }
            catch (FormatException e)
            {
                Assert.IsTrue(e.Message.Substring(0,1).Equals("A"));
            }
            for (var i = 0; i < testIncorrect.Length; i++)
            {
                try
                {
                    testMatcher.MatchArgument(testIncorrect[i], "");
                }
                catch (FormatException e)
                {
                    Assert.IsTrue(e.Message.Substring(0,1).Equals("I"));
                }
            }

        }
    }
}
