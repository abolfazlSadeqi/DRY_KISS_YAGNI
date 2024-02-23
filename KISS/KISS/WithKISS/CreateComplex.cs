using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KISS.WithKISS;

public class CreateComplex
{

    public string GetComplex(bool IsTeacher, bool IsEmployee, bool IsStudent)
    {
        string Position = "He/She is ";

        Position += AddPosition(Position, IsTeacher, "Teacher");
        Position += AddPosition(Position, IsEmployee, "Employee");
        Position += AddPosition(Position, IsStudent, "Student");

        return Position + ", Human";
    }

    private string AddPosition(string Position, bool ISvalue, string value)
        => ISvalue ? $"{value}," : Position;



}