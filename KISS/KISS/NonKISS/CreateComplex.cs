using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KISS.NonKISS;

public class CreateComplex
{
    public string GetComplex(bool IsTeacher, bool IsEmployee, bool IsStudent)
    {
        string Position = "He/She is ";

        if (IsTeacher)
            Position += " Teacher,";
        

        if (IsEmployee)
            Position += "Employee,";
        

        if (IsStudent)
            Position += "Employee,";
        

        Position += "Human";


        return Position;
    }
}