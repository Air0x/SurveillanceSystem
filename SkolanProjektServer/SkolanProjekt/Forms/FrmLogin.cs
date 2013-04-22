using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkolanProjekt
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_field.Text == "1" && password_field.Text == "1") //Demo
            {
                FrmMain frm_login = new FrmMain();
                frm_login.Visible = true;
                this.Visible = false;
                
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FrmMain frm_login = new FrmMain();
            this.Visible = false;
            frm_login.Visible = true;
            
        }
    }
}
