/*
9. Driver’s License Exam
The local driver’s license office has asked you to design a program that grades the
written portion of the driver’s license exam. The exam has 20 multiple choice questions. Here are the correct answers:
1. B  6. A 11. B 16. C
2. D 7. B 12. C 17. C
3. A 8. A 13. D 18. B
4. A 9. C 14. A 19. D
5. C 10. D 15. D 20. A
Your program should store these correct answers in an array. (Store each question’s correct answer in an element of a Stringarray.) The program should ask the
user to enter the student’s answers for each of the 20 questions, which should be
stored in another array. After the student’s answers have been entered, the program
should display a message indicating whether the student passed or failed the exam.
(A student must correctly answer 15 of the 20 questions to pass the exam.) It
should then display the total number of correctly answered questions, the total
number of incorrectly answered questions, and a list showing the question numbers of the incorrectly answered questions.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___09.Driver_s_License_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var limit = 15;
            var length = 20;
            var correctAnswers = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
            var answersToTheTest = new string[length];
            var countPositive = 0;
            var countNegative = 0;
            

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Please enter the answer to question number {0}:", i + 1);
                answersToTheTest[i] = Console.ReadLine();
                if (answersToTheTest[i].ToLower() == correctAnswers[i].ToLower())
                {
                    countPositive++;
                }
                else
                {
                    countNegative++;
                }
            }

            if (countPositive >= limit)
            {
                Console.WriteLine("Congrats! You have passed the test!");
            }
            else
            {
                Console.WriteLine("I'm sorry, you have failed.");
            }
            Console.WriteLine("You have answered {0} questions correctly and {1} questions incorrectly.", countPositive, countNegative);
            Console.WriteLine();
            Console.WriteLine("These are the question numbers you have answered incorrectly:");
            for (int i = 0; i < length; i++)
            {
                if (answersToTheTest[i].ToLower() != correctAnswers[i].ToLower() && i != length - 1)
                {
                    Console.Write("{0}, ", i + 1);
                }
                else if (answersToTheTest[i].ToLower() != correctAnswers[i].ToLower() && i == length - 1)
                {
                    Console.Write("{0} ", i + 1);
                }
            }

        }
    }
}
