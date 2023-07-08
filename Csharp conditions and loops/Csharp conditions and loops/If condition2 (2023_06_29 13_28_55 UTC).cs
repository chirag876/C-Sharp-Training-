using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ifelse2
{
	public void ifcondition2()
	{
		int i = 10, j = 20;

		if (isGreater(i, j))
		{
			Console.WriteLine("i is the younger sister of j");
		}

		if (isGreater(j, i))
		{
			Console.WriteLine("j is the elder sister of j");
		}
		static bool isGreater(int i, int j) //Calling Function as Condition
        {
			return i > j;
		}
	}
}

