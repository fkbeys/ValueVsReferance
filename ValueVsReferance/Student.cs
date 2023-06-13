namespace ValueVsReferance
{
    public class Student
    {
        public Student()
        {
            Console.WriteLine("Student class instance is created.");
        }
        public int id { get; set; }
        public string name { get; set; }
    }

    public struct StudentStruct
    {
        public int id { get; set; }
        public string name { get; set; }
    }

}
