using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DRY.NonDRY;
// Example of a Non-DRY report generation 
public class Reports
{
    void Report1()
    {
      var  data = GetData();
        process(data);
    }

    private void process(object data)
    {
        throw new NotImplementedException();
    }

    private object GetData()
    {
        throw new NotImplementedException();
    }

    void Report2()
    {
      var  data = GetData();
        process(data);
    }
}

