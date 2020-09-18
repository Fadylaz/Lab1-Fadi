using System;


namespace Lab1_Fadi_Lazkani
{
    class Program
    {
        static void Main(string[] args)
        {
            double Total = 0;
            Console.ResetColor();
            string text = "";
            Console.WriteLine("enter the value:");
            text = Console.ReadLine();
            bool found = false;
            int i = 0, j = 0;
            for (i = 0; i < text.Length; i++)
            {
                j = i + 1;
                found = false;
                if (Char.IsDigit(text[i]))
                {
                    int fst = int.Parse(text[i].ToString());
                    while ((j < text.Length) && (found == false))
                    {
                        if (Char.IsDigit(text[j]))
                        {
                            int scnd = int.Parse(text[j].ToString());
                            if (scnd == fst)
                            {
                                found = true;
                                for (int k = 0; k < i; k++)
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Write(text[k]);
                                }
                                for (int k = i; k < j + 1; k++)
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.Write(text[k]);

                                }
                                for (int k = j + 1; k < text.Length; k++)
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Write(text[k]);
                                }
                                int startIndex = i;
                                int endIndex = j + 1 - i; //number of character i want to copy
                                String temp = text.Substring(startIndex, endIndex);
                                Total += double.Parse(temp);
                                Console.WriteLine();
                            }
                            j++;
                        }
                        else break;
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Total = {0}", Total);
            Console.ReadLine();
        }
    }
}
