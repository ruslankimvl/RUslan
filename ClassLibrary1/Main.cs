using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Backupo
{
    class StorageService
    {

        List<Storage> storages = new List<Storage>();
        public double getALLCapacity()
        {
            double sum = 0;
            for (int i = 0; i < storages.Count; i++)
            {
                sum += storages[i].getCapacity();
            }
            return sum;
        }
        public TimeSpan getTimeCopying(Flash flash, double mem)
        {
            TimeSpan time;
            if (    flash.getFreeCapacity()<mem)
            {
                time = new TimeSpan(0, 0, 0);
            }
            else
            {
                double tmp = mem / flash.speed;
                time = TimeSpan.FromMinutes(tmp);
            }
            return time;
        }
      
        public void getCountStorage(double v)
        {
            for (int i = 0; i < storages.Count; i++)
            {
                string Info = string.Format("{0}){1} count{2}", i + 1, v / storages[i].getCapacity());
                Console.WriteLine( Info ); 
            }
        }
        public void T(Storage storage , double mem)
        {

            if (storage.getFreeCapacity()<mem)
            {
                throw new Exception("we haven't free capacity");

            }
            else
            {
                for (int i = 0; i < getTimeCopying(storage ,mem).Minutes; i++)
                {
                    Console.WriteLine(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.WriteLine("Copying is done");
            }
        }
    }
}
