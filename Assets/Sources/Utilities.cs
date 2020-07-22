using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Pair<TFirst, TSecond>
{
	public TFirst first;
	public TSecond second;
	public Pair()
	{
		first = default(TFirst);
		second = default(TSecond);
	}
	public Pair(TFirst first, TSecond second)
	{
		this.first = first;
		this.second = second;
	}
}