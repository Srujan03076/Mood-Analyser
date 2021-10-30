using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestMoodAnalyser
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser()
        {
        }
        public string analyseMood()
        {
            if (this.message.Contains("sad"))
                return "SAD";
            else if (this.message.Contains("happy"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}