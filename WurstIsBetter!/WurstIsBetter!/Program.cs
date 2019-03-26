using System;

namespace WurstIsBetter_
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("WurstIsBetter!");
            Console.WriteLine("\nEnter something that contains sausage :D ");

            var SausageText = Console.ReadLine();
            Console.WriteLine(ChangeForWursts(SausageText));
            Console.ReadLine();

        }

        private static string ChangeForWursts(string SausageText)
        {
            string wordToCheck = "";
            string wurstText = "";

            SausageText += ' ';
            foreach (char i in SausageText)
            {
                if (!char.IsWhiteSpace(i))
                {
                    wordToCheck += i;
                }
                else
                {
                    wordToCheck = wordToCheck.ToLower();
                    if (wordToCheck.Contains("wurst")) { }
                    else if (wordToCheck.Contains("kielbasa") || wordToCheck.Contains("chorizo") || wordToCheck.Contains("moronga")
                            || wordToCheck.Contains("salami") || wordToCheck.Contains("sausage") || wordToCheck.Contains("andouille")
                                || wordToCheck.Contains("naem") || wordToCheck.Contains("merguez") || wordToCheck.Contains("gurka")
                                    || wordToCheck.Contains("snorkers") || wordToCheck.Contains("pepperoni"))
                    {
                        wordToCheck = "Wurst";
                    }
                    wurstText += wordToCheck + ' ';
                    wordToCheck = "";
                }
            }
            return wurstText;
        }
    }
}
