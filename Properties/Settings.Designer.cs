﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lrt_Ilukste.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("11000")]
        public int Level_Max {
            get {
                return ((int)(this["Level_Max"]));
            }
            set {
                this["Level_Max"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Level_Min {
            get {
                return ((int)(this["Level_Min"]));
            }
            set {
                this["Level_Min"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-30")]
        public float AvgTemp_Min {
            get {
                return ((float)(this["AvgTemp_Min"]));
            }
            set {
                this["AvgTemp_Min"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        public float AvgTemp_Max {
            get {
                return ((float)(this["AvgTemp_Max"]));
            }
            set {
                this["AvgTemp_Max"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("820")]
        public float LabDensity20_Min {
            get {
                return ((float)(this["LabDensity20_Min"]));
            }
            set {
                this["LabDensity20_Min"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("861.9")]
        public float LabDensity20_Max {
            get {
                return ((float)(this["LabDensity20_Max"]));
            }
            set {
                this["LabDensity20_Max"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("820")]
        public float Density_Min {
            get {
                return ((float)(this["Density_Min"]));
            }
            set {
                this["Density_Min"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("861.9")]
        public float Density_Max {
            get {
                return ((float)(this["Density_Max"]));
            }
            set {
                this["Density_Max"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoSaabRead {
            get {
                return ((bool)(this["AutoSaabRead"]));
            }
            set {
                this["AutoSaabRead"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.133.213")]
        public string SaabOPCServerIP {
            get {
                return ((string)(this["SaabOPCServerIP"]));
            }
            set {
                this["SaabOPCServerIP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SaabTankRadar.TankServer.1")]
        public string SaabOPCServerName {
            get {
                return ((string)(this["SaabOPCServerName"]));
            }
            set {
                this["SaabOPCServerName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\Work\\Lrt\\Lrt_Ilukste\\Documents\\Report.dot")]
        public string DocumentPath {
            get {
                return ((string)(this["DocumentPath"]));
            }
            set {
                this["DocumentPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int SaabTimeInterval {
            get {
                return ((int)(this["SaabTimeInterval"]));
            }
            set {
                this["SaabTimeInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("55")]
        public int SaabTimeIntervalDB {
            get {
                return ((int)(this["SaabTimeIntervalDB"]));
            }
            set {
                this["SaabTimeIntervalDB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SaabDataSource {
            get {
                return ((bool)(this["SaabDataSource"]));
            }
            set {
                this["SaabDataSource"] = value;
            }
        }
    }
}