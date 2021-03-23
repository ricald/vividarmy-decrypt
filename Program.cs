using System;
using System.IO;

namespace vividarmy_decrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader("data.txt"))
            {
                while (true)
                {
                    var line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    var answer = string.Empty;
                    foreach (var c in line)
                    {
                        answer += (char)(c - 3);
                    }

                    Console.WriteLine(answer);
                }
            }
        }
    }
}
