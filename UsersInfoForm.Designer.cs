﻿
namespace Treasurer2
{
    partial class UsersInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersInfoForm));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureOfUser = new DevExpress.XtraEditors.PictureEdit();
            this.labelFirstname = new DevExpress.XtraEditors.LabelControl();
            this.labelLastname = new DevExpress.XtraEditors.LabelControl();
            this.labelEmailAddress = new DevExpress.XtraEditors.LabelControl();
            this.labelUsername = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl7.Location = new System.Drawing.Point(84, 269);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(25, 14);
            this.labelControl7.TabIndex = 55;
            this.labelControl7.Text = "Нэр:";
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.Location = new System.Drawing.Point(51, 229);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 14);
            this.labelControl3.TabIndex = 48;
            this.labelControl3.Text = "Username:";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(40, 344);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 14);
            this.labelControl2.TabIndex = 47;
            this.labelControl2.Text = "Имейл хаяг:";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(27, 305);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 14);
            this.labelControl1.TabIndex = 46;
            this.labelControl1.Text = "Эцэг/Эх-н нэр:";
            // 
            // pictureOfUser
            // 
            this.pictureOfUser.Location = new System.Drawing.Point(27, 12);
            this.pictureOfUser.Name = "pictureOfUser";
            this.pictureOfUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureOfUser.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureOfUser.Size = new System.Drawing.Size(231, 202);
            this.pictureOfUser.TabIndex = 40;
            this.pictureOfUser.TabStop = true;
            // 
            // labelFirstname
            // 
            this.labelFirstname.Appearance.Options.UseTextOptions = true;
            this.labelFirstname.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelFirstname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelFirstname.Location = new System.Drawing.Point(115, 269);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(110, 14);
            this.labelFirstname.TabIndex = 56;
            this.labelFirstname.Text = "Бүртгэлийн дугаар:";
            this.labelFirstname.Click += new System.EventHandler(this.labelFirstname_Click);
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelLastname.Location = new System.Drawing.Point(115, 305);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(110, 14);
            this.labelLastname.TabIndex = 57;
            this.labelLastname.Text = "Бүртгэлийн дугаар:";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelEmailAddress.Location = new System.Drawing.Point(115, 344);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(110, 14);
            this.labelEmailAddress.TabIndex = 58;
            this.labelEmailAddress.Text = "Бүртгэлийн дугаар:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelUsername.Location = new System.Drawing.Point(115, 229);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(110, 14);
            this.labelUsername.TabIndex = 59;
            this.labelUsername.Text = "Бүртгэлийн дугаар:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.richTextBox1.Location = new System.Drawing.Point(280, 385);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(143, 33);
            this.richTextBox1.TabIndex = 60;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // UsersInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 377);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureOfUser);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("UsersInfoForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "UsersInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хэрэглэгчийн мэдээлэл";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfUser.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.XtraEditors.PictureEdit pictureOfUser;
        internal DevExpress.XtraEditors.LabelControl labelFirstname;
        internal DevExpress.XtraEditors.LabelControl labelLastname;
        internal DevExpress.XtraEditors.LabelControl labelEmailAddress;
        internal DevExpress.XtraEditors.LabelControl labelUsername;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}