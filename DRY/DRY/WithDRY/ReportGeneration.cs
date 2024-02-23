using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DRY.WithDRY;
// Example of a Non-DRY report generation 
public class Reports
{
    // Example of a DRY report generation 
    void GenerateReport(databaseDetails databaseDetails)
    {
        var data = GetData(databaseDetails);
        process(data);
    }

    public void Main()
    {
        // Generate different reports calling the same method
        databaseDetails databaseDetails = new databaseDetails();
        GenerateReport(databaseDetails);
        GenerateReport(databaseDetails);
    }
    private void process(object data)
    {
        throw new NotImplementedException();
    }

    private object GetData(databaseDetails databaseDetails)
    {
        throw new NotImplementedException();
    }


}

