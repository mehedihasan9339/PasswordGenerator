namespace PasswordGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnUpload = new Button();
            btnDownload = new Button();
            dataGridViewResults = new DataGridView();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.LightSkyBlue;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpload.Location = new Point(14, 14);
            btnUpload.Margin = new Padding(4, 3, 4, 3);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(140, 46);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload Excel";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.LightCoral;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDownload.Location = new Point(596, 14);
            btnDownload.Margin = new Padding(4, 3, 4, 3);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(140, 46);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download Results";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.AllowUserToAddRows = false;
            dataGridViewResults.AllowUserToDeleteRows = false;
            dataGridViewResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(14, 81);
            dataGridViewResults.Margin = new Padding(4, 3, 4, 3);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.ReadOnly = true;
            dataGridViewResults.Size = new Size(722, 494);
            dataGridViewResults.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(295, 587);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(157, 19);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "OPUS Technology Ltd.";
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 615);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridViewResults);
            Controls.Add(btnDownload);
            Controls.Add(btnUpload);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private LinkLabel linkLabel1;
    }
}
