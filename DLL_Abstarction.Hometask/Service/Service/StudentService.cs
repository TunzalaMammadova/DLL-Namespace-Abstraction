using System;
using Domain.Models;

namespace Service.Service
{
    public class StudentService
    {
        private Student[] GetAll()
        {
            return new Student[]
            {
            new Student{Id = 1, FullName = "Tunzale Memmedova", Age = 24, Email = "tunzale@gmail.com"},
            new Student{Id = 2, FullName = "Meryem Eliyeva", Age = 23, Email = "meryem@gmail.com"},
            new Student{Id = 3, FullName = "Metanet Abbasli", Age = 21, Email = "metanet@gmail.com"},
            new Student{Id = 4, FullName = "Arzu Kerimli", Age = 25, Email = "arzu@gmail.com"},
            };


        }


        public Student[] GetAllStudents() => GetAll();


        public Student[] SortStudents(string sortType)
        {
            var students = GetAll();

            if (sortType == "asc")

                return students.OrderBy(m => m.Age).ToArray();

            return students.OrderByDescending(m => m.Age).ToArray();
        }


        public Student GetByID(int id) => GetAll().FirstOrDefault(m => m.Id == id);


       
    }


    
}

