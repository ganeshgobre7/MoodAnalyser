using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace TestMood
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethodSad()
        {
            MoodAnalyse mood = new MoodAnalyse("I am in sad Mood");
            string res = mood.Analyser();
            Assert.AreEqual("Sad", res);
        }
        [TestMethod]
        public void TestMethodHappy()
        {
            MoodAnalyse mood = new MoodAnalyse("I am in any Mood");
            string res = mood.Analyser();
            Assert.AreEqual("Happy", res);
        }
    }
}
