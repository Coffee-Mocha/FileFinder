﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileFinder {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files\\Microsoft Office\\root\\Office16\\EXCEL.EXE")]
        public string ExternalAppPath {
            get {
                return ((string)(this["ExternalAppPath"]));
            }
            set {
                this["ExternalAppPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\pcfs001\\SharedHome\\カスタムクラウド_案件用\\課金・請求関連\\請求明細+雛形")]
        public string FindBase {
            get {
                return ((string)(this["FindBase"]));
            }
            set {
                this["FindBase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CmdSwitchReadOnly {
            get {
                return ((bool)(this["CmdSwitchReadOnly"]));
            }
            set {
                this["CmdSwitchReadOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CmdSwitchInstanceExecute {
            get {
                return ((bool)(this["CmdSwitchInstanceExecute"]));
            }
            set {
                this["CmdSwitchInstanceExecute"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/r")]
        public string CmdSwitchReadOnlyText {
            get {
                return ((string)(this["CmdSwitchReadOnlyText"]));
            }
            set {
                this["CmdSwitchReadOnlyText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/x")]
        public string CmdSwitchInstanceExecuteText {
            get {
                return ((string)(this["CmdSwitchInstanceExecuteText"]));
            }
            set {
                this["CmdSwitchInstanceExecuteText"] = value;
            }
        }
    }
}
