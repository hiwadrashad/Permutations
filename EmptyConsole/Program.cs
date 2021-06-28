using System;
using System.Collections.Generic;

namespace EmptyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] source = new string[] { "dog", "cat", "mouse" };
            var item = Permutations.perm.Permute(source);
            foreach (var item2d in item)
            {
                string stringtowrite = "";
                foreach (var item3d in item2d)
                {
                    stringtowrite += item3d + " ";
                }
                Console.WriteLine(stringtowrite);
                stringtowrite = "";
            }

        }
    }
}
