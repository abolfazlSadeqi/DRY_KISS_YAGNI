using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGNI.NonYAGNI;

public class Orders
{
    public int Amount { set; get; }
    public string Address { set; get; }
    // Unnecessary feature 
    public string City { set; get; }

    public void Pay()
    {
        // to do

        // Unnecessary feature 
        if ( City!=string.Empty)
        {
            GetDiscountWithCity(City);
        }
    }

    private int GetDiscountWithCity(string City)
    {
        return 0;
    }
}
