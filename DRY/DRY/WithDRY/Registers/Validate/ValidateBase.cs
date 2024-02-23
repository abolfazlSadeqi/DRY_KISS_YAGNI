using DRY.WithDRY.Registers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DRY.WithDRY.Registers.Validate;

public class ValidateBase
{
    public void Valid(Base   @base )
    {
        if (string.IsNullOrWhiteSpace(@base.Name))
            throw new Exception("Name can not Empty.");

        if (string.IsNullOrWhiteSpace(@base.CustomerType))
            throw new Exception("CustomerType can not Empty.");


    }
}
