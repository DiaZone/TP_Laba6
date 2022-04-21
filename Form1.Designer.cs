namespace TP6
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
            this.NumOfVarBar = new System.Windows.Forms.TrackBar();
            this.NumOfVarLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CoordTextBox = new System.Windows.Forms.TextBox();
            this.FunListBox = new System.Windows.Forms.ListBox();
            this.XListBox = new System.Windows.Forms.ListBox();
            this.YListBox = new System.Windows.Forms.ListBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.GetFuncButton = new System.Windows.Forms.Button();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RewriteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfVarBar)).BeginInit();
            this.SuspendLayout();
            // 
            // NumOfVarBar
            // 
            this.NumOfVarBar.LargeChange = 1;
            this.NumOfVarBar.Location = new System.Drawing.Point(23, 43);
            this.NumOfVarBar.Maximum = 3;
            this.NumOfVarBar.Minimum = 1;
            this.NumOfVarBar.Name = "NumOfVarBar";
            this.NumOfVarBar.Size = new System.Drawing.Size(103, 45);
            this.NumOfVarBar.TabIndex = 0;
            this.NumOfVarBar.Value = 1;
            this.NumOfVarBar.Scroll += new System.EventHandler(this.NumOfVarBar_Scroll);
            // 
            // NumOfVarLabel
            // 
            this.NumOfVarLabel.AutoSize = true;
            this.NumOfVarLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumOfVarLabel.Location = new System.Drawing.Point(133, 43);
            this.NumOfVarLabel.Name = "NumOfVarLabel";
            this.NumOfVarLabel.Size = new System.Drawing.Size(22, 25);
            this.NumOfVarLabel.TabIndex = 1;
            this.NumOfVarLabel.Text = "1";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(36, 82);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(97, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CoordTextBox
            // 
            this.CoordTextBox.Location = new System.Drawing.Point(37, 312);
            this.CoordTextBox.Name = "CoordTextBox";
            this.CoordTextBox.Size = new System.Drawing.Size(156, 23);
            this.CoordTextBox.TabIndex = 3;
            // 
            // FunListBox
            // 
            this.FunListBox.FormattingEnabled = true;
            this.FunListBox.ItemHeight = 15;
            this.FunListBox.Location = new System.Drawing.Point(192, 43);
            this.FunListBox.Name = "FunListBox";
            this.FunListBox.Size = new System.Drawing.Size(209, 109);
            this.FunListBox.TabIndex = 4;
            // 
            // XListBox
            // 
            this.XListBox.FormattingEnabled = true;
            this.XListBox.ItemHeight = 15;
            this.XListBox.Location = new System.Drawing.Point(23, 155);
            this.XListBox.Name = "XListBox";
            this.XListBox.Size = new System.Drawing.Size(68, 124);
            this.XListBox.TabIndex = 5;
            // 
            // YListBox
            // 
            this.YListBox.FormattingEnabled = true;
            this.YListBox.ItemHeight = 15;
            this.YListBox.Location = new System.Drawing.Point(97, 155);
            this.YListBox.Name = "YListBox";
            this.YListBox.Size = new System.Drawing.Size(66, 124);
            this.YListBox.TabIndex = 6;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(23, 126);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(140, 23);
            this.ReadButton.TabIndex = 7;
            this.ReadButton.Text = "Получить координаты";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // GetFuncButton
            // 
            this.GetFuncButton.Location = new System.Drawing.Point(199, 312);
            this.GetFuncButton.Name = "GetFuncButton";
            this.GetFuncButton.Size = new System.Drawing.Size(75, 23);
            this.GetFuncButton.TabIndex = 8;
            this.GetFuncButton.Text = "Получить";
            this.GetFuncButton.UseVisualStyleBackColor = true;
            this.GetFuncButton.Click += new System.EventHandler(this.GetFuncButton_Click);
            // 
            // FilesListBox
            // 
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 15;
            this.FilesListBox.Location = new System.Drawing.Point(192, 185);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(209, 94);
            this.FilesListBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Расчеты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Наборы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Файлы:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Значение по координатам:";
            // 
            // RewriteButton
            // 
            this.RewriteButton.Location = new System.Drawing.Point(37, 353);
            this.RewriteButton.Name = "RewriteButton";
            this.RewriteButton.Size = new System.Drawing.Size(364, 23);
            this.RewriteButton.TabIndex = 14;
            this.RewriteButton.Text = "Создать/Очистить файлы";
            this.RewriteButton.UseVisualStyleBackColor = true;
            this.RewriteButton.Click += new System.EventHandler(this.RewriteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(431, 394);
            this.Controls.Add(this.RewriteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.GetFuncButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.YListBox);
            this.Controls.Add(this.XListBox);
            this.Controls.Add(this.FunListBox);
            this.Controls.Add(this.CoordTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.NumOfVarLabel);
            this.Controls.Add(this.NumOfVarBar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumOfVarBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar NumOfVarBar;
        private Label NumOfVarLabel;
        private Button CalculateButton;
        private TextBox CoordTextBox;
        private ListBox FunListBox;
        private ListBox XListBox;
        private ListBox YListBox;
        private Button ReadButton;
        private Button GetFuncButton;
        private ListBox FilesListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button RewriteButton;
    }
}