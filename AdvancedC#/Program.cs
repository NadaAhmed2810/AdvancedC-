namespace AdvancedC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics01
            //int A = 4, B = 3;

            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"B:{B}");
            //Helper<int>.Swap(ref A, ref B);
            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"B:{B}");
            //double X = 3.7, Y = 2.5;
            //Console.WriteLine($"X:{X}");
            //Console.WriteLine($"Y:{Y}");
            //Helper.Swap(ref X, ref Y);
            //Console.WriteLine($"X:{X}");
            //Console.WriteLine($"Y:{Y}");
            //Point point1 = new Point(10, 20);
            //Point point2 = new Point(11, 22);
            //Console.WriteLine(point1.ToString());
            //Console.WriteLine(point2.ToString());
            //Helper.Swap(ref point1, ref point2);
            //Console.WriteLine(point1.ToString());
            //Console.WriteLine(point2.ToString());

            #endregion
            #region Linear Search
            //int[] nums = [1, 2, 5, 7, 9, 0, 3, 6];
            //int result = Helper<int>.Linearsearch(nums, 8);
            //Console.WriteLine($"Index: {result}");
            //Employee[] employees =
            //{
            //    new Employee(){Id=12,Name="Noura",Salary=3000},
            //    new Employee(){Id=11,Name="Nour",Salary=5000},
            //    new Employee(){Id=22,Name="Nada",Salary=6000},
            //};
            //int result=Helper<Employee>.Linearsearch(employees,new Employee() { Id = 12, Name = "Noura", Salary = 3000 });
            //Console.WriteLine(result);

            //    Employee employee = new Employee() { Id=10,Name="Noura",Salary=3000 };
            //    Employee employee2 = new Employee() { Id = 10, Name = "Noura", Salary = 3000 };
            //    if (employee.Equals( employee2))
            //    {
            //        Console.WriteLine("Equal ");
            //    }
            //    else Console.WriteLine("not Equal");  
            #endregion
            #region Equality and Hash Code
            //Employee E01 = new Employee() { Id = 10, Name = "Noura", Salary = 5000 };
            //Employee E02 = new Employee() { Id = 10, Name = "Noura", Salary = 5000 };
            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());
          
            // if (E01.Equals(E02))
            //    //if (E01==E02)
            //{
            //    Console.WriteLine("Equal ");
            //}
            //else Console.WriteLine("not Equal");
            // HashSet<Employee>employees = new HashSet<Employee>();
            //employees.Add(E01);
            //employees.Add(E02);
            //foreach (Employee e in employees)
            //{
            //    Console.WriteLine(e);
            //}
            #endregion
        }
    }
}
