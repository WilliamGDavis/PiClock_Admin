﻿#pragma checksum "..\..\UserManagement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "53C52BC8E198F25610BDCB5B2565807C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PiClock_Admin;
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


namespace PiClock_Admin {
    
    
    /// <summary>
    /// UserManagement
    /// </summary>
    public partial class UserManagement : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\UserManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\UserManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_AddUser;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\UserManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_EditUser;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\UserManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ManagePunches;
        
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
            System.Uri resourceLocater = new System.Uri("/PiClock_Admin;component/usermanagement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserManagement.xaml"
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
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.button_AddUser = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\UserManagement.xaml"
            this.button_AddUser.Click += new System.Windows.RoutedEventHandler(this.button_AddUser_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button_EditUser = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\UserManagement.xaml"
            this.button_EditUser.Click += new System.Windows.RoutedEventHandler(this.button_EditUser_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_ManagePunches = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\UserManagement.xaml"
            this.button_ManagePunches.Click += new System.Windows.RoutedEventHandler(this.button_EditUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
