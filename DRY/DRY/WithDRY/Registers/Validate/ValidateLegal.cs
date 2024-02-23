using DRY.WithDRY.Registers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DRY.WithDRY.Registers.Validate;

public class ValidateLegal
{
    public void Valid(Legal  legal )
    {
        new ValidateBase().Valid(legal);
        if (string.IsNullOrWhiteSpace(legal.RegisterId))
            throw new Exception("RegisterId can not Empty.");

    }
}
