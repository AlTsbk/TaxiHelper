﻿#pragma checksum "..\..\DeleteUser.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A2CD5BCEB329D8CBB61530A7781459CB1325BBC0"
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
    /// DeleteUser
    /// </summary>
    public partial class DeleteUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AutorizeName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path Pt;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserRow;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button yesBt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button noBt;
        
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
            System.Uri resourceLocater = new System.Uri("/courseProject;component/deleteuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DeleteUser.xaml"
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
            this.AutorizeName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            
            #line 23 "..\..\DeleteUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Pt = ((System.Windows.Shapes.Path)(target));
            return;
            case 4:
            this.UserRow = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.yesBt = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\DeleteUser.xaml"
            this.yesBt.Click += new System.Windows.RoutedEventHandler(this.YesBt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.noBt = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\DeleteUser.xaml"
            this.noBt.Click += new System.Windows.RoutedEventHandler(this.NoBt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

