using MSTestMoodAnalyser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        #region TC 1.1
        [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in happy mood");
            string result = obj.analyseMood();
            Assert.AreEqual("SAD", result);
        }
        #endregion


        #region TC 1.2
        [TestMethod]
        public void GivenMoodSad_ShouldReturnSad()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in sad mood ");
            string result = obj.analyseMood();
            Assert.AreEqual("SAD", result);
        }
        #endregion


        #region TC 2.1
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodNull_ShouldThrowException()
        {
            MoodAnalyser obj = new MoodAnalyser(null);
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);
        }
        #endregion
    }
}
