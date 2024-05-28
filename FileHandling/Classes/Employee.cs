using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Classes
{
    public class Employee
    {
        public string employeeId { get; set; } = Guid.NewGuid().ToString();
        public string employeeName { get; set; }
        public string employeeSurname { get; set; }
        public int salary { get; set; }
    }
}
