﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CardGame.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CardGame.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to CARD_2:
        ///┌───────┐
        ///│2      │
        ///│♦      │
        ///│       │
        ///│   ♦   │
        ///│       │
        ///│       │
        ///│   ♦   │
        ///│       │
        ///│      ♦│
        ///│      2│
        ///└───────┘
        ///CARD_3:
        ///┌───────┐
        ///│3      │
        ///│♦      │
        ///│       │
        ///│   ♦   │
        ///│       │
        ///│   ♦   │
        ///│       │
        ///│   ♦   │
        ///│      ♦│
        ///│      3│
        ///└───────┘
        ///CARD_4:
        ///┌───────┐
        ///│4      │
        ///│♦      │
        ///│       │
        ///│  ♦ ♦  │
        ///│       │
        ///│       │
        ///│  ♦ ♦  │
        ///│       │
        ///│      ♦│
        ///│      4│
        ///└───────┘
        ///CARD_5:
        ///┌───────┐
        ///│5      │
        ///│♦      │
        ///│       │
        ///│  ♦ ♦  │
        ///│   ♦   │
        ///│  ♦ ♦  │
        ///│   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string cardFaces {
            get {
                return ResourceManager.GetString("cardFaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ┌───────────────────────────────────────────────────────────────────┐
        ///│                     Welcome to Basic Card Game                    │
        ///│                                                                   │
        ///│                                                                   │
        ///│          The Rules:                                               │
        ///│                                                                   │
        ///│          Have a card with a higher value than your opponent.      │
        ///│          If t [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string splashScreen {
            get {
                return ResourceManager.GetString("splashScreen", resourceCulture);
            }
        }
    }
}
