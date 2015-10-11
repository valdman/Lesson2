namespace Lesson2
{
    partial class AdminPanel
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
            this.autorizationLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.warningField = new System.Windows.Forms.TextBox();
            this.signLabel = new System.Windows.Forms.Label();
            this.adminLayout = new System.Windows.Forms.TableLayoutPanel();
            this.carListAdmin = new System.Windows.Forms.ListView();
            this.carNameAdmin = new System.Windows.Forms.TextBox();
            this.carDescriptionAdmin = new System.Windows.Forms.RichTextBox();
            this.changeNameAndDescription = new System.Windows.Forms.Button();
            this.createACar = new System.Windows.Forms.Button();
            this.deleteACar = new System.Windows.Forms.Button();
            this.unlogin = new System.Windows.Forms.Button();
            this.autorizationLayout.SuspendLayout();
            this.adminLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // autorizationLayout
            // 
            this.autorizationLayout.ColumnCount = 3;
            this.autorizationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.25134F));
            this.autorizationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.74866F));
            this.autorizationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.autorizationLayout.Controls.Add(this.loginLabel, 1, 1);
            this.autorizationLayout.Controls.Add(this.passwordLabel, 2, 1);
            this.autorizationLayout.Controls.Add(this.loginField, 1, 2);
            this.autorizationLayout.Controls.Add(this.passwordField, 2, 2);
            this.autorizationLayout.Controls.Add(this.enterButton, 2, 3);
            this.autorizationLayout.Controls.Add(this.warningField, 1, 3);
            this.autorizationLayout.Controls.Add(this.signLabel, 1, 0);
            this.autorizationLayout.Location = new System.Drawing.Point(0, 0);
            this.autorizationLayout.Name = "autorizationLayout";
            this.autorizationLayout.RowCount = 4;
            this.autorizationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.4138F));
            this.autorizationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.58621F));
            this.autorizationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.autorizationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.autorizationLayout.Size = new System.Drawing.Size(406, 299);
            this.autorizationLayout.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(47, 82);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(232, 82);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(48, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Пароль:";
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(47, 116);
            this.loginField.MaxLength = 16;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(114, 20);
            this.loginField.TabIndex = 2;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(232, 116);
            this.passwordField.MaxLength = 16;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(119, 20);
            this.passwordField.TabIndex = 3;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(232, 263);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // warningField
            // 
            this.warningField.Enabled = false;
            this.warningField.Location = new System.Drawing.Point(47, 263);
            this.warningField.Name = "warningField";
            this.warningField.Size = new System.Drawing.Size(100, 20);
            this.warningField.TabIndex = 5;
            // 
            // signLabel
            // 
            this.signLabel.AutoSize = true;
            this.signLabel.Location = new System.Drawing.Point(47, 0);
            this.signLabel.Name = "signLabel";
            this.signLabel.Size = new System.Drawing.Size(117, 26);
            this.signLabel.TabIndex = 6;
            this.signLabel.Text = "Для входа требуется авторизация";
            // 
            // adminLayout
            // 
            this.adminLayout.ColumnCount = 2;
            this.adminLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.28571F));
            this.adminLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.adminLayout.Controls.Add(this.carListAdmin, 0, 0);
            this.adminLayout.Controls.Add(this.carNameAdmin, 0, 1);
            this.adminLayout.Controls.Add(this.carDescriptionAdmin, 0, 2);
            this.adminLayout.Controls.Add(this.changeNameAndDescription, 0, 3);
            this.adminLayout.Controls.Add(this.createACar, 1, 3);
            this.adminLayout.Controls.Add(this.deleteACar, 1, 0);
            this.adminLayout.Controls.Add(this.unlogin, 1, 1);
            this.adminLayout.Location = new System.Drawing.Point(0, 0);
            this.adminLayout.Name = "adminLayout";
            this.adminLayout.RowCount = 4;
            this.adminLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.14286F));
            this.adminLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.85714F));
            this.adminLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.adminLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.adminLayout.Size = new System.Drawing.Size(406, 299);
            this.adminLayout.TabIndex = 1;
            this.adminLayout.Visible = false;
            // 
            // carListAdmin
            // 
            this.carListAdmin.Location = new System.Drawing.Point(3, 3);
            this.carListAdmin.Name = "carListAdmin";
            this.carListAdmin.Size = new System.Drawing.Size(254, 133);
            this.carListAdmin.TabIndex = 0;
            this.carListAdmin.UseCompatibleStateImageBehavior = false;
            // 
            // carNameAdmin
            // 
            this.carNameAdmin.Location = new System.Drawing.Point(3, 152);
            this.carNameAdmin.Name = "carNameAdmin";
            this.carNameAdmin.Size = new System.Drawing.Size(197, 20);
            this.carNameAdmin.TabIndex = 1;
            // 
            // carDescriptionAdmin
            // 
            this.carDescriptionAdmin.Location = new System.Drawing.Point(3, 178);
            this.carDescriptionAdmin.Name = "carDescriptionAdmin";
            this.carDescriptionAdmin.Size = new System.Drawing.Size(254, 86);
            this.carDescriptionAdmin.TabIndex = 2;
            this.carDescriptionAdmin.Text = "";
            // 
            // changeNameAndDescription
            // 
            this.changeNameAndDescription.Location = new System.Drawing.Point(3, 270);
            this.changeNameAndDescription.Name = "changeNameAndDescription";
            this.changeNameAndDescription.Size = new System.Drawing.Size(234, 23);
            this.changeNameAndDescription.TabIndex = 3;
            this.changeNameAndDescription.Text = "Изменить имя и описание";
            this.changeNameAndDescription.UseVisualStyleBackColor = true;
            // 
            // createACar
            // 
            this.createACar.Location = new System.Drawing.Point(263, 270);
            this.createACar.Name = "createACar";
            this.createACar.Size = new System.Drawing.Size(131, 23);
            this.createACar.TabIndex = 4;
            this.createACar.Text = "Создать машину";
            this.createACar.UseVisualStyleBackColor = true;
            // 
            // deleteACar
            // 
            this.deleteACar.Location = new System.Drawing.Point(263, 3);
            this.deleteACar.Name = "deleteACar";
            this.deleteACar.Size = new System.Drawing.Size(131, 57);
            this.deleteACar.TabIndex = 5;
            this.deleteACar.Text = "Удалить машину";
            this.deleteACar.UseVisualStyleBackColor = true;
            // 
            // unlogin
            // 
            this.unlogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.unlogin.Location = new System.Drawing.Point(319, 152);
            this.unlogin.Name = "unlogin";
            this.unlogin.Size = new System.Drawing.Size(84, 20);
            this.unlogin.TabIndex = 6;
            this.unlogin.Text = "Разлогинься!";
            this.unlogin.UseVisualStyleBackColor = true;
            this.unlogin.Click += new System.EventHandler(this.unlogin_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 299);
            this.Controls.Add(this.autorizationLayout);
            this.Controls.Add(this.adminLayout);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 337);
            this.MinimumSize = new System.Drawing.Size(422, 337);
            this.Name = "AdminPanel";
            this.Text = "Панель администратора сервиса";
            this.autorizationLayout.ResumeLayout(false);
            this.autorizationLayout.PerformLayout();
            this.adminLayout.ResumeLayout(false);
            this.adminLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel autorizationLayout;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox warningField;
        private System.Windows.Forms.Label signLabel;
        private System.Windows.Forms.TableLayoutPanel adminLayout;
        private System.Windows.Forms.ListView carListAdmin;
        private System.Windows.Forms.TextBox carNameAdmin;
        private System.Windows.Forms.RichTextBox carDescriptionAdmin;
        private System.Windows.Forms.Button changeNameAndDescription;
        private System.Windows.Forms.Button createACar;
        private System.Windows.Forms.Button deleteACar;
        private System.Windows.Forms.Button unlogin;
    }
}