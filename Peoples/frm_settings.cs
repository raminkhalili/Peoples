using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peoples
{
    public partial class frm_settings : Form
    {
        public frm_settings()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {


         
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                Peoples.Properties.Settings.Default["backup"] = txt_address.Text;
                if (chk_startup.Checked)
                {
                    Peoples.Properties.Settings.Default["startup"] = true;
                    rk.SetValue("People", Application.ExecutablePath);
                }

                else
                {
                    Peoples.Properties.Settings.Default["startup"] = false;
                    
                    rk.DeleteValue("People", false);
                }
      
                
            Peoples.Properties.Settings.Default.Save();
            this.Close();
        }

        private void frm_settings_Load(object sender, EventArgs e)
        {
            txt_address.Text = Peoples.Properties.Settings.Default["backup"].ToString();
            chk_startup.Checked = Convert.ToBoolean(Peoples.Properties.Settings.Default["startup"].ToString());
        }

        private void btn_select_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_address.Text = fbd.SelectedPath;
            }
        }
    }
}
