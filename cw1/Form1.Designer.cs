namespace cw1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtShift = new TextBox();
            txtEncoded = new TextBox();
            btnEncode = new Button();
            btnSort = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 70);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 119);
            label2.Name = "label2";
            label2.Size = new Size(314, 32);
            label2.TabIndex = 1;
            label2.Text = "Enter Shift Value (-25 to 25):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 166);
            label3.Name = "label3";
            label3.Size = new Size(215, 32);
            label3.TabIndex = 2;
            label3.Text = "Encoded Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(234, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 39);
            txtPassword.TabIndex = 3;
            // 
            // txtShift
            // 
            txtShift.Location = new Point(370, 118);
            txtShift.Name = "txtShift";
            txtShift.Size = new Size(200, 39);
            txtShift.TabIndex = 4;
            // 
            // txtEncoded
            // 
            txtEncoded.Location = new Point(271, 163);
            txtEncoded.Name = "txtEncoded";
            txtEncoded.ReadOnly = true;
            txtEncoded.Size = new Size(200, 39);
            txtEncoded.TabIndex = 5;
            txtEncoded.TextChanged += txtEncoded_TextChanged;
            // 
            // btnEncode
            // 
            btnEncode.Location = new Point(491, 271);
            btnEncode.Name = "btnEncode";
            btnEncode.Size = new Size(150, 46);
            btnEncode.TabIndex = 6;
            btnEncode.Text = "Encode";
            btnEncode.UseVisualStyleBackColor = true;
            btnEncode.Click += btnEncode_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(115, 271);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(150, 46);
            btnSort.TabIndex = 7;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 474);
            Controls.Add(btnSort);
            Controls.Add(btnEncode);
            Controls.Add(txtEncoded);
            Controls.Add(txtShift);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtShift;
        private TextBox txtEncoded;
        private Button btnEncode;
        private Button btnSort;
    }
}
