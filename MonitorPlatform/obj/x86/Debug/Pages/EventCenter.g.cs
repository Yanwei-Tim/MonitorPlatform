﻿#pragma checksum "..\..\..\..\Pages\EventCenter.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "20434EF36DCE1929D475B370523D6551"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.239
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using De.TorstenMandelkow.MetroChart;
using DevExpress.Core;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.LookUp;
using DevExpress.Xpf.Grid.Themes;
using DevExpress.Xpf.Grid.TreeList;
using MonitorPlatform.Convert;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MonitorPlatform.Pages {
    
    
    /// <summary>
    /// EventCenter
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class EventCenter : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\Pages\EventCenter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox status;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Pages\EventCenter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox lines;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Pages\EventCenter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox type;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Pages\EventCenter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox grade;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\Pages\EventCenter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker1;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\Pages\EventCenter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal De.TorstenMandelkow.MetroChart.ChartSeries lineEventChart;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Pages\EventCenter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Grid.GridControl gridEvent;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MonitorPlatform;component/pages/eventcenter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\EventCenter.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.status = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\..\..\Pages\EventCenter.xaml"
            this.status.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.datePicker1_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lines = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\..\..\Pages\EventCenter.xaml"
            this.lines.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.datePicker1_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.type = ((System.Windows.Controls.ComboBox)(target));
            
            #line 68 "..\..\..\..\Pages\EventCenter.xaml"
            this.type.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.datePicker1_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.grade = ((System.Windows.Controls.ComboBox)(target));
            
            #line 81 "..\..\..\..\Pages\EventCenter.xaml"
            this.grade.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.datePicker1_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.datePicker1 = ((System.Windows.Controls.DatePicker)(target));
            
            #line 95 "..\..\..\..\Pages\EventCenter.xaml"
            this.datePicker1.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.datePicker1_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lineEventChart = ((De.TorstenMandelkow.MetroChart.ChartSeries)(target));
            return;
            case 7:
            this.gridEvent = ((DevExpress.Xpf.Grid.GridControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

