﻿#pragma checksum "C:\Users\Michael\Desktop\Folders\Desktop\Stuff\2017\CTU Stuff\Michael Everything\Semester 1\Programming\WPE\DimensionCalculator\DimensionCalculator\Simple_Interest\SimpleInterest_R.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1783D83F0A4B177C5721727036B7AC7D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DimensionCalculator
{
    partial class SimpleInterest_R : 
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
                    this.btnBackSI_r = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 11 "..\..\..\Simple_Interest\SimpleInterest_R.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBackSI_r).Click += this.btnBackSI_r_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.txtA_si_R = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.txtP_si_R = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.txtN_si_R = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.lblA_si_R = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.lblP_si_R = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.lblN_si_R = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.txtOutput_si_R = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.comboBox_simpleinterest_R = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 10:
                {
                    this.btnCalculate_si_R = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\Simple_Interest\SimpleInterest_R.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCalculate_si_R).Click += this.btnCalculate_si_R_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.btnReset_si_R = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\Simple_Interest\SimpleInterest_R.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnReset_si_R).Click += this.btnReset_si_R_Click_1;
                    #line default
                }
                break;
            case 12:
                {
                    this.lblHeader_si_R = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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

