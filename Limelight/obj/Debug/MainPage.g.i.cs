﻿#pragma checksum "c:\users\michelle\documents\visual studio 2013\Projects\Limelight\Limelight\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "922654B35249EDE93BF7216267834A18"
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


namespace Limelight {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox host_textbox;
        
        internal System.Windows.Controls.RadioButton _60fps_button;
        
        internal System.Windows.Controls.RadioButton _30fps_button;
        
        internal System.Windows.Controls.RadioButton _1080p_button;
        
        internal System.Windows.Controls.RadioButton _720p_button;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Limelight;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.host_textbox = ((System.Windows.Controls.TextBox)(this.FindName("host_textbox")));
            this._60fps_button = ((System.Windows.Controls.RadioButton)(this.FindName("_60fps_button")));
            this._30fps_button = ((System.Windows.Controls.RadioButton)(this.FindName("_30fps_button")));
            this._1080p_button = ((System.Windows.Controls.RadioButton)(this.FindName("_1080p_button")));
            this._720p_button = ((System.Windows.Controls.RadioButton)(this.FindName("_720p_button")));
        }
    }
}

