using System;
using HierarchicalInheritanceTwo;
using Microsoft.VisualBasic;
namespace HierarchicalInhertanceTwo;
class Program{
    public static void Main(string[] args)
    {
        SalaryInfo salary=new SalaryInfo(215000,15);
        PermanentEmployee permanentEmployee1=new PermanentEmployee(salary.BasicSalary,salary.Month,"Permanent");
        TemporaryEmployee temporaryEmployee1=new TemporaryEmployee(salary.BasicSalary,salary.Month,"Temporary");

        permanentEmployee1.ShowSalary();
        temporaryEmployee1.ShowSalary1();
    }
}
