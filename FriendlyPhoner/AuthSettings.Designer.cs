﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FriendlyPhoner {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
    internal sealed partial class AuthSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static AuthSettings defaultInstance = ((AuthSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AuthSettings())));
        
        public static AuthSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AccountSID {
            get {
                return ((string)(this["AccountSID"]));
            }
            set {
                this["AccountSID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AuthToken {
            get {
                return ((string)(this["AuthToken"]));
            }
            set {
                this["AuthToken"] = value;
            }
        }
    }
}
