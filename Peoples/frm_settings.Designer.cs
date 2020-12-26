
namespace Peoples
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_select_path = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_startup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 83);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "ذخیره";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(93, 83);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(49, 28);
            this.txt_address.Name = "txt_address";
            this.txt_address.ReadOnly = true;
            this.txt_address.Size = new System.Drawing.Size(331, 23);
            this.txt_address.TabIndex = 2;
            // 
            // btn_select_path
            // 
            this.btn_select_path.Location = new System.Drawing.Point(12, 28);
            this.btn_select_path.Name = "btn_select_path";
            this.btn_select_path.Size = new System.Drawing.Size(31, 23);
            this.btn_select_path.TabIndex = 3;
            this.btn_select_path.Text = "...";
            this.btn_select_path.UseVisualStyleBackColor = true;
            this.btn_select_path.Click += new System.EventHandler(this.btn_select_path_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "محل ذخیره پشتیبان گیری";
            // 
            // chk_startup
            // 
            this.chk_startup.AutoSize = true;
            this.chk_startup.Location = new System.Drawing.Point(12, 57);
            this.chk_startup.Name = "chk_startup";
            this.chk_startup.Size = new System.Drawing.Size(215, 20);
            this.chk_startup.TabIndex = 5;
            this.chk_startup.Text = "اجرای برنامه هنگام بالا آمدن ویندوز";
            this.chk_startup.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chk_startup.UseVisualStyleBackColor = true;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 120);
            this.Controls.Add(this.chk_startup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_select_path);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_settings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.frm_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button btn_select_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_startup;
    }
}