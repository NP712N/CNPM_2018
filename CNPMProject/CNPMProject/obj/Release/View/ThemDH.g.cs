﻿#pragma checksum "..\..\..\View\ThemDH.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6011F5853EF23E38EB83B5E0D9B81AE190240800"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CNPMProject;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace CNPMProject {
    
    
    /// <summary>
    /// ThemDH
    /// </summary>
    public partial class ThemDH : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\View\ThemDH.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_closewindow;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\View\ThemDH.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_madonhang;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\View\ThemDH.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_mamathang;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\View\ThemDH.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_soluong;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\View\ThemDH.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_add;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\View\ThemDH.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_update;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\View\ThemDH.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_delete;
        
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
            System.Uri resourceLocater = new System.Uri("/CNPMProject;component/view/themdh.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ThemDH.xaml"
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
            this.button_closewindow = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\View\ThemDH.xaml"
            this.button_closewindow.Click += new System.Windows.RoutedEventHandler(this.button_closewindow_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_madonhang = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_mamathang = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_soluong = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.button_add = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.button_update = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.button_delete = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

