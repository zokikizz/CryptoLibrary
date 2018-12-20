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
            this.btnEncode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDecode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSaveInFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDecodeFromFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gbKnapSackProp = new System.Windows.Forms.GroupBox();
            this.tbIM = new System.Windows.Forms.TextBox();
            this.lbN = new MaterialSkin.Controls.MaterialLabel();
            this.lbIM = new MaterialSkin.Controls.MaterialLabel();
            this.lbM = new MaterialSkin.Controls.MaterialLabel();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbDecode = new System.Windows.Forms.TextBox();
            this.btnRandomGenerateKey = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSetKey = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mlbTextLable = new MaterialSkin.Controls.MaterialLabel();
            this.mlKey = new MaterialSkin.Controls.MaterialLabel();
            this.gbAlgorithm = new System.Windows.Forms.GroupBox();
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.lbHint = new MaterialSkin.Controls.MaterialLabel();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gbKnapSackProp.SuspendLayout();
            this.gbAlgorithm.SuspendLayout();
            this.gbFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncode
            // 
            this.btnEncode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEncode.Depth = 0;
            this.btnEncode.Icon = null;
            this.btnEncode.Location = new System.Drawing.Point(3, 549);
            this.btnEncode.MouseState = MaterialSkin.MouseState.Hover;
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Primary = true;
            this.btnEncode.Size = new System.Drawing.Size(109, 51);
            this.btnEncode.TabIndex = 5;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecode.Depth = 0;
            this.btnDecode.Icon = null;
            this.btnDecode.Location = new System.Drawing.Point(118, 549);
            this.btnDecode.MouseState = MaterialSkin.MouseState.Hover;
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Primary = true;
            this.btnDecode.Size = new System.Drawing.Size(217, 51);
            this.btnDecode.TabIndex = 6;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnSaveInFile
            // 
            this.btnSaveInFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveInFile.Depth = 0;
            this.btnSaveInFile.Icon = null;
            this.btnSaveInFile.Location = new System.Drawing.Point(564, 549);
            this.btnSaveInFile.MouseState = MaterialSkin.MouseState.Hover;
            this.btnSaveInFile.Name = "btnSaveInFile";
            this.btnSaveInFile.Primary = true;
            this.btnSaveInFile.Size = new System.Drawing.Size(217, 51);
            this.btnSaveInFile.TabIndex = 8;
            this.btnSaveInFile.Text = "Save in file";
            this.btnSaveInFile.UseVisualStyleBackColor = true;
            this.btnSaveInFile.Click += new System.EventHandler(this.btnSaveInFile_Click);
            // 
            // btnDecodeFromFile
            // 
            this.btnDecodeFromFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecodeFromFile.Depth = 0;
            this.btnDecodeFromFile.Icon = null;
            this.btnDecodeFromFile.Location = new System.Drawing.Point(341, 549);
            this.btnDecodeFromFile.MouseState = MaterialSkin.MouseState.Hover;
            this.btnDecodeFromFile.Name = "btnDecodeFromFile";
            this.btnDecodeFromFile.Primary = true;
            this.btnDecodeFromFile.Size = new System.Drawing.Size(217, 51);
            this.btnDecodeFromFile.TabIndex = 7;
            this.btnDecodeFromFile.Text = "Decode from file";
            this.btnDecodeFromFile.UseVisualStyleBackColor = true;
            this.btnDecodeFromFile.Click += new System.EventHandler(this.btnDecodeFromFile_Click);
            // 
            // gbKnapSackProp
            // 
            this.gbKnapSackProp.Controls.Add(this.tbIM);
            this.gbKnapSackProp.Controls.Add(this.lbN);
            this.gbKnapSackProp.Controls.Add(this.lbIM);
            this.gbKnapSackProp.Controls.Add(this.lbM);
            this.gbKnapSackProp.Controls.Add(this.tbM);
            this.gbKnapSackProp.Controls.Add(this.tbN);
            this.gbKnapSackProp.Location = new System.Drawing.Point(412, 240);
            this.gbKnapSackProp.Name = "gbKnapSackProp";
            this.gbKnapSackProp.Size = new System.Drawing.Size(369, 57);
            this.gbKnapSackProp.TabIndex = 20;
            this.gbKnapSackProp.TabStop = false;
            this.gbKnapSackProp.Text = "Knapsack";
            // 
            // tbIM
            // 
            this.tbIM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbIM.Location = new System.Drawing.Point(272, 19);
            this.tbIM.Multiline = true;
            this.tbIM.Name = "tbIM";
            this.tbIM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbIM.Size = new System.Drawing.Size(81, 25);
            this.tbIM.TabIndex = 11;
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Depth = 0;
            this.lbN.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.lbN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbN.Location = new System.Drawing.Point(11, 21);
            this.lbN.MouseState = MaterialSkin.MouseState.Hover;
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(20, 23);
            this.lbN.TabIndex = 14;
            this.lbN.Text = "N";
            // 
            // lbIM
            // 
            this.lbIM.AutoSize = true;
            this.lbIM.Depth = 0;
            this.lbIM.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.lbIM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbIM.Location = new System.Drawing.Point(239, 21);
            this.lbIM.MouseState = MaterialSkin.MouseState.Hover;
            this.lbIM.Name = "lbIM";
            this.lbIM.Size = new System.Drawing.Size(27, 23);
            this.lbIM.TabIndex = 18;
            this.lbIM.Text = "IM";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Depth = 0;
            this.lbM.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.lbM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbM.Location = new System.Drawing.Point(124, 21);
            this.lbM.MouseState = MaterialSkin.MouseState.Hover;
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(22, 23);
            this.lbM.TabIndex = 15;
            this.lbM.Text = "M";
            // 
            // tbM
            // 
            this.tbM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbM.Location = new System.Drawing.Point(152, 19);
            this.tbM.Multiline = true;
            this.tbM.Name = "tbM";
            this.tbM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbM.Size = new System.Drawing.Size(81, 25);
            this.tbM.TabIndex = 10;
            // 
            // tbN
            // 
            this.tbN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbN.Location = new System.Drawing.Point(37, 19);
            this.tbN.Multiline = true;
            this.tbN.Name = "tbN";
            this.tbN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbN.Size = new System.Drawing.Size(81, 25);
            this.tbN.TabIndex = 9;
            // 
            // tbDecode
            // 
            this.tbDecode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDecode.Location = new System.Drawing.Point(3, 404);
            this.tbDecode.Multiline = true;
            this.tbDecode.Name = "tbDecode";
            this.tbDecode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDecode.Size = new System.Drawing.Size(778, 139);
            this.tbDecode.TabIndex = 4;
            // 
            // btnRandomGenerateKey
            // 
            this.btnRandomGenerateKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRandomGenerateKey.Depth = 0;
            this.btnRandomGenerateKey.Icon = null;
            this.btnRandomGenerateKey.Location = new System.Drawing.Point(363, 324);
            this.btnRandomGenerateKey.MouseState = MaterialSkin.MouseState.Hover;
            this.btnRandomGenerateKey.Name = "btnRandomGenerateKey";
            this.btnRandomGenerateKey.Primary = true;
            this.btnRandomGenerateKey.Size = new System.Drawing.Size(418, 51);
            this.btnRandomGenerateKey.TabIndex = 3;
            this.btnRandomGenerateKey.Text = "Random generate key";
            this.btnRandomGenerateKey.UseVisualStyleBackColor = true;
            this.btnRandomGenerateKey.Click += new System.EventHandler(this.btnRandomGenerateKey_Click);
            // 
            // btnSetKey
            // 
            this.btnSetKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetKey.Depth = 0;
            this.btnSetKey.Icon = null;
            this.btnSetKey.Location = new System.Drawing.Point(3, 324);
            this.btnSetKey.MouseState = MaterialSkin.MouseState.Hover;
            this.btnSetKey.Name = "btnSetKey";
            this.btnSetKey.Primary = true;
            this.btnSetKey.Size = new System.Drawing.Size(354, 51);
            this.btnSetKey.TabIndex = 2;
            this.btnSetKey.Text = "Set key";
            this.btnSetKey.UseVisualStyleBackColor = true;
            this.btnSetKey.Click += new System.EventHandler(this.btnSetKey_Click);
            // 
            // tbData
            // 
            this.tbData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbData.Location = new System.Drawing.Point(3, 76);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbData.Size = new System.Drawing.Size(778, 139);
            this.tbData.TabIndex = 0;
            // 
            // tbKey
            // 
            this.tbKey.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbKey.Location = new System.Drawing.Point(3, 245);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbKey.Size = new System.Drawing.Size(403, 52);
            this.tbKey.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 378);
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
            this.mlbTextLable.Location = new System.Drawing.Point(3, 53);
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
            this.mlKey.Location = new System.Drawing.Point(3, 219);
            this.mlKey.MouseState = MaterialSkin.MouseState.Hover;
            this.mlKey.Name = "mlKey";
            this.mlKey.Size = new System.Drawing.Size(33, 23);
            this.mlKey.TabIndex = 2;
            this.mlKey.Text = "Key";
            // 
            // gbAlgorithm
            // 
            this.gbAlgorithm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gbAlgorithm.Controls.Add(this.lbHint);
            this.gbAlgorithm.Controls.Add(this.msOptions);
            this.gbAlgorithm.Controls.Add(this.btnEncode);
            this.gbAlgorithm.Controls.Add(this.tbData);
            this.gbAlgorithm.Controls.Add(this.btnDecode);
            this.gbAlgorithm.Controls.Add(this.gbKnapSackProp);
            this.gbAlgorithm.Controls.Add(this.btnSaveInFile);
            this.gbAlgorithm.Controls.Add(this.mlbTextLable);
            this.gbAlgorithm.Controls.Add(this.btnDecodeFromFile);
            this.gbAlgorithm.Controls.Add(this.tbKey);
            this.gbAlgorithm.Controls.Add(this.tbDecode);
            this.gbAlgorithm.Controls.Add(this.materialLabel1);
            this.gbAlgorithm.Controls.Add(this.mlKey);
            this.gbAlgorithm.Controls.Add(this.btnRandomGenerateKey);
            this.gbAlgorithm.Controls.Add(this.btnSetKey);
            this.gbAlgorithm.Location = new System.Drawing.Point(2, 77);
            this.gbAlgorithm.Name = "gbAlgorithm";
            this.gbAlgorithm.Size = new System.Drawing.Size(794, 608);
            this.gbAlgorithm.TabIndex = 22;
            this.gbAlgorithm.TabStop = false;
            this.gbAlgorithm.Text = "Algorithm";
            // 
            // msOptions
            // 
            this.msOptions.BackColor = System.Drawing.SystemColors.HighlightText;
            this.msOptions.Location = new System.Drawing.Point(3, 16);
            this.msOptions.Name = "msOptions";
            this.msOptions.Size = new System.Drawing.Size(788, 24);
            this.msOptions.TabIndex = 12;
            this.msOptions.Text = "menuStrip1";
            // 
            // lbHint
            // 
            this.lbHint.AutoSize = true;
            this.lbHint.Depth = 0;
            this.lbHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbHint.Location = new System.Drawing.Point(6, 300);
            this.lbHint.MouseState = MaterialSkin.MouseState.Hover;
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(160, 13);
            this.lbHint.TabIndex = 21;
            this.lbHint.Text = "*separete key values with space";
            // 
            // gbFiles
            // 
            this.gbFiles.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gbFiles.Controls.Add(this.materialRaisedButton4);
            this.gbFiles.Controls.Add(this.materialRaisedButton3);
            this.gbFiles.Controls.Add(this.listBox3);
            this.gbFiles.Controls.Add(this.materialLabel2);
            this.gbFiles.Controls.Add(this.materialLabel3);
            this.gbFiles.Controls.Add(this.textBox2);
            this.gbFiles.Controls.Add(this.textBox1);
            this.gbFiles.Controls.Add(this.materialRaisedButton2);
            this.gbFiles.Controls.Add(this.materialRaisedButton1);
            this.gbFiles.Controls.Add(this.listBox1);
            this.gbFiles.Location = new System.Drawing.Point(803, 77);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(485, 608);
            this.gbFiles.TabIndex = 23;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(472, 160);
            this.listBox1.TabIndex = 0;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(7, 549);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.Hover;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(241, 48);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Upload";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(254, 549);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.Hover;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(225, 48);
            this.materialRaisedButton2.TabIndex = 3;
            this.materialRaisedButton2.Text = "Download";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(177, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(302, 25);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(177, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(302, 25);
            this.textBox2.TabIndex = 20;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 110);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.Hover;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(141, 23);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Path to encrypt folder";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 78);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.Hover;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(143, 23);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "Path to original folder";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(7, 383);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(472, 160);
            this.listBox3.TabIndex = 24;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(7, 315);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.Hover;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(241, 48);
            this.materialRaisedButton3.TabIndex = 25;
            this.materialRaisedButton3.Text = "Encrypt selected file";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = null;
            this.materialRaisedButton4.Location = new System.Drawing.Point(254, 315);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.Hover;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(225, 48);
            this.materialRaisedButton4.TabIndex = 26;
            this.materialRaisedButton4.Text = "Decrypt selected fie";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            // 
            // CryptoClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 696);
            this.Controls.Add(this.gbFiles);
            this.Controls.Add(this.gbAlgorithm);
            this.MaximumSize = new System.Drawing.Size(1300, 696);
            this.MinimumSize = new System.Drawing.Size(1300, 696);
            this.Name = "CryptoClientForm";
            this.ShowIcon = false;
            this.Text = "Crypto Client";
            this.Load += new System.EventHandler(this.CryptoClientForm_Load);
            this.gbKnapSackProp.ResumeLayout(false);
            this.gbKnapSackProp.PerformLayout();
            this.gbAlgorithm.ResumeLayout(false);
            this.gbAlgorithm.PerformLayout();
            this.gbFiles.ResumeLayout(false);
            this.gbFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private MaterialSkin.Controls.MaterialLabel lbIM;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbN;
        private MaterialSkin.Controls.MaterialLabel lbM;
        private MaterialSkin.Controls.MaterialLabel lbN;
        private System.Windows.Forms.TextBox tbIM;
        private System.Windows.Forms.GroupBox gbKnapSackProp;
        private System.Windows.Forms.GroupBox gbAlgorithm;
        private System.Windows.Forms.MenuStrip msOptions;
        private MaterialSkin.Controls.MaterialLabel lbHint;
        private System.Windows.Forms.GroupBox gbFiles;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private System.Windows.Forms.ListBox listBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

