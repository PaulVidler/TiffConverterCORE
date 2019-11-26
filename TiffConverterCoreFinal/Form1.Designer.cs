namespace TiffConverterCoreFinal
{ 
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.input = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Button();
            this.make_KMZ = new System.Windows.Forms.Button();
            this.inputFolderText = new System.Windows.Forms.TextBox();
            this.outputFolderText = new System.Windows.Forms.TextBox();
            this.inputBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.outputBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.35165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.64835F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.input, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.output, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.make_KMZ, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputFolderText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputFolderText, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 229);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // input
            // 
            this.input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input.Location = new System.Drawing.Point(5, 29);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 0;
            this.input.Text = "Input";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // output
            // 
            this.output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.output.Location = new System.Drawing.Point(5, 111);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(75, 23);
            this.output.TabIndex = 1;
            this.output.Text = "Output";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // make_KMZ
            // 
            this.make_KMZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.make_KMZ.Location = new System.Drawing.Point(187, 185);
            this.make_KMZ.Name = "make_KMZ";
            this.make_KMZ.Size = new System.Drawing.Size(75, 23);
            this.make_KMZ.TabIndex = 2;
            this.make_KMZ.Text = "Make KMZ";
            this.make_KMZ.UseVisualStyleBackColor = true;
            this.make_KMZ.Click += new System.EventHandler(this.make_KMZ_Click);
            // 
            // inputFolderText
            // 
            this.inputFolderText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputFolderText.Location = new System.Drawing.Point(88, 31);
            this.inputFolderText.Name = "inputFolderText";
            this.inputFolderText.Size = new System.Drawing.Size(273, 20);
            this.inputFolderText.TabIndex = 3;
            this.inputFolderText.TextChanged += new System.EventHandler(this.inputFolderText_TextChanged);
            // 
            // outputFolderText
            // 
            this.outputFolderText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputFolderText.Location = new System.Drawing.Point(88, 113);
            this.outputFolderText.Name = "outputFolderText";
            this.outputFolderText.Size = new System.Drawing.Size(273, 20);
            this.outputFolderText.TabIndex = 4;
            this.outputFolderText.TextChanged += new System.EventHandler(this.outputFolderText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 229);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "GeoTIFF Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.Button make_KMZ;
        private System.Windows.Forms.TextBox inputFolderText;
        private System.Windows.Forms.TextBox outputFolderText;
        private System.Windows.Forms.FolderBrowserDialog inputBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog outputBrowserDialog2;
    }
}
