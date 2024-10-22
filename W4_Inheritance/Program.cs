using W4_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student();
        student.FirstName = "John";
        student.LastName = "Wick";
        student.StudentId = 1111111;
        student.PrintFullInfo();

        Teacher teacher = new Teacher();
        teacher.FirstName = "Max";
        teacher.LastName = "Payne";
        teacher.Salary = 50000;
        teacher.PrintFullInfo();

        Console.ReadKey();
    }
}