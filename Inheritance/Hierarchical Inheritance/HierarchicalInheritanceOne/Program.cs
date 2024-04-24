using System;
using System.Data;
using System.Runtime.CompilerServices;
namespace HierarchicalInheritanceOne;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person1=new PersonalInfo("Suresh","Maran","21/05/2000",987654567,Gender.Male,"suresh@gamil.com");
        Teacher teacher1=new Teacher(person1.Name,person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.MailID,"CSe","Aritificial Intelligence","BE",6,30/05/2000);
        StudentInfo student1=new StudentInfo(person1.Name,person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.MailID,"BE","EEE",6);
        PrincipalInfo principal=new PrincipalInfo(person1.Name,person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.MailID,"Be",10,"08/06/2000");


        teacher1.ShowDetails();
        student1.ShowDetails();
        principal.ShowDetails();
    }
}
