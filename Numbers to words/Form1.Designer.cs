namespace Numbers_to_words
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
            this.convertbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.MaskedTextBox();
            this.wordsBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertbutton
            // 
            this.convertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertbutton.Location = new System.Drawing.Point(505, 200);
            this.convertbutton.Margin = new System.Windows.Forms.Padding(4);
            this.convertbutton.Name = "convertbutton";
            this.convertbutton.Size = new System.Drawing.Size(210, 72);
            this.convertbutton.TabIndex = 0;
            this.convertbutton.Text = "Վերափոխել";
            this.convertbutton.UseVisualStyleBackColor = true;
            this.convertbutton.Click += new System.EventHandler(this.convertbutton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Թիվը";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.HidePromptOnLeave = true;
            this.number.Location = new System.Drawing.Point(460, 106);
            this.number.Mask = "000000000000000";
            this.number.Name = "number";
            this.number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.number.Size = new System.Drawing.Size(308, 49);
            this.number.TabIndex = 4;
            this.number.ValidatingType = typeof(int);
            this.number.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.number_MaskInputRejected);
            // 
            // wordsBox
            // 
            this.wordsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsBox.Location = new System.Drawing.Point(307, 371);
            this.wordsBox.Name = "wordsBox";
            this.wordsBox.ReadOnly = true;
            this.wordsBox.Size = new System.Drawing.Size(616, 156);
            this.wordsBox.TabIndex = 5;
            this.wordsBox.Text = "";
            this.wordsBox.TextChanged += new System.EventHandler(this.wordsBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Թիվը բառերով";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1243, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordsBox);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertbutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Numbers to words";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox number;
        private System.Windows.Forms.RichTextBox wordsBox;
        private System.Windows.Forms.Label label2;
    }
}

