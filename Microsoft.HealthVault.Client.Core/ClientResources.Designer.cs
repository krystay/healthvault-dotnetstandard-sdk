﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.HealthVault.Client.Core {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ClientResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ClientResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.HealthVault.Client.Core.ClientResources", typeof(ClientResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you see this error then you need to reference the Microsoft.HealthVault.Client NuGet package from your client projects as well as your portable ones..
        /// </summary>
        internal static string BaitWithoutSwitchError {
            get {
                return ResourceManager.GetString("BaitWithoutSwitchError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete.
        /// </summary>
        internal static string FileAccessActionDelete {
            get {
                return ResourceManager.GetString("FileAccessActionDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to read.
        /// </summary>
        internal static string FileAccessActionRead {
            get {
                return ResourceManager.GetString("FileAccessActionRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to write.
        /// </summary>
        internal static string FileAccessActionWrite {
            get {
                return ResourceManager.GetString("FileAccessActionWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while attempting to {0} file: {1}.
        /// </summary>
        internal static string FileAccessErrorMessage {
            get {
                return ResourceManager.GetString("FileAccessErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login Failed.
        /// </summary>
        internal static string LoginError {
            get {
                return ResourceManager.GetString("LoginError", resourceCulture);
            }
        }
    }
}
