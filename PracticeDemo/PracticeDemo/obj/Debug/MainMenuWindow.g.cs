﻿#pragma checksum "..\..\MainMenuWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC36AB514D5F8AE1A9674D02D12D447B8C05B1EC647901598D3F8EF43C67A359"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PracticeDemo;
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


namespace PracticeDemo {
    
    
    /// <summary>
    /// MainMenuWindow
    /// </summary>
    public partial class MainMenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InfoTxtBlock;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EmployeeListButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProductionAreaListButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WordEquipmentGettingButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EquipmentAddingButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EquipmentEditingButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EquipmentDeletingButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PracticeDemo;component/mainmenuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainMenuWindow.xaml"
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
            this.InfoTxtBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.EmployeeListButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\MainMenuWindow.xaml"
            this.EmployeeListButton.Click += new System.Windows.RoutedEventHandler(this.EmployeeListButton_Click);
            
            #line default
            #line hidden
            
            #line 30 "..\..\MainMenuWindow.xaml"
            this.EmployeeListButton.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.EmployeeListButton_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ProductionAreaListButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MainMenuWindow.xaml"
            this.ProductionAreaListButton.Click += new System.Windows.RoutedEventHandler(this.ProductionAreaListButton_Click);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MainMenuWindow.xaml"
            this.ProductionAreaListButton.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.ProductionAreaListButton_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 4:
            this.WordEquipmentGettingButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\MainMenuWindow.xaml"
            this.WordEquipmentGettingButton.Click += new System.Windows.RoutedEventHandler(this.WordEquipmentGettingButton_Click);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainMenuWindow.xaml"
            this.WordEquipmentGettingButton.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.WordEquipmentGettingButton_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EquipmentAddingButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\MainMenuWindow.xaml"
            this.EquipmentAddingButton.Click += new System.Windows.RoutedEventHandler(this.EquipmentAddingButton_Click);
            
            #line default
            #line hidden
            
            #line 33 "..\..\MainMenuWindow.xaml"
            this.EquipmentAddingButton.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.EquipmentAddingButton_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EquipmentEditingButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\MainMenuWindow.xaml"
            this.EquipmentEditingButton.Click += new System.Windows.RoutedEventHandler(this.EquipmentEditingButton_Click);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainMenuWindow.xaml"
            this.EquipmentEditingButton.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.EquipmentEditingButton_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EquipmentDeletingButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\MainMenuWindow.xaml"
            this.EquipmentDeletingButton.Click += new System.Windows.RoutedEventHandler(this.EquipmentDeletingButton_Click);
            
            #line default
            #line hidden
            
            #line 35 "..\..\MainMenuWindow.xaml"
            this.EquipmentDeletingButton.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.EquipmentDeletingButton_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
