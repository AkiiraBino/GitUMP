﻿#pragma checksum "C:\Program Files (x86)\Куча папок\Проект\GitUMP-change_branch\GitUMP\CollectivsPage\InfoStatus.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1959A2AE75DF1198C12245D7907ACE49EFBBC1BB94526EFB9C593BC7F772876"
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
    partial class InfoStatus : 
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
                    this.Back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\CollectivsPage\InfoStatus.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Click += this.ButtonBack_Click;
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
