﻿#pragma checksum "..\..\..\MaHoa.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2DCE83E2D67AD3EB5B1F195BDB768CDF21698724"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MaHoa
    /// </summary>
    public partial class MaHoa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\MaHoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image AnhGoc;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MaHoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ThongDiep;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MaHoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ThongDiepMaHoa;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MaHoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Loi;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MaHoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ThongDiepSauGiaiMa;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MaHoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Khoa;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\MaHoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbAnhGiauTin;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MaHoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image AnhGiauTin;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AES_GiauTinAnh;component/mahoa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MaHoa.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AnhGoc = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            
            #line 13 "..\..\..\MaHoa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ChonAnh);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ThongDiep = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 16 "..\..\..\MaHoa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btMaHoa);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ThongDiepMaHoa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 18 "..\..\..\MaHoa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GiauTin);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Loi = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            
            #line 20 "..\..\..\MaHoa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LayThongDiep);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 21 "..\..\..\MaHoa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btGiaiMa);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ThongDiepSauGiaiMa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 23 "..\..\..\MaHoa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LamMoi);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Khoa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 26 "..\..\..\MaHoa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btLayTxt);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 27 "..\..\..\MaHoa.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btCatTxt);
            
            #line default
            #line hidden
            return;
            case 15:
            this.lbAnhGiauTin = ((System.Windows.Controls.Label)(target));
            return;
            case 16:
            this.AnhGiauTin = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

