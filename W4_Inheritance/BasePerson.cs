namespace W4_Inheritance
{
    public abstract class BasePerson
    {
        private string _firstName;
        private string _lastName;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        // abstract method for overriding in inherited classes
        public abstract void PrintFullInfo();
    }

    public class Student : BasePerson
    {
        private int _studentId;

        public int StudentId { get; set; }

        public override void PrintFullInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}, Student Id: {StudentId}");
        }
    }

    public class Teacher : BasePerson
    {
        private int _salary;

        public int Salary { get; set; }

        public override void PrintFullInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}, Salary: {Salary}");
        }
    }
}
