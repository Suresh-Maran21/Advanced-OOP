using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritanceOne
{
    public class PersonalInfo
    {
        //properties
        //Name, FatherName,Phone,Mail, dob,Gender
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }


        public PersonalInfo(string name,string fatherName,DateTime dob,long phone,string mail,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }
    }
}