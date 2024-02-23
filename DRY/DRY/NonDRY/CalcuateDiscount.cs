using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY.NonDRY;

public class CalcuateDiscount
{

    public double CalculateDiscountCategoryLaptop(int Amount)
          => Amount * 0.14;


    public double CalculateDiscountCategoryMobile(int Amount)
        => Amount * 0.14;

}

