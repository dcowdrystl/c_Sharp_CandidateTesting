using System;
using System.Collections.Generic;
namespace Unit_1_Candidate_Testing_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string candidateAnswer;
            double correctAnswer = 0;
            double grade =0;
            List<string> questions = new List<string> { "Who was the first American woman in space?", "True or false: 5 kilometer == 5000 meters? ", "(5 + 3)/2 * 10 = ? ", "Given the array [8, 'Orbit', 'Trajectory', 45], what entry is at index 2? ", "What is the minimum crew size for the ISS? " };
            List<string> correctAnswers = new List<string> { "Sally Ride", "true", "40", "Trajectory", "3" };
            List<string> answers = new List<string>();
            foreach (string question in questions)
            {
                Console.WriteLine(question);
                candidateAnswer = Console.ReadLine();
                answers.Add(candidateAnswer);

            }
            Console.WriteLine("\n");
            for (int i = 0; i < answers.Count; i++)
            {
                /*Console.WriteLine(answers[i]);*/
                if (answers[i].ToLower() == correctAnswers[i].ToLower())
                {
                    Console.WriteLine($"{questions[i]} : Your answer: {answers[i]}--------- Correct!");
                    correctAnswer++;
                }
                else
                {
                    Console.WriteLine($"{questions[i]} : Your answer: {answers[i]}-------- Incorrect!");
                }
            }
            /*Console.WriteLine(correctAnswer);*/
            grade = (correctAnswer / 5) * 100;
            Console.WriteLine($"\nYou got {correctAnswer } out of {correctAnswers.Count} answers correct");
            Console.WriteLine($"Your grade is {grade}%");
            
        }
    }
}
