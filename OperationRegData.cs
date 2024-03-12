using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lrt_Ilukste
{
    class OperationRegData
    {
        public Nullable<int> ActN { get; set; }
        public string TankName { get; set; }
        public Nullable<DateTime> StartDataTime { get; set; }
        public Nullable<DateTime> EndDataTime { get; set; }
        public string OperName { get; set; }
        public double? Massa { get; set; }
        public Nullable<DateTime> CreateDataTime { get; set; }
        public Nullable<int> RegID { get; set; }
        public Nullable<int> FullReport { get; set; }
    }
}
