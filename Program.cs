using System;

public static class Globals
{
	internal static int Main()

	{
		int n = 0;
		scanf_s("%d", n);
		int a;
		int x = 0;
		int maxv = 0;
		for (int i = 0; i < n; i++)
		{
			scanf_s("%d", a);
			if (x < 0)
			{
				return -1; //incorect
			}
			if (a == 0)
			{
				x++;
			}
			else
			{
				if (a == 1)
				{
					x--;
				}
			}
			if (x > maxv)
			{
				maxv = x;
			}
		}
		if (x != 0)
		{
			return -1;
		}
		return maxv;
	}
}
