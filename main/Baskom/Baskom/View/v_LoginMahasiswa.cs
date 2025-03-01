﻿using Baskom.Controller;
using Baskom.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskom.View
{
    partial class v_LoginMahasiswa : Form
    {
        private c_Akun c_Akun;
        private m_DataAkunMahasiswa m_DataAkunMahasiswa = new();

        public v_LoginMahasiswa(c_Akun c_Akun)
        {
            InitializeComponent();
            this.c_Akun = c_Akun;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nim = tbx_nimlogin.Text;
            string kata_sandi = tbx_katasandilogin.Text;
            this.Close();
            c_Akun.loginMahasiswa(nim,kata_sandi,this);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            v_Login v_Login = new();
            v_Login.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        public bool loginMahasiswa(string nim_mahasiswa, string kata_sandi)
        {
            if (nim_mahasiswa.Length == 0 || kata_sandi.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
