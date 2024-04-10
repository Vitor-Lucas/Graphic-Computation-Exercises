namespace Line_Drawer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.patternComboBox = new System.Windows.Forms.ComboBox();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.functionLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.RectangleCheckBox = new System.Windows.Forms.CheckBox();
            this.RedTextBox = new System.Windows.Forms.TextBox();
            this.GreenTextBox = new System.Windows.Forms.TextBox();
            this.BlueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // patternComboBox
            // 
            this.patternComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patternComboBox.FormattingEnabled = true;
            this.patternComboBox.Items.AddRange(new object[] {
            "Nenhum",
            "Linha Sólida",
            "Linha Tracejada",
            "Linha Traço ponto",
            "Linha Traço dois pontos",
            "Linha Pontilhada"});
            this.patternComboBox.Location = new System.Drawing.Point(12, 380);
            this.patternComboBox.Name = "patternComboBox";
            this.patternComboBox.Size = new System.Drawing.Size(167, 28);
            this.patternComboBox.TabIndex = 0;
            this.patternComboBox.Text = "Nenhum";
            this.patternComboBox.SelectedIndexChanged += new System.EventHandler(this.patternComboBox_SelectedIndexChanged);
            // 
            // widthUpDown
            // 
            this.widthUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.widthUpDown.Location = new System.Drawing.Point(185, 380);
            this.widthUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(40, 26);
            this.widthUpDown.TabIndex = 1;
            this.widthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthUpDown.ValueChanged += new System.EventHandler(this.widthUpDown_ValueChanged);
            // 
            // functionLabel
            // 
            this.functionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.functionLabel.AutoSize = true;
            this.functionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.functionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionLabel.Location = new System.Drawing.Point(231, 376);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(182, 34);
            this.functionLabel.TabIndex = 2;
            this.functionLabel.Text = "f(x) = mx + b";
            // 
            // distanceLabel
            // 
            this.distanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(227, 417);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(80, 20);
            this.distanceLabel.TabIndex = 3;
            this.distanceLabel.Text = "Distance: ";
            // 
            // RectangleCheckBox
            // 
            this.RectangleCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleCheckBox.AutoSize = true;
            this.RectangleCheckBox.Location = new System.Drawing.Point(12, 417);
            this.RectangleCheckBox.Name = "RectangleCheckBox";
            this.RectangleCheckBox.Size = new System.Drawing.Size(108, 24);
            this.RectangleCheckBox.TabIndex = 4;
            this.RectangleCheckBox.Text = "Rectangle";
            this.RectangleCheckBox.UseVisualStyleBackColor = true;
            this.RectangleCheckBox.CheckedChanged += new System.EventHandler(this.RectangleCheckBox_CheckedChanged);
            // 
            // RedTextBox
            // 
            this.RedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RedTextBox.Location = new System.Drawing.Point(39, 284);
            this.RedTextBox.Name = "RedTextBox";
            this.RedTextBox.Size = new System.Drawing.Size(45, 26);
            this.RedTextBox.TabIndex = 5;
            this.RedTextBox.TextChanged += new System.EventHandler(this.RedTextBox_TextChanged);
            // 
            // GreenTextBox
            // 
            this.GreenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GreenTextBox.Location = new System.Drawing.Point(39, 316);
            this.GreenTextBox.Name = "GreenTextBox";
            this.GreenTextBox.Size = new System.Drawing.Size(45, 26);
            this.GreenTextBox.TabIndex = 6;
            this.GreenTextBox.TextChanged += new System.EventHandler(this.GreenTextBox_TextChanged);
            // 
            // BlueTextBox
            // 
            this.BlueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BlueTextBox.Location = new System.Drawing.Point(39, 348);
            this.BlueTextBox.Name = "BlueTextBox";
            this.BlueTextBox.Size = new System.Drawing.Size(45, 26);
            this.BlueTextBox.TabIndex = 7;
            this.BlueTextBox.TextChanged += new System.EventHandler(this.BlueTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "G";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlueTextBox);
            this.Controls.Add(this.GreenTextBox);
            this.Controls.Add(this.RedTextBox);
            this.Controls.Add(this.RectangleCheckBox);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.widthUpDown);
            this.Controls.Add(this.patternComboBox);
            this.Name = "Form1";
            this.Text = "Line Drawer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox patternComboBox;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.CheckBox RectangleCheckBox;
        private System.Windows.Forms.TextBox RedTextBox;
        private System.Windows.Forms.TextBox GreenTextBox;
        private System.Windows.Forms.TextBox BlueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

