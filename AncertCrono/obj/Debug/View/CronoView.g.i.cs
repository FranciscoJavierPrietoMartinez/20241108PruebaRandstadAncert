﻿#pragma checksum "..\..\..\View\CronoView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E7F257A38035224F988A826015F4F7C275F24CE96E2CF1706815C9DE7280E2B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AncertCrono;
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


namespace AncertCrono {
    
    
    /// <summary>
    /// CronoView
    /// </summary>
    public partial class CronoView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\CronoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCrono;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\CronoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCronoInicio;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\CronoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCronoPausa;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\CronoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCronoReset;
        
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
            System.Uri resourceLocater = new System.Uri("/AncertCrono;component/view/cronoview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CronoView.xaml"
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
            this.lblCrono = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnCronoInicio = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\View\CronoView.xaml"
            this.btnCronoInicio.Click += new System.Windows.RoutedEventHandler(this.btnCronoInicio_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCronoPausa = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\View\CronoView.xaml"
            this.btnCronoPausa.Click += new System.Windows.RoutedEventHandler(this.btnCronoPausa_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCronoReset = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\View\CronoView.xaml"
            this.btnCronoReset.Click += new System.Windows.RoutedEventHandler(this.btnCronoReset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
