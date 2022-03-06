using System;

namespace walkingDownThe_Street
{


    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Battle("One", "One"));
            Console.ReadLine();
            
        }
    static string Battle (string x, string y)
        {
            char[] bigNums = new char[26] {     'A', 'B', 'C', 'D', 'E', 'F', 'G',
                                                'H', 'I', 'J', 'K', 'L', 'M', 'N',
                                                'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                                                'V', 'W', 'X', 'Y', 'Z'};

            char[] smallNums = new char[26] {   'a', 'b', 'c', 'd', 'e', 'f', 'g',
                                                'h', 'i', 'j', 'k', 'l', 'm', 'n',
                                                'o', 'p', 'q', 'r', 's', 't', 'u',
                                                'v', 'w', 'x', 'y', 'z'};
            
            double total1 = 0.0, total2 = 0.0;


            double numOut (string word)
            {
                double bigSum = 0.0;
                double smallSum = 0.0;

                foreach (char c in word)
                {
                    foreach (char s in bigNums)
                    {
                        bigSum += c == s ? Array.IndexOf(bigNums, s) + 1 : 0;
                    }
                    foreach (char s in smallNums)
                    {
                        smallSum += c == s ? (double)(Array.IndexOf(smallNums, s)) / 2 + 0.5 : 0;
                    }
                }
                return bigSum+smallSum;

            }
            total1 = numOut(x);
            total2 = numOut(y);

            if (total1 > total2)
            { return x; }
            else if (total1 < total2)
            { return y; }
            else { return "Tie"; }

        }
    }
}
