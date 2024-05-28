using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTaskMentor.Classes
{
    internal class ArrayListOperation
    {
        public ArrayList DublicateRemove(ArrayList listOne)
        {
            ArrayList result = new ArrayList();
            foreach (var item in listOne)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
