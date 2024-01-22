using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackchallenge01.Methods
{
    public class FindSingleton
    {
        public static int FindMethod(int[] student_list)
        {
            if (student_list != null && student_list.Length < 1)
                return 0;
            var studentList = student_list.ToList();
            return studentList.Where(x => studentList.Count(y => x == y) < 2).FirstOrDefault();
        }
    }

}
