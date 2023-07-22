using System;

namespace AlgoLibrary.QuickFindUF
{
    /// <summary>
    /// Example
    /// Joining 1 to 2
    /// 0 2 2 3 4 5 6 7 8 9
    /// Joining 3 to 4
    /// 0 2 2 4 4 5 6 7 8 9
    /// Joining 4 to 6
    /// 0 2 2 6 6 5 6 7 8 9
    /// Joining 6 to 5
    /// 0 2 2 5 5 5 5 7 8 9
    /// 3 6 are connected
    /// </summary>
    public class QuickFindUF
    {
        public readonly int[] ints;

        /// <summary>
        /// Defining how many number array we need to create
        /// </summary>
        public QuickFindUF(int n)
        {
            ints = new int[n];
            for (int i = 0; i < n; i++)
            {
                ints[i] = i;
            }
        }

        public void Union(int p, int q)
        {
            {
                for (int i = 0; i < ints.Length; i++)
                {
                    if (p == ints[i])
                    {
                        ints[i] = q;
                    }
                }
                Console.WriteLine("Joining {0} to {1}", p, q);
                Console.WriteLine(string.Join(" ", ints));
            }
        }

        public void AreConnected(int p, int q)
        {
            if (ints[p] == ints[q])
            {
                Console.WriteLine("{0} {1} are connected", p, q);
            }
        }
    }
}