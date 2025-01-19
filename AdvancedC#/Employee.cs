using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary {  get; set; }

        //public static bool operator ==(Employee E1,Employee E2)
        //{
        //     //return (E1.Name==E2.Name) && (E1.Salary==E2.Salary) && (E1.Id==E2.Id);
        //     return E1.Equals(E2);
        //}
        //public static bool operator !=(Employee E1, Employee E2)
        //{
        //    return !(E1==E2);
        //}
        public override bool Equals(object? obj)
        {
            Employee? other = obj as Employee;//un safe
            if (other is not null)
            {
                return Id==other.Id && Name==other.Name && Salary==other.Salary;
            }
            return false;

        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }
    }
}
