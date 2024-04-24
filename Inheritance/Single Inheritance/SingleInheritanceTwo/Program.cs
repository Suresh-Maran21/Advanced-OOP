using System;
namespace SingleInheritanceTwo;
class Program{
    public static void Main(string[] args)
    {
        AccountInfo person1 = new AccountInfo("suresh","ganesan",987654321,"suresh@gmail.com",new DateTime(1999,05,21),"Male",1234,"sas","sf123",1000);
        AccountInfo person2 = new AccountInfo("ashok","ganesan",9876542321,"ashok@gmail.com",new DateTime(1998,05,23),"Male",4321,"qwe","123qwe",1010);
        AccountInfo person3 = new AccountInfo("santhosh","ganesan",9876543211,"santhosh@gmail.com",new DateTime(2000,01,01),"Male",9876,"qwerty","q12we",10101);

        person1.ShowAccountInfo();
        person2.ShowAccountInfo();
        person3.ShowAccountInfo();

        person1.Deposit(1000);
        person2.Deposit(1010);
        person3.Deposit(2020);

        person1.Withdraw(2020);
        person2.Withdraw(1010);
        person3.Withdraw(2000);

        person1.ShowBalance();
        person2.ShowBalance();
        person3.ShowBalance();
    }
}
