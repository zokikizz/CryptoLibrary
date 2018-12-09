namespace CryptoClient
{
    partial class CryptoClientForm
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.Materialstepper = new MaterialSkin.Controls.MaterialTabControl();
            this.SimpleSubstitution = new System.Windows.Forms.TabPage();
            this.btnEncode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDecode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbDecode = new System.Windows.Forms.TextBox();
            this.btnRandomGenerateKey = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSaveInFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDecodeFromFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSetKey = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mlbTextLable = new MaterialSkin.Controls.MaterialLabel();
            this.mlKey = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.Materialstepper.SuspendLayout();
            this.SimpleSubstitution.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.Materialstepper;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.Hover;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 38);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Materialstepper
            // 
            this.Materialstepper.Controls.Add(this.SimpleSubstitution);
            this.Materialstepper.Controls.Add(this.tabPage2);
            this.Materialstepper.Depth = 0;
            this.Materialstepper.Location = new System.Drawing.Point(0, 106);
            this.Materialstepper.MouseState = MaterialSkin.MouseState.Hover;
            this.Materialstepper.Name = "Materialstepper";
            this.Materialstepper.SelectedIndex = 0;
            this.Materialstepper.Size = new System.Drawing.Size(800, 521);
            this.Materialstepper.TabIndex = 0;
            // 
            // SimpleSubstitution
            // 
            this.SimpleSubstitution.Controls.Add(this.btnEncode);
            this.SimpleSubstitution.Controls.Add(this.btnDecode);
            this.SimpleSubstitution.Controls.Add(this.tbDecode);
            this.SimpleSubstitution.Controls.Add(this.btnRandomGenerateKey);
            this.SimpleSubstitution.Controls.Add(this.btnSaveInFile);
            this.SimpleSubstitution.Controls.Add(this.btnDecodeFromFile);
            this.SimpleSubstitution.Controls.Add(this.btnSetKey);
            this.SimpleSubstitution.Controls.Add(this.tbData);
            this.SimpleSubstitution.Controls.Add(this.tbKey);
            this.SimpleSubstitution.Controls.Add(this.materialLabel1);
            this.SimpleSubstitution.Controls.Add(this.mlbTextLable);
            this.SimpleSubstitution.Controls.Add(this.mlKey);
            this.SimpleSubstitution.Controls.Add(this.msOptions);
            this.SimpleSubstitution.Location = new System.Drawing.Point(4, 22);
            this.SimpleSubstitution.Name = "SimpleSubstitution";
            this.SimpleSubstitution.Padding = new System.Windows.Forms.Padding(3);
            this.SimpleSubstitution.Size = new System.Drawing.Size(792, 495);
            this.SimpleSubstitution.TabIndex = 0;
            this.SimpleSubstitution.Text = "Simple substitution";
            this.SimpleSubstitution.UseVisualStyleBackColor = true;
            // 
            // btnEncode
            // 
            this.btnEncode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEncode.Depth = 0;
            this.btnEncode.Icon = null;
            this.btnEncode.Location = new System.Drawing.Point(6, 435);
            this.btnEncode.MouseState = MaterialSkin.MouseState.Hover;
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Primary = true;
            this.btnEncode.Size = new System.Drawing.Size(197, 51);
            this.btnEncode.TabIndex = 12;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecode.Depth = 0;
            this.btnDecode.Icon = null;
            this.btnDecode.Location = new System.Drawing.Point(209, 435);
            this.btnDecode.MouseState = MaterialSkin.MouseState.Hover;
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Primary = true;
            this.btnDecode.Size = new System.Drawing.Size(200, 51);
            this.btnDecode.TabIndex = 11;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // tbDecode
            // 
            this.tbDecode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDecode.Location = new System.Drawing.Point(6, 290);
            this.tbDecode.Multiline = true;
            this.tbDecode.Name = "tbDecode";
            this.tbDecode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDecode.Size = new System.Drawing.Size(775, 139);
            this.tbDecode.TabIndex = 10;
            // 
            // btnRandomGenerateKey
            // 
            this.btnRandomGenerateKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRandomGenerateKey.Depth = 0;
            this.btnRandomGenerateKey.Icon = null;
            this.btnRandomGenerateKey.Location = new System.Drawing.Point(590, 206);
            this.btnRandomGenerateKey.MouseState = MaterialSkin.MouseState.Hover;
            this.btnRandomGenerateKey.Name = "btnRandomGenerateKey";
            this.btnRandomGenerateKey.Primary = true;
            this.btnRandomGenerateKey.Size = new System.Drawing.Size(191, 51);
            this.btnRandomGenerateKey.TabIndex = 7;
            this.btnRandomGenerateKey.Text = "Random generate key";
            this.btnRandomGenerateKey.UseVisualStyleBackColor = true;
            this.btnRandomGenerateKey.Click += new System.EventHandler(this.btnRandomGenerateKey_Click);
            // 
            // btnSaveInFile
            // 
            this.btnSaveInFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveInFile.Depth = 0;
            this.btnSaveInFile.Icon = null;
            this.btnSaveInFile.Location = new System.Drawing.Point(415, 435);
            this.btnSaveInFile.MouseState = MaterialSkin.MouseState.Hover;
            this.btnSaveInFile.Name = "btnSaveInFile";
            this.btnSaveInFile.Primary = true;
            this.btnSaveInFile.Size = new System.Drawing.Size(172, 51);
            this.btnSaveInFile.TabIndex = 6;
            this.btnSaveInFile.Text = "Save in file";
            this.btnSaveInFile.UseVisualStyleBackColor = true;
            this.btnSaveInFile.Click += new System.EventHandler(this.btnSaveInFile_Click);
            // 
            // btnDecodeFromFile
            // 
            this.btnDecodeFromFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecodeFromFile.Depth = 0;
            this.btnDecodeFromFile.Icon = null;
            this.btnDecodeFromFile.Location = new System.Drawing.Point(593, 435);
            this.btnDecodeFromFile.MouseState = MaterialSkin.MouseState.Hover;
            this.btnDecodeFromFile.Name = "btnDecodeFromFile";
            this.btnDecodeFromFile.Primary = true;
            this.btnDecodeFromFile.Size = new System.Drawing.Size(188, 51);
            this.btnDecodeFromFile.TabIndex = 5;
            this.btnDecodeFromFile.Text = "Decode from file";
            this.btnDecodeFromFile.UseVisualStyleBackColor = true;
            this.btnDecodeFromFile.Click += new System.EventHandler(this.btnDecodeFromFile_Click);
            // 
            // btnSetKey
            // 
            this.btnSetKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetKey.Depth = 0;
            this.btnSetKey.Icon = null;
            this.btnSetKey.Location = new System.Drawing.Point(415, 206);
            this.btnSetKey.MouseState = MaterialSkin.MouseState.Hover;
            this.btnSetKey.Name = "btnSetKey";
            this.btnSetKey.Primary = true;
            this.btnSetKey.Size = new System.Drawing.Size(172, 51);
            this.btnSetKey.TabIndex = 4;
            this.btnSetKey.Text = "Set key";
            this.btnSetKey.UseVisualStyleBackColor = true;
            this.btnSetKey.Click += new System.EventHandler(this.btnSetKey_Click);
            // 
            // tbData
            // 
            this.tbData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbData.Location = new System.Drawing.Point(9, 38);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbData.Size = new System.Drawing.Size(775, 139);
            this.tbData.TabIndex = 1;
            // 
            // tbKey
            // 
            this.tbKey.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbKey.Location = new System.Drawing.Point(6, 206);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbKey.Size = new System.Drawing.Size(403, 52);
            this.tbKey.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 267);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.Hover;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 23);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Encoded Text";
            // 
            // mlbTextLable
            // 
            this.mlbTextLable.AutoSize = true;
            this.mlbTextLable.Depth = 0;
            this.mlbTextLable.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.mlbTextLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlbTextLable.Location = new System.Drawing.Point(9, 12);
            this.mlbTextLable.MouseState = MaterialSkin.MouseState.Hover;
            this.mlbTextLable.Name = "mlbTextLable";
            this.mlbTextLable.Size = new System.Drawing.Size(157, 23);
            this.mlbTextLable.TabIndex = 3;
            this.mlbTextLable.Text = "Text you want to encode";
            // 
            // mlKey
            // 
            this.mlKey.AutoSize = true;
            this.mlKey.Depth = 0;
            this.mlKey.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.mlKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlKey.Location = new System.Drawing.Point(6, 180);
            this.mlKey.MouseState = MaterialSkin.MouseState.Hover;
            this.mlKey.Name = "mlKey";
            this.mlKey.Size = new System.Drawing.Size(33, 23);
            this.mlKey.TabIndex = 2;
            this.mlKey.Text = "Key";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // msOptions
            // 
            this.msOptions.Location = new System.Drawing.Point(3, 3);
            this.msOptions.Name = "msOptions";
            this.msOptions.Size = new System.Drawing.Size(786, 24);
            this.msOptions.TabIndex = 13;
            this.msOptions.Text = "menuStrip1";
            // 
            // CryptoClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.Materialstepper);
            this.Name = "CryptoClientForm";
            this.ShowIcon = false;
            this.Text = "Crypto Client";
            this.Load += new System.EventHandler(this.CryptoClientForm_Load);
            this.Materialstepper.ResumeLayout(false);
            this.SimpleSubstitution.ResumeLayout(false);
            this.SimpleSubstitution.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl Materialstepper;
        private System.Windows.Forms.TabPage SimpleSubstitution;
        private MaterialSkin.Controls.MaterialRaisedButton btnEncode;
        private MaterialSkin.Controls.MaterialRaisedButton btnDecode;
        private System.Windows.Forms.TextBox tbDecode;
        private MaterialSkin.Controls.MaterialRaisedButton btnRandomGenerateKey;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveInFile;
        private MaterialSkin.Controls.MaterialRaisedButton btnDecodeFromFile;
        private MaterialSkin.Controls.MaterialRaisedButton btnSetKey;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbKey;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel mlbTextLable;
        private MaterialSkin.Controls.MaterialLabel mlKey;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip msOptions;
    }
}

