namespace ValueVsReferance
{
    internal class Program
    {

        static ref int calc(ref int num)
        {
            num = num + 1;
            return ref num;
        }

        public static Student ChangeName(Student stu)
        {
            //stu=new Student();
            stu.name = "changed";
            return new Student { id = 33, name = "xx" };
        }


        static void Main(string[] args)
        {

            string a = "a";
            string b = a;
            b = "c";
            Console.WriteLine(a);
            Console.WriteLine(b);



        }
    }
}