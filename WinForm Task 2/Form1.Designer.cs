namespace WinForm_Task_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            Save_Button = new Button();
            Cins_Panel = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label8 = new Label();
            Dogum_ili = new DateTimePicker();
            label7 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Telefon_Text = new TextBox();
            Olke_Text = new TextBox();
            Sheher_Text = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Peshe_Text = new TextBox();
            Ad_Text = new TextBox();
            Soyad_Text = new TextBox();
            Load_Text = new TextBox();
            Load_Button = new Button();
            Error_Label = new Label();
            groupBox1.SuspendLayout();
            Cins_Panel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(Save_Button);
            groupBox1.Controls.Add(Cins_Panel);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(Dogum_ili);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(7, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 633);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // Save_Button
            // 
            Save_Button.Location = new Point(9, 565);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(435, 43);
            Save_Button.TabIndex = 9;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = true;
            Save_Button.Click += Save_Button_Click;
            // 
            // Cins_Panel
            // 
            Cins_Panel.Controls.Add(radioButton3);
            Cins_Panel.Controls.Add(radioButton2);
            Cins_Panel.Controls.Add(radioButton1);
            Cins_Panel.Location = new Point(134, 477);
            Cins_Panel.Name = "Cins_Panel";
            Cins_Panel.Size = new Size(319, 41);
            Cins_Panel.TabIndex = 8;
            Cins_Panel.Paint += Cins_Panel_Paint;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(243, 5);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(125, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Qadin";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(24, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 24);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Kisi";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(9, 477);
            label8.Name = "label8";
            label8.Size = new Size(48, 28);
            label8.TabIndex = 7;
            label8.Text = "Cins";
            // 
            // Dogum_ili
            // 
            Dogum_ili.Location = new Point(139, 400);
            Dogum_ili.Name = "Dogum_ili";
            Dogum_ili.Size = new Size(305, 27);
            Dogum_ili.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 398);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 5;
            label7.Text = "Dogum ili";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Telefon_Text);
            panel2.Controls.Add(Olke_Text);
            panel2.Controls.Add(Sheher_Text);
            panel2.Location = new Point(6, 211);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 155);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(3, 104);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 5;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(3, 64);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 4;
            label5.Text = "Sheher";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(3, 21);
            label6.Name = "label6";
            label6.Size = new Size(52, 28);
            label6.TabIndex = 3;
            label6.Text = "Olke";
            // 
            // Telefon_Text
            // 
            Telefon_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Telefon_Text.Location = new Point(86, 98);
            Telefon_Text.Name = "Telefon_Text";
            Telefon_Text.Size = new Size(352, 34);
            Telefon_Text.TabIndex = 2;
            // 
            // Olke_Text
            // 
            Olke_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Olke_Text.Location = new Point(86, 18);
            Olke_Text.Name = "Olke_Text";
            Olke_Text.Size = new Size(352, 34);
            Olke_Text.TabIndex = 0;
            // 
            // Sheher_Text
            // 
            Sheher_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Sheher_Text.Location = new Point(86, 58);
            Sheher_Text.Name = "Sheher_Text";
            Sheher_Text.Size = new Size(352, 34);
            Sheher_Text.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Peshe_Text);
            panel1.Controls.Add(Ad_Text);
            panel1.Controls.Add(Soyad_Text);
            panel1.Location = new Point(6, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 155);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(3, 104);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 5;
            label3.Text = "Peshe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(3, 64);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 4;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(36, 28);
            label1.TabIndex = 3;
            label1.Text = "Ad";
            // 
            // Peshe_Text
            // 
            Peshe_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Peshe_Text.Location = new Point(86, 98);
            Peshe_Text.Name = "Peshe_Text";
            Peshe_Text.Size = new Size(352, 34);
            Peshe_Text.TabIndex = 2;
            // 
            // Ad_Text
            // 
            Ad_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Ad_Text.Location = new Point(86, 18);
            Ad_Text.Name = "Ad_Text";
            Ad_Text.Size = new Size(352, 34);
            Ad_Text.TabIndex = 0;
            // 
            // Soyad_Text
            // 
            Soyad_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Soyad_Text.Location = new Point(86, 58);
            Soyad_Text.Name = "Soyad_Text";
            Soyad_Text.Size = new Size(352, 34);
            Soyad_Text.TabIndex = 1;
            // 
            // Load_Text
            // 
            Load_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Load_Text.Location = new Point(21, 15);
            Load_Text.Name = "Load_Text";
            Load_Text.Size = new Size(320, 34);
            Load_Text.TabIndex = 1;
            Load_Text.Click += Load_Text_Click;
            // 
            // Load_Button
            // 
            Load_Button.Location = new Point(356, 15);
            Load_Button.Name = "Load_Button";
            Load_Button.Size = new Size(100, 34);
            Load_Button.TabIndex = 2;
            Load_Button.Text = "Load";
            Load_Button.UseVisualStyleBackColor = true;
            Load_Button.Click += Load_Button_Click;
            // 
            // Error_Label
            // 
            Error_Label.AutoSize = true;
            Error_Label.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Error_Label.ForeColor = Color.Red;
            Error_Label.Location = new Point(23, 52);
            Error_Label.Name = "Error_Label";
            Error_Label.Size = new Size(58, 25);
            Error_Label.TabIndex = 3;
            Error_Label.Text = "Error";
            Error_Label.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 732);
            Controls.Add(Error_Label);
            Controls.Add(Load_Button);
            Controls.Add(Load_Text);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Anket";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Cins_Panel.ResumeLayout(false);
            Cins_Panel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
        private TextBox Peshe_Text;
        private TextBox Ad_Text;
        private TextBox Soyad_Text;
        private Label label3;
        private Label label2;
        private Label label7;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Telefon_Text;
        private TextBox Olke_Text;
        private TextBox Sheher_Text;
        private DateTimePicker Dogum_ili;
        private Panel Cins_Panel;
        private Label label8;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button Save_Button;
        private TextBox Load_Text;
        private Button Load_Button;
        private Label Error_Label;
    }
}
