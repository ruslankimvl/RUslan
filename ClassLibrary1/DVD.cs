using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backupo
{
    public enum DVDtype {oneSided ,twoSided}
    class DVD:Storage
    {

        public DVD(double capacity):base(capacity)
        {

        }
DVDtype dvdtype { get; set; }
public int speed { get; set; }
        public override void copyInfo()
        {

        }
    }
}
