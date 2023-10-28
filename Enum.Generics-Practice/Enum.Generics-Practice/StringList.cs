using System;
namespace Enum.Generics_Practice
{
	public class StringList
	{
        private string[] _stringList;

        public StringList()
        {
            _stringList = new string[0];
        }

        public void Add(string item)
        {
            Array.Resize(ref _stringList, _stringList.Length + 1);
            _stringList[_stringList.Length - 1] = item;
        }

        public void GetAll()
        {
            foreach (var item in _stringList)
            {
                Console.WriteLine(item);
            }
        }
    }
}


