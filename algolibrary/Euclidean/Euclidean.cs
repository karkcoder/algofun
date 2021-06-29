using System;
using System.Collections.Generic;
using System.Text;

namespace algolibrary.EuclideanGCD
{
	/// <summary>
	/// Time complexicity O(log min(a,b))
	/// </summary>
	public class Euclidean
	{
		public int GCD(int a, int b)
		{
			if (b == 0)
			{
				return a;
			}
			else
			{
				return GCD(b, a % b);
			}
		}

		public int LCM(int a, int b)
		{
			return a / GCD(a, b) * b;
		}
	}
}
