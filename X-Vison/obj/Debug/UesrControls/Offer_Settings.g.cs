﻿#pragma checksum "..\..\..\UesrControls\Offer_Settings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "71E284337FAE841A6F47864910143F9D5FB73A3F2A9FF4FCB91643908B4E9E6B"
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
    /// Offer_Settings
    /// </summary>
    public partial class Offer_Settings : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\UesrControls\Offer_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox offer_name_input;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UesrControls\Offer_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox offer_duration_input;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UesrControls\Offer_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox offer_cost_input;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\UesrControls\Offer_Settings.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Center_Maneger;component/uesrcontrols/offer_settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UesrControls\Offer_Settings.xaml"
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
            this.offer_name_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.offer_duration_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.offer_cost_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 43 "..\..\..\UesrControls\Offer_Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.remove_offer_record);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 49 "..\..\..\UesrControls\Offer_Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.save_offer_record);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 55 "..\..\..\UesrControls\Offer_Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.new_offer_record);
            
            #line default
            #line hidden
            return;
            case 7:
            this.data_grid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 64 "..\..\..\UesrControls\Offer_Settings.xaml"
            this.data_grid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.change_selected_record);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\UesrControls\Offer_Settings.xaml"
            this.data_grid.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.change_header_name);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

