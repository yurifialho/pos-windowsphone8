﻿#pragma checksum "C:\Users\posgrad\Documents\Visual Studio 2013\Projects\Aula04\Controllers\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BADF3165A2042127D99C2FFA2760CB4D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Controllers {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Shapes.Rectangle Rectangle;
        
        internal System.Windows.Controls.Slider Red;
        
        internal System.Windows.Controls.TextBlock Red_Label;
        
        internal System.Windows.Controls.Slider Green;
        
        internal System.Windows.Controls.TextBlock Green_Label;
        
        internal System.Windows.Controls.Slider Blue;
        
        internal System.Windows.Controls.TextBlock Blue_Label;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Controllers;component/MainPage.xaml", System.UriKind.Relative));
            this.Rectangle = ((System.Windows.Shapes.Rectangle)(this.FindName("Rectangle")));
            this.Red = ((System.Windows.Controls.Slider)(this.FindName("Red")));
            this.Red_Label = ((System.Windows.Controls.TextBlock)(this.FindName("Red_Label")));
            this.Green = ((System.Windows.Controls.Slider)(this.FindName("Green")));
            this.Green_Label = ((System.Windows.Controls.TextBlock)(this.FindName("Green_Label")));
            this.Blue = ((System.Windows.Controls.Slider)(this.FindName("Blue")));
            this.Blue_Label = ((System.Windows.Controls.TextBlock)(this.FindName("Blue_Label")));
        }
    }
}

