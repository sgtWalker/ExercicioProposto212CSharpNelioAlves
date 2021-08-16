using System;
using System.Collections.Generic;
using ExercicioProposto212.Entities;

namespace ExercicioProposto212
{
    class Program
    {
        private const string Courses = "A,B,C";
        static void Main(string[] args)
        {
            try
            {
                ProcessStudentsPerCourse();
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine($"An ApplicationException has ocurred: {ex.Message} \n {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Exception has ocurred: {ex.Message} \n {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
        }

        private static void ProcessStudentsPerCourse()
        {
            try
            {
                var courses = Courses.Split(',');

                int studentsNumber = RequestData(courses[0]);
                var studentsInCourseA = SetStudents(studentsNumber);

                studentsNumber = RequestData(courses[1]);
                var studentsInCourseB = SetStudents(studentsNumber);

                studentsNumber = RequestData(courses[2]);
                var studentsInCourseC = SetStudents(studentsNumber);

                PrintTotalStudents(studentsInCourseA, studentsInCourseB, studentsInCourseC);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"Method: ProcessStudentsPerCourse, Error Messages: {ex.Message} {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Method: ProcessStudentsPerCourse, Error Messages: {ex.Message} {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
        }
        private static int RequestData(string course)
        {
            try
            {
                Console.Write($"How many students students for course {course}? ");
                return int.Parse(Console.ReadLine());
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"Method: RequestData, Error Messages: {ex.Message} {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Method: RequestData, Error Messages: {ex.Message} {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
        }
        private static HashSet<Student> SetStudents(int studentsNumber)
        {
            try
            {
                HashSet<Student> hsStudents = new HashSet<Student>();

                for (int i = 0; i < studentsNumber; i++)
                {
                    hsStudents.Add(new Student(int.Parse(Console.ReadLine())));
                }

                return hsStudents;
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"Method: SetStudents, Error Messages: {ex.Message} {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Method: SetStudents, Error Messages: {ex.Message} {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
        }
        private static void PrintTotalStudents(HashSet<Student> studentsInCourseA, HashSet<Student> studentsInCourseB, HashSet<Student> studentsInCourseC)
        {
            try
            {
                HashSet<Student> hsAllCourses = new HashSet<Student>(studentsInCourseA);
                hsAllCourses.UnionWith(studentsInCourseB);
                hsAllCourses.UnionWith(studentsInCourseC);

                Console.WriteLine($"Total students: {hsAllCourses.Count}");
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"Method: PrintTotalStudents, Error Messages: {ex.Message} {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Method: PrintTotalStudents, Error Messages: {ex.Message} {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
        }

    }
}
