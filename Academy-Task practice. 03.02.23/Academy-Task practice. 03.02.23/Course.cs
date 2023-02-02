using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_Task_practice._03._02._23
{
    internal class Course
    {
        
        public Student[] Students;
        public int StudentLimits;

        public void AddStudent(Student std)
        {
            if (Students.Length<StudentLimits)
            {
                if (!HasNo(std.No))
                {
                    Array.Resize(ref Students, +Students.Length + 1);
                    Students[Students.Length - 1] = std;
                }
              
            }
        }
          
        public bool HasNo( int no)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].No==no)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
    
}
