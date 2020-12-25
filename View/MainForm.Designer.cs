namespace View
{
    partial class MainForm
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
            this.dispButton = new System.Windows.Forms.RadioButton();
            this.powButton = new System.Windows.Forms.RadioButton();
            this.medButton = new System.Windows.Forms.RadioButton();
            this.pow2Button = new System.Windows.Forms.RadioButton();
            this.factButton = new System.Windows.Forms.RadioButton();
            this.divButton = new System.Windows.Forms.RadioButton();
            this.logButton = new System.Windows.Forms.RadioButton();
            this.multButton = new System.Windows.Forms.RadioButton();
            this.sqButton = new System.Windows.Forms.RadioButton();
            this.subButton = new System.Windows.Forms.RadioButton();
            this.sq2Button = new System.Windows.Forms.RadioButton();
            this.sumButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.count_label = new System.Windows.Forms.Label();
            this.DLCfield = new System.Windows.Forms.TextBox();
            this.DLC_ok_BTN = new System.Windows.Forms.Button();
            this.repeatBTN = new System.Windows.Forms.Button();
            this.undoBTN = new System.Windows.Forms.Button();
            this.exportBTN = new System.Windows.Forms.Button();
            this.dataField = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dispButton
            // 
            this.dispButton.AutoSize = true;
            this.dispButton.Location = new System.Drawing.Point(137, 155);
            this.dispButton.Name = "dispButton";
            this.dispButton.Size = new System.Drawing.Size(110, 21);
            this.dispButton.TabIndex = 173;
            this.dispButton.TabStop = true;
            this.dispButton.Text = "Отклонение";
            this.dispButton.UseVisualStyleBackColor = true;
            this.dispButton.CheckedChanged += new System.EventHandler(this.DispButton_CheckedChanged);
            // 
            // powButton
            // 
            this.powButton.AutoSize = true;
            this.powButton.Location = new System.Drawing.Point(21, 155);
            this.powButton.Name = "powButton";
            this.powButton.Size = new System.Drawing.Size(44, 21);
            this.powButton.TabIndex = 172;
            this.powButton.TabStop = true;
            this.powButton.Text = "^n";
            this.powButton.UseVisualStyleBackColor = true;
            this.powButton.CheckedChanged += new System.EventHandler(this.PowButton_CheckedChanged);
            // 
            // medButton
            // 
            this.medButton.AutoSize = true;
            this.medButton.Location = new System.Drawing.Point(137, 128);
            this.medButton.Name = "medButton";
            this.medButton.Size = new System.Drawing.Size(88, 21);
            this.medButton.TabIndex = 171;
            this.medButton.TabStop = true;
            this.medButton.Text = "Медиана";
            this.medButton.UseVisualStyleBackColor = true;
            this.medButton.CheckedChanged += new System.EventHandler(this.MedButton_CheckedChanged);
            // 
            // pow2Button
            // 
            this.pow2Button.AutoSize = true;
            this.pow2Button.Location = new System.Drawing.Point(21, 128);
            this.pow2Button.Name = "pow2Button";
            this.pow2Button.Size = new System.Drawing.Size(44, 21);
            this.pow2Button.TabIndex = 170;
            this.pow2Button.TabStop = true;
            this.pow2Button.Text = "^2";
            this.pow2Button.UseVisualStyleBackColor = true;
            this.pow2Button.CheckedChanged += new System.EventHandler(this.Pow2Button_CheckedChanged);
            // 
            // factButton
            // 
            this.factButton.AutoSize = true;
            this.factButton.Location = new System.Drawing.Point(137, 102);
            this.factButton.Name = "factButton";
            this.factButton.Size = new System.Drawing.Size(32, 21);
            this.factButton.TabIndex = 169;
            this.factButton.TabStop = true;
            this.factButton.Text = "!";
            this.factButton.UseVisualStyleBackColor = true;
            this.factButton.CheckedChanged += new System.EventHandler(this.FactButton_CheckedChanged);
            // 
            // divButton
            // 
            this.divButton.AutoSize = true;
            this.divButton.Location = new System.Drawing.Point(21, 102);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(41, 21);
            this.divButton.TabIndex = 168;
            this.divButton.TabStop = true;
            this.divButton.Text = "/n";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.CheckedChanged += new System.EventHandler(this.DivButton_CheckedChanged);
            // 
            // logButton
            // 
            this.logButton.AutoSize = true;
            this.logButton.Location = new System.Drawing.Point(137, 75);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(82, 21);
            this.logButton.TabIndex = 167;
            this.logButton.TabStop = true;
            this.logButton.Text = "log_n(..)";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.CheckedChanged += new System.EventHandler(this.LogButton_CheckedChanged);
            // 
            // multButton
            // 
            this.multButton.AutoSize = true;
            this.multButton.Location = new System.Drawing.Point(21, 75);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(42, 21);
            this.multButton.TabIndex = 166;
            this.multButton.TabStop = true;
            this.multButton.Text = "*n";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.CheckedChanged += new System.EventHandler(this.MultButton_CheckedChanged);
            // 
            // sqButton
            // 
            this.sqButton.AutoSize = true;
            this.sqButton.Location = new System.Drawing.Point(137, 48);
            this.sqButton.Name = "sqButton";
            this.sqButton.Size = new System.Drawing.Size(45, 21);
            this.sqButton.TabIndex = 165;
            this.sqButton.TabStop = true;
            this.sqButton.Text = "n√";
            this.sqButton.UseVisualStyleBackColor = true;
            this.sqButton.CheckedChanged += new System.EventHandler(this.SqButton_CheckedChanged);
            // 
            // subButton
            // 
            this.subButton.AutoSize = true;
            this.subButton.Location = new System.Drawing.Point(21, 48);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(42, 21);
            this.subButton.TabIndex = 164;
            this.subButton.TabStop = true;
            this.subButton.Text = "-n";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.CheckedChanged += new System.EventHandler(this.SubButton_CheckedChanged);
            // 
            // sq2Button
            // 
            this.sq2Button.AutoSize = true;
            this.sq2Button.Location = new System.Drawing.Point(137, 21);
            this.sq2Button.Name = "sq2Button";
            this.sq2Button.Size = new System.Drawing.Size(37, 21);
            this.sq2Button.TabIndex = 163;
            this.sq2Button.TabStop = true;
            this.sq2Button.Text = "√";
            this.sq2Button.UseVisualStyleBackColor = true;
            this.sq2Button.CheckedChanged += new System.EventHandler(this.sq2Button_CheckedChanged);
            // 
            // sumButton
            // 
            this.sumButton.AutoSize = true;
            this.sumButton.Location = new System.Drawing.Point(21, 21);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(45, 21);
            this.sumButton.TabIndex = 162;
            this.sumButton.TabStop = true;
            this.sumButton.Text = "+n";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.CheckedChanged += new System.EventHandler(this.SumButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 161;
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(687, 226);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(28, 17);
            this.count_label.TabIndex = 159;
            this.count_label.Text = "0/0";
            // 
            // DLCfield
            // 
            this.DLCfield.Enabled = false;
            this.DLCfield.Location = new System.Drawing.Point(102, 259);
            this.DLCfield.Margin = new System.Windows.Forms.Padding(4);
            this.DLCfield.Name = "DLCfield";
            this.DLCfield.Size = new System.Drawing.Size(257, 22);
            this.DLCfield.TabIndex = 146;
            this.DLCfield.TextChanged += new System.EventHandler(this.DLCfield_TextChanged);
            // 
            // DLC_ok_BTN
            // 
            this.DLC_ok_BTN.Enabled = false;
            this.DLC_ok_BTN.Location = new System.Drawing.Point(151, 288);
            this.DLC_ok_BTN.Name = "DLC_ok_BTN";
            this.DLC_ok_BTN.Size = new System.Drawing.Size(100, 30);
            this.DLC_ok_BTN.TabIndex = 145;
            this.DLC_ok_BTN.Text = "ОК";
            this.DLC_ok_BTN.UseVisualStyleBackColor = true;
            this.DLC_ok_BTN.Click += new System.EventHandler(this.DLC_ok_BTN_Click);
            // 
            // repeatBTN
            // 
            this.repeatBTN.Enabled = false;
            this.repeatBTN.Location = new System.Drawing.Point(581, 256);
            this.repeatBTN.Name = "repeatBTN";
            this.repeatBTN.Size = new System.Drawing.Size(100, 30);
            this.repeatBTN.TabIndex = 144;
            this.repeatBTN.Text = "Repeat";
            this.repeatBTN.UseVisualStyleBackColor = true;
            this.repeatBTN.Click += new System.EventHandler(this.RepeatBTN_Click);
            // 
            // undoBTN
            // 
            this.undoBTN.Location = new System.Drawing.Point(381, 256);
            this.undoBTN.Name = "undoBTN";
            this.undoBTN.Size = new System.Drawing.Size(100, 30);
            this.undoBTN.TabIndex = 143;
            this.undoBTN.Text = "Undo";
            this.undoBTN.UseVisualStyleBackColor = true;
            this.undoBTN.Click += new System.EventHandler(this.UndoBTN_Click);
            // 
            // exportBTN
            // 
            this.exportBTN.Location = new System.Drawing.Point(802, 423);
            this.exportBTN.Name = "exportBTN";
            this.exportBTN.Size = new System.Drawing.Size(149, 46);
            this.exportBTN.TabIndex = 142;
            this.exportBTN.Text = "export";
            this.exportBTN.UseVisualStyleBackColor = true;
            this.exportBTN.Click += new System.EventHandler(this.ExportBTN_Click);
            // 
            // dataField
            // 
            this.dataField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataField.FormattingEnabled = true;
            this.dataField.Location = new System.Drawing.Point(381, 226);
            this.dataField.Name = "dataField";
            this.dataField.Size = new System.Drawing.Size(300, 24);
            this.dataField.TabIndex = 141;
            this.dataField.SelectedIndexChanged += new System.EventHandler(this.DataField_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 140;
            this.label8.Text = "Текущие значения";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.sq2Button);
            this.groupBox.Controls.Add(this.dispButton);
            this.groupBox.Controls.Add(this.sumButton);
            this.groupBox.Controls.Add(this.powButton);
            this.groupBox.Controls.Add(this.subButton);
            this.groupBox.Controls.Add(this.medButton);
            this.groupBox.Controls.Add(this.sqButton);
            this.groupBox.Controls.Add(this.pow2Button);
            this.groupBox.Controls.Add(this.multButton);
            this.groupBox.Controls.Add(this.factButton);
            this.groupBox.Controls.Add(this.logButton);
            this.groupBox.Controls.Add(this.divButton);
            this.groupBox.Location = new System.Drawing.Point(71, 29);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(273, 193);
            this.groupBox.TabIndex = 174;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Действия";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 521);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.DLCfield);
            this.Controls.Add(this.DLC_ok_BTN);
            this.Controls.Add(this.repeatBTN);
            this.Controls.Add(this.undoBTN);
            this.Controls.Add(this.exportBTN);
            this.Controls.Add(this.dataField);
            this.Controls.Add(this.label8);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton dispButton;
        private System.Windows.Forms.RadioButton powButton;
        private System.Windows.Forms.RadioButton medButton;
        private System.Windows.Forms.RadioButton pow2Button;
        private System.Windows.Forms.RadioButton factButton;
        private System.Windows.Forms.RadioButton divButton;
        private System.Windows.Forms.RadioButton logButton;
        private System.Windows.Forms.RadioButton multButton;
        private System.Windows.Forms.RadioButton sqButton;
        private System.Windows.Forms.RadioButton subButton;
        private System.Windows.Forms.RadioButton sq2Button;
        private System.Windows.Forms.RadioButton sumButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.TextBox DLCfield;
        private System.Windows.Forms.Button DLC_ok_BTN;
        private System.Windows.Forms.Button repeatBTN;
        private System.Windows.Forms.Button undoBTN;
        private System.Windows.Forms.Button exportBTN;
        private System.Windows.Forms.ComboBox dataField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBox;
    }
}