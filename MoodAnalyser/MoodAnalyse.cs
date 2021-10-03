using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
  public class MoodAnalyse
    {
        public string message; //Declare string
        /// <summary>
        /// Parameterized Constructor to initilaize data
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyse(string message)
        {
            this.message = message; 
        }
        /// <summary>
        /// Method to check the mood Happy or Sad
        /// </summary>
        /// <returns></returns>
        public string Analyser()
        {
            if (this.message.ToLower().Contains("sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}
