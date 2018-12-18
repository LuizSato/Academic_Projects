using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_13
{
    [Flags]
    enum DisplayOption
    {
        All = 0,
        Code = 0b1,
        Name = 0b10,
        Prerequsite = 0b100,
        Semester = 0b1000
    }
    class Course
    {
        public string Code { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
        public string Prerequisite { get; private set; }
        public int Semester { get; private set; }

        public Course(string code, string name, string description, string semester, string prerequisites)
        {
            Code = code;
            Name = name;
            Description = description;
            //Semester = Convert.ToInt32(semester);
            if(int.TryParse(semester, out int value))
            {
                Semester = value;
            }
            else
            {
                Semester = 0;
            }
            Prerequisite = prerequisites;
        }
        public override string ToString()
        {
            return $"\nCode: {Code} \nName: {Name} \nDescription:  {Description.Substring(0,60)} \nSemester: {Semester}  \nPrerequisite: {Prerequisite}";
        }
    }

    class CourseManager
    {
        static List<Course> courses = new List<Course>() { };

        public static void Display(DisplayOption option, string toMatch="")
        {
            foreach (Course item in courses)
            {
                if (option == DisplayOption.All)
                {
                    Console.WriteLine($"{item}");
                }
                else if (option == DisplayOption.Code)
                {
                    if (item.Code == toMatch)
                    {
                        Console.WriteLine($"{item}");
                    }
                }
                else if (option == DisplayOption.Name)
                {
                    if (item.Name == toMatch)
                    {
                        Console.WriteLine($"{item}");
                    }
                }
                else if(option == DisplayOption.Prerequsite)
                {
                    if(item.Prerequisite.Contains(toMatch))
                    {
                        Console.WriteLine($"{item}");
                    }
                }
                else if(option == DisplayOption.Semester)
                {
                    if (item.Semester == Convert.ToInt32(toMatch))
                    {
                        Console.WriteLine($"{item}");
                    }
                }
            }
        }
        public static void LoadCourses(string filename)
        {
            TextReader reader = new StreamReader(filename);
            string code;
            while((code = reader.ReadLine()) != null)
            {
                string name = reader.ReadLine();
                string description = reader.ReadLine();
                string semester = reader.ReadLine();
                string prerequisite = reader.ReadLine();

                Course all = new Course(code, name, description, semester, prerequisite);

                courses.Add(all);
                
            }
            reader.Close();
        }
    }
}
