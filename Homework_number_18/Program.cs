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
            string line = "((()(()))";
            int numberBracketOpen = 0;
            int numberBracketClose = 0;
            int maxNumberOpenBrackets = 0;
            int maxNumberCloseBrackets = 0;
            int evaluationVisas = 0;

            foreach (char item in line)
            {
                if (item == '(')
                {
                    numberBracketClose = 0;
                    if (numberBracketOpen >= maxNumberOpenBrackets)
                    {
                        maxNumberOpenBrackets++;
                    }
                    numberBracketOpen++;
                }
                else if (item == ')')
                {
                    numberBracketOpen = 0;
                    if (numberBracketClose >= maxNumberCloseBrackets)
                    {
                        maxNumberCloseBrackets++;
                    }
                    numberBracketClose++;
                }
            }

            foreach (char item in line)
            {
                if (item == '(')
                {
                    evaluationVisas++;
                }
                else if (item == ')' && evaluationVisas != 0)
                {
                    evaluationVisas--;
                }
                else if (item == ')' && evaluationVisas == 0)
                {
                    isLineCorrect = false;
                    break;
                }
            }



            if (isLineCorrect != false && evaluationVisas == 0)
            {
                if (maxNumberOpenBrackets >= maxNumberCloseBrackets)
                {
                    Console.WriteLine($"Строка корректная и максимум глубины равняется {maxNumberOpenBrackets}");
                }
                else
                {
                    Console.WriteLine($"Строка корректная и максимум глубины равняется {maxNumberCloseBrackets}");
                }
            }
            else
            {
                Console.WriteLine("Строка не корректная");
            }

            Console.ReadLine();
        }
    }
}
