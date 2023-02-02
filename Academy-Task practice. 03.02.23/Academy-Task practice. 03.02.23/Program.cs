using System;

namespace Academy_Task_practice._03._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Course cr1 = new Course();
            //cr1.StudentLimits = 5;
            //cr1.Students = new Student[0];

            //Student st1 = new Student()
            //{
            //    Fullname = "Alim Haciyev",
            //    Groupno = "P232",
            //    point=78

            //};
            //Student st2 = new Student()
            //{

            //    Fullname = "Manuela Efendi",
            //    Groupno = "P231",
            //    point = 87
            //};
            //Student st3 = new Student()
            //{

            //    Fullname = "Huseyn Hasanli",
            //    Groupno = "D203",
            //    point = 90
            //};
            //Student st4 = new Student()
            //{

            //    Fullname = "Deniz Hasanli",
            //    Groupno = "D204",
            //    point = 97
            //};            
            //cr1.AddStudent(st1);
            //cr1.AddStudent(st2);
            //cr1.AddStudent(st3);
            //cr1.AddStudent(st4);

            //Console.WriteLine(cr1.Students.Length);
            //foreach (Student item in cr1.Students)
            //{
            //    Console.WriteLine(item.Fullname);
            //}
            #endregion


            #region Task2
            //int[] numbers = { 23, 45, 67 };
            //Console.WriteLine("indexi daxil edin:");
            //string indexStr = Console.ReadLine();

            //try
            //{
            //    int index = System.Convert.ToInt32(indexStr);
            //    Console.WriteLine(numbers[index]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Array de bele bir index yoxdur:");
            //}

            //Console.WriteLine("Continue");
            //Console.WriteLine("....");
            //Console.WriteLine("....");

            #endregion

            #region Task3
            int num = 6;
            Convert("sda", ref num);
            Console.WriteLine(num);
            #endregion

        }
        static void Convert( string value,ref int num)
        {
            try
            {
                num = System.Convert.ToInt32(value);
            }
            catch (Exception)
            {
                num = 0;
            }
        }
    }
}
