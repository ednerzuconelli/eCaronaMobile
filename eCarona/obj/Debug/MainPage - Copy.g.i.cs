﻿#pragma checksum "C:\Users\Edlaine\documents\visual studio 2013\Projects\eCarona\eCarona\MainPage - Copy.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A2359D44FEDFFC3C0990E2D019A6D3D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace eCarona {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock tblToken;
        
        internal System.Windows.Controls.TextBox tbToken;
        
        internal System.Windows.Controls.TextBox tbNome;
        
        internal System.Windows.Controls.TextBlock tblNome;
        
        internal System.Windows.Controls.TextBox tbEndereco;
        
        internal System.Windows.Controls.TextBlock tblEndereco;
        
        internal System.Windows.Controls.TextBlock tblCidade;
        
        internal System.Windows.Controls.TextBox tbCidade;
        
        internal System.Windows.Controls.TextBlock tblBairro;
        
        internal System.Windows.Controls.TextBox tbBairro;
        
        internal System.Windows.Controls.TextBlock tblTipoCarona;
        
        internal System.Windows.Controls.RadioButton rad_A;
        
        internal System.Windows.Controls.RadioButton rad_B;
        
        internal System.Windows.Controls.TextBlock tblPeriodo;
        
        internal Microsoft.Phone.Controls.DatePicker tbDataInicial;
        
        internal Microsoft.Phone.Controls.DatePicker tbDataFinal;
        
        internal System.Windows.Controls.TextBlock tblVagas;
        
        internal System.Windows.Controls.TextBox tbVagas;
        
        internal System.Windows.Controls.TextBlock tblPercurso;
        
        internal System.Windows.Controls.RadioButton percursoRad_A;
        
        internal System.Windows.Controls.RadioButton percursoRad_B;
        
        internal System.Windows.Controls.RadioButton percursoRad_C;
        
        internal System.Windows.Controls.TextBlock tblHorarioIda;
        
        internal Microsoft.Phone.Controls.TimePicker tbHorarioIda;
        
        internal System.Windows.Controls.TextBlock tblHorarioVolta;
        
        internal Microsoft.Phone.Controls.TimePicker tbHorarioVolta;
        
        internal System.Windows.Controls.Button btnSalvar;
        
        internal System.Windows.Controls.Button btnCancelar;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/eCarona;component/MainPage%20-%20Copy.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.tblToken = ((System.Windows.Controls.TextBlock)(this.FindName("tblToken")));
            this.tbToken = ((System.Windows.Controls.TextBox)(this.FindName("tbToken")));
            this.tbNome = ((System.Windows.Controls.TextBox)(this.FindName("tbNome")));
            this.tblNome = ((System.Windows.Controls.TextBlock)(this.FindName("tblNome")));
            this.tbEndereco = ((System.Windows.Controls.TextBox)(this.FindName("tbEndereco")));
            this.tblEndereco = ((System.Windows.Controls.TextBlock)(this.FindName("tblEndereco")));
            this.tblCidade = ((System.Windows.Controls.TextBlock)(this.FindName("tblCidade")));
            this.tbCidade = ((System.Windows.Controls.TextBox)(this.FindName("tbCidade")));
            this.tblBairro = ((System.Windows.Controls.TextBlock)(this.FindName("tblBairro")));
            this.tbBairro = ((System.Windows.Controls.TextBox)(this.FindName("tbBairro")));
            this.tblTipoCarona = ((System.Windows.Controls.TextBlock)(this.FindName("tblTipoCarona")));
            this.rad_A = ((System.Windows.Controls.RadioButton)(this.FindName("rad_A")));
            this.rad_B = ((System.Windows.Controls.RadioButton)(this.FindName("rad_B")));
            this.tblPeriodo = ((System.Windows.Controls.TextBlock)(this.FindName("tblPeriodo")));
            this.tbDataInicial = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("tbDataInicial")));
            this.tbDataFinal = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("tbDataFinal")));
            this.tblVagas = ((System.Windows.Controls.TextBlock)(this.FindName("tblVagas")));
            this.tbVagas = ((System.Windows.Controls.TextBox)(this.FindName("tbVagas")));
            this.tblPercurso = ((System.Windows.Controls.TextBlock)(this.FindName("tblPercurso")));
            this.percursoRad_A = ((System.Windows.Controls.RadioButton)(this.FindName("percursoRad_A")));
            this.percursoRad_B = ((System.Windows.Controls.RadioButton)(this.FindName("percursoRad_B")));
            this.percursoRad_C = ((System.Windows.Controls.RadioButton)(this.FindName("percursoRad_C")));
            this.tblHorarioIda = ((System.Windows.Controls.TextBlock)(this.FindName("tblHorarioIda")));
            this.tbHorarioIda = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("tbHorarioIda")));
            this.tblHorarioVolta = ((System.Windows.Controls.TextBlock)(this.FindName("tblHorarioVolta")));
            this.tbHorarioVolta = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("tbHorarioVolta")));
            this.btnSalvar = ((System.Windows.Controls.Button)(this.FindName("btnSalvar")));
            this.btnCancelar = ((System.Windows.Controls.Button)(this.FindName("btnCancelar")));
        }
    }
}

