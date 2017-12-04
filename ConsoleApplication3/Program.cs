using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            int counter = 0;            
            string[] input_String = {"teacher", "chalk", "blackboard", "cheater", "desk", "hears", "shear", "hares"};
            input.AddRange(input_String);

            for (int i = 0; i < input.Count; i++)
            {
                counter = 0;
                for (int j = 0; j < input.Count; j++)
                {
                    if (i != j)
                    {
                        if (input[i].Length == input[j].Length)
                        {
                            int count = 0;
                            char[] input1 = input[i].ToCharArray();
                            char[] input2 = input[j].ToCharArray();
                            Array.Sort(input1);
                            Array.Sort(input2);

                            for (int b = 0; b < input1.Count(); b++)
                            {
                                if(input1[b] == input2[b])
                                    count++;
                            }

                            if (count == input[i].Length)
                            {
                                counter++;
                                if (counter == 1)
                                    Console.Write(input[i]);
                                Console.Write("  " + input[j]);
                            }
                        }
                    }
                }
                if (counter > 0)
                    Console.WriteLine();              
            }
            Console.Read();
        }
    }
}
