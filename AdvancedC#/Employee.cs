using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
    class EmployeeEqualityComparerById : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Id== y?.Id;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Id);
        }
    }
    class EmployeeEqualityComparerByName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Name== y?.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }
    internal class Employee:IEquatable<Employee>,IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary {  get; set; }

      

        public int CompareTo(Employee? other)
        {
           if(other == null) return 1;
           return Salary.CompareTo(other.Salary);
        }

        //public static bool operator ==(Employee E1,Employee E2)
        //{
        //     //return (E1.Name==E2.Name) && (E1.Salary==E2.Salary) && (E1.Id==E2.Id);
        //     return E1.Equals(E2);
        //}
        //public static bool operator !=(Employee E1, Employee E2)
        //{
        //    return !(E1==E2);
        //}
        //public override bool Equals(object? obj)
        //{
        //    #region Is Operator
        //    //1. Is Operator
        //    //if (obj is Employee other)//true if obj is Employee Or Class Inherits from Employee
        //    //{
        //    //    return Id == other.Id && Name == other.Name && Salary == other.Salary;
        //    //}
        //    //return false; 
        //    #endregion
        //    #region As Operator
        //    //Employee? other = obj as Employee;
        //    //if (other != null)
        //    //{
        //    //    return Id == other.Id && Name == other.Name && Salary == other.Salary;
        //    //}
        //    //return false;
        //    #endregion
        //    #region wrong
        //    //Employee? other;//un safe [Invalid Casting]
        //    //other = (Employee?)obj;
        //    //if (other != null)
        //    //{
        //    //    return Id==other.Id && Name==other.Name && Salary==other.Salary;
        //    //}
        //    //return false; 
        //    #endregion


        //}

        public bool Equals(Employee? other)
        {
            if (other != null)
            {
                return Id == other.Id && Name == other.Name && Salary == other.Salary;
            }
            return false;
        }

        public override int GetHashCode()
        {
          
            int hashvalue = 11;
            hashvalue= hashvalue*7 ^ Id.GetHashCode();
            hashvalue= hashvalue*7 ^ Name?.GetHashCode()??0;
            hashvalue= hashvalue*7 ^ Salary.GetHashCode();
            return hashvalue;
            // return Id.GetHashCode()^Name?.GetHashCode()??0^Salary.GetHashCode();//not valid
            // return Id.GetHashCode() + Name?.GetHashCode() ?? 0 + Salary.GetHashCode();//take time and not valid
            //return HashCode.Combine(Id, Name, Salary);
        }
        public override string ToString()
        {
            return $"Id:{Id},Name:{Name},Salary:{Salary}";
        }
    }
}
