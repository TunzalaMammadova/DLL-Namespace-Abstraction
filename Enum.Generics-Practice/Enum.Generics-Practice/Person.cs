using System;


namespace Enum.Generics_Practice
{
	public class Person : BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }

        //public override string ToString()
        //{
        //    return $"{Id} - {Name} - {Surname}";
        //}
    }
}

