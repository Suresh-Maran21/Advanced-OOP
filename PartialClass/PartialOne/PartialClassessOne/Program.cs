using System;
namespace PartialClassessOne;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee1=new EmployeeInfo("SF1001","Suresh","Male","2105/2002",9876543456);
        employee1.Display();
        employee1.Update("maran","Male","09/06/2002",9876545678);
        employee1.Display();
    }
}
