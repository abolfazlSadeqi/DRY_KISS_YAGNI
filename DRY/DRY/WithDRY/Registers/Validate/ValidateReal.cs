using DRY.WithDRY.Registers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DRY.WithDRY.Registers.Validate;

public class ValidateReal
{
    public void Valid(Real real )
    {
          new ValidateBase().Valid(real);
        if (string.IsNullOrWhiteSpace(real.NationalId))
            throw new Exception("NationalId can not Empty.");

    }
}
