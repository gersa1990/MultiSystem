﻿#pragma checksum "..\..\..\..\..\..\app\Library\Views\Login\BibliotecaLogin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "18C9CBF941643A46F9E08E945A38A345"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
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


namespace MultiSystem.app.Library.view.Login {
    
    
    /// <summary>
    /// LoginLibrary
    /// </summary>
    public partial class LoginLibrary : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\..\..\..\app\Library\Views\Login\BibliotecaLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MultiSystem.app.Library.view.Login.LoginLibrary Window;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\app\Library\Views\Login\BibliotecaLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\..\app\Library\Views\Login\BibliotecaLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userNameBookStore;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\..\app\Library\Views\Login\BibliotecaLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passWordNameBookStore;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\..\app\Library\Views\Login\BibliotecaLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageBackgroundLibrary;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\..\app\Library\Views\Login\BibliotecaLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTittleLibrary;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\..\app\Library\Views\Login\BibliotecaLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label messageLogin;
        
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
            System.Uri resourceLocater = new System.Uri("/MultiSystem;component/app/library/views/login/bibliotecalogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\app\Library\Views\Login\BibliotecaLogin.xaml"
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
            this.Window = ((MultiSystem.app.Library.view.Login.LoginLibrary)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.userNameBookStore = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.passWordNameBookStore = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            
            #line 34 "..\..\..\..\..\..\app\Library\Views\Login\BibliotecaLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.actionClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 44 "..\..\..\..\..\..\app\Library\Views\Login\BibliotecaLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.returnToHome);
            
            #line default
            #line hidden
            return;
            case 7:
            this.imageBackgroundLibrary = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.labelTittleLibrary = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.messageLogin = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

