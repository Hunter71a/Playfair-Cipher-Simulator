namespace PlayfairCipher
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
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.tbxMatrix = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.Location = new System.Drawing.Point(202, 100);
            this.tbxInput.MinimumSize = new System.Drawing.Size(200, 100);
            this.tbxInput.Multiline = true;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(586, 100);
            this.tbxInput.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnTranslate);
            this.panel1.Location = new System.Drawing.Point(12, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 44);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(650, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(190, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.Location = new System.Drawing.Point(3, 3);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(155, 38);
            this.btnTranslate.TabIndex = 3;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Text:  ";
            // 
            // tbxOutput
            // 
            this.tbxOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOutput.Location = new System.Drawing.Point(202, 230);
            this.tbxOutput.MinimumSize = new System.Drawing.Size(200, 100);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.Size = new System.Drawing.Size(586, 100);
            this.tbxOutput.TabIndex = 7;
            this.tbxOutput.TabStop = false;
            this.tbxOutput.Text = "Encoded message will appear here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Text:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cipher \"Secret\" Word:  ";
            // 
            // tbxKey
            // 
            this.tbxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKey.Location = new System.Drawing.Point(202, 51);
            this.tbxKey.MinimumSize = new System.Drawing.Size(100, 25);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(249, 26);
            this.tbxKey.TabIndex = 0;
            // 
            // tbxMatrix
            // 
            this.tbxMatrix.Font = new System.Drawing.Font("Noto Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMatrix.Location = new System.Drawing.Point(202, 444);
            this.tbxMatrix.Name = "tbxMatrix";
            this.tbxMatrix.ReadOnly = true;
            this.tbxMatrix.Size = new System.Drawing.Size(219, 195);
            this.tbxMatrix.TabIndex = 7;
            this.tbxMatrix.Text = "Code Matrix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.tbxMatrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxInput);
            this.Name = "Form1";
            this.Text = "Code Translator XL2000";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.RichTextBox tbxMatrix;
    }
}

