using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lrt_Ilukste
{
    class SaveSaabToDB
    {
        public static async void SaveSaabDataToDBAsync(System.Collections.IList dgwList)
        {
            await Task.Run(() =>
            {
                using (IluksteEntities db = new IluksteEntities())
                {
                    foreach (SaabOPCToDataGrid s in dgwList)
                    {
                        SaabData sb = new SaabData();
                        sb.SaabDateTime = s.TankDateTime;
                        sb.TankID = Convert.ToInt32(s.TankName.Substring(1));
                        sb.TankLevel = s.TankLevel;
                        sb.TankAvgTemp = s.TankAvgTemp;
                        sb.TankDensity = s.TankDensity;
                        sb.TankVolume = s.TankVolume;
                        sb.TankMassa = s.TankMassa;

                        db.SaabData.Add(sb);
                        db.SaveChanges();
                    }
                }
            }
            ); 
        }
    }
}
