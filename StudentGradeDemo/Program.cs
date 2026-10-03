//Create a program StudentGradeDemo
//that attempts to create several valid and invalid ReportCard objects.
//Immediately after each instantiation attempt, handle any thrown exceptions
//by displaying an error message. Create a ReportCard class with four fields
//for a student name, a numeric midterm grade, a numeric final exam grade, and
//letter grade.
//
//The ReportCard constructor requires values for the name and two
//numeric grades and determines the letter grade. Upon construction, throw an
//ArgumentException if the midterm or final exam grade is less than 0 or more than 100.
//The letter grade is based on the arithmetic average of the midterm and final exams
//using a grading scale of A for an average of 90 to 100, B for 80 to 90, C for 70 to 80,
//D for 60 to 70, and F for an average below 60. Display all the data if the instantiation is successful.

// Use the Main() method to test your code.

using System;
using static System.Console;
using System.Globalization;
class StudentGradeDemo
{
    static void Main()
    {
        ReportCard student1 = new ReportCard("John Doe", 85, 92);
        ReportCard student2 = new ReportCard("Jane Smith", 105, 88);
        ReportCard student3 = new ReportCard("Alice Johnson", 78, 65);
        ReportCard student4 = new ReportCard("Bob Wilson", 78, -1);
    }
}

class ReportCard
{
    private string studentName;
    private double midtermGrade;
    private double finalExamGrade;
    private char letterGrade;

    public ReportCard(string name, double midterm, double final)
    {
        studentName = name;
        midtermGrade = midterm;
        finalExamGrade = final;

        try
        {
            if (midtermGrade < 0 || midtermGrade > 100 || finalExamGrade < 0 || finalExamGrade > 100)
            {
                throw new ArgumentException("Invalid grade input. Grades must be between 0 and 100.");
            }

            else
            {
                double average = (midtermGrade + finalExamGrade) / 2;
                if (average >= 90)
                {
                    letterGrade = 'A';
                }
                else if (average >= 80)
                {
                    letterGrade = 'B';
                }
                else if (average >= 70)
                {
                    letterGrade = 'C';
                }
                else if (average >= 60)
                {
                    letterGrade = 'D';
                }
                else
                {
                    letterGrade = 'F';
                }

            }
            WriteLine($"Student: {studentName}, Midterm: {midtermGrade}, Final: {finalExamGrade}, Letter Grade: {letterGrade}");
        }

        catch (ArgumentException e)
        {
            WriteLine("{0}, {1}", e.GetType().Name, e.Message);
        }
    }
}