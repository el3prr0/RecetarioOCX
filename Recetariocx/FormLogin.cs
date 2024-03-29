﻿using Logic.Helpers;
using Logic.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recetariocx
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        public  bool IsLogin { get; private set; }
        public string Nivel { get; private set; }
        UsuarioRepository _usuarioRepository;
        private readonly string Salt;
        public FormLogin()
        {
            InitializeComponent();
            _usuarioRepository = new UsuarioRepository();
            Salt = ConfigurationManager.AppSettings["SecretKey"].ToString();

        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnIniciar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
            {
                var usuario = await _usuarioRepository.GetUsuario(txtUsuario.Text.Trim().ToUpper());
                if(usuario.Usuario != null)
                {
                    var saltArray = Encoding.UTF8.GetBytes(Salt);
                    var passArray = Encoding.UTF8.GetBytes(txtPassword.Text.Trim());

                    var ContraArray = PasswordHelper.GenerateSaltedHash(passArray, saltArray);

                    var dbArray = Convert.FromBase64String(usuario.Password);

                    IsLogin = PasswordHelper.CompareByteArrays(dbArray, ContraArray);

                    if (IsLogin)
                    {
                        Nivel = usuario.Nivel;
                        this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Ingresar Contrase o Usuario valido", "Avertencia");
                        txtPassword.Text = "";
                        txtPassword.Focus();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Ingresar Contrase o Usuario valido", "Avertencia");
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
                

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Llenar los campos", "Aviso");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnIniciar_Click(null, null);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //activa el tecladovirtual del textinsumos
            txtUsuario.TextEntryMode = TextBoxWKeyBoard.TexBoxWKeyBoard.EntryMode.Standard;
        }

        private void TxtUsuario_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnIniciar_Click(null, null);
            }
        }

        private void Btnborrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 0)
            {
                txtUsuario.Text = txtUsuario.Text.TrimEnd(txtUsuario.Text[txtUsuario.Text.Length - 1]);

                txtUsuario.Focus();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                txtPassword.Text = txtPassword.Text.TrimEnd(txtPassword.Text[txtPassword.Text.Length - 1]);

                txtPassword.Focus();
            }
        }
    }
}
