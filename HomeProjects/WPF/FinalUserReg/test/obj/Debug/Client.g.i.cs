﻿#pragma checksum "..\..\Client.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "808FF5DB84E4388C8F709F70FF8F0D128650FD1201E9D1AFB9AB0B8E924ABF75"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using shipmentregistrator;


namespace shipmentregistrator {
    
    
    /// <summary>
    /// Client
    /// </summary>
    public partial class Client : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NameInputButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label InfoLabel;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Shipment;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DDelcomp;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox License;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timeLabel;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button regshipments;
        
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
            System.Uri resourceLocater = new System.Uri("/Shipment Registrator;component/client.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Client.xaml"
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
            this.NameInputButton = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\Client.xaml"
            this.NameInputButton.Click += new System.Windows.RoutedEventHandler(this.NameInputButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.InfoLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Shipment = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DDelcomp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.License = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 126 "..\..\Client.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.timeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.regshipments = ((System.Windows.Controls.Button)(target));
            
            #line 148 "..\..\Client.xaml"
            this.regshipments.Click += new System.Windows.RoutedEventHandler(this.regshipments_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 172 "..\..\Client.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.testing);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 184 "..\..\Client.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.testing);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 196 "..\..\Client.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.testing);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
