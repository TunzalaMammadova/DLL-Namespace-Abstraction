using System;
using Service.Service;

namespace DLL_Abstarction.Hometask.Controllers
{
	public class StudentController
	{
		private readonly StudentService _studentService;

		public StudentController()
		{
			_studentService = new StudentService();
		}

	
		public void GetAllStudents()
		{
			foreach (var item in _studentService.GetAllStudents())
			{
				Console.WriteLine($"{item.FullName} - {item.Age} - {item.Email}");
			}
			
		}


		public void GetStudentById()
		{
			var student = _studentService.GetByID(1);
			string result = $"{student.FullName} - {student.Age} - {student.Email}";
			Console.WriteLine(result);
		}


        public void SortStudentsByAge()
        {
            Console.WriteLine("Please select to sort");

            string sortText = Console.ReadLine();

            foreach (var item in _studentService.SortStudents(sortText))
            {
                Console.WriteLine($"{item.FullName} - {item.Age} - {item.Email}");
            }

        }


        public void GetStudentByAgeAverage()
		{
			var students = _studentService.GetAllStudents();

			var AverageAge = students.Sum(m => m.Age / students.Length);

			Console.WriteLine(AverageAge);
		}


		
	}
}

