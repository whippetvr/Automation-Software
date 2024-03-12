using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitaniumAS.Opc.Client;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;
using TitaniumAS.Opc.Client.Da.Browsing;

namespace Lrt_Ilukste
{
    class SaabOPCClient
    {
        public static BindingList<SaabOPCToDataGrid> ReadDataFromOPCServerAsync()
        {
            BindingList<SaabOPCToDataGrid> dgwList = new BindingList<SaabOPCToDataGrid>();
            string SaabOPCServerIP = Properties.Settings.Default.SaabOPCServerIP;
            string SaabOPCServerName = Properties.Settings.Default.SaabOPCServerName;

            //Uri url = UrlBuilder.Build("SaabTankRadar.TankServer.1", "192.168.133.213");
            Uri url = UrlBuilder.Build(SaabOPCServerName, SaabOPCServerIP);

            using (var server = new OpcDaServer(url))
            {

                // Connect to the server first.
                server.Connect();

                // Create a group with items.
                OpcDaGroup group = CreateGroupWithItems(server);

                // Read OPCvalues of items from device synchronously.
                OpcDaItemValue[] OPCvalues = group.Read(group.Items, OpcDaDataSource.Device);

                // Output OPCvalues
                //foreach (OpcDaItemValue value in OPCvalues)
                //{
                //    Console.WriteLine("ItemId: {0}; Value: {1}; Quality: {2}; Timestamp: {3}",
                //        value.Item.ItemId, value.Value, value.Quality, value.Timestamp);
                //}

                dgwList.Clear();
                DateTime dt = DateTime.Now;

                SaabOPCToDataGrid opc1 = new SaabOPCToDataGrid();
                opc1.TankDateTime = dt;
                opc1.TankName = "N1";
                opc1.TankLevel = Convert.ToSingle(OPCvalues[0].Value) * 1000;
                opc1.TankAvgTemp = Convert.ToSingle(OPCvalues[1].Value);
                float td1 = Convert.ToSingle(OPCvalues[2].Value);
                opc1.TankDensity = td1;
                float tv1 = Convert.ToSingle(OPCvalues[3].Value);
                opc1.TankVolume = tv1;
                opc1.TankMassa = td1 * tv1 / (float)1000.0;   //Convert.ToSingle(OPCvalues[4].Value);
                dgwList.Add(opc1);

                SaabOPCToDataGrid opc2 = new SaabOPCToDataGrid();
                opc2.TankDateTime = dt;
                opc2.TankName = "N2";
                opc2.TankLevel = Convert.ToSingle(OPCvalues[5].Value) * 1000;
                opc2.TankAvgTemp = Convert.ToSingle(OPCvalues[6].Value);
                float td2 = Convert.ToSingle(OPCvalues[7].Value);
                opc2.TankDensity = td2;
                float tv2 = Convert.ToSingle(OPCvalues[8].Value);
                opc2.TankVolume = tv2;
                opc2.TankMassa = td2 * tv2 / (float)1000.0;
                //opc2.TankDensity = Convert.ToSingle(OPCvalues[7].Value);
                //opc2.TankVolume = Convert.ToSingle(OPCvalues[8].Value);
                //opc2.TankMassa = Convert.ToSingle(OPCvalues[9].Value);
                dgwList.Add(opc2);

                SaabOPCToDataGrid opc3 = new SaabOPCToDataGrid();
                opc3.TankDateTime = dt;
                opc3.TankName = "N3";
                opc3.TankLevel = Convert.ToSingle(OPCvalues[10].Value) * 1000;
                opc3.TankAvgTemp = Convert.ToSingle(OPCvalues[11].Value);
                float td3 = Convert.ToSingle(OPCvalues[12].Value);
                opc3.TankDensity = td1;
                float tv3 = Convert.ToSingle(OPCvalues[13].Value);
                opc3.TankVolume = tv3;
                opc3.TankMassa = td3 * tv3 / (float)1000.0;
                //opc3.TankDensity = Convert.ToSingle(OPCvalues[12].Value);
                //opc3.TankVolume = Convert.ToSingle(OPCvalues[13].Value);
                //opc3.TankMassa = Convert.ToSingle(OPCvalues[14].Value);
                dgwList.Add(opc3);

                SaabOPCToDataGrid opc4 = new SaabOPCToDataGrid();
                opc4.TankDateTime = dt;
                opc4.TankName = "N4";
                opc4.TankLevel = Convert.ToSingle(OPCvalues[15].Value) * 1000;
                opc4.TankAvgTemp = Convert.ToSingle(OPCvalues[16].Value);
                float td4 = Convert.ToSingle(OPCvalues[17].Value);
                opc4.TankDensity = td1;
                float tv4 = Convert.ToSingle(OPCvalues[18].Value);
                opc4.TankVolume = tv4;
                opc4.TankMassa = td4 * tv4 / (float)1000.0;
                //opc4.TankDensity = Convert.ToSingle(OPCvalues[17].Value);
                //opc4.TankVolume = Convert.ToSingle(OPCvalues[18].Value);
                //opc4.TankMassa = Convert.ToSingle(OPCvalues[19].Value);
                dgwList.Add(opc4);

                SaabOPCToDataGrid opc5 = new SaabOPCToDataGrid();
                opc5.TankDateTime = dt;
                opc5.TankName = "N5";
                opc5.TankLevel = Convert.ToSingle(OPCvalues[20].Value) * 1000;
                opc5.TankAvgTemp = Convert.ToSingle(OPCvalues[21].Value);
                float td5 = Convert.ToSingle(OPCvalues[22].Value);
                opc5.TankDensity = td5;
                float tv5 = Convert.ToSingle(OPCvalues[23].Value);
                opc5.TankVolume = tv5;
                opc5.TankMassa = td5 * tv5 / (float)1000.0;
                //opc5.TankDensity = Convert.ToSingle(OPCvalues[22].Value);
                //opc5.TankVolume = Convert.ToSingle(OPCvalues[23].Value);
                //opc5.TankMassa = Convert.ToSingle(OPCvalues[24].Value);
                dgwList.Add(opc5);

                SaabOPCToDataGrid opc6 = new SaabOPCToDataGrid();
                opc6.TankDateTime = dt;
                opc6.TankName = "N6";
                opc6.TankLevel = Convert.ToSingle(OPCvalues[25].Value) * 1000;
                opc6.TankAvgTemp = Convert.ToSingle(OPCvalues[26].Value);
                float td6 = Convert.ToSingle(OPCvalues[27].Value);
                opc6.TankDensity = td6;
                float tv6 = Convert.ToSingle(OPCvalues[28].Value);
                opc6.TankVolume = tv6;
                opc6.TankMassa = td6 * tv6 / (float)1000.0;
                //opc6.TankDensity = Convert.ToSingle(OPCvalues[27].Value);
                //opc6.TankVolume = Convert.ToSingle(OPCvalues[28].Value);
                //opc6.TankMassa = Convert.ToSingle(OPCvalues[29].Value);
                dgwList.Add(opc6);

                SaabOPCToDataGrid opc7 = new SaabOPCToDataGrid();
                opc7.TankDateTime = dt;
                opc7.TankName = "N7";
                opc7.TankLevel = Convert.ToSingle(OPCvalues[30].Value) * 1000;
                opc7.TankAvgTemp = Convert.ToSingle(OPCvalues[31].Value);
                float td7 = Convert.ToSingle(OPCvalues[32].Value);
                opc7.TankDensity = td7;
                float tv7 = Convert.ToSingle(OPCvalues[33].Value);
                opc7.TankVolume = tv7;
                opc7.TankMassa = td7 * tv7 / (float)1000.0;
                //opc7.TankDensity = Convert.ToSingle(OPCvalues[32].Value);
                //opc7.TankVolume = Convert.ToSingle(OPCvalues[33].Value);
                //opc7.TankMassa = Convert.ToSingle(OPCvalues[34].Value);
                dgwList.Add(opc7);

                SaabOPCToDataGrid opc8 = new SaabOPCToDataGrid();
                opc8.TankDateTime = dt;
                opc8.TankName = "N8";
                opc8.TankLevel = Convert.ToSingle(OPCvalues[35].Value) * 1000;
                opc8.TankAvgTemp = Convert.ToSingle(OPCvalues[36].Value);
                float td8 = Convert.ToSingle(OPCvalues[37].Value);
                opc8.TankDensity = td8;
                float tv8 = Convert.ToSingle(OPCvalues[38].Value);
                opc8.TankVolume = tv8;
                opc8.TankMassa = td8 * tv8 / (float)1000.0;
                //opc8.TankDensity = Convert.ToSingle(OPCvalues[37].Value);
                //opc8.TankVolume = Convert.ToSingle(OPCvalues[38].Value);
                //opc8.TankMassa = Convert.ToSingle(OPCvalues[39].Value);
                dgwList.Add(opc8);

                SaabOPCToDataGrid opc9 = new SaabOPCToDataGrid();
                opc9.TankDateTime = dt;
                opc9.TankName = "N9";
                opc9.TankLevel = Convert.ToSingle(OPCvalues[40].Value) * 1000;
                opc9.TankAvgTemp = Convert.ToSingle(OPCvalues[41].Value);
                float td9 = Convert.ToSingle(OPCvalues[42].Value);
                opc9.TankDensity = td9;
                float tv9 = Convert.ToSingle(OPCvalues[43].Value);
                opc9.TankVolume = tv9;
                opc9.TankMassa = td9 * tv9 / (float)1000.0;
                //opc9.TankDensity = Convert.ToSingle(OPCvalues[42].Value);
                //opc9.TankVolume = Convert.ToSingle(OPCvalues[43].Value);
                //opc9.TankMassa = Convert.ToSingle(OPCvalues[44].Value);
                dgwList.Add(opc9);

                SaabOPCToDataGrid opc10 = new SaabOPCToDataGrid();
                opc10.TankDateTime = dt;
                opc10.TankName = "N10";
                opc10.TankLevel = Convert.ToSingle(OPCvalues[45].Value) * 1000;
                opc10.TankAvgTemp = Convert.ToSingle(OPCvalues[46].Value);
                float td10 = Convert.ToSingle(OPCvalues[47].Value);
                opc10.TankDensity = td10;
                float tv10 = Convert.ToSingle(OPCvalues[48].Value);
                opc10.TankVolume = tv10;
                opc10.TankMassa = td10 * tv10 / (float)1000.0;
                //opc10.TankDensity = Convert.ToSingle(OPCvalues[47].Value);
                //opc10.TankVolume = Convert.ToSingle(OPCvalues[48].Value);
                //opc10.TankMassa = Convert.ToSingle(OPCvalues[49].Value);
                dgwList.Add(opc10);

                SaabOPCToDataGrid opc11 = new SaabOPCToDataGrid();
                opc11.TankDateTime = dt;
                opc11.TankName = "N11";
                opc11.TankLevel = Convert.ToSingle(OPCvalues[50].Value) * 1000;
                opc11.TankAvgTemp = Convert.ToSingle(OPCvalues[51].Value);
                float td11 = Convert.ToSingle(OPCvalues[52].Value);
                opc11.TankDensity = td11;
                float tv11 = Convert.ToSingle(OPCvalues[53].Value);
                opc11.TankVolume = tv11;
                opc11.TankMassa = td11 * tv11 / (float)1000.0;
                //opc11.TankDensity = Convert.ToSingle(OPCvalues[52].Value);
                //opc11.TankVolume = Convert.ToSingle(OPCvalues[53].Value);
                //opc11.TankMassa = Convert.ToSingle(OPCvalues[54].Value);
                dgwList.Add(opc11);

                SaabOPCToDataGrid opc12 = new SaabOPCToDataGrid();
                opc12.TankDateTime = dt;
                opc12.TankName = "N12";
                opc12.TankLevel = Convert.ToSingle(OPCvalues[55].Value) * 1000;
                opc12.TankAvgTemp = Convert.ToSingle(OPCvalues[56].Value);
                float td12 = Convert.ToSingle(OPCvalues[57].Value);
                opc12.TankDensity = td12;
                float tv12 = Convert.ToSingle(OPCvalues[58].Value);
                opc12.TankVolume = tv12;
                opc12.TankMassa = td12 * tv12 / (float)1000.0;
                //opc12.TankDensity = Convert.ToSingle(OPCvalues[57].Value);
                //opc12.TankVolume = Convert.ToSingle(OPCvalues[58].Value);
                //opc12.TankMassa = Convert.ToSingle(OPCvalues[59].Value);
                dgwList.Add(opc12);

                SaabOPCToDataGrid opc13 = new SaabOPCToDataGrid();
                opc13.TankDateTime = dt;
                opc13.TankName = "N13";
                opc13.TankLevel = Convert.ToSingle(OPCvalues[60].Value) * 1000;
                opc13.TankAvgTemp = Convert.ToSingle(OPCvalues[61].Value);
                float td13 = Convert.ToSingle(OPCvalues[62].Value);
                opc13.TankDensity = td13;
                float tv13 = Convert.ToSingle(OPCvalues[63].Value);
                opc13.TankVolume = tv13;
                opc13.TankMassa = td13 * tv13 / (float)1000.0;
                //opc13.TankDensity = Convert.ToSingle(OPCvalues[62].Value);
                //opc13.TankVolume = Convert.ToSingle(OPCvalues[63].Value);
                //opc13.TankMassa = Convert.ToSingle(OPCvalues[64].Value);
                dgwList.Add(opc13);

                SaabOPCToDataGrid opc14 = new SaabOPCToDataGrid();
                opc14.TankDateTime = dt;
                opc14.TankName = "N14";
                opc14.TankLevel = Convert.ToSingle(OPCvalues[65].Value) * 1000;
                opc14.TankAvgTemp = Convert.ToSingle(OPCvalues[66].Value);
                float td14 = Convert.ToSingle(OPCvalues[67].Value);
                opc14.TankDensity = td14;
                float tv14 = Convert.ToSingle(OPCvalues[68].Value);
                opc14.TankVolume = tv14;
                opc14.TankMassa = td14 * tv14 / (float)1000.0;
                //opc14.TankDensity = Convert.ToSingle(OPCvalues[67].Value);
                //opc14.TankVolume = Convert.ToSingle(OPCvalues[68].Value);
                //opc14.TankMassa = Convert.ToSingle(OPCvalues[69].Value);
                dgwList.Add(opc14);

                SaabOPCToDataGrid opc15 = new SaabOPCToDataGrid();
                opc15.TankDateTime = dt;
                opc15.TankName = "N15";
                opc15.TankLevel = Convert.ToSingle(OPCvalues[70].Value) * 1000;
                opc15.TankAvgTemp = Convert.ToSingle(OPCvalues[71].Value);
                float td15 = Convert.ToSingle(OPCvalues[72].Value);
                opc15.TankDensity = td15;
                float tv15 = Convert.ToSingle(OPCvalues[73].Value);
                opc15.TankVolume = tv5;
                opc15.TankMassa = td15 * tv15 / (float)1000.0;
                //opc15.TankDensity = Convert.ToSingle(OPCvalues[72].Value);
                //opc15.TankVolume = Convert.ToSingle(OPCvalues[73].Value);
                //opc15.TankMassa = Convert.ToSingle(OPCvalues[74].Value);
                dgwList.Add(opc15);

                SaabOPCToDataGrid opc16 = new SaabOPCToDataGrid();
                opc16.TankDateTime = dt;
                opc16.TankName = "N16";
                opc16.TankLevel = Convert.ToSingle(OPCvalues[75].Value) * 1000;
                opc16.TankAvgTemp = Convert.ToSingle(OPCvalues[76].Value);
                float td16 = Convert.ToSingle(OPCvalues[77].Value);
                opc16.TankDensity = td16;
                float tv16 = Convert.ToSingle(OPCvalues[78].Value);
                opc16.TankVolume = tv16;
                opc16.TankMassa = td16 * tv16 / (float)1000.0;
                //opc16.TankDensity = Convert.ToSingle(OPCvalues[77].Value);
                //opc16.TankVolume = Convert.ToSingle(OPCvalues[78].Value);
                //opc16.TankMassa = Convert.ToSingle(OPCvalues[79].Value);
                dgwList.Add(opc16);

                // The output should be like the following:
                //   ItemId: Bucket Brigade.Int4; Value: 0; Quality: Good+Good+NotLimited; Timestamp: 04/18/2016 13:40:57 +03:00
                //   ItemId: Random.Int2; Value: 26500; Quality: Good+Good+NotLimited; Timestamp: 04/18/2016 13:40:57 +03:00
            }

            // The output should be like the following:
            // #MonitorACLFile (ItemId: #MonitorACLFile, IsHint: False, IsItem: True, HasChildren: False)
            // @Clients (ItemId: @Clients, IsHint: False, IsItem: True, HasChildren: False)
            // Configured Aliases (ItemId: Configured Aliases, IsHint: False, IsItem: False, HasChildren: True)
            // Simulation Items (ItemId: Simulation Items, IsHint: False, IsItem: False, HasChildren: True)
            //   Bucket Brigade (ItemId: Bucket Brigade, IsHint: False, IsItem: False, HasChildren: True)
            //     ArrayOfReal8 (ItemId: Bucket Brigade.ArrayOfReal8, IsHint: False, IsItem: True, HasChildren: False)
            //     ArrayOfString (ItemId: Bucket Brigade.ArrayOfString, IsHint: False, IsItem: True, HasChildren: False)
            //     Boolean (ItemId: Bucket Brigade.Boolean, IsHint: False, IsItem: True, HasChildren: False)
            //     Int1 (ItemId: Bucket Brigade.Int1, IsHint: False, IsItem: True, HasChildren: False)
            //     Int2 (ItemId: Bucket Brigade.Int2, IsHint: False, IsItem: True, HasChildren: False)
            //     Int4 (ItemId: Bucket Brigade.Int4, IsHint: False, IsItem: True, HasChildren: False)
            // ...
            return dgwList;
        }

        private static OpcDaGroup CreateGroupWithItems(OpcDaServer server)
        {
            // Create a group with items.
            OpcDaGroup group = server.AddGroup("TANKS");
            group.IsActive = true;

            var definition11 = new OpcDaItemDefinition
            {
                ItemId = "Tank-1.LL.CV",
                IsActive = true
            };
            var definition12 = new OpcDaItemDefinition
            {
                ItemId = "Tank-1.AT.CV",
                IsActive = true
            };
            var definition13 = new OpcDaItemDefinition
            {
                ItemId = "Tank-1.DOBS.CV",
                IsActive = true
            };
            var definition14 = new OpcDaItemDefinition
            {
                ItemId = "Tank-1.V_SP.CV",
                IsActive = true
            };
            var definition15 = new OpcDaItemDefinition
            {
                ItemId = "Tank-1.MASS.CV",
                IsActive = true
            };

            var definition21 = new OpcDaItemDefinition
            {
                ItemId = "Tank-2.LL.CV",
                IsActive = true
            };
            var definition22 = new OpcDaItemDefinition
            {
                ItemId = "Tank-2.AT.CV",
                IsActive = true
            };
            var definition23 = new OpcDaItemDefinition
            {
                ItemId = "Tank-2.DOBS.CV",
                IsActive = true
            };
            var definition24 = new OpcDaItemDefinition
            {
                ItemId = "Tank-2.V_SP.CV",
                IsActive = true
            };
            var definition25 = new OpcDaItemDefinition
            {
                ItemId = "Tank-2.MASS.CV",
                IsActive = true
            };

            var definition31 = new OpcDaItemDefinition
            {
                ItemId = "Tank-3.LL.CV",
                IsActive = true
            };
            var definition32 = new OpcDaItemDefinition
            {
                ItemId = "Tank-3.AT.CV",
                IsActive = true
            };
            var definition33 = new OpcDaItemDefinition
            {
                ItemId = "Tank-3.DOBS.CV",
                IsActive = true
            };
            var definition34 = new OpcDaItemDefinition
            {
                ItemId = "Tank-3.V_SP.CV",
                IsActive = true
            };
            var definition35 = new OpcDaItemDefinition
            {
                ItemId = "Tank-3.MASS.CV",
                IsActive = true
            };

            var definition41 = new OpcDaItemDefinition
            {
                ItemId = "Tank-4.LL.CV",
                IsActive = true
            };
            var definition42 = new OpcDaItemDefinition
            {
                ItemId = "Tank-4.AT.CV",
                IsActive = true
            };
            var definition43 = new OpcDaItemDefinition
            {
                ItemId = "Tank-4.DOBS.CV",
                IsActive = true
            };
            var definition44 = new OpcDaItemDefinition
            {
                ItemId = "Tank-4.V_SP.CV",
                IsActive = true
            };
            var definition45 = new OpcDaItemDefinition
            {
                ItemId = "Tank-4.MASS.CV",
                IsActive = true
            };

            var definition51 = new OpcDaItemDefinition
            {
                ItemId = "Tank-5.LL.CV",
                IsActive = true
            };
            var definition52 = new OpcDaItemDefinition
            {
                ItemId = "Tank-5.AT.CV",
                IsActive = true
            };
            var definition53 = new OpcDaItemDefinition
            {
                ItemId = "Tank-5.DOBS.CV",
                IsActive = true
            };
            var definition54 = new OpcDaItemDefinition
            {
                ItemId = "Tank-5.V_SP.CV",
                IsActive = true
            };
            var definition55 = new OpcDaItemDefinition
            {
                ItemId = "Tank-5.MASS.CV",
                IsActive = true
            };

            var definition61 = new OpcDaItemDefinition
            {
                ItemId = "Tank-6.LL.CV",
                IsActive = true
            };
            var definition62 = new OpcDaItemDefinition
            {
                ItemId = "Tank-6.AT.CV",
                IsActive = true
            };
            var definition63 = new OpcDaItemDefinition
            {
                ItemId = "Tank-6.DOBS.CV",
                IsActive = true
            };
            var definition64 = new OpcDaItemDefinition
            {
                ItemId = "Tank-6.V_SP.CV",
                IsActive = true
            };
            var definition65 = new OpcDaItemDefinition
            {
                ItemId = "Tank-6.MASS.CV",
                IsActive = true
            };

            var definition71 = new OpcDaItemDefinition
            {
                ItemId = "Tank-7.LL.CV",
                IsActive = true
            };
            var definition72 = new OpcDaItemDefinition
            {
                ItemId = "Tank-7.AT.CV",
                IsActive = true
            };
            var definition73 = new OpcDaItemDefinition
            {
                ItemId = "Tank-7.DOBS.CV",
                IsActive = true
            };
            var definition74 = new OpcDaItemDefinition
            {
                ItemId = "Tank-7.V_SP.CV",
                IsActive = true
            };
            var definition75 = new OpcDaItemDefinition
            {
                ItemId = "Tank-7.MASS.CV",
                IsActive = true
            };

            var definition81 = new OpcDaItemDefinition
            {
                ItemId = "Tank-8.LL.CV",
                IsActive = true
            };
            var definition82 = new OpcDaItemDefinition
            {
                ItemId = "Tank-8.AT.CV",
                IsActive = true
            };
            var definition83 = new OpcDaItemDefinition
            {
                ItemId = "Tank-8.DOBS.CV",
                IsActive = true
            };
            var definition84 = new OpcDaItemDefinition
            {
                ItemId = "Tank-8.V_SP.CV",
                IsActive = true
            };
            var definition85 = new OpcDaItemDefinition
            {
                ItemId = "Tank-8.MASS.CV",
                IsActive = true
            };

            var definition91 = new OpcDaItemDefinition
            {
                ItemId = "Tank-9.LL.CV",
                IsActive = true
            };
            var definition92 = new OpcDaItemDefinition
            {
                ItemId = "Tank-9.AT.CV",
                IsActive = true
            };
            var definition93 = new OpcDaItemDefinition
            {
                ItemId = "Tank-9.DOBS.CV",
                IsActive = true
            };
            var definition94 = new OpcDaItemDefinition
            {
                ItemId = "Tank-9.V_SP.CV",
                IsActive = true
            };
            var definition95 = new OpcDaItemDefinition
            {
                ItemId = "Tank-9.MASS.CV",
                IsActive = true
            };


            var definition101 = new OpcDaItemDefinition
            {
                ItemId = "Tank-10.LL.CV",
                IsActive = true
            };
            var definition102 = new OpcDaItemDefinition
            {
                ItemId = "Tank-10.AT.CV",
                IsActive = true
            };
            var definition103 = new OpcDaItemDefinition
            {
                ItemId = "Tank-10.DOBS.CV",
                IsActive = true
            };
            var definition104 = new OpcDaItemDefinition
            {
                ItemId = "Tank-10.V_SP.CV",
                IsActive = true
            };
            var definition105 = new OpcDaItemDefinition
            {
                ItemId = "Tank-10.MASS.CV",
                IsActive = true
            };

            var definition111 = new OpcDaItemDefinition
            {
                ItemId = "Tank-11.LL.CV",
                IsActive = true
            };
            var definition112 = new OpcDaItemDefinition
            {
                ItemId = "Tank-11.AT.CV",
                IsActive = true
            };
            var definition113 = new OpcDaItemDefinition
            {
                ItemId = "Tank-11.DOBS.CV",
                IsActive = true
            };
            var definition114 = new OpcDaItemDefinition
            {
                ItemId = "Tank-11.V_SP.CV",
                IsActive = true
            };
            var definition115 = new OpcDaItemDefinition
            {
                ItemId = "Tank-11.MASS.CV",
                IsActive = true
            };

            var definition121 = new OpcDaItemDefinition
            {
                ItemId = "Tank-12.LL.CV",
                IsActive = true
            };
            var definition122 = new OpcDaItemDefinition
            {
                ItemId = "Tank-12.AT.CV",
                IsActive = true
            };
            var definition123 = new OpcDaItemDefinition
            {
                ItemId = "Tank-12.DOBS.CV",
                IsActive = true
            };
            var definition124 = new OpcDaItemDefinition
            {
                ItemId = "Tank-12.V_SP.CV",
                IsActive = true
            };
            var definition125 = new OpcDaItemDefinition
            {
                ItemId = "Tank-12.MASS.CV",
                IsActive = true
            };

            var definition131 = new OpcDaItemDefinition
            {
                ItemId = "Tank-13.LL.CV",
                IsActive = true
            };
            var definition132 = new OpcDaItemDefinition
            {
                ItemId = "Tank-13.AT.CV",
                IsActive = true
            };
            var definition133 = new OpcDaItemDefinition
            {
                ItemId = "Tank-13.DOBS.CV",
                IsActive = true
            };
            var definition134 = new OpcDaItemDefinition
            {
                ItemId = "Tank-13.V_SP.CV",
                IsActive = true
            };
            var definition135 = new OpcDaItemDefinition
            {
                ItemId = "Tank-13.MASS.CV",
                IsActive = true
            };

            var definition141 = new OpcDaItemDefinition
            {
                ItemId = "Tank-14.LL.CV",
                IsActive = true
            };
            var definition142 = new OpcDaItemDefinition
            {
                ItemId = "Tank-14.AT.CV",
                IsActive = true
            };
            var definition143 = new OpcDaItemDefinition
            {
                ItemId = "Tank-14.DOBS.CV",
                IsActive = true
            };
            var definition144 = new OpcDaItemDefinition
            {
                ItemId = "Tank-14.V_SP.CV",
                IsActive = true
            };
            var definition145 = new OpcDaItemDefinition
            {
                ItemId = "Tank-14.MASS.CV",
                IsActive = true
            };

            var definition151 = new OpcDaItemDefinition
            {
                ItemId = "Tank-15.LL.CV",
                IsActive = true
            };
            var definition152 = new OpcDaItemDefinition
            {
                ItemId = "Tank-15.AT.CV",
                IsActive = true
            };
            var definition153 = new OpcDaItemDefinition
            {
                ItemId = "Tank-15.DOBS.CV",
                IsActive = true
            };
            var definition154 = new OpcDaItemDefinition
            {
                ItemId = "Tank-15.V_SP.CV",
                IsActive = true
            };
            var definition155 = new OpcDaItemDefinition
            {
                ItemId = "Tank-15.MASS.CV",
                IsActive = true
            };

            var definition161 = new OpcDaItemDefinition
            {
                ItemId = "Tank-16.LL.CV",
                IsActive = true
            };
            var definition162 = new OpcDaItemDefinition
            {
                ItemId = "Tank-16.AT.CV",
                IsActive = true
            };
            var definition163 = new OpcDaItemDefinition
            {
                ItemId = "Tank-16.DOBS.CV",
                IsActive = true
            };
            var definition164 = new OpcDaItemDefinition
            {
                ItemId = "Tank-16.V_SP.CV",
                IsActive = true
            };
            var definition165 = new OpcDaItemDefinition
            {
                ItemId = "Tank-16.MASS.CV",
                IsActive = true
            };
            OpcDaItemDefinition[] definitions = {
                definition11, definition12, definition13, definition14, definition15,
                definition21, definition22, definition23, definition24, definition25,
                definition31, definition32, definition33, definition34, definition35,
                definition41, definition42, definition43, definition44, definition45,
                definition51, definition52, definition53, definition54, definition55,
                definition61, definition62, definition63, definition64, definition65,
                definition71, definition72, definition73, definition74, definition75,
                definition81, definition82, definition83, definition84, definition85,
                definition91, definition92, definition93, definition94, definition95,
                definition101, definition102, definition103, definition104, definition105,
                definition111, definition112, definition113, definition114, definition115,
                definition121, definition122, definition123, definition124, definition125,
                definition131, definition132, definition133, definition134, definition135,
                definition141, definition142, definition143, definition144, definition145,
                definition151, definition152, definition153, definition154, definition155,
                definition161, definition162, definition163, definition164, definition165
            };
            OpcDaItemResult[] results1 = group.AddItems(definitions);

            //// Handle adding results.
            //foreach (OpcDaItemResult result in results)
            //{
            //    if (result.Error.Failed)
            //        Console.WriteLine("Error adding items: {0}", result.Error);
            //}

            return group;
        }

    }
}
