using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTaskMentor.Classes
{
    internal class ListFindEvenOperation
    {
        public List<int> GenerateEvenList(List<int> numbers)
        {
            List<int> result = new List<int>();
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public void PrintList(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
