
namespace ThreadsFormTime {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btShow = new System.Windows.Forms.Button();
            this.btDoNotShow = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(149, 77);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(199, 23);
            this.btShow.TabIndex = 0;
            this.btShow.Text = "zobraz";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btDoNotShow
            // 
            this.btDoNotShow.Location = new System.Drawing.Point(158, 134);
            this.btDoNotShow.Name = "btDoNotShow";
            this.btDoNotShow.Size = new System.Drawing.Size(190, 23);
            this.btDoNotShow.TabIndex = 1;
            this.btDoNotShow.Text = "nezobrazuj";
            this.btDoNotShow.UseVisualStyleBackColor = true;
            this.btDoNotShow.Click += new System.EventHandler(this.btDoNotShow_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(158, 307);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(190, 23);
            this.btEnd.TabIndex = 2;
            this.btEnd.Text = "konec";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btDoNotShow);
            this.Controls.Add(this.btShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btDoNotShow;
        private System.Windows.Forms.Button btEnd;
    }
}

