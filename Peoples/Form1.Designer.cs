
namespace Peoples
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.ms_main_file = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_main_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_main_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main_person = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main_add = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main_about = new System.Windows.Forms.ToolStripMenuItem();
            this.cbo_search = new System.Windows.Forms.ComboBox();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.cms_dgv_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_dgv_main_show = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_dgv_main_add = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_dgv_main_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_dgv_main_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ni_main = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_main_show = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_main_add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_main_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_main_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.cms_dgv_main.SuspendLayout();
            this.cms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(12, 33);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(66, 16);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "جستوجو :";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(84, 30);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(173, 23);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // ms_main
            // 
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_main_file,
            this.ms_main_person,
            this.ms_main_about});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(409, 24);
            this.ms_main.TabIndex = 2;
            this.ms_main.Text = "menuStrip1";
            // 
            // ms_main_file
            // 
            this.ms_main_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_main_backup,
            this.ms_main_restore,
            this.toolStripMenuItem2,
            this.ms_main_setting,
            this.toolStripSeparator1,
            this.ms_main_exit});
            this.ms_main_file.Name = "ms_main_file";
            this.ms_main_file.Size = new System.Drawing.Size(40, 20);
            this.ms_main_file.Text = "فایل";
            // 
            // ms_main_backup
            // 
            this.ms_main_backup.Name = "ms_main_backup";
            this.ms_main_backup.Size = new System.Drawing.Size(180, 22);
            this.ms_main_backup.Text = "پشتیبان گیری";
            this.ms_main_backup.Click += new System.EventHandler(this.ms_main_backup_Click);
            // 
            // ms_main_restore
            // 
            this.ms_main_restore.Name = "ms_main_restore";
            this.ms_main_restore.Size = new System.Drawing.Size(180, 22);
            this.ms_main_restore.Text = "بازیابی";
            this.ms_main_restore.Click += new System.EventHandler(this.ms_main_restore_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // ms_main_setting
            // 
            this.ms_main_setting.Name = "ms_main_setting";
            this.ms_main_setting.Size = new System.Drawing.Size(180, 22);
            this.ms_main_setting.Text = "تنظیمات";
            this.ms_main_setting.Click += new System.EventHandler(this.ms_main_setting_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ms_main_exit
            // 
            this.ms_main_exit.Name = "ms_main_exit";
            this.ms_main_exit.Size = new System.Drawing.Size(180, 22);
            this.ms_main_exit.Text = "خروج";
            this.ms_main_exit.Click += new System.EventHandler(this.ms_main_exit_Click);
            // 
            // ms_main_person
            // 
            this.ms_main_person.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_main_add,
            this.ms_main_edit,
            this.ms_main_delete});
            this.ms_main_person.Name = "ms_main_person";
            this.ms_main_person.Size = new System.Drawing.Size(58, 20);
            this.ms_main_person.Text = "اشخاص";
            // 
            // ms_main_add
            // 
            this.ms_main_add.Name = "ms_main_add";
            this.ms_main_add.Size = new System.Drawing.Size(110, 22);
            this.ms_main_add.Text = "افزودن";
            this.ms_main_add.Click += new System.EventHandler(this.ms_main_add_Click);
            // 
            // ms_main_edit
            // 
            this.ms_main_edit.Name = "ms_main_edit";
            this.ms_main_edit.Size = new System.Drawing.Size(110, 22);
            this.ms_main_edit.Text = "ویرایش";
            this.ms_main_edit.Click += new System.EventHandler(this.ms_main_edit_Click);
            // 
            // ms_main_delete
            // 
            this.ms_main_delete.Name = "ms_main_delete";
            this.ms_main_delete.Size = new System.Drawing.Size(110, 22);
            this.ms_main_delete.Text = "حذف";
            this.ms_main_delete.Click += new System.EventHandler(this.ms_main_delete_Click);
            // 
            // ms_main_about
            // 
            this.ms_main_about.Name = "ms_main_about";
            this.ms_main_about.Size = new System.Drawing.Size(47, 20);
            this.ms_main_about.Text = "درباره";
            this.ms_main_about.Click += new System.EventHandler(this.ms_main_about_Click);
            // 
            // cbo_search
            // 
            this.cbo_search.FormattingEnabled = true;
            this.cbo_search.Items.AddRange(new object[] {
            "نام",
            "نام خانوادگی",
            "شماره"});
            this.cbo_search.Location = new System.Drawing.Point(263, 30);
            this.cbo_search.Name = "cbo_search";
            this.cbo_search.Size = new System.Drawing.Size(134, 24);
            this.cbo_search.TabIndex = 3;
            this.cbo_search.Text = "جستوجو بر اساس";
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.ContextMenuStrip = this.cms_dgv_main;
            this.dgv_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_main.Location = new System.Drawing.Point(0, 60);
            this.dgv_main.MultiSelect = false;
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.Size = new System.Drawing.Size(409, 501);
            this.dgv_main.TabIndex = 4;
            this.dgv_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_main_MouseDown);
            // 
            // cms_dgv_main
            // 
            this.cms_dgv_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_dgv_main_show,
            this.cms_dgv_main_add,
            this.cms_dgv_main_edit,
            this.cms_dgv_main_delete});
            this.cms_dgv_main.Name = "cms_dgv_main";
            this.cms_dgv_main.Size = new System.Drawing.Size(115, 92);
            // 
            // cms_dgv_main_show
            // 
            this.cms_dgv_main_show.Name = "cms_dgv_main_show";
            this.cms_dgv_main_show.Size = new System.Drawing.Size(114, 22);
            this.cms_dgv_main_show.Text = "مشاهده";
            this.cms_dgv_main_show.Click += new System.EventHandler(this.cms_dgv_main_show_Click);
            // 
            // cms_dgv_main_add
            // 
            this.cms_dgv_main_add.Name = "cms_dgv_main_add";
            this.cms_dgv_main_add.Size = new System.Drawing.Size(114, 22);
            this.cms_dgv_main_add.Text = "افزودن";
            this.cms_dgv_main_add.Click += new System.EventHandler(this.ms_main_add_Click);
            // 
            // cms_dgv_main_edit
            // 
            this.cms_dgv_main_edit.Name = "cms_dgv_main_edit";
            this.cms_dgv_main_edit.Size = new System.Drawing.Size(114, 22);
            this.cms_dgv_main_edit.Text = "ویرایش";
            this.cms_dgv_main_edit.Click += new System.EventHandler(this.ms_main_edit_Click);
            // 
            // cms_dgv_main_delete
            // 
            this.cms_dgv_main_delete.Name = "cms_dgv_main_delete";
            this.cms_dgv_main_delete.Size = new System.Drawing.Size(114, 22);
            this.cms_dgv_main_delete.Text = "حذف";
            this.cms_dgv_main_delete.Click += new System.EventHandler(this.ms_main_delete_Click);
            // 
            // ni_main
            // 
            this.ni_main.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ni_main.BalloonTipText = "مشخصات افراد";
            this.ni_main.BalloonTipTitle = "اشخاص";
            this.ni_main.ContextMenuStrip = this.cms_main;
            this.ni_main.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_main.Icon")));
            this.ni_main.Text = "اشخاص";
            this.ni_main.Visible = true;
            // 
            // cms_main
            // 
            this.cms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_main_show,
            this.cms_main_add,
            this.toolStripSeparator2,
            this.cms_main_setting,
            this.toolStripSeparator3,
            this.cms_main_exit});
            this.cms_main.Name = "cms_main";
            this.cms_main.Size = new System.Drawing.Size(175, 104);
            // 
            // cms_main_show
            // 
            this.cms_main_show.Name = "cms_main_show";
            this.cms_main_show.Size = new System.Drawing.Size(174, 22);
            this.cms_main_show.Text = "نمایش";
            this.cms_main_show.Click += new System.EventHandler(this.cms_main_show_Click);
            // 
            // cms_main_add
            // 
            this.cms_main_add.Name = "cms_main_add";
            this.cms_main_add.Size = new System.Drawing.Size(174, 22);
            this.cms_main_add.Text = "افزودن مخاطب جدید";
            this.cms_main_add.Click += new System.EventHandler(this.ms_main_add_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // cms_main_setting
            // 
            this.cms_main_setting.Name = "cms_main_setting";
            this.cms_main_setting.Size = new System.Drawing.Size(174, 22);
            this.cms_main_setting.Text = "تنظیمات";
            this.cms_main_setting.Click += new System.EventHandler(this.ms_main_setting_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(171, 6);
            // 
            // cms_main_exit
            // 
            this.cms_main_exit.Name = "cms_main_exit";
            this.cms_main_exit.Size = new System.Drawing.Size(174, 22);
            this.cms_main_exit.Text = "خروج";
            this.cms_main_exit.Click += new System.EventHandler(this.ms_main_exit_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 561);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.cbo_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.ms_main);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_main;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اشخاص";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.cms_dgv_main.ResumeLayout(false);
            this.cms_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem ms_main_file;
        private System.Windows.Forms.ToolStripMenuItem ms_main_backup;
        private System.Windows.Forms.ToolStripMenuItem ms_main_restore;
        private System.Windows.Forms.ToolStripMenuItem ms_main_person;
        private System.Windows.Forms.ToolStripMenuItem ms_main_about;
        private System.Windows.Forms.ComboBox cbo_search;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ms_main_setting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ms_main_exit;
        private System.Windows.Forms.ToolStripMenuItem ms_main_add;
        private System.Windows.Forms.ToolStripMenuItem ms_main_edit;
        private System.Windows.Forms.ToolStripMenuItem ms_main_delete;
        private System.Windows.Forms.NotifyIcon ni_main;
        private System.Windows.Forms.ContextMenuStrip cms_dgv_main;
        private System.Windows.Forms.ToolStripMenuItem cms_dgv_main_add;
        private System.Windows.Forms.ToolStripMenuItem cms_dgv_main_edit;
        private System.Windows.Forms.ToolStripMenuItem cms_dgv_main_delete;
        private System.Windows.Forms.ContextMenuStrip cms_main;
        private System.Windows.Forms.ToolStripMenuItem cms_main_show;
        private System.Windows.Forms.ToolStripMenuItem cms_main_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cms_main_setting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cms_main_exit;
        private System.Windows.Forms.ToolStripMenuItem cms_dgv_main_show;
    }
}

