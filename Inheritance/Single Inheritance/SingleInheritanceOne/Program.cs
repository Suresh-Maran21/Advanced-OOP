using System;
namespace SingleInheritance;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal= new PersonalInfo("suresh","Ganesan",9876543210,"suresh@gmail.com",new DateTime(2000,05,21),"Male");
        StudentInfo student=new StudentInfo(personal.Name,personal.FatherName,personal.Phone,personal.MailID,personal.DOB,personal.Gender,12345,"first","cse",2020);
        student.ShowStudentInfo();
    }
}