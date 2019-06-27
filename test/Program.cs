using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinct. ";
            foreach (var item in Program.SplitString(text,25))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        internal static IEnumerable<string> SplitString(string str, int chunkSize)
        {
            decimal chunkCount = Math.Ceiling((decimal)(str.Length / chunkSize));
            List<string> array = new List<string>();
            int pointA = 0, pointB = chunkSize;

            for (int  i = 0;  i <= chunkCount;  i++)
            {
                if (pointA + chunkSize > str.Length)
                {
                    array.Add(str.Substring(pointA, str.Length - pointA));
                }
                else
                {
                    array.Add(str.Substring(pointA, chunkSize));
                }
                pointA += chunkSize;
            }
            return array;
        }
    }
}
