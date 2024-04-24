using System;
namespace MultipleInheritanceOne;
class Program{
    public static void Main(string[] args)
    {
        RegisterPerson registerPerson1=new RegisterPerson("Maran","Ganesan","Jaya",new DateTime(2000,05,05),"987654567",MartialDetails.Single,"No.10 ramachander pet2,salem",2,new DateTime(2020,05,21));
        RegisterPerson registerPerson2=new RegisterPerson("suresh","Ganesan","Jaya",new DateTime(2000,11,25),"8234654567",MartialDetails.Single,"No.8 ramachander pet2,salem",2,new DateTime(2020,05,25));
        registerPerson1.ShowInfo();
        registerPerson1.ShowInfo();
    }
}
