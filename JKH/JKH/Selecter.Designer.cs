
namespace JKH
{
    partial class Selecter
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
            this.S = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.vehicle_mark_check = new System.Windows.Forms.CheckBox();
            this.vehicle_type_check = new System.Windows.Forms.CheckBox();
            this.Vehicles_rich_textbox = new System.Windows.Forms.RichTextBox();
            this.Select_all_vehicles_btn = new System.Windows.Forms.Button();
            this.vehicle_adress_check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Vehicle_select_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Serial_number_textbox = new System.Windows.Forms.TextBox();
            this.vehicle_availability_check = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mat_adress_box = new System.Windows.Forms.ComboBox();
            this.material_vacancy_check = new System.Windows.Forms.CheckBox();
            this.Select_all_mat_bttn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Materials_rich_textbox = new System.Windows.Forms.RichTextBox();
            this.material_mass_volume_check = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.material_select_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mat_name_box = new System.Windows.Forms.TextBox();
            this.S.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // S
            // 
            this.S.Controls.Add(this.tabPage1);
            this.S.Controls.Add(this.tabPage2);
            this.S.Location = new System.Drawing.Point(12, 12);
            this.S.Name = "S";
            this.S.SelectedIndex = 0;
            this.S.Size = new System.Drawing.Size(760, 365);
            this.S.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.vehicle_mark_check);
            this.tabPage1.Controls.Add(this.vehicle_type_check);
            this.tabPage1.Controls.Add(this.Vehicles_rich_textbox);
            this.tabPage1.Controls.Add(this.Select_all_vehicles_btn);
            this.tabPage1.Controls.Add(this.vehicle_adress_check);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Vehicle_select_btn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Serial_number_textbox);
            this.tabPage1.Controls.Add(this.vehicle_availability_check);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehicles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // vehicle_mark_check
            // 
            this.vehicle_mark_check.AutoSize = true;
            this.vehicle_mark_check.Location = new System.Drawing.Point(165, 146);
            this.vehicle_mark_check.Name = "vehicle_mark_check";
            this.vehicle_mark_check.Size = new System.Drawing.Size(59, 17);
            this.vehicle_mark_check.TabIndex = 8;
            this.vehicle_mark_check.Text = "Марка";
            this.vehicle_mark_check.UseVisualStyleBackColor = true;
            this.vehicle_mark_check.CheckedChanged += new System.EventHandler(this.vehicle_mark_check_CheckedChanged);
            // 
            // vehicle_type_check
            // 
            this.vehicle_type_check.AutoSize = true;
            this.vehicle_type_check.Location = new System.Drawing.Point(165, 123);
            this.vehicle_type_check.Name = "vehicle_type_check";
            this.vehicle_type_check.Size = new System.Drawing.Size(45, 17);
            this.vehicle_type_check.TabIndex = 7;
            this.vehicle_type_check.Text = "Тип";
            this.vehicle_type_check.UseVisualStyleBackColor = true;
            this.vehicle_type_check.CheckedChanged += new System.EventHandler(this.vehicle_type_check_CheckedChanged);
            // 
            // Vehicles_rich_textbox
            // 
            this.Vehicles_rich_textbox.Location = new System.Drawing.Point(263, 28);
            this.Vehicles_rich_textbox.Name = "Vehicles_rich_textbox";
            this.Vehicles_rich_textbox.Size = new System.Drawing.Size(448, 260);
            this.Vehicles_rich_textbox.TabIndex = 6;
            this.Vehicles_rich_textbox.Text = "";
            // 
            // Select_all_vehicles_btn
            // 
            this.Select_all_vehicles_btn.Location = new System.Drawing.Point(41, 211);
            this.Select_all_vehicles_btn.Name = "Select_all_vehicles_btn";
            this.Select_all_vehicles_btn.Size = new System.Drawing.Size(169, 37);
            this.Select_all_vehicles_btn.TabIndex = 5;
            this.Select_all_vehicles_btn.Text = "Запросить всю информацию по всему транспорту";
            this.Select_all_vehicles_btn.UseVisualStyleBackColor = true;
            this.Select_all_vehicles_btn.Click += new System.EventHandler(this.Select_all_vehicles_btn_Click);
            // 
            // vehicle_adress_check
            // 
            this.vehicle_adress_check.AutoSize = true;
            this.vehicle_adress_check.Location = new System.Drawing.Point(44, 146);
            this.vehicle_adress_check.Name = "vehicle_adress_check";
            this.vehicle_adress_check.Size = new System.Drawing.Size(104, 17);
            this.vehicle_adress_check.TabIndex = 4;
            this.vehicle_adress_check.Text = "Текущий адрес";
            this.vehicle_adress_check.UseVisualStyleBackColor = true;
            this.vehicle_adress_check.CheckedChanged += new System.EventHandler(this.vehicle_adress_check_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выберите типы данных для отображения";
            // 
            // Vehicle_select_btn
            // 
            this.Vehicle_select_btn.Location = new System.Drawing.Point(164, 28);
            this.Vehicle_select_btn.Name = "Vehicle_select_btn";
            this.Vehicle_select_btn.Size = new System.Drawing.Size(85, 37);
            this.Vehicle_select_btn.TabIndex = 3;
            this.Vehicle_select_btn.Text = "Запросить информацию";
            this.Vehicle_select_btn.UseVisualStyleBackColor = true;
            this.Vehicle_select_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Серийный номер";
            // 
            // Serial_number_textbox
            // 
            this.Serial_number_textbox.Location = new System.Drawing.Point(41, 45);
            this.Serial_number_textbox.Name = "Serial_number_textbox";
            this.Serial_number_textbox.Size = new System.Drawing.Size(100, 20);
            this.Serial_number_textbox.TabIndex = 1;
            this.Serial_number_textbox.TextChanged += new System.EventHandler(this.Serial_number_textbox_TextChanged);
            // 
            // vehicle_availability_check
            // 
            this.vehicle_availability_check.AutoSize = true;
            this.vehicle_availability_check.Location = new System.Drawing.Point(44, 123);
            this.vehicle_availability_check.Name = "vehicle_availability_check";
            this.vehicle_availability_check.Size = new System.Drawing.Size(92, 17);
            this.vehicle_availability_check.TabIndex = 0;
            this.vehicle_availability_check.Text = "Доступность";
            this.vehicle_availability_check.UseVisualStyleBackColor = true;
            this.vehicle_availability_check.CheckedChanged += new System.EventHandler(this.vehicle_availability_check_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mat_adress_box);
            this.tabPage2.Controls.Add(this.material_vacancy_check);
            this.tabPage2.Controls.Add(this.Select_all_mat_bttn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Materials_rich_textbox);
            this.tabPage2.Controls.Add(this.material_mass_volume_check);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.material_select_btn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.mat_name_box);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Materials";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mat_adress_box
            // 
            this.mat_adress_box.FormattingEnabled = true;
            this.mat_adress_box.Location = new System.Drawing.Point(26, 78);
            this.mat_adress_box.Name = "mat_adress_box";
            this.mat_adress_box.Size = new System.Drawing.Size(121, 21);
            this.mat_adress_box.TabIndex = 15;
            this.mat_adress_box.SelectedValueChanged += new System.EventHandler(this.mat_adress_box_SelectedValueChanged);
            this.mat_adress_box.Click += new System.EventHandler(this.mat_adress_box_Click);
            // 
            // material_vacancy_check
            // 
            this.material_vacancy_check.AutoSize = true;
            this.material_vacancy_check.Location = new System.Drawing.Point(29, 198);
            this.material_vacancy_check.Name = "material_vacancy_check";
            this.material_vacancy_check.Size = new System.Drawing.Size(92, 17);
            this.material_vacancy_check.TabIndex = 14;
            this.material_vacancy_check.Text = "Доступность";
            this.material_vacancy_check.UseVisualStyleBackColor = true;
            this.material_vacancy_check.CheckedChanged += new System.EventHandler(this.material_mass_vacancy_check_CheckedChanged);
            // 
            // Select_all_mat_bttn
            // 
            this.Select_all_mat_bttn.Location = new System.Drawing.Point(29, 238);
            this.Select_all_mat_bttn.Name = "Select_all_mat_bttn";
            this.Select_all_mat_bttn.Size = new System.Drawing.Size(205, 41);
            this.Select_all_mat_bttn.TabIndex = 13;
            this.Select_all_mat_bttn.Text = "Запросить информацию по всем материалам";
            this.Select_all_mat_bttn.UseVisualStyleBackColor = true;
            this.Select_all_mat_bttn.Click += new System.EventHandler(this.Select_all_mat_bttn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Материал";
            // 
            // Materials_rich_textbox
            // 
            this.Materials_rich_textbox.Location = new System.Drawing.Point(240, 42);
            this.Materials_rich_textbox.Name = "Materials_rich_textbox";
            this.Materials_rich_textbox.Size = new System.Drawing.Size(483, 237);
            this.Materials_rich_textbox.TabIndex = 11;
            this.Materials_rich_textbox.Text = "";
            // 
            // material_mass_volume_check
            // 
            this.material_mass_volume_check.AutoSize = true;
            this.material_mass_volume_check.Location = new System.Drawing.Point(29, 175);
            this.material_mass_volume_check.Name = "material_mass_volume_check";
            this.material_mass_volume_check.Size = new System.Drawing.Size(99, 17);
            this.material_mass_volume_check.TabIndex = 10;
            this.material_mass_volume_check.Text = "Объём/Масса";
            this.material_mass_volume_check.UseVisualStyleBackColor = true;
            this.material_mass_volume_check.CheckedChanged += new System.EventHandler(this.material_mass_volume_check_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите типы данных для отображения";
            // 
            // material_select_btn
            // 
            this.material_select_btn.Location = new System.Drawing.Point(149, 25);
            this.material_select_btn.Name = "material_select_btn";
            this.material_select_btn.Size = new System.Drawing.Size(85, 37);
            this.material_select_btn.TabIndex = 8;
            this.material_select_btn.Text = "Запросить информацию";
            this.material_select_btn.UseVisualStyleBackColor = true;
            this.material_select_btn.Click += new System.EventHandler(this.Materials_Select_bttn);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 6;
            // 
            // mat_name_box
            // 
            this.mat_name_box.Location = new System.Drawing.Point(26, 42);
            this.mat_name_box.Name = "mat_name_box";
            this.mat_name_box.Size = new System.Drawing.Size(100, 20);
            this.mat_name_box.TabIndex = 5;
            this.mat_name_box.TextChanged += new System.EventHandler(this.mat_name_TextChanged);
            // 
            // Selecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.S);
            this.Name = "Selecter";
            this.Text = "Selecter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Selecter_FormClosing);
            this.Load += new System.EventHandler(this.Selecter_Load);
            this.S.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl S;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox Vehicles_rich_textbox;
        private System.Windows.Forms.Button Select_all_vehicles_btn;
        private System.Windows.Forms.CheckBox vehicle_adress_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Vehicle_select_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Serial_number_textbox;
        private System.Windows.Forms.CheckBox vehicle_availability_check;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox Materials_rich_textbox;
        private System.Windows.Forms.CheckBox material_mass_volume_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button material_select_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mat_name_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Select_all_mat_bttn;
        private System.Windows.Forms.CheckBox vehicle_mark_check;
        private System.Windows.Forms.CheckBox vehicle_type_check;
        private System.Windows.Forms.CheckBox material_vacancy_check;
        private System.Windows.Forms.ComboBox mat_adress_box;
    }
}