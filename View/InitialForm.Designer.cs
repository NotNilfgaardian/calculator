namespace View
{
    partial class InitialForm
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
            this.GoNextBTN = new System.Windows.Forms.Button();
            this.ImportBTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textField = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // GoNextBTN
            // 
            this.GoNextBTN.Enabled = false;
            this.GoNextBTN.Location = new System.Drawing.Point(318, 227);
            this.GoNextBTN.Name = "GoNextBTN";
            this.GoNextBTN.Size = new System.Drawing.Size(100, 30);
            this.GoNextBTN.TabIndex = 92;
            this.GoNextBTN.Text = "ОК";
            this.GoNextBTN.UseVisualStyleBackColor = true;
            this.GoNextBTN.Click += new System.EventHandler(this.GoNextBTN_Click);
            // 
            // ImportBTN
            // 
            this.ImportBTN.Location = new System.Drawing.Point(643, 395);
            this.ImportBTN.Name = "ImportBTN";
            this.ImportBTN.Size = new System.Drawing.Size(149, 46);
            this.ImportBTN.TabIndex = 91;
            this.ImportBTN.Text = "import";
            this.ImportBTN.UseVisualStyleBackColor = true;
            this.ImportBTN.Click += new System.EventHandler(this.ImportBTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 17);
            this.label8.TabIndex = 90;
            this.label8.Text = "введите свои значения";
            // 
            // textField
            // 
            this.textField.Location = new System.Drawing.Point(222, 198);
            this.textField.Margin = new System.Windows.Forms.Padding(4);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(300, 22);
            this.textField.TabIndex = 89;
            this.textField.TextChanged += new System.EventHandler(this.TextField_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoNextBTN);
            this.Controls.Add(this.ImportBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textField);
            this.Name = "InitialForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoNextBTN;
        private System.Windows.Forms.Button ImportBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textField;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

