namespace PrintStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            students[0] = new Student { FirstName = "Donovan", LastName = "Deben" };
            students[1] = new Student { FirstName = "Jane", LastName = "Doe" };

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

        }
    }
}
