using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTaskMentor.Classes
{
    internal class ListFindMaxOperation
    {
        public int FindMax(List<int> numbers)
        {
            int max = numbers[0];
            if (numbers.Count > 0)
            {
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }
                return max;
            }
            else
            {
                throw new ArgumentException("The list is empty");
            }
        }
    }
}
