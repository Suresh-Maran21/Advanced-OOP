using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceOne
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_studentID=8000;

        public string StudentID{get;set;}
        public string Degree{get;set;}
        public string Department{get;set;}
        public int Semester{get;set;}

        public StudentInfo(string name,string fatherName,string dob,long phone, Gender gender,string mailID,string degree,string department,int semester):base( name, fatherName, dob, phone,  gender, mailID)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"{Name}|{FatherName}|{DOB}|{Phone}|{Gender}|{MailID}|{Degree}|{Department}|{Semester}");
        }
    }
}