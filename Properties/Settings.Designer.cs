﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassroomScreenToolBox.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public string AutoStart {
            get {
                return ((string)(this["AutoStart"]));
            }
            set {
                this["AutoStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoIcon {
            get {
                return ((bool)(this["AutoIcon"]));
            }
            set {
                this["AutoIcon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red")]
        public global::System.Drawing.Color TimerColorRGB {
            get {
                return ((global::System.Drawing.Color)(this["TimerColorRGB"]));
            }
            set {
                this["TimerColorRGB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TimerWaveFile {
            get {
                return ((string)(this["TimerWaveFile"]));
            }
            set {
                this["TimerWaveFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TimerWave {
            get {
                return ((bool)(this["TimerWave"]));
            }
            set {
                this["TimerWave"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool StopWatchWave {
            get {
                return ((bool)(this["StopWatchWave"]));
            }
            set {
                this["StopWatchWave"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TimerColor {
            get {
                return ((bool)(this["TimerColor"]));
            }
            set {
                this["TimerColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoShutdown {
            get {
                return ((bool)(this["AutoShutdown"]));
            }
            set {
                this["AutoShutdown"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoShutdownMsg {
            get {
                return ((bool)(this["AutoShutdownMsg"]));
            }
            set {
                this["AutoShutdownMsg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string AutoShutdownMsgTime {
            get {
                return ((string)(this["AutoShutdownMsgTime"]));
            }
            set {
                this["AutoShutdownMsgTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string TimerWaveTime {
            get {
                return ((string)(this["TimerWaveTime"]));
            }
            set {
                this["TimerWaveTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <string>期中考试</string>
  <string>期末考试</string>
  <string>中考</string>
  <string>高考</string>
  <string>放假</string>
  <string>运动会</string>
  <string>自招考试</string>
  <string>毕业</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection DayMatterEventLib {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DayMatterEventLib"]));
            }
            set {
                this["DayMatterEventLib"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2023-06-26")]
        public global::System.DateTime DayMatterTime {
            get {
                return ((global::System.DateTime)(this["DayMatterTime"]));
            }
            set {
                this["DayMatterTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Saying {
            get {
                return ((string)(this["Saying"]));
            }
            set {
                this["Saying"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TimerColorTime {
            get {
                return ((string)(this["TimerColorTime"]));
            }
            set {
                this["TimerColorTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TimerRing {
            get {
                return ((bool)(this["TimerRing"]));
            }
            set {
                this["TimerRing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("每天")]
        public string AutoShutdownPinlv {
            get {
                return ((string)(this["AutoShutdownPinlv"]));
            }
            set {
                this["AutoShutdownPinlv"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring>1.wav</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection WaveFileList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["WaveFileList"]));
            }
            set {
                this["WaveFileList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DayMatterOpen {
            get {
                return ((bool)(this["DayMatterOpen"]));
            }
            set {
                this["DayMatterOpen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DayMatterEvent {
            get {
                return ((string)(this["DayMatterEvent"]));
            }
            set {
                this["DayMatterEvent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal AutoShutdownTimeHour {
            get {
                return ((decimal)(this["AutoShutdownTimeHour"]));
            }
            set {
                this["AutoShutdownTimeHour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal AutoShutdownTimeMinute {
            get {
                return ((decimal)(this["AutoShutdownTimeMinute"]));
            }
            set {
                this["AutoShutdownTimeMinute"] = value;
            }
        }
    }
}