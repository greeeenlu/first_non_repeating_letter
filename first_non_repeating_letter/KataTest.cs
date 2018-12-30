using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace first_non_repeating_letter
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void only_one_letter_return_this_one_letter()
        {
            var actual = Kata.FirstNonRepeatingLetter("a");
            Assert.AreEqual("a",actual);
        }
    }

    public class Kata
    {
        public static string FirstNonRepeatingLetter(string word)
        {
            return word;
        }
    }
}
