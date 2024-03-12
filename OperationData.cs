//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lrt_Ilukste
{
    using System;
    using System.Collections.Generic;
    
    public partial class OperationData
    {
        public int OperDataID { get; set; }
        public Nullable<int> RegID { get; set; }
        public Nullable<short> StateID { get; set; }
        public Nullable<System.DateTime> DataTime { get; set; }
        public Nullable<float> TankLevel { get; set; }
        public Nullable<float> TankAvgTemp { get; set; }
        public Nullable<float> TankDensity { get; set; }
        public Nullable<float> TankTgrad { get; set; }
        public Nullable<float> AirTemp { get; set; }
        public Nullable<float> CalcVolume { get; set; }
        public Nullable<float> CalcDensity20 { get; set; }
        public Nullable<float> CalcVolume20 { get; set; }
        public Nullable<float> CalcMassa { get; set; }
        public Nullable<float> LabDensity { get; set; }
        public Nullable<float> LabVolume { get; set; }
        public Nullable<float> LabDensity20 { get; set; }
        public Nullable<float> LabVolume20 { get; set; }
        public Nullable<float> LabMassa { get; set; }
        public Nullable<byte> MeasureType { get; set; }
    
        public virtual OperationState OperationState { get; set; }
        public virtual OperationRegister OperationRegister { get; set; }
    }
}
