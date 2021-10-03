using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        public string message; //Declare string

        public MoodAnalyse()
        {
            this.message = "I am in Sad Mood";
        }
        /// <summary>
        /// Method to check the mood Happy or Sad
        /// </summary>
        /// <returns></returns>
        public string Analyser()
        {
            if (this.message.ToLower().Contains("sad"))
            {
                return "Sad";
            }
            else if (this.message.ToLower().Contains("happy"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }

        }
    }
}
