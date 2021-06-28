﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmptyConsole.Permutations
{

    public class TestSerialization
    {
        public static void main(string[] args)
        {
            Console.WriteLine("something");
        }
    
    }
    public static class perm
    {

        public static IEnumerable<IEnumerable<T>> Permute<T>(this IEnumerable<T> sequence)
        {
            if (sequence == null)
            {
                yield break;
            }

            var list = sequence.ToList();

            if (!list.Any())
            {
                yield return Enumerable.Empty<T>();
            }
            else
            {
                var startingElementIndex = 0;

                foreach (var startingElement in list)
                {
                    var index = startingElementIndex;
                    var remainingItems = list.Where((e, i) => i != index);

                    foreach (var permutationOfRemainder in remainingItems.Permute())
                    {
                        yield return permutationOfRemainder.Prepend(startingElement);
                    }

                    startingElementIndex++;
                }
            }
        }
    }
}
