using DRY.WithDRY.Registers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY.WithDRY.Registers;

public class RegisterReal
{

    public void Register(Real real)
    {
        new
            Validate
           .ValidateReal()
           .Valid(real);

        // Step 2: Save the customer to the database
        // ...
    }


}
