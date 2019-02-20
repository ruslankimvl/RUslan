using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backupo
{
    public abstract class Storage
    {
        public Storage(double capacity)
        {
            this.capacity = capacity;

        }
        public int memory { get; set; }
    
        protected string name { get; set; }
        protected string model { get; set; }
        private double capacity { get; set; }
        public virtual double getCapacity()
        {
            return capacity;
        }
        public abstract void copyInfo();

        public virtual double getFreeCapacity()
        {
            return capacity=memory;
        }
        public virtual void printInfo()
        {
            Console.WriteLine("name:{0}",name);
            Console.WriteLine("model:{0}", model);
            Console.WriteLine("memory:{0}", memory);
            Console.WriteLine("capacity:{0}", capacity);
        }

    }

}
