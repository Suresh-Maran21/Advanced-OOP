using System;
namespace MultiLevelInheritanceOne;
class Program{
    public static void Main(string[] args)
    {
        HSCDetails student = new HSCDetails("suresh","Ganesan",new DateTime(2002,05,21),987654321,"suresh@gmail.com","Male",12345,"First","Cse",2020,9876,90,80,70);
        student.GetMarks();
        student.CalculateTotal();
        student.CalculatePercentage();
        student.ShowMarksheet();
    }
}
