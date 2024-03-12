using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lrt_Ilukste
{
    class CalculateTankOperation
    {
        // Linear extention coef. 1/°C for carbon steel
        private const double cAlfa = 0.0000125;

        public int TankID { get; set; }
        public double TankLevel { get; set; }
        public double TankAvgTemp { get; set; }
        public double TankDensity { get; set; }
        public double TankTgrad { get; set; }

        // Input by Operator
        public double AirTemp { get; set; }
        public bool MeasureType { get; set; }

        // Calculatuon Values from Saab Data
        public double CalcVolume { get; set; }
        public double CalcDensity20 { get; set; }
        public double CalcVolume20 { get; set; }
        public double CalcMassa { get; set; }

        // Calculation Values from Laboratory Data
        public double LabDensity20 { get; set; }
        public double LabDensity { get; set; }
        public double LabVolume { get; set; }
        public double LabVolume20 { get; set; }
        public double LabMassa { get; set; }
        public double CTL20 { get; set; }

        public void CalculateCTL20()
        {
          

        }

        public void CalculateVolume()
        {


        }

        public void CalculateLabVolume()
        {


        }

        public void CalculateLabMassa()
        {


        };
        }
    }
}
