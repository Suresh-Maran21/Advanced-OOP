using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritanceTwo
{
    public class PeronalInfo
    {
        //Properties
        //  Name, FatherName, Phone, Mail, DOB, Gender
        public string  Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }


        public PeronalInfo(string name,string fatherName,long phone,string mail,DateTime dob,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            Gender=gender;
            DOB=DOB;
        }
    }
}