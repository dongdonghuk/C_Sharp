using System;
namespace CH10
{
    public class OneArray
    {
        static void scoreInput(int[] _score)
        {
            for (int i = 0; i < _score.Length; i++)
            {
                Console.Write("{0} 성적 입력하세요 ", i+1);

                _score[i] = int.Parse(Console.ReadLine());
            }
        }

        static void scoreOutput(int[] _score)
        {
            Console.WriteLine("\n 학생점수출력 : ");
            for (int i = 0; i < _score.Length; i++)
            {
                Console.Write(" {0}, ", _score[i]);
            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            int[] score = new int[5];

            scoreInput(score);
            scoreOutput(score);
        }
    }
}
