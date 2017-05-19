using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X12.Data;

namespace X12._837._5010
{
    class WorkerObject
    {

        public WorkerObject()
        {
            loop837 = new Loop837();
            transaction = new X12Orginizer(loop837.Definition);
        }
        public bool InUse{get;set;}
        public  Loop837 loop837 { get; set; }
        public  X12Orginizer transaction { get; set; }
        
    }
}
