namespace lab1_2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.next1 = new System.Windows.Forms.Button();
            this.can1 = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скільки інтервалів треба перемножити?";
            // 
            // next1
            // 
            this.next1.Location = new System.Drawing.Point(57, 145);
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(171, 39);
            this.next1.TabIndex = 1;
            this.next1.Text = "Далі";
            this.next1.UseVisualStyleBackColor = true;
            this.next1.Click += new System.EventHandler(this.next1_Click);
            // 
            // can1
            // 
            this.can1.Location = new System.Drawing.Point(282, 145);
            this.can1.Name = "can1";
            this.can1.Size = new System.Drawing.Size(171, 39);
            this.can1.TabIndex = 1;
            this.can1.Text = "Скасувати";
            this.can1.UseVisualStyleBackColor = true;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(373, 68);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(52, 31);
            this.n.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 214);
            this.Controls.Add(this.n);
            this.Controls.Add(this.can1);
            this.Controls.Add(this.next1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button next1;
        private System.Windows.Forms.Button can1;
        public System.Windows.Forms.TextBox n;
    }
}