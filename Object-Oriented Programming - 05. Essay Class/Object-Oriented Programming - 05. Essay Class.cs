/*
5. EssayClass
Design an Essayclass that extends the GradedActivityclass presented in this
chapter. The Essayclass should determine the grade a student receives for an 
essay. The student’s essay score can be up to 100 and is determined in the following manner:
● Grammar: up to 30 points
● Spelling: up to 20 points
● Correct length: up to 20 points
● Content: up to 30 points
Once you have designed the class, design a program that prompts the user to 
enter the number of points that a student has earned for grammar, spelling, 
length, and content. Create an Essayobject and store this data in the object. Use
the object’s methods to get the student’s overall score and grade, and display this
data on the screen.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming___05.Essay_Class
{

    class GradedActivity
    {
        private double score;

        public void setScore(double score)
        {
            this.score = score;
        }

        public double getScore()
        {
            return this.score;
        }

        public string getGrade()
        {
            var grade = "";
            if (this.score >= 90)
            {
                grade = "A";
            }
            else if (this.score >= 80)
            {
                grade = "B";
            }
            else if (this.score >= 70)
            {
                grade = "C";
            }
            else if (this.score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            return grade;
        }
    }

    class Essay : GradedActivity
    {
        private double grammer;
        private double spelling;
        private double length;
        private double content;

        public Essay(double grammer, double spelling, double length, double content)
        {
            this.grammer = grammer;
            this.spelling = spelling;
            this.length = length;
            this.content = content;

        }

        public void calculateScore() // could move this into the constructor
        {
            var score = this.grammer + this.spelling + this.length + this.content;
           
            setScore(score);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the student's scores for grammar, spelling, length and content:");
            var grammar = double.Parse(Console.ReadLine());
            var spelling = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());
            var content = double.Parse(Console.ReadLine());

            Essay essay = new Essay(grammar, spelling, length, content);
            essay.calculateScore(); // don't forget to calculate the score
            Console.WriteLine("The student's score is {0}", essay.getScore());
            Console.WriteLine("The student's grade is {0}", essay.getGrade());
          
            
        }
    }
}
