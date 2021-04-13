// Anita Martin
// amartin98@cnm.edu
// WPF Data Demo
// Objectives: 
//      1.1.    Demonstrate how to create a database.
//      1.2.	Demonstrate how to open and use database connections.
//      1.3.	Demonstrate how to use database commands.
//      1.4.	Demonstrate how to use a DataReader.


using System;

namespace WPFDemo
{
    public class Assignment
    {
        public string Title { get; set; }
        private int score;

        public int Score
        {
            get { return score; }
            set
            {
                //Validate list of scores pased in as value
                if (value >= 0 && value <= 100)
                {
                    score = value;
                }
                else//it's not valid, throw an exception
                {
                    throw new ArgumentOutOfRangeException("Scores must be between 0 and 100");
                }
            }
        }
        public override string ToString()
        {
            return Title + " " + score;
        }
    }
}
