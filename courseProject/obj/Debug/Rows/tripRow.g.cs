﻿#pragma checksum "..\..\..\Rows\tripRow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F4CF346ACE60CE13F6717ED84CC08E34A44F1A163D7AA03895AAD3B27986868A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using courseProject;


namespace courseProject {
    
    
    /// <summary>
    /// tripRow
    /// </summary>
    public partial class tripRow : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Rows\tripRow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image TripState;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Rows\tripRow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TripsNumber;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Rows\tripRow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock From;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Rows\tripRow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Destination;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Rows\tripRow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Driver;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Rows\tripRow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Date;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Rows\tripRow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CompleteButtons;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Rows\tripRow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CompleteBt;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Rows\tripRow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBt;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Rows\tripRow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InfoBt;
        
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
            System.Uri resourceLocater = new System.Uri("/courseProject;component/rows/triprow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Rows\tripRow.xaml"
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
            this.TripState = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.TripsNumber = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.From = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Destination = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Driver = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Date = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.CompleteButtons = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.CompleteBt = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Rows\tripRow.xaml"
            this.CompleteBt.Click += new System.Windows.RoutedEventHandler(this.CompleteBt_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DeleteBt = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Rows\tripRow.xaml"
            this.DeleteBt.Click += new System.Windows.RoutedEventHandler(this.СanceledBt_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.InfoBt = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Rows\tripRow.xaml"
            this.InfoBt.Click += new System.Windows.RoutedEventHandler(this.InfoBt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
