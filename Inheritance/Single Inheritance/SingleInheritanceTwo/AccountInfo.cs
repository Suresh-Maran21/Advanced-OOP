using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritanceTwo
{
    public class AccountInfo : PeronalInfo
    {
        //Properties
        //AccountNumber, BranchName, IFSCCode, Balance
        public int AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }


        public AccountInfo(string name,string fatherName,long phone,string mail,DateTime dob,string gender,int accountNumber,string branchName,string ifscCode,double balance) : base ( name, fatherName, phone, mail, dob,gender)
        {
            AccountNumber=accountNumber;
            BranchName=branchName;
            IFSCCode=ifscCode;
            Balance=balance;
        }
        public void ShowAccountInfo()
        {
            Console.WriteLine($"{Name}||{FatherName}||{Phone}||{Mail}||{DOB}||{Gender}||{AccountNumber}||{BranchName}||{IFSCCode}||{Balance}");
        }
        public void Deposit(double Amount)
        {
            Balance=Balance+Amount;
            Console.WriteLine(Math.Abs(Balance));
        }
        public void Withdraw(double Amount)
        {
            if(Balance>Amount){
                Balance=Balance-Amount;
            Console.WriteLine(Math.Abs(Balance));
            }
            else{
                Console.WriteLine("Invalid Balance");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine(Balance);
        }
    }
}