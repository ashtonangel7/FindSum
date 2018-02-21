namespace FindSum
{
	using System;
	using System.Collections.Generic;
	class Program
	{
		static List<Tuple<int, int>> FindTwoSum(List<int> sumParts, int targetSum)
		{
			if (sumParts == null)
			{
				return null;
			}

			List<Tuple<int, int>> results = new List<Tuple<int, int>>();
			List<Tuple<int, int>> resultsReversed = new List<Tuple<int, int>>();

			for (int loop = 0; loop < sumParts.Count; loop++)
			{
				for (int innerLoop = loop + 1; innerLoop < sumParts.Count; innerLoop++)
				{
					if (sumParts[loop] + sumParts[innerLoop] == targetSum)
					{
						results.Add(Tuple.Create(sumParts[loop], sumParts[innerLoop]));
						resultsReversed.Insert(0, Tuple.Create(sumParts[innerLoop], sumParts[loop]));
					}
				}
			}

			results.AddRange(resultsReversed);

			return results.Count > 0 ? results : null;
		}
		static void Main(string[] args)
		{
			List<int> sumParts = new List<int>()
			{
				1,3,5,7,9,11,2,6,8,0,4,10,12,-2,14,-6,-6
			};

			int target = 12;

			List<Tuple<int, int>> results = FindTwoSum(sumParts, target);

			foreach (Tuple<int, int> result in results)
			{
				Console.WriteLine("{0} + {1} = {2}", result.Item1, result.Item2, target);
			}

			Console.ReadLine();
		}
	}
}
