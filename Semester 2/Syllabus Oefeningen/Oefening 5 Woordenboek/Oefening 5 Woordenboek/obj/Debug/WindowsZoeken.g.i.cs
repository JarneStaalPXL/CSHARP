﻿#pragma checksum "..\..\WindowsZoeken.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "05A99BD968DE4620D3400A8BEB43BCF91FC70D17184939A0F9DE561F48B769F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Oefening_5_Woordenboek;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Oefening_5_Woordenboek {
    
    
    /// <summary>
    /// WindowsZoeken
    /// </summary>
    public partial class WindowsZoeken : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\WindowsZoeken.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MnuVorigVenster;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WindowsZoeken.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MnuAfsluiten;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\WindowsZoeken.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtEngels;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\WindowsZoeken.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNederlands;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WindowsZoeken.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnZoeken;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\WindowsZoeken.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnControle;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Oefening 5 Woordenboek;component/windowszoeken.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowsZoeken.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MnuVorigVenster = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\WindowsZoeken.xaml"
            this.MnuVorigVenster.Click += new System.Windows.RoutedEventHandler(this.MnuVorigvenster_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MnuAfsluiten = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\WindowsZoeken.xaml"
            this.MnuAfsluiten.Click += new System.Windows.RoutedEventHandler(this.MnuAfsluiten_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtEngels = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtNederlands = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BtnZoeken = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\WindowsZoeken.xaml"
            this.BtnZoeken.Click += new System.Windows.RoutedEventHandler(this.BtnZoeken_Click_);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnControle = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\WindowsZoeken.xaml"
            this.BtnControle.Click += new System.Windows.RoutedEventHandler(this.BtnControle_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
