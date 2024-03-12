using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lrt_Ilukste
{
    class AddTankToOperation
    {
        public string TankName { get; set; }
        public string StateName { get; set; }
        public float? TankLevel { get; set; }
        public float? TankAvgTemp { get; set; }
        public float? TankDensity { get; set; }
        public float? CalcVolume { get; set; }
        public float? LabDensity20 { get; set; }
        public float? LabVolume20 { get; set; }
        public float? LabMassa { get; set; }
        public int RegID { get; set; }
        public byte? MeasureType { get; set; }
    }
}
