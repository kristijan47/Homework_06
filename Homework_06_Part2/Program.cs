using System;

namespace Homework_06_Part2
{
    //Task 2

    // In this exercise you are asked to program three simple classes which keep track of the grading of a sample student
    //The classes are called FirstCourse, SecondCourse, and Project.

    //  A FirstCourse encapsulates a course name and a registration of passed/not passed for our sample student.
    //
    // A SecondCourse encapsulates a course name and the grade of the student. For grading we use the grades, numerical grades 10, 9, 8, 7, 6, 5. 
    //You are also welcome use the enumeration.The grade 6 is the lowest passing grade.
    //In both FirstCourse and SecondCourse you should write a method called Passed. 
    //The method is supposed to return whether our sample student passes the course.

    //The class Project aggregates two FirstCourse courses and two SecondCourse courses.
    //You can assume that a project is passed if at least three out of the four courses are passed. 

    //Write a method Passed in class Project which implements this passing policy.

    // In Main method initialize 2 FirstCourse objects, 2 SecondCourse objects and 1 Project object.

    //Add both FirstCourse and both SecondCourse objects like a properties to Project object.
    //Call Project's object Passed method to see if the student passed.

    public class FirstCourse
    {
        public FirstCourse(string courseName, bool passed)
        {
            CourseName = courseName;
            pass = passed;
        }

        public FirstCourse()
        {
        }

        public string CourseName;
        public bool pass;

       

        public bool Passed()
        {
            if (pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class SecondCourse
    {

        public SecondCourse(string courseName, int grades)
        {
            CourseName = courseName;
            StudentGrades = grades;

        }

        public string CourseName;
        public int StudentGrades;

        public bool Passed()
        {
           
            if (StudentGrades > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }



    public class Project
    {
        public Project(bool firstCoursePartOne, bool firstCoursePartTwo, bool secondCoursePartOne, bool secondCoursePartTwo)
        {
            CourseOnePartOne = firstCoursePartOne;
            CourseOnePartTwo = firstCoursePartTwo;
            CourseTwoPartOne = secondCoursePartOne;
            CourseTwoPartTwo = secondCoursePartTwo;

        }



        bool CourseOnePartOne;
        bool CourseOnePartTwo;
        bool CourseTwoPartOne;
        bool CourseTwoPartTwo;

        public void Passed()
        {
            bool[] courses = { CourseOnePartOne, CourseOnePartTwo, CourseTwoPartOne, CourseTwoPartTwo };
            int totalCourses = 0;

            foreach (var course in courses)
            {
                if (course == true)
                {
                    totalCourses++;
                }
            }
            if (totalCourses >= 3)
            {
                Console.WriteLine($"The Student Has Passed The Academy Succesfully By Completing {totalCourses} number of courses!");
            }
            else
            {
                Console.WriteLine("The Student Didn't Complete The Required Number Of Courses To Pass The Academy.");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var firstCoursePartOne = new FirstCourse("HTML", false);
            var firstCoursePartTwo = new FirstCourse("CSS", true);

            var secondCoursePartOne = new SecondCourse("JavaScript", 6);
            var secondCoursePartTwo = new SecondCourse("AdvancedJavaScript",9);

            Project PassOrFail = new Project(firstCoursePartOne.Passed(), firstCoursePartTwo.Passed(), secondCoursePartOne.Passed(), secondCoursePartTwo.Passed());
            PassOrFail.Passed();
            Console.ReadLine();
        }
    }
}