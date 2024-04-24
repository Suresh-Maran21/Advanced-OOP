using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceOne
{
    public class Teacher : PersonalInfo
    {
        private static int s_teacherID=4000;
        public string TeacherID{get;}
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience {get;set;}
        public int DateOfJoining {get;set;}

        public Teacher(string name,string fatherName,string dob,long phone, Gender gender,string mailID,string department,string subjectTeaching,string qualification,int yearOfExperience,int dateOfJoining):base( name, fatherName, dob, phone,  gender, mailID)
        {
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{Name}|{FatherName}|{DOB}|{Phone}|{Gender}|{MailID}|{Department}|{SubjectTeaching}|{Qualification}|{YearOfExperience}|{DateOfJoining}");
        }
    }
}