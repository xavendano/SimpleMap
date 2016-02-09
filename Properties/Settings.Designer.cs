﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgramMain.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Путь к кешу с картой на диске
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Путь к кешу с картой на диске")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SimpleMap\\")]
        public string MapPath {
            get {
                return ((string)(this["MapPath"]));
            }
            set {
                this["MapPath"] = value;
            }
        }
        
        /// <summary>
        /// Начальная широта карты(центральная точка)
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Начальная широта карты(центральная точка)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("55.75676")]
        public double StartLatitude {
            get {
                return ((double)(this["StartLatitude"]));
            }
            set {
                this["StartLatitude"] = value;
            }
        }
        
        /// <summary>
        /// Начальная долгота карты(центральная точка)
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Начальная долгота карты(центральная точка)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("37.61894")]
        public double StartLongitude {
            get {
                return ((double)(this["StartLongitude"]));
            }
            set {
                this["StartLongitude"] = value;
            }
        }
        
        /// <summary>
        /// Режим увеличения карты по умолчанию
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Режим увеличения карты по умолчанию")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public int StartZoomLevel {
            get {
                return ((int)(this["StartZoomLevel"]));
            }
            set {
                this["StartZoomLevel"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://mt1.google.com/vt/lyrs=m@146&hl=en&x={0}&y={1}&z={2}")]
        public string GoogleUrl {
            get {
                return ((string)(this["GoogleUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.3.8.5")]
        public string AppVersion {
            get {
                return ((string)(this["AppVersion"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("17")]
        public int MaxZoomLevel {
            get {
                return ((int)(this["MaxZoomLevel"]));
            }
            set {
                this["MaxZoomLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int MinZoomLevel {
            get {
                return ((int)(this["MinZoomLevel"]));
            }
            set {
                this["MinZoomLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("37.24468")]
        public double LeftMapBound {
            get {
                return ((double)(this["LeftMapBound"]));
            }
            set {
                this["LeftMapBound"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("55.9469")]
        public double TopMapBound {
            get {
                return ((double)(this["TopMapBound"]));
            }
            set {
                this["TopMapBound"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("38.00891")]
        public double RightMapBound {
            get {
                return ((double)(this["RightMapBound"]));
            }
            set {
                this["RightMapBound"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("55.5601")]
        public double BottomMapBound {
            get {
                return ((double)(this["BottomMapBound"]));
            }
            set {
                this["BottomMapBound"] = value;
            }
        }
    }
}