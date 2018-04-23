namespace XPOReport
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
            this.btnOpenEud = new System.Windows.Forms.Button();
            this.btnNewXpoReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenEud
            // 
            this.btnOpenEud.Location = new System.Drawing.Point(12, 12);
            this.btnOpenEud.Name = "btnOpenEud";
            this.btnOpenEud.Size = new System.Drawing.Size(180, 23);
            this.btnOpenEud.TabIndex = 1;
            this.btnOpenEud.Text = "Open End-User Report Designer...";
            this.btnOpenEud.UseVisualStyleBackColor = true;
            this.btnOpenEud.Click += new System.EventHandler(this.btnOpenEud_Click);
            // 
            // btnNewXpoReport
            // 
            this.btnNewXpoReport.Location = new System.Drawing.Point(12, 41);
            this.btnNewXpoReport.Name = "btnNewXpoReport";
            this.btnNewXpoReport.Size = new System.Drawing.Size(180, 23);
            this.btnNewXpoReport.TabIndex = 0;
            this.btnNewXpoReport.Text = "Design New Xpo Report...";
            this.btnNewXpoReport.UseVisualStyleBackColor = true;
            this.btnNewXpoReport.Click += new System.EventHandler(this.btnNewXpoReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 79);
            this.Controls.Add(this.btnOpenEud);
            this.Controls.Add(this.btnNewXpoReport);
            this.Name = "Form1";
            this.Text = "Xpo Report Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenEud;
        private System.Windows.Forms.Button btnNewXpoReport;

    }
}

