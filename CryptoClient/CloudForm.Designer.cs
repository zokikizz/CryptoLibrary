namespace CryptoClient
{
    partial class CloudForm
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
            this.cbClient = new System.Windows.Forms.CheckedListBox();
            this.cbCloud = new System.Windows.Forms.CheckedListBox();
            this.btnDownLoad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpload = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDeleteClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDeleteCloud = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(12, 99);
            this.cbClient.Name = "cbClient";
            this.cbClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbClient.Size = new System.Drawing.Size(610, 154);
            this.cbClient.TabIndex = 0;
            // 
            // cbCloud
            // 
            this.cbCloud.FormattingEnabled = true;
            this.cbCloud.Location = new System.Drawing.Point(642, 99);
            this.cbCloud.Name = "cbCloud";
            this.cbCloud.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCloud.Size = new System.Drawing.Size(617, 154);
            this.cbCloud.TabIndex = 1;
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownLoad.Depth = 0;
            this.btnDownLoad.Icon = null;
            this.btnDownLoad.Location = new System.Drawing.Point(958, 259);
            this.btnDownLoad.MouseState = MaterialSkin.MouseState.Hover;
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Primary = true;
            this.btnDownLoad.Size = new System.Drawing.Size(301, 51);
            this.btnDownLoad.TabIndex = 2;
            this.btnDownLoad.Text = "Download checked items";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpload.Depth = 0;
            this.btnUpload.Icon = null;
            this.btnUpload.Location = new System.Drawing.Point(319, 259);
            this.btnUpload.MouseState = MaterialSkin.MouseState.Hover;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Primary = true;
            this.btnUpload.Size = new System.Drawing.Size(303, 51);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload Checked Items";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.Hover;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 23);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "On client side";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(642, 73);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.Hover;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(93, 23);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "On Cloud side";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteClient.Depth = 0;
            this.btnDeleteClient.Icon = null;
            this.btnDeleteClient.Location = new System.Drawing.Point(12, 259);
            this.btnDeleteClient.MouseState = MaterialSkin.MouseState.Hover;
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Primary = true;
            this.btnDeleteClient.Size = new System.Drawing.Size(301, 51);
            this.btnDeleteClient.TabIndex = 7;
            this.btnDeleteClient.Text = "Delete checked files Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnDeleteCloud
            // 
            this.btnDeleteCloud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteCloud.Depth = 0;
            this.btnDeleteCloud.Icon = null;
            this.btnDeleteCloud.Location = new System.Drawing.Point(642, 259);
            this.btnDeleteCloud.MouseState = MaterialSkin.MouseState.Hover;
            this.btnDeleteCloud.Name = "btnDeleteCloud";
            this.btnDeleteCloud.Primary = true;
            this.btnDeleteCloud.Size = new System.Drawing.Size(310, 51);
            this.btnDeleteCloud.TabIndex = 8;
            this.btnDeleteCloud.Text = "Delete checked files Cloud";
            this.btnDeleteCloud.UseVisualStyleBackColor = true;
            this.btnDeleteCloud.Click += new System.EventHandler(this.btnDeleteCloud_Click);
            // 
            // CloudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 325);
            this.Controls.Add(this.btnDeleteCloud);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnDownLoad);
            this.Controls.Add(this.cbCloud);
            this.Controls.Add(this.cbClient);
            this.MaximumSize = new System.Drawing.Size(1271, 325);
            this.MinimumSize = new System.Drawing.Size(1271, 325);
            this.Name = "CloudForm";
            this.ShowIcon = false;
            this.Text = "Cloud Form";
            this.Load += new System.EventHandler(this.CloudForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbClient;
        private System.Windows.Forms.CheckedListBox cbCloud;
        private MaterialSkin.Controls.MaterialRaisedButton btnDownLoad;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpload;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteClient;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteCloud;
    }
}