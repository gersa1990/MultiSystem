﻿#pragma checksum "..\..\..\..\..\..\app\Library\Views\Controls\EditAndDeleteBook.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E4440177CDBC7B164A85B8F10AF154A1"
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


namespace MultiSystem.app.Library.Views.Controls {
    
    
    /// <summary>
    /// EditAndDeleteBook
    /// </summary>
    public partial class EditAndDeleteBook : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\..\app\Library\Views\Controls\EditAndDeleteBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataBooks;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\..\app\Library\Views\Controls\EditAndDeleteBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonEdit;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\..\app\Library\Views\Controls\EditAndDeleteBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDelete;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\..\app\Library\Views\Controls\EditAndDeleteBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBooksField;
        
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
            System.Uri resourceLocater = new System.Uri("/MultiSystem;component/app/library/views/controls/editanddeletebook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\app\Library\Views\Controls\EditAndDeleteBook.xaml"
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
            this.dataBooks = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\..\..\..\..\app\Library\Views\Controls\EditAndDeleteBook.xaml"
            this.dataBooks.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.OnAutoGeneratingColumn);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\..\..\..\app\Library\Views\Controls\EditAndDeleteBook.xaml"
            this.dataBooks.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.selectedRow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonEdit = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\..\app\Library\Views\Controls\EditAndDeleteBook.xaml"
            this.buttonEdit.Click += new System.Windows.RoutedEventHandler(this.editBook);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\..\app\Library\Views\Controls\EditAndDeleteBook.xaml"
            this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.deleteBook);
            
            #line default
            #line hidden
            return;
            case 4:
            this.searchBooksField = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\..\..\..\app\Library\Views\Controls\EditAndDeleteBook.xaml"
            this.searchBooksField.KeyUp += new System.Windows.Input.KeyEventHandler(this.searchBook);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

