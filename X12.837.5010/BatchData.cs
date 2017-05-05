using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZirMed.Claims.Objects.Transactions.CLP;
namespace X12._837._5010
{
    class BatchData
    {
        public clp clp { get; set; }
        private List<clp> _internalClp = new List<clp>();
        internal void Add(ZirMed.Claims.Objects.Transactions.CLP.clp clp)
        {
            //todo roll up logic
            _internalClp.Add(clp);
        }
        public int Count { get { return _internalClp.Count; } }
    }
}
