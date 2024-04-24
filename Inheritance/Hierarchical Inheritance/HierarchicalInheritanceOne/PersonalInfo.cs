using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HierarchicalInheritanceOne
{
    public enum Gender{Select,Male,Female}
    public class PersonalInfo
    {
        public string Name {get; set;}
        public string FatherName{get;set;}
        public string DOB{get;set;}
        public long Phone{get;set;}
        public Gender Gender{get;set;}
        public string MailID{get; set;}

        public PersonalInfo(string name,string fatherName,string dob,long phone, Gender gender,string mailID)
        {
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phone;
            Gender=gender;
            MailID=mailID;
        } 
    }
}