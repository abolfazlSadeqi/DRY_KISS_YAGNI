using DRY.NonDRY.Registers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DRY.NonDRY.Registers.Validate;

public class ValidateReal
{
    public void Valid(Real real )
    {
        if (string.IsNullOrWhiteSpace(real.Name))
            throw new Exception("Name can not Empty.");

        if (string.IsNullOrWhiteSpace(real.CustomerType))
            throw new Exception("CustomerType can not Empty.");

        if (string.IsNullOrWhiteSpace(real.NationalId))
            throw new Exception("NationalId can not Empty.");

    }
}
