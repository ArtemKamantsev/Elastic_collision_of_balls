﻿#pragma checksum "..\..\wSettings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D2D6368E7929B0B57EF7D08D59781139"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Modeling;
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


namespace Modeling {
    
    
    /// <summary>
    /// wSettings
    /// </summary>
    public partial class wSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\wSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_Path;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\wSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ChangePath;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\wSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_MinTime;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\wSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_MaxFrames;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\wSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_MinScale;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\wSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_ScrollStep;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\wSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_TranslateFields;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\wSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_AverageSpeedRatio;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\wSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Back;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\wSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Reset;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\wSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Apply;
        
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
            System.Uri resourceLocater = new System.Uri("/Modeling;component/wsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\wSettings.xaml"
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
            
            #line 8 "..\..\wSettings.xaml"
            ((Modeling.wSettings)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lb_Path = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btn_ChangePath = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\wSettings.xaml"
            this.btn_ChangePath.Click += new System.Windows.RoutedEventHandler(this.btn_ChangePath_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tb_MinTime = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\wSettings.xaml"
            this.tb_MinTime.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_MinTime_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tb_MaxFrames = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\wSettings.xaml"
            this.tb_MaxFrames.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_MaxFrames_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tb_MinScale = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\wSettings.xaml"
            this.tb_MinScale.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_MinScale_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tb_ScrollStep = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\wSettings.xaml"
            this.tb_ScrollStep.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_ScrollStep_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tb_TranslateFields = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\wSettings.xaml"
            this.tb_TranslateFields.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_TranslateFields_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tb_AverageSpeedRatio = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\wSettings.xaml"
            this.tb_AverageSpeedRatio.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_AverageSpeedRatio_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_Back = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\wSettings.xaml"
            this.btn_Back.Click += new System.Windows.RoutedEventHandler(this.btn_Back_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_Reset = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\wSettings.xaml"
            this.btn_Reset.Click += new System.Windows.RoutedEventHandler(this.btn_Reset_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btn_Apply = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\wSettings.xaml"
            this.btn_Apply.Click += new System.Windows.RoutedEventHandler(this.btn_Apply_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
