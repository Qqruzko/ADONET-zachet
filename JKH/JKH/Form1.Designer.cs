
namespace JKH
{
    partial class MainPanel
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_login = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.Action_box = new System.Windows.Forms.GroupBox();
            this.select_start_btn = new System.Windows.Forms.Button();
            this.Alter_start_btn = new System.Windows.Forms.Button();
            this.Action_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.Location = new System.Drawing.Point(44, 50);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(33, 13);
            this.l_login.TabIndex = 0;
            this.l_login.Text = "Login";
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Location = new System.Drawing.Point(44, 90);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(53, 13);
            this.l_password.TabIndex = 1;
            this.l_password.Text = "Password";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(104, 50);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(143, 20);
            this.tb_login.TabIndex = 2;
            this.tb_login.TextChanged += new System.EventHandler(this.tb_login_TextChanged);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(103, 90);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(144, 20);
            this.tb_password.TabIndex = 3;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // Connect_btn
            // 
            this.Connect_btn.Location = new System.Drawing.Point(288, 46);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(75, 23);
            this.Connect_btn.TabIndex = 4;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // Action_box
            // 
            this.Action_box.Controls.Add(this.select_start_btn);
            this.Action_box.Controls.Add(this.Alter_start_btn);
            this.Action_box.Location = new System.Drawing.Point(47, 139);
            this.Action_box.Name = "Action_box";
            this.Action_box.Size = new System.Drawing.Size(381, 100);
            this.Action_box.TabIndex = 5;
            this.Action_box.TabStop = false;
            this.Action_box.Text = "Action";
            this.Action_box.Visible = false;
            // 
            // select_start_btn
            // 
            this.select_start_btn.Location = new System.Drawing.Point(149, 42);
            this.select_start_btn.Name = "select_start_btn";
            this.select_start_btn.Size = new System.Drawing.Size(75, 23);
            this.select_start_btn.TabIndex = 1;
            this.select_start_btn.Text = "Select";
            this.select_start_btn.UseVisualStyleBackColor = true;
            this.select_start_btn.Click += new System.EventHandler(this.select_start_btn_Click);
            // 
            // Alter_start_btn
            // 
            this.Alter_start_btn.Location = new System.Drawing.Point(18, 42);
            this.Alter_start_btn.Name = "Alter_start_btn";
            this.Alter_start_btn.Size = new System.Drawing.Size(75, 23);
            this.Alter_start_btn.TabIndex = 0;
            this.Alter_start_btn.Text = "Alter";
            this.Alter_start_btn.UseVisualStyleBackColor = true;
            this.Alter_start_btn.Click += new System.EventHandler(this.Alter_start_btn_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Action_box);
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_login);
            this.Name = "MainPanel";
            this.Text = "Главная панель";
            this.Action_box.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.GroupBox Action_box;
        private System.Windows.Forms.Button select_start_btn;
        private System.Windows.Forms.Button Alter_start_btn;
    }
}

