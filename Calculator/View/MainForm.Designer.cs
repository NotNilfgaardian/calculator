namespace Calculator
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
            this.exportField = new System.Windows.Forms.TextBox();
            this.count_label = new System.Windows.Forms.Label();
            this.DLCfield = new System.Windows.Forms.TextBox();
            this.DLC_ok_BTN = new System.Windows.Forms.Button();
            this.repeatBTN = new System.Windows.Forms.Button();
            this.undoBTN = new System.Windows.Forms.Button();
            this.exportBTN = new System.Windows.Forms.Button();
            this.dataField = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dispButton
            // 
            this.dispButton.AutoSize = true;
            this.dispButton.Location = new System.Drawing.Point(145, 193);
            this.dispButton.Name = "dispButton";
            this.dispButton.Size = new System.Drawing.Size(110, 21);
            this.dispButton.TabIndex = 173;
            this.dispButton.TabStop = true;
            this.dispButton.Text = "Отклонение";
            this.dispButton.UseVisualStyleBackColor = true;
            // 
            // powButton
            // 
            this.powButton.AutoSize = true;
            this.powButton.Location = new System.Drawing.Point(29, 193);
            this.powButton.Name = "powButton";
            this.powButton.Size = new System.Drawing.Size(44, 21);
            this.powButton.TabIndex = 172;
            this.powButton.TabStop = true;
            this.powButton.Text = "^n";
            this.powButton.UseVisualStyleBackColor = true;
            // 
            // medButton
            // 
            this.medButton.AutoSize = true;
            this.medButton.Location = new System.Drawing.Point(145, 166);
            this.medButton.Name = "medButton";
            this.medButton.Size = new System.Drawing.Size(88, 21);
            this.medButton.TabIndex = 171;
            this.medButton.TabStop = true;
            this.medButton.Text = "Медиана";
            this.medButton.UseVisualStyleBackColor = true;
            // 
            // pow2Button
            // 
            this.pow2Button.AutoSize = true;
            this.pow2Button.Location = new System.Drawing.Point(29, 166);
            this.pow2Button.Name = "pow2Button";
            this.pow2Button.Size = new System.Drawing.Size(44, 21);
            this.pow2Button.TabIndex = 170;
            this.pow2Button.TabStop = true;
            this.pow2Button.Text = "^2";
            this.pow2Button.UseVisualStyleBackColor = true;
            // 
            // factButton
            // 
            this.factButton.AutoSize = true;
            this.factButton.Location = new System.Drawing.Point(145, 140);
            this.factButton.Name = "factButton";
            this.factButton.Size = new System.Drawing.Size(32, 21);
            this.factButton.TabIndex = 169;
            this.factButton.TabStop = true;
            this.factButton.Text = "!";
            this.factButton.UseVisualStyleBackColor = true;
            // 
            // divButton
            // 
            this.divButton.AutoSize = true;
            this.divButton.Location = new System.Drawing.Point(29, 140);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(41, 21);
            this.divButton.TabIndex = 168;
            this.divButton.TabStop = true;
            this.divButton.Text = "/n";
            this.divButton.UseVisualStyleBackColor = true;
            // 
            // logButton
            // 
            this.logButton.AutoSize = true;
            this.logButton.Location = new System.Drawing.Point(145, 113);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(82, 21);
            this.logButton.TabIndex = 167;
            this.logButton.TabStop = true;
            this.logButton.Text = "log_n(..)";
            this.logButton.UseVisualStyleBackColor = true;
            // 
            // multButton
            // 
            this.multButton.AutoSize = true;
            this.multButton.Location = new System.Drawing.Point(29, 113);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(42, 21);
            this.multButton.TabIndex = 166;
            this.multButton.TabStop = true;
            this.multButton.Text = "*n";
            this.multButton.UseVisualStyleBackColor = true;
            // 
            // sqButton
            // 
            this.sqButton.AutoSize = true;
            this.sqButton.Location = new System.Drawing.Point(145, 86);
            this.sqButton.Name = "sqButton";
            this.sqButton.Size = new System.Drawing.Size(45, 21);
            this.sqButton.TabIndex = 165;
            this.sqButton.TabStop = true;
            this.sqButton.Text = "n√";
            this.sqButton.UseVisualStyleBackColor = true;
            // 
            // subButton
            // 
            this.subButton.AutoSize = true;
            this.subButton.Location = new System.Drawing.Point(29, 86);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(42, 21);
            this.subButton.TabIndex = 164;
            this.subButton.TabStop = true;
            this.subButton.Text = "-n";
            this.subButton.UseVisualStyleBackColor = true;
            // 
            // sq2Button
            // 
            this.sq2Button.AutoSize = true;
            this.sq2Button.Location = new System.Drawing.Point(145, 59);
            this.sq2Button.Name = "sq2Button";
            this.sq2Button.Size = new System.Drawing.Size(37, 21);
            this.sq2Button.TabIndex = 163;
            this.sq2Button.TabStop = true;
            this.sq2Button.Text = "√";
            this.sq2Button.UseVisualStyleBackColor = true;
            // 
            // sumButton
            // 
            this.sumButton.AutoSize = true;
            this.sumButton.Location = new System.Drawing.Point(29, 59);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(45, 21);
            this.sumButton.TabIndex = 162;
            this.sumButton.TabStop = true;
            this.sumButton.Text = "+n";
            this.sumButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 161;
            // 
            // exportField
            // 
            this.exportField.Location = new System.Drawing.Point(413, 402);
            this.exportField.Margin = new System.Windows.Forms.Padding(4);
            this.exportField.Name = "exportField";
            this.exportField.Size = new System.Drawing.Size(308, 22);
            this.exportField.TabIndex = 160;
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(613, 193);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(28, 17);
            this.count_label.TabIndex = 159;
            this.count_label.Text = "0/0";
            // 
            // DLCfield
            // 
            this.DLCfield.Enabled = false;
            this.DLCfield.Location = new System.Drawing.Point(28, 239);
            this.DLCfield.Margin = new System.Windows.Forms.Padding(4);
            this.DLCfield.Name = "DLCfield";
            this.DLCfield.Size = new System.Drawing.Size(206, 22);
            this.DLCfield.TabIndex = 146;
            // 
            // DLC_ok_BTN
            // 
            this.DLC_ok_BTN.Location = new System.Drawing.Point(77, 268);
            this.DLC_ok_BTN.Name = "DLC_ok_BTN";
            this.DLC_ok_BTN.Size = new System.Drawing.Size(100, 30);
            this.DLC_ok_BTN.TabIndex = 145;
            this.DLC_ok_BTN.Text = "ОК";
            this.DLC_ok_BTN.UseVisualStyleBackColor = true;
            // 
            // repeatBTN
            // 
            this.repeatBTN.Location = new System.Drawing.Point(507, 223);
            this.repeatBTN.Name = "repeatBTN";
            this.repeatBTN.Size = new System.Drawing.Size(100, 30);
            this.repeatBTN.TabIndex = 144;
            this.repeatBTN.Text = "Repeat";
            this.repeatBTN.UseVisualStyleBackColor = true;
            // 
            // undoBTN
            // 
            this.undoBTN.Location = new System.Drawing.Point(307, 223);
            this.undoBTN.Name = "undoBTN";
            this.undoBTN.Size = new System.Drawing.Size(100, 30);
            this.undoBTN.TabIndex = 143;
            this.undoBTN.Text = "Undo";
            this.undoBTN.UseVisualStyleBackColor = true;
            // 
            // exportBTN
            // 
            this.exportBTN.Location = new System.Drawing.Point(728, 390);
            this.exportBTN.Name = "exportBTN";
            this.exportBTN.Size = new System.Drawing.Size(149, 46);
            this.exportBTN.TabIndex = 142;
            this.exportBTN.Text = "export";
            this.exportBTN.UseVisualStyleBackColor = true;
            // 
            // dataField
            // 
            this.dataField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataField.FormattingEnabled = true;
            this.dataField.Location = new System.Drawing.Point(307, 193);
            this.dataField.Name = "dataField";
            this.dataField.Size = new System.Drawing.Size(300, 24);
            this.dataField.TabIndex = 141;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 140;
            this.label8.Text = "текущие значения";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 483);
            this.Controls.Add(this.dispButton);
            this.Controls.Add(this.powButton);
            this.Controls.Add(this.medButton);
            this.Controls.Add(this.pow2Button);
            this.Controls.Add(this.factButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.sqButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.sq2Button);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exportField);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.DLCfield);
            this.Controls.Add(this.DLC_ok_BTN);
            this.Controls.Add(this.repeatBTN);
            this.Controls.Add(this.undoBTN);
            this.Controls.Add(this.exportBTN);
            this.Controls.Add(this.dataField);
            this.Controls.Add(this.label8);
            this.Name = "MainForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox exportField;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.TextBox DLCfield;
        private System.Windows.Forms.Button DLC_ok_BTN;
        private System.Windows.Forms.Button repeatBTN;
        private System.Windows.Forms.Button undoBTN;
        private System.Windows.Forms.Button exportBTN;
        private System.Windows.Forms.ComboBox dataField;
        private System.Windows.Forms.Label label8;
    }
}