using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritanceOne
{
    public class HSCDetails : StudentInfo
    {
        //properties
        //HSCMarksheetNumber, Physics, Chemistry, Maths, Total, Percentage marks
        public int HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public int Percentage { get; set; }


        public HSCDetails(string name,string fatherName,DateTime dob,long phone,string mail,string gender,int registerNumber,string standard,string branch,int acadamicYear,int hscMarksheetNumber,int physics,int chemistry,int maths) : base( name, fatherName, dob, phone, mail, gender, registerNumber, standard, branch, acadamicYear)
        {
            HSCMarksheetNumber=hscMarksheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public void GetMarks()
        {
            Console.WriteLine($"Physics : {Physics}\nchemistry : {Chemistry}\nMaths : {Maths}");
        }
        public void CalculateTotal()
        {
            Total=Physics+Maths+Chemistry;
            Console.WriteLine($"Total Marks : {Total}");
        }
        public void CalculatePercentage()
        {
            Percentage=Total/3;
            Console.WriteLine($"Persentage : {Percentage}");
        }
        public void ShowMarksheet()
        {
            Console.WriteLine($"HSCMarkSheetNumber : {HSCMarksheetNumber}\nPhysics : {Physics}\nchemistry : {Chemistry}\nMaths : {Maths}\nTotal : {Total}\nPercntage : {Percentage}");
        }
    }
}