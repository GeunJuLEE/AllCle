﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6C2799FD60C3670248B87BDE89ED61EF15DB6F06"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using Client;
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


namespace Client {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Client.MainWindow mainwindow;
        
        #line default
        #line hidden
        
        
        #line 274 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox temp;
        
        #line default
        #line hidden
        
        
        #line 276 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock screen;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID_Box;
        
        #line default
        #line hidden
        
        
        #line 282 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PW_Box_Text;
        
        #line default
        #line hidden
        
        
        #line 286 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PW_Box;
        
        #line default
        #line hidden
        
        
        #line 294 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Login_btn;
        
        #line default
        #line hidden
        
        
        #line 317 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SingUP_btn;
        
        #line default
        #line hidden
        
        
        #line 320 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Geust_Login;
        
        #line default
        #line hidden
        
        
        #line 323 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Forget_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/Client;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.mainwindow = ((Client.MainWindow)(target));
            
            #line 11 "..\..\MainWindow.xaml"
            this.mainwindow.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.temp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.screen = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.ID_Box = ((System.Windows.Controls.TextBox)(target));
            
            #line 280 "..\..\MainWindow.xaml"
            this.ID_Box.LostFocus += new System.Windows.RoutedEventHandler(this.ID_Box_LostFocus);
            
            #line default
            #line hidden
            
            #line 281 "..\..\MainWindow.xaml"
            this.ID_Box.GotFocus += new System.Windows.RoutedEventHandler(this.ID_Box_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PW_Box_Text = ((System.Windows.Controls.TextBox)(target));
            
            #line 285 "..\..\MainWindow.xaml"
            this.PW_Box_Text.GotFocus += new System.Windows.RoutedEventHandler(this.PW_Box_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PW_Box = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 288 "..\..\MainWindow.xaml"
            this.PW_Box.KeyDown += new System.Windows.Input.KeyEventHandler(this.PW_Box_KeyDown);
            
            #line default
            #line hidden
            
            #line 288 "..\..\MainWindow.xaml"
            this.PW_Box.LostFocus += new System.Windows.RoutedEventHandler(this.PW_Box_LostFocus);
            
            #line default
            #line hidden
            
            #line 289 "..\..\MainWindow.xaml"
            this.PW_Box.GotFocus += new System.Windows.RoutedEventHandler(this.PW_Box_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Login_btn = ((System.Windows.Controls.Button)(target));
            
            #line 295 "..\..\MainWindow.xaml"
            this.Login_btn.Click += new System.Windows.RoutedEventHandler(this.Login_btn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SingUP_btn = ((System.Windows.Controls.Button)(target));
            
            #line 318 "..\..\MainWindow.xaml"
            this.SingUP_btn.Click += new System.Windows.RoutedEventHandler(this.SingUP_btn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Geust_Login = ((System.Windows.Controls.Button)(target));
            
            #line 321 "..\..\MainWindow.xaml"
            this.Geust_Login.Click += new System.Windows.RoutedEventHandler(this.Geust_Login_Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Forget_btn = ((System.Windows.Controls.Button)(target));
            
            #line 324 "..\..\MainWindow.xaml"
            this.Forget_btn.Click += new System.Windows.RoutedEventHandler(this.Forget_btn_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

