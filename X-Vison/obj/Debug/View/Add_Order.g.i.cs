﻿#pragma checksum "..\..\..\View\Add_Order.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "812B9AA0A93B59B7AE76A20E077771AB4BB509E5"
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
    /// Add_Order
    /// </summary>
    public partial class Add_Order : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\View\Add_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock username_label;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\Add_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock chair_class;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\Add_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock chair;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\View\Add_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid products_grid;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\View\Add_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel bought_stack;
        
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
            System.Uri resourceLocater = new System.Uri("/Center_Maneger;component/view/add_order.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Add_Order.xaml"
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
            
            #line 7 "..\..\..\View\Add_Order.xaml"
            ((Center_Maneger.View.Add_Order)(target)).Loaded += new System.Windows.RoutedEventHandler(this.load_data);
            
            #line default
            #line hidden
            return;
            case 2:
            this.username_label = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.chair_class = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.chair = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.products_grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.bought_stack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            
            #line 104 "..\..\..\View\Add_Order.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.save_order);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

