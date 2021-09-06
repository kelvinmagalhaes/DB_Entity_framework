using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class Program
    {
        public static void  student_insert(string name)
        {
            using (var context = new Model1()) 
            {
                Student std = new Student() {
                    Name = name,
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
        }

        public static void course_insert(string course)
        {
            using(var context = new Model1())
            {
                Course std = new Course()
                {
                    Name = course,
                };
                context.Courses.Add(std);
                context.SaveChanges();
            }
        }

        public static List<Student> students_select()
        {
            using (var context = new Model1())
            {
                List<Student> std = context.Students.ToList();
                return std;
            }
        }

        public static List<Course> course_select()
        {
            using (var context = new Model1())
            {
                List<Course> std = context.Courses.ToList();
                return std;
            }

        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite o Nome do Aluno:");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o Nome do Curso:");
                string course = Console.ReadLine();
                course_insert(course);
                student_insert(name);

                var test = course_select();
                var test2 = students_select();

                Console.WriteLine("\nLista de Nomes:");
                foreach (var x in test2)
                {
                    Console.WriteLine(x.Name);
                }

                Console.WriteLine("\nLista de Cursos:");

                foreach (var x in test)
                {
                    Console.WriteLine(x.Name);
                }
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
