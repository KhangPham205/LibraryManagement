// Updated by XamlIntelliSenseFileGenerator 16/12/2024 4:14:55 PM
#pragma checksum "..\..\infoxaml.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3FA9F61130AE4BA375C94144234C3D3E963BA0006B6DB20FDF41671266E2178D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryManagementApplication.Model.Class;
using LibraryManagementApplication.ViewModel;
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


namespace LibraryManagementApplication
{


    /// <summary>
    /// infoxaml
    /// </summary>
    public partial class infoxaml : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 62 "..\..\infoxaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tentb;

#line default
#line hidden


#line 75 "..\..\infoxaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userid;

#line default
#line hidden


#line 88 "..\..\infoxaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailtb;

#line default
#line hidden


#line 101 "..\..\infoxaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cccdtb;

#line default
#line hidden


#line 114 "..\..\infoxaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sdttb;

#line default
#line hidden


#line 121 "..\..\infoxaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logout;

#line default
#line hidden


#line 134 "..\..\infoxaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changemk;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryManagementApplication;component/infoxaml.xaml", System.UriKind.Relative);

#line 1 "..\..\infoxaml.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Logoutpage = ((LibraryManagementApplication.infoxaml)(target));
                    return;
                case 2:
                    this.tentb = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.userid = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.emailtb = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.cccdtb = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.sdttb = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.logout = ((System.Windows.Controls.Button)(target));
                    return;
                case 8:
                    this.changemk = ((System.Windows.Controls.Button)(target));

#line 141 "..\..\infoxaml.xaml"
                    this.changemk.Click += new System.Windows.RoutedEventHandler(this.changemk_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Page Logoutpage;
    }
}

