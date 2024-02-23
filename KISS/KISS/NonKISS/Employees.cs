using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KISS.NonKISS;

public class Employees
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Balance { get; set; }
    public int Type { get; set; }
    public bool ISEnable { get; set; }

    public string GetStatus()
    {
        if (this.ISEnable)
        {
            if (this.Balance > 10000 && this.Type == 1)
            {
                return "Employee can Get Loan";
            }
            else
            {
                if (this.Balance > 0 && this.Balance < 10000 && this.Type == 1)
                {
                    return "Employee Must Get Loan";
                }
                else
                {
                    return "Employee can not Get Loan";
                }
            }
        }
        else
        {
            return "Employee can not Get Loan";
        }

    }

}
