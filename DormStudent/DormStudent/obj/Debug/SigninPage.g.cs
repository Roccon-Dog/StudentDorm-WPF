﻿#pragma checksum "..\..\SigninPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E0B40AB88247B6E09FC37094D2DC07E4AD84F0F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DormStudent;
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


namespace DormStudent {
    
    
    /// <summary>
    /// SigninPage
    /// </summary>
    public partial class SigninPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\SigninPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentID;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\SigninPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentPassword;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\SigninPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentPasswordAgain;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\SigninPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentName;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\SigninPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentMajor;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\SigninPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentDorm;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\SigninPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StudentGender;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\SigninPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Gender_Male;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\SigninPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Gender_Female;
        
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
            System.Uri resourceLocater = new System.Uri("/DormStudent;component/signinpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SigninPage.xaml"
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
            this.StudentID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.StudentPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.StudentPasswordAgain = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.StudentName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.StudentMajor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.StudentDorm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.StudentGender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.Gender_Male = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 9:
            this.Gender_Female = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 10:
            
            #line 56 "..\..\SigninPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addStudent);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 57 "..\..\SigninPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Return_Mainwindow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
