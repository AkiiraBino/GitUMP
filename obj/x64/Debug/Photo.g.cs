﻿#pragma checksum "C:\Program Files (x86)\Куча папок\Проект\GitUMP-change_branch\GitUMP\Photo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "53928B3D58C82C98D5C8B78643984D19A3FA43DA71375F084C211450070D9618"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GitUMP
{
    partial class Photo : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\Photo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 34 "..\..\..\Photo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.VideoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\Photo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.VideoButton).Click += this.VideoButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.PhotoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\Photo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.PhotoButton).Click += this.PhotoButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.NewsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\Photo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.NewsButton).Click += this.News_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.CollectivsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\Photo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CollectivsButton).Click += this.CollectivsButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

