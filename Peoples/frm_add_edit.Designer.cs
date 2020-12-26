
namespace Peoples
{
    partial class frm_add_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_edit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "توضیحات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "شماره";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(98, 20);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(187, 23);
            this.txt_firstname.TabIndex = 6;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(98, 49);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(187, 23);
            this.txt_lastname.TabIndex = 7;
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(98, 78);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(187, 23);
            this.txt_phonenumber.TabIndex = 8;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(98, 107);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(187, 123);
            this.txt_description.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(15, 241);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "ثبت";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(96, 241);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frm_add_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 276);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_edit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "افزودن";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_firstname;
        public System.Windows.Forms.TextBox txt_lastname;
        public System.Windows.Forms.TextBox txt_phonenumber;
        public System.Windows.Forms.TextBox txt_description;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_cancel;
    }
}