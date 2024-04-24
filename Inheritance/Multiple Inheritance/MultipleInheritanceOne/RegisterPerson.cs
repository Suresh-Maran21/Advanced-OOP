using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceOne
{
    public class RegisterPerson : PersonalInfo,IShowData,IFamilyInfo
    {
        private static int s_registrationNumber = 1000;
        private static string gender;

        public string RegisterNumber { get; }
        public string FatherName {get;set;}
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSibilings { get; set; }
        public DateTime DateOfRegistration{get;set;}
        public RegisterPerson(string name,string fatherName,string motherName,DateTime dob,string phone,MartialDetails martialDetails,string houseAddress,int noOfSibilings,DateTime dateOfRegistration):base(name,gender,dob,phone,martialDetails)
        {
            s_registrationNumber++;
            RegisterNumber="RID"+s_registrationNumber;
            FatherName=fatherName;
            MotherName=motherName;
            HouseAddress=houseAddress;
            NoOfSibilings=noOfSibilings;
            DateOfRegistration=dateOfRegistration;
        }
        public new void ShowInfo()
        {
            Console.WriteLine($"|{RegisterNumber}|{Name}|{FatherName}|{MotherName}|{DOB}|{Phone}|{MartialDetails}|{HouseAddress}|{NoOfSibilings}|{DateOfRegistration}|");
        }
    }
}