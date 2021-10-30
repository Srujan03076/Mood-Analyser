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

        #region UC-3
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodEmpty_ShouldThrowException()
        {
            MoodAnalyser obj = new MoodAnalyser();
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);

        }
        #endregion

        #region UC-4
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MSTestMoodAnalyser.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);

        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]

        public void GivenWrongClassName_ShouldThrowException()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MSTestMoodAnalyser.Moodanalyser", "MoodAnalyser");
            expected.Equals(obj);

        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenClassConstructerNotProper_ShouldThrowException()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MSTestMoodAnalyser.Moodanalyser", "MoodAnalyser(int)");
            expected.Equals(obj);

        }
        #endregion

        #region UC-5

        [TestMethod]
        public void GivenMoodAnalyser_ShouldReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MSTestMoodAnalyser.MoodAnalyser", "MoodAnalyser", "SAD");
            expected.Equals(obj);
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]

        public void GivenMoodAnalyserWrongClassName_ShouldThrowMoodAnalysisException()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MSTestMoodAnalyser.moodnalyser", "MoodAnalyser", "SAD");
            expected.Equals(obj);
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]

        public void GivenMoodAnalyserClassNameWithNoProperConstructor_ShouldThrowMoodAnalysisException()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MSTestMoodAnalyser.MoodAnalyser", "moodanalyser", "SAD");
            expected.Equals(obj);
        }
        #endregion
    }
}