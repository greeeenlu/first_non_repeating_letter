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
            Assert.AreEqual("a",Kata.FirstNonRepeatingLetter("a"));
        }
        [TestMethod]
        public void stress_return_t()
        {
            Assert.AreEqual("t",Kata.FirstNonRepeatingLetter("stress"));
        }
    }
}
