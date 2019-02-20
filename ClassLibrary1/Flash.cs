using Backupo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backupo
{
    enum USBTYPE { USB20 ,USB30}

   public class Flash: Storage
    {
        public Flash(double capacity,string name ,string model , int speed , USBTYPE USBtype ):base(capacity)
        {
            this.speed = speed;
            this.name = name;
            this.model = model;
            this.USBtype = USBtype;


        }
        USBTYPE flashType { get; set; }
        public int speed { get; set; }
        public override void copyInfo()
        {
        }
    }
}
