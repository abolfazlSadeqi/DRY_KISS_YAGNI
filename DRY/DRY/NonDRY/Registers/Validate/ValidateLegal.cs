using DRY.NonDRY.Registers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DRY.NonDRY.Registers.Validate;

public class ValidateLegal
{
    public void Valid(Legal  legal )
    {
        if (string.IsNullOrWhiteSpace(legal.Name))
            throw new Exception("Name can not Empty.");

        if (string.IsNullOrWhiteSpace(legal.CustomerType))
            throw new Exception("CustomerType can not Empty.");

        if (string.IsNullOrWhiteSpace(legal.RegisterId))
            throw new Exception("RegisterId can not Empty.");

    }
}
