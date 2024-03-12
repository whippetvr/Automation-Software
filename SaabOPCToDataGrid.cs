using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lrt_Ilukste
{
    [Serializable]
    public class SaabOPCToDataGrid
    {
        public DateTime TankDateTime { get; set; }
        public string TankName { get; set; }
        public float TankLevel { get; set; }
        public float TankAvgTemp { get; set; }
        public float TankDensity { get; set; }
        public float TankVolume { get; set; }
        public float TankMassa { get; set; }
    }
}

