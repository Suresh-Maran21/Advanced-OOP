using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceOne
{
    public enum MartialDetails{Select,Married,Single}
    public class PersonalInfo
    {
        public string Name {get;set;}
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public MartialDetails MartialDetails{get;set;}

        public PersonalInfo(string name,string gender,DateTime dob,string phone,MartialDetails martialDetails)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            MartialDetails=martialDetails;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"DOB : {DOB}");
            Console.WriteLine($"Phone : {Phone}");
            Console.WriteLine($"Martial Details : {MartialDetails}");

        }
    }
}