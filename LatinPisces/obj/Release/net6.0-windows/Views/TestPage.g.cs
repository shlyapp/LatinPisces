﻿#pragma checksum "..\..\..\..\Views\TestPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "952FD9C701D75670AE647C0B772D498836A9EF20"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LatinPisces.View;
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


namespace LatinPisces.View {
    
    
    /// <summary>
    /// TestPage
    /// </summary>
    public partial class TestPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Views\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Views\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CardImage;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Views\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox isLatin;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\TestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox isRussian;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LatinPisces;component/views/testpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\TestPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid = ((System.Windows.Controls.Grid)(target));
            
            #line 11 "..\..\..\..\Views\TestPage.xaml"
            this.grid.KeyDown += new System.Windows.Input.KeyEventHandler(this.Page_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CardImage = ((System.Windows.Controls.Image)(target));
            
            #line 16 "..\..\..\..\Views\TestPage.xaml"
            this.CardImage.KeyDown += new System.Windows.Input.KeyEventHandler(this.Page_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 26 "..\..\..\..\Views\TestPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GiveAnswer);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 33 "..\..\..\..\Views\TestPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GiveAnswer);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 40 "..\..\..\..\Views\TestPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GiveAnswer);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 47 "..\..\..\..\Views\TestPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GiveAnswer);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 54 "..\..\..\..\Views\TestPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GiveAnswer);
            
            #line default
            #line hidden
            return;
            case 8:
            this.isLatin = ((System.Windows.Controls.CheckBox)(target));
            
            #line 62 "..\..\..\..\Views\TestPage.xaml"
            this.isLatin.Click += new System.Windows.RoutedEventHandler(this.ChangeLanguage);
            
            #line default
            #line hidden
            return;
            case 9:
            this.isRussian = ((System.Windows.Controls.CheckBox)(target));
            
            #line 72 "..\..\..\..\Views\TestPage.xaml"
            this.isRussian.Click += new System.Windows.RoutedEventHandler(this.ChangeLanguage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
