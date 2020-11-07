﻿#pragma checksum "..\..\PlayerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C9465FE0BC19788CD151F8E0D99105C2ABD4A46766806C9AA4554648818E8E00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MonoRead;
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


namespace MonoRead {
    
    
    /// <summary>
    /// PlayerWindow
    /// </summary>
    public partial class PlayerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\PlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DisplayLabel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\PlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\PlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimiseButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\PlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider PositionSlider;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\PlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider RateSlider;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RateLabel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\PlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PlayPause;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/playerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PlayerWindow.xaml"
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
            
            #line 9 "..\..\PlayerWindow.xaml"
            ((MonoRead.PlayerWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DisplayLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            
            #line 12 "..\..\PlayerWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\PlayerWindow.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MinimiseButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\PlayerWindow.xaml"
            this.MinimiseButton.Click += new System.Windows.RoutedEventHandler(this.MinimiseButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PositionSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 15 "..\..\PlayerWindow.xaml"
            this.PositionSlider.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PositionSlider_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\PlayerWindow.xaml"
            this.PositionSlider.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.PositionSlider_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 15 "..\..\PlayerWindow.xaml"
            this.PositionSlider.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.PositionSlider_GotMouseCapture);
            
            #line default
            #line hidden
            
            #line 15 "..\..\PlayerWindow.xaml"
            this.PositionSlider.LostMouseCapture += new System.Windows.Input.MouseEventHandler(this.PositionSlider_LostMouseCapture);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RateSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 16 "..\..\PlayerWindow.xaml"
            this.RateSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.RateSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RateLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.PlayPause = ((System.Windows.Controls.Image)(target));
            
            #line 18 "..\..\PlayerWindow.xaml"
            this.PlayPause.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PlayPause_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

