﻿#pragma checksum "..\..\FTimKiemCongViec.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "85E1C538AE689E70CC7B71539A760700C8E7690B893D200247BE9ACEC149449F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
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
using Test;


namespace Test {
    
    
    /// <summary>
    /// FTimKiemCongViec
    /// </summary>
    public partial class FTimKiemCongViec : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\FTimKiemCongViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTimkiem;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\FTimKiemCongViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTimkiem;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\FTimKiemCongViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoc;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\FTimKiemCongViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ltvCongviec;
        
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
            System.Uri resourceLocater = new System.Uri("/Test;component/ftimkiemcongviec.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FTimKiemCongViec.xaml"
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
            
            #line 13 "..\..\FTimKiemCongViec.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtTimkiem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnTimkiem = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\FTimKiemCongViec.xaml"
            this.btnTimkiem.Click += new System.Windows.RoutedEventHandler(this.btnTimKiem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnLoc = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\FTimKiemCongViec.xaml"
            this.btnLoc.Click += new System.Windows.RoutedEventHandler(this.btnLoc_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ltvCongviec = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            
            #line 47 "..\..\FTimKiemCongViec.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

