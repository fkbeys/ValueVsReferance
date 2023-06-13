namespace ValueVsReferance
{

    internal class Program
    {
        static IEnumerable<Student> GetStudents()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i > 3)
                {
                    yield break;
                }
                yield return new Student { id = i, name = $"stu:{i}" };


            }
        }
        static void Main(string[] args)
        {

           // var stus = GetStudents().ToList();



            var stus = GetStudents().GetEnumerator();

            while (stus.MoveNext())
            {

                Console.WriteLine(stus.Current.name);

            }





        }
    }
}