﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Web.RazorSingleFileGenerator.Resources {
    using System;
    
    
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
    internal class SingleFileResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SingleFileResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Web.RazorSingleFileGenerator.Resources.SingleFileResources", typeof(SingleFileResources).Assembly);
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
        ///   Looks up a localized string similar to Unknown generator &quot;{0}&quot;. Type &quot;{0}&quot;Host could not be loaded..
        /// </summary>
        internal static string GeneratorError_UnknownGenerator {
            get {
                return ResourceManager.GetString("GeneratorError_UnknownGenerator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ////***********************************************************************************************************
        ///Could not precompile the input file contents. Ensure that a generator declaration exists in the cshtml file. 
        ///A generator declaration is the first line of your cshtml file and looks like this: 
        ///@* Generator: MvcHelper *@
        ///Valid host names: {0}
        ///************************************************************************************************************/.
        /// </summary>
        internal static string GeneratorFailureMessage {
            get {
                return ResourceManager.GetString("GeneratorFailureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The call to GetDefaultExtension() has failed due to the exception:.
        /// </summary>
        internal static string GetDefaultExtensionFailed {
            get {
                return ResourceManager.GetString("GetDefaultExtensionFailed", resourceCulture);
            }
        }
    }
}
