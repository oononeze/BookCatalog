﻿#pragma checksum "..\..\PrismAppShell.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F5FB8033EDE1B80BDA51B4FCBB6134FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Regions.Behaviors;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Ribbon;
using Shell;
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


namespace Shell {
    
    
    /// <summary>
    /// PrismAppShell
    /// </summary>
    public partial class PrismAppShell : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\PrismAppShell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\PrismAppShell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockPanel1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PrismAppShell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.Ribbon ribbon1;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\PrismAppShell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeView1;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\PrismAppShell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl1;
        
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
            System.Uri resourceLocater = new System.Uri("/Shell;component/prismappshell.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PrismAppShell.xaml"
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
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.dockPanel1 = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.ribbon1 = ((Microsoft.Windows.Controls.Ribbon.Ribbon)(target));
            return;
            case 4:
            this.treeView1 = ((System.Windows.Controls.TreeView)(target));
            return;
            case 5:
            this.tabControl1 = ((System.Windows.Controls.TabControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

