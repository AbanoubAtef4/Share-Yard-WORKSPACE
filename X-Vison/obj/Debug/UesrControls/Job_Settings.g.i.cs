﻿#pragma checksum "..\..\..\UesrControls\Job_Settings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8EAFAABD08226B5B5EB07C35F722AD669530BA19"
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


namespace Center_Maneger.UesrControls {
    
    
    /// <summary>
    /// Job_Settings
    /// </summary>
    public partial class Job_Settings : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\UesrControls\Job_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name_of_job_input;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\UesrControls\Job_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid data_grid;
        
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
            System.Uri resourceLocater = new System.Uri("/Center_Maneger;component/uesrcontrols/job_settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UesrControls\Job_Settings.xaml"
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
            this.name_of_job_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 31 "..\..\..\UesrControls\Job_Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.remove_job_record);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 37 "..\..\..\UesrControls\Job_Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.save_job_record);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 43 "..\..\..\UesrControls\Job_Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.new_job_record);
            
            #line default
            #line hidden
            return;
            case 5:
            this.data_grid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 52 "..\..\..\UesrControls\Job_Settings.xaml"
            this.data_grid.Sorting += new System.Windows.Controls.DataGridSortingEventHandler(this.grid_sort);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\UesrControls\Job_Settings.xaml"
            this.data_grid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DataGrid_LoadingRow);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\UesrControls\Job_Settings.xaml"
            this.data_grid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.change_selected_record);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\UesrControls\Job_Settings.xaml"
            this.data_grid.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.change_header_name);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

