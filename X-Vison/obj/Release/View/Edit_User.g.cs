﻿#pragma checksum "..\..\..\View\Edit_User.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ABD9B60840A60E3278B7F8F4F03B3D16C3A1EF21"
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


namespace Center_Maneger.View {
    
    
    /// <summary>
    /// Edit_User
    /// </summary>
    public partial class Edit_User : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\View\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phoneTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FacultyComboBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox JobComboBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox levelTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Center_Maneger;component/view/edit_user.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Edit_User.xaml"
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
            
            #line 5 "..\..\..\View\Edit_User.xaml"
            ((Center_Maneger.View.Edit_User)(target)).Loaded += new System.Windows.RoutedEventHandler(this.load_data);
            
            #line default
            #line hidden
            return;
            case 2:
            this.userNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.phoneTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.FacultyComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.JobComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.levelTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 35 "..\..\..\View\Edit_User.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.edit_user);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

