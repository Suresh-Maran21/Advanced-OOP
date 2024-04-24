using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceOne
{
    public interface IFamilyInfo
    {
        string FatherName{get;set;}
        string MotherName{get;set;}
        string HouseAddress{get;set;}
        int NoOfSibilings{get;set;}
    }
}