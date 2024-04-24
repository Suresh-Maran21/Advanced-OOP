using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritanceOne
{
    public class StudentInfo : PersonalInfo
    {
        //properties
        //RegisterNumber, Standard, Branch, AcadamicYear
        public int RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public int AcadamicYear { get; set; }

        public StudentInfo(string name,string fatherName,DateTime dob,long phone,string mail,string gender,int registerNumber,string standard,string branch,int acadamicYear) : base( name, fatherName, dob, phone, mail, gender)
        {
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }
    }
}