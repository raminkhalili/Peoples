using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Forms;
using System.IO;

namespace Peoples
{
    public partial class frm_main : Form
    {
        DataBaseDataContext db;
        public frm_main()
        {

            InitializeComponent();

            if (!Directory.Exists(Properties.Settings.Default["backup"].ToString()))
            {
                Properties.Settings.Default["backup"] = Application.StartupPath + "\\Backup";
                Properties.Settings.Default.Save();
            }


            if (db == null)
                db = new DataBaseDataContext();

            var result = from data in db.tbl_persons
                         select data;
            dgv_main.DataSource = result;

            dgv_main.Columns[0].HeaderText = "شماره";
            dgv_main.Columns[1].HeaderText = "نام";
            dgv_main.Columns[2].HeaderText = "نام خانوادگی";
            dgv_main.Columns[3].HeaderText = "شماره تلفن";
            dgv_main.Columns[4].HeaderText = "تاریخ";
            dgv_main.Columns[5].HeaderText = "توضیحات";
            dgv_main.Columns[0].Visible = false;
            dgv_main.Columns[4].Visible = false;
            dgv_main.Columns[5].Visible = false;
            dgv_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ms_main_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ms_main_add_Click(object sender, EventArgs e)
        {

            frm_add_edit add = new frm_add_edit();
            if (add.ShowDialog() == DialogResult.OK)
            {
                db = new DataBaseDataContext();
                var query = from persons in db.tbl_persons
                            select persons;
                dgv_main.DataSource = query;
            }
        }

        private void ms_main_edit_Click(object sender, EventArgs e)
        {
            if (dgv_main.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv_main.SelectedRows[0].Cells[0].Value.ToString());
                frm_add_edit edit = new frm_add_edit();
                edit.id = id;
                edit.Text = "ویرایش";
                var person = (from persons in db.tbl_persons
                              where persons.Id == id
                              select persons).Single();
                edit.txt_firstname.Text = person.firstname;
                edit.txt_lastname.Text = person.lastname;
                edit.txt_phonenumber.Text = person.phonenumber;
                edit.txt_description.Text = person.description;
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    db = new DataBaseDataContext();
                    var query = from persons in db.tbl_persons
                                select persons;
                    dgv_main.DataSource = query;
                }
            }
            else
            {
                MessageBox.Show("لطفاً یک گزینه را اتنخاب کنید.", "ویرایش مخاطب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ms_main_delete_Click(object sender, EventArgs e)
        {
            if (dgv_main.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv_main.SelectedRows[0].Cells[0].Value.ToString());
                var person = (from persons in db.tbl_persons
                              where persons.Id == id
                              select persons).Single();
                db.tbl_persons.DeleteOnSubmit(person);
                db.SubmitChanges();
                db.Refresh(RefreshMode.KeepChanges);
                dgv_main.DataSource = db.tbl_persons.Select(x => x);

            }
            else
            {
                MessageBox.Show("لطفاً یک گزینه را اتنخاب کنید.", "حذف مخاطب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cms_dgv_main_show_Click(object sender, EventArgs e)
        {
            if (dgv_main.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv_main.SelectedRows[0].Cells[0].Value.ToString());
                frm_view view = new frm_view();
                view.id = id;
                if (view.ShowDialog() == DialogResult.Yes)
                {
                    db.Refresh(RefreshMode.KeepChanges);
                    dgv_main.DataSource = db.tbl_persons.Select(x => x);
                }
            }
        }
        private void dgv_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgv_main.Rows.Count > 0)
                if (e.Button == MouseButtons.Right)
                {
                    var hit = dgv_main.HitTest(e.X, e.Y);
                    dgv_main.ClearSelection();
                    try
                    {
                        dgv_main.Rows[hit.RowIndex].Selected = true;
                    }
                    catch
                    {

                    }
                }
        }

        private void ms_main_about_Click(object sender, EventArgs e)
        {
            frm_about about = new frm_about();
            about.ShowDialog();
        }

        private void ms_main_setting_Click(object sender, EventArgs e)
        {
            frm_settings setting = new frm_settings();
            setting.ShowDialog();
        }

        private void cms_main_show_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (cbo_search.Text == "نام")
            {
                var query = from persons in db.tbl_persons
                            where persons.firstname.Contains(txt_search.Text)
                            select persons;
                dgv_main.DataSource = query;
            }
            else if (cbo_search.Text == "نام خانوادگی")
            {
                var query = from persons in db.tbl_persons
                            where persons.lastname.Contains(txt_search.Text)
                            select persons;
                dgv_main.DataSource = query;
            }
            else if (cbo_search.Text == "شماره")
            {
                var query = from persons in db.tbl_persons
                            where persons.phonenumber.Contains(txt_search.Text)
                            select persons;
                dgv_main.DataSource = query;
            }
            else
            {
                var query = from persons in db.tbl_persons
                            where persons.firstname.Contains(txt_search.Text) | persons.lastname.Contains(txt_search.Text) | persons.phonenumber.Contains(txt_search.Text)
                            select persons;
                dgv_main.DataSource = query;
            }
        }

        private void ms_main_backup_Click(object sender, EventArgs e)
        {
            try
            {
                string dbPath = System.IO.Path.Combine(Application.StartupPath, "Database", db.Mapping.DatabaseName + ".mdf");
                if (!Directory.Exists(Properties.Settings.Default["backup"].ToString()))
                    Directory.CreateDirectory(Properties.Settings.Default["backup"].ToString());
                string file = Path.Combine(Properties.Settings.Default["backup"].ToString(), string.Format("{0}_{1}_{2}_{3}_{4}_{5}_People_Backup.bak", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
                db.ExecuteCommand(string.Format("BACKUP DATABASE [{0}] to DISK=N'{1}'",dbPath,file));
                MessageBox.Show("فابل پشتیبان با موفقیت تهیه شد.", "پشتیبان گیری", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("در تهیه نسخه پشتیبان مشکلی رخ داد.", "پشتیبان گیری", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ms_main_restore_Click(object sender, EventArgs e)
        {
            try
            {
                string dbPath = System.IO.Path.Combine(Application.StartupPath, "Database", db.Mapping.DatabaseName + ".mdf");
                OpenFileDialog ofd_rstore = new OpenFileDialog();
                ofd_rstore.Filter = "Backup People (*.bak)|*.bak";
                ofd_rstore.Multiselect = false;
                if (ofd_rstore.ShowDialog() == DialogResult.OK)
                {
                    db.ExecuteCommand(string.Format("USE MASTER RESTORE DATABASE [{0}] FROM DISK=N'{1}' WITH  FILE = 1,  NOUNLOAD,  STATS = 10", dbPath, ofd_rstore.FileName));
                    db.Refresh(RefreshMode.KeepChanges);
                    dgv_main.DataSource = db.tbl_persons.Select(x => x);
                }
            }
            catch
            {
                MessageBox.Show("در بازیابی اطلاعات مشکلی رخ داده است.", "بازیابی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
