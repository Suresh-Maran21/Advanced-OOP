using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class StudentInfo : PersonalInfo
    {
        //properties
        //RegisterNumber, Standard, Branch, AcadamicYear
        public int RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set;}
        public int AcadamicYear { get; set; }


        public StudentInfo(string name,string fatherName,long phone,string mailID,DateTime dob,string gender,int registerNumber,string standard,string branch,int acadamicYear) : base( name, fatherName, phone, mailID, dob, gender)
        {
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"|{Name}||{FatherName}||{Phone}||{MailID}||{DOB}||{Gender}||{RegisterNumber}||{Standard}||{Branch}||{AcadamicYear}|");
        }
    }
}