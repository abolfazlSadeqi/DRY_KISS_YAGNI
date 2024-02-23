using DRY.NonDRY.Registers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY.NonDRY.Registers;

public class RegisterLegal
{

    public void Register(Legal legal)
    {
        // Validate
           new 
             Validate
            .ValidateLegal()
            .Valid(legal);

        // Save the customer to the database
        // ...
    }
}
