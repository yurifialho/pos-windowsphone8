﻿#pragma checksum "C:\Users\posgrad\Documents\Visual Studio 2013\Projects\Aula04\Pivot\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "47A9E92A600E6475DE2FF73324D73E55"
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


namespace ExemploContatos {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.Pivot pivot;
        
        internal System.Windows.Controls.ListBox lstContatos;
        
        internal System.Windows.Controls.Image imgFoto;
        
        internal System.Windows.Controls.TextBlock txtNome;
        
        internal System.Windows.Controls.Button btnDetalhes;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Pivot;component/MainPage.xaml", System.UriKind.Relative));
            this.pivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("pivot")));
            this.lstContatos = ((System.Windows.Controls.ListBox)(this.FindName("lstContatos")));
            this.imgFoto = ((System.Windows.Controls.Image)(this.FindName("imgFoto")));
            this.txtNome = ((System.Windows.Controls.TextBlock)(this.FindName("txtNome")));
            this.btnDetalhes = ((System.Windows.Controls.Button)(this.FindName("btnDetalhes")));
        }
    }
}

