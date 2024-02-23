using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KISS.NonKISS;

public class Orders
{
    public long Calcuate(long Amount, int Count) 
        => Amount > 0 && Count > 0 ? Amount * Count : 0;
}
