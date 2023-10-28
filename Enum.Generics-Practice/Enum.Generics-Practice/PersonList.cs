using System;
namespace Enum.Generics_Practice
{
	public class PersonList
	{
        private Person[] _personList;

        public PersonList()
        {
            _personList = new Person[0];
        }

        public void Add(Person item)
        {
            Array.Resize(ref _personList, _personList.Length + 1);
            _personList[_personList.Length - 1] = item;
        }

        public void GetAll()
        {
            foreach (var item in _personList)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname);
            }
        }
    }
}

