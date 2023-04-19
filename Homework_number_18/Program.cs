using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isLineCorrect = true;
            string line = "'(' и ')'";
            int numberBracketOpen = 0;
            int numberBracketClose = 0;
            int maxDepthNesting = 0;
            int evaluationVisas = 0;

            foreach (char item in line)
            {
                if (item == '(')
                {
                    numberBracketClose = 0;
                   
                    if (numberBracketOpen >= maxDepthNesting)
                    {
                        maxDepthNesting++;
                    }
                 
                    numberBracketOpen++;
                }
                else if (item == ')')
                {
                    numberBracketOpen = 0;
                   
                    if (numberBracketClose >= maxDepthNesting)
                    {
                        maxDepthNesting++;
                    }
                  
                    numberBracketClose++;
                }

                if (item == '(')
                {
                    evaluationVisas++;
                }
                else if (item == ')')
                {
                    evaluationVisas--;
                }

                if (evaluationVisas < 0)
                {
                    isLineCorrect = false;
                }
            }

            if (isLineCorrect != false && evaluationVisas == 0)
            {
                Console.WriteLine($"Строка корректная и максимум глубины равняется {maxDepthNesting}");
            }
            else
            {
                Console.WriteLine("Строка не корректная");
            }

            Console.ReadLine();
        }
    }
}
