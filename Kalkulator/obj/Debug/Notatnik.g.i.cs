﻿#pragma checksum "..\..\Notatnik.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "131894982695EC3770899F5C4630BA57"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Kalkulator;
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


namespace Kalkulator {
    
    
    /// <summary>
    /// Notatnik
    /// </summary>
    public partial class Notatnik : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Notatnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLiczWGore;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Notatnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCzas;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Notatnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPokazCzas;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Notatnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLiczWDol;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Notatnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLiczWGore;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Notatnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLiczWDol;
        
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
            System.Uri resourceLocater = new System.Uri("/Kalkulator;component/notatnik.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Notatnik.xaml"
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
            this.btnLiczWGore = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Notatnik.xaml"
            this.btnLiczWGore.Click += new System.Windows.RoutedEventHandler(this.btnLiczWGore_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblCzas = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnPokazCzas = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Notatnik.xaml"
            this.btnPokazCzas.Click += new System.Windows.RoutedEventHandler(this.btnPokazCzas_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnLiczWDol = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Notatnik.xaml"
            this.btnLiczWDol.Click += new System.Windows.RoutedEventHandler(this.btnLiczWDol_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblLiczWGore = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtLiczWDol = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

