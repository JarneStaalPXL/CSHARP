﻿#pragma checksum "..\..\..\..\..\Oefeningenbundel\Oefening 2 StringZoekenBestand\StringZoekenBestand.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F431CF5DC0D130233218A0E068708E6BA997D3D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ExamenOefenen.Oefeningenbundel.Oefening_2_StringZoekenBestand;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ExamenOefenen.Oefeningenbundel.Oefening_2_StringZoekenBestand {
    
    
    /// <summary>
    /// StringZoekenBestand
    /// </summary>
    public partial class StringZoekenBestand : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\Oefeningenbundel\Oefening 2 StringZoekenBestand\StringZoekenBestand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pathBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Oefeningenbundel\Oefening 2 StringZoekenBestand\StringZoekenBestand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchedString;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Oefeningenbundel\Oefening 2 StringZoekenBestand\StringZoekenBestand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtResultaat;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ExamenOefenen;component/oefeningenbundel/oefening%202%20stringzoekenbestand/stri" +
                    "ngzoekenbestand.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Oefeningenbundel\Oefening 2 StringZoekenBestand\StringZoekenBestand.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.pathBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.searchedString = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\..\..\Oefeningenbundel\Oefening 2 StringZoekenBestand\StringZoekenBestand.xaml"
            this.searchedString.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchedString_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtResultaat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 28 "..\..\..\..\..\Oefeningenbundel\Oefening 2 StringZoekenBestand\StringZoekenBestand.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Bladeren_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 29 "..\..\..\..\..\Oefeningenbundel\Oefening 2 StringZoekenBestand\StringZoekenBestand.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Zoeken_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
