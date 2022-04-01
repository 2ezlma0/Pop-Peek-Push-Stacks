
namespace PopPeekPush
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
            this.arrayLabel = new System.Windows.Forms.Label();
            this.popButton = new System.Windows.Forms.Button();
            this.peekButton = new System.Windows.Forms.Button();
            this.pushButton = new System.Windows.Forms.Button();
            this.numInput = new System.Windows.Forms.NumericUpDown();
            this.exportButton = new System.Windows.Forms.Button();
            this.factorButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).BeginInit();
            this.SuspendLayout();
            // 
            // arrayLabel
            // 
            this.arrayLabel.AutoSize = true;
            this.arrayLabel.Location = new System.Drawing.Point(146, 103);
            this.arrayLabel.Name = "arrayLabel";
            this.arrayLabel.Size = new System.Drawing.Size(103, 15);
            this.arrayLabel.TabIndex = 0;
            this.arrayLabel.Text = "intArray contains: ";
            this.arrayLabel.Click += new System.EventHandler(this.arrayLabel_Click);
            // 
            // popButton
            // 
            this.popButton.Location = new System.Drawing.Point(91, 214);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(139, 86);
            this.popButton.TabIndex = 1;
            this.popButton.Text = "POP";
            this.popButton.UseVisualStyleBackColor = true;
            this.popButton.Click += new System.EventHandler(this.popButton_Click);
            // 
            // peekButton
            // 
            this.peekButton.Location = new System.Drawing.Point(328, 214);
            this.peekButton.Name = "peekButton";
            this.peekButton.Size = new System.Drawing.Size(143, 86);
            this.peekButton.TabIndex = 2;
            this.peekButton.Text = "PEEK";
            this.peekButton.UseVisualStyleBackColor = true;
            this.peekButton.Click += new System.EventHandler(this.peekButton_Click);
            // 
            // pushButton
            // 
            this.pushButton.Location = new System.Drawing.Point(578, 214);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(136, 86);
            this.pushButton.TabIndex = 3;
            this.pushButton.Text = "PUSH";
            this.pushButton.UseVisualStyleBackColor = true;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(578, 326);
            this.numInput.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.numInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(136, 23);
            this.numInput.TabIndex = 4;
            this.numInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(328, 404);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(143, 34);
            this.exportButton.TabIndex = 5;
            this.exportButton.Text = "EXPORT";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // factorButton
            // 
            this.factorButton.Location = new System.Drawing.Point(400, 326);
            this.factorButton.Name = "factorButton";
            this.factorButton.Size = new System.Drawing.Size(156, 23);
            this.factorButton.TabIndex = 6;
            this.factorButton.Text = "FIND FACTORS OF";
            this.factorButton.UseVisualStyleBackColor = true;
            this.factorButton.Click += new System.EventHandler(this.factorButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(91, 345);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(95, 41);
            this.randomButton.TabIndex = 7;
            this.randomButton.Text = "RANDOMISE ARRAY";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "(Number in here determines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = " amount of max digits used in";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = " randomised array)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.factorButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.pushButton);
            this.Controls.Add(this.peekButton);
            this.Controls.Add(this.popButton);
            this.Controls.Add(this.arrayLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arrayLabel;
        private System.Windows.Forms.Button popButton;
        private System.Windows.Forms.Button peekButton;
        private System.Windows.Forms.Button pushButton;
        private System.Windows.Forms.NumericUpDown numInput;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button factorButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

