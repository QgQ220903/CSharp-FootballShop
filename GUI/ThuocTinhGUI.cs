﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThuocTinhGUI : Form
    {
        Form activeForm = null;
        TheLoaiGUI theLoaiGUI = new TheLoaiGUI();
        MauSacGUI mauSacGUI = new MauSacGUI();
        KichCoGUI kichCoGUI = new KichCoGUI();

        public ThuocTinhGUI(TheLoaiGUI theLoaiGUI, MauSacGUI mauSacGUI, KichCoGUI kichCoGUI)
        {
            InitializeComponent();
            OpenForm(theLoaiGUI, TheLoaiGUI);
            OpenForm(mauSacGUI, MauSacGUI);
            OpenForm(kichCoGUI, KichCoGUI);
        }



        public void OpenForm(Form form, TabPage pageContainer)
        {

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pageContainer.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
    }
}
