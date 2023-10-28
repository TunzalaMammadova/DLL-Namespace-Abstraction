using System;
namespace Enum.Generics_Practice
{
	public class IntList
	{
		private int[] _ints;

		public IntList()
		{
			_ints = new int[0];
		}

		public void Add(int item)
		{
			Array.Resize(ref _ints, _ints.Length + 1);
			_ints[_ints.Length - 1] = item;
		}

		public void GetAll()
		{
			foreach (var item in _ints)
			{
				Console.WriteLine(item);
			}
		}
	}
}

