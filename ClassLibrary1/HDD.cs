using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backupo
{
    enum HDDtype {USB20 }
    class HDD : Storage
    {

        public HDD(double capacity) : base(capacity)
        {

        }
        HDDtype hddtype { get; set; }
        public int speed { get; set; }
        public override void copyInfo()
        {

        }
        public int CountSections{get;set;}
    }
}
