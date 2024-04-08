using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09._04._2024.Models
{
    public interface ICodeAcademy
    {
        string CodeEmail { get; set; }
        void GenerateEmail();
    }

    public class Student : ICodeAcademy
    {
        private static int Count = 0;

        public int Id 
        {
            get;
            private set; 
        }
        public string Name 
        {
            get; 
        }
        public string Surname 
        {
            get; 
        }
        public string CodeEmail 
        {
            get;
            set; 
        }

        public Student(string name, string surname)
        {
            Id = ++Count;
            Name = name;
            Surname = surname;
            GenerateEmail();
        }

        public static void CheckName()
        {

        }

        public void GenerateEmail()
        {
            string emailName = $"{Name.ToLower()}.{Surname.ToLower()}{Id}";
            emailName = Regex.Replace(emailName, @"[^a-zA-Z0-9]", "");
            CodeEmail = $"{emailName}@code.edu.az";
        }
    }
}
