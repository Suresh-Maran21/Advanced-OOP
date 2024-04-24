using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceOne
{
    public class PrincipalInfo : PersonalInfo
    {
        private static int s_PrincipleID=2000;

        public string PrincipalID{get;}
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public string DateOfJoing {get;set;}

        public PrincipalInfo(string name,string fatherName,string dob,long phone, Gender gender,string mailID,string qualification,int yearOfExperience,string dateOfJoing): base( name, fatherName, dob, phone,  gender, mailID)
        {
            s_PrincipleID++;
            PrincipalID="PID"+s_PrincipleID;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoing=dateOfJoing;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{Name}|{FatherName}|{DOB}|{Phone}|{Gender}|{MailID}|{Qualification}|{YearOfExperience}|{DateOfJoing}");
        }
    }
}