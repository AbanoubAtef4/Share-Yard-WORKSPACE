﻿#pragma checksum "..\..\..\UesrControls\Prices_Settings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73955D8285138209AC590E5B69BC5E91D328B8CF"
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
    /// Prices_Settings
    /// </summary>
    public partial class Prices_Settings : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\UesrControls\Prices_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox start_date_price_input;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UesrControls\Prices_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox end_date_price_input;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UesrControls\Prices_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cost_price_input;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\UesrControls\Prices_Settings.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Center_Maneger;component/uesrcontrols/prices_settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UesrControls\Prices_Settings.xaml"
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
            this.start_date_price_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.end_date_price_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cost_price_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 43 "..\..\..\UesrControls\Prices_Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.remove_price_record);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 49 "..\..\..\UesrControls\Prices_Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.save_price_record);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 55 "..\..\..\UesrControls\Prices_Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.new_price_record);
            
            #line default
            #line hidden
            return;
            case 7:
            this.data_grid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 64 "..\..\..\UesrControls\Prices_Settings.xaml"
            this.data_grid.Sorting += new System.Windows.Controls.DataGridSortingEventHandler(this.grid_sort);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\UesrControls\Prices_Settings.xaml"
            this.data_grid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DataGrid_LoadingRow);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\UesrControls\Prices_Settings.xaml"
            this.data_grid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.change_selected_record);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\UesrControls\Prices_Settings.xaml"
            this.data_grid.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.change_header_name);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

