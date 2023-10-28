using System;

namespace Enum.Generics_Practice
{
	public class Repository <T> where T : BaseEntity
	{
		private T[] _datas;

		public Repository()
		{
			_datas = new T[0];
		}

		public void Add(T data)
		{
			Array.Resize(ref _datas, _datas.Length + 1);
			_datas[_datas.Length - 1] = data;
		}
	}
}

