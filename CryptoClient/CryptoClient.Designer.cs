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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptoClientForm));
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
            this.lbHint = new MaterialSkin.Controls.MaterialLabel();
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.btnDecryptAll = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEncryptAll = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDecryptSeleced = new MaterialSkin.Controls.MaterialFlatButton();
            this.bntEncryptSelected = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDestPath = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnOrgPath = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbEncryptedFiles = new System.Windows.Forms.ListBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbSrcPath = new System.Windows.Forms.TextBox();
            this.tbDstPath = new System.Windows.Forms.TextBox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbFilesToEncrypt = new System.Windows.Forms.ListBox();
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
            // lbHint
            // 
            this.lbHint.AutoSize = true;
            this.lbHint.Depth = 0;
            this.lbHint.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.lbHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbHint.Location = new System.Drawing.Point(6, 300);
            this.lbHint.MouseState = MaterialSkin.MouseState.Hover;
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(200, 23);
            this.lbHint.TabIndex = 21;
            this.lbHint.Text = "*separete key values with space";
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
            // gbFiles
            // 
            this.gbFiles.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gbFiles.Controls.Add(this.btnDecryptAll);
            this.gbFiles.Controls.Add(this.btnEncryptAll);
            this.gbFiles.Controls.Add(this.btnDecryptSeleced);
            this.gbFiles.Controls.Add(this.bntEncryptSelected);
            this.gbFiles.Controls.Add(this.btnDestPath);
            this.gbFiles.Controls.Add(this.btnOrgPath);
            this.gbFiles.Controls.Add(this.lbEncryptedFiles);
            this.gbFiles.Controls.Add(this.materialLabel2);
            this.gbFiles.Controls.Add(this.materialLabel3);
            this.gbFiles.Controls.Add(this.tbSrcPath);
            this.gbFiles.Controls.Add(this.tbDstPath);
            this.gbFiles.Controls.Add(this.materialRaisedButton2);
            this.gbFiles.Controls.Add(this.materialRaisedButton1);
            this.gbFiles.Controls.Add(this.lbFilesToEncrypt);
            this.gbFiles.Location = new System.Drawing.Point(803, 77);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(609, 608);
            this.gbFiles.TabIndex = 23;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // btnDecryptAll
            // 
            this.btnDecryptAll.AutoSize = true;
            this.btnDecryptAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecryptAll.Depth = 0;
            this.btnDecryptAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDecryptAll.Icon = ((System.Drawing.Image)(resources.GetObject("btnDecryptAll.Icon")));
            this.btnDecryptAll.Location = new System.Drawing.Point(465, 308);
            this.btnDecryptAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDecryptAll.MouseState = MaterialSkin.MouseState.Hover;
            this.btnDecryptAll.Name = "btnDecryptAll";
            this.btnDecryptAll.Primary = false;
            this.btnDecryptAll.Size = new System.Drawing.Size(138, 36);
            this.btnDecryptAll.TabIndex = 33;
            this.btnDecryptAll.Text = "Decrypt all";
            this.btnDecryptAll.UseVisualStyleBackColor = true;
            this.btnDecryptAll.Click += new System.EventHandler(this.btnDecryptAll_Click);
            // 
            // btnEncryptAll
            // 
            this.btnEncryptAll.AutoSize = true;
            this.btnEncryptAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEncryptAll.Depth = 0;
            this.btnEncryptAll.Icon = ((System.Drawing.Image)(resources.GetObject("btnEncryptAll.Icon")));
            this.btnEncryptAll.Location = new System.Drawing.Point(318, 308);
            this.btnEncryptAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEncryptAll.MouseState = MaterialSkin.MouseState.Hover;
            this.btnEncryptAll.Name = "btnEncryptAll";
            this.btnEncryptAll.Primary = false;
            this.btnEncryptAll.Size = new System.Drawing.Size(139, 36);
            this.btnEncryptAll.TabIndex = 32;
            this.btnEncryptAll.Text = "Encrypt all";
            this.btnEncryptAll.UseVisualStyleBackColor = true;
            this.btnEncryptAll.Click += new System.EventHandler(this.btnEncryptAll_Click);
            // 
            // btnDecryptSeleced
            // 
            this.btnDecryptSeleced.AutoSize = true;
            this.btnDecryptSeleced.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecryptSeleced.Depth = 0;
            this.btnDecryptSeleced.Icon = ((System.Drawing.Image)(resources.GetObject("btnDecryptSeleced.Icon")));
            this.btnDecryptSeleced.Location = new System.Drawing.Point(168, 308);
            this.btnDecryptSeleced.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDecryptSeleced.MouseState = MaterialSkin.MouseState.Hover;
            this.btnDecryptSeleced.Name = "btnDecryptSeleced";
            this.btnDecryptSeleced.Primary = false;
            this.btnDecryptSeleced.Size = new System.Drawing.Size(142, 36);
            this.btnDecryptSeleced.TabIndex = 31;
            this.btnDecryptSeleced.Text = "Decrypt file";
            this.btnDecryptSeleced.UseVisualStyleBackColor = true;
            this.btnDecryptSeleced.Click += new System.EventHandler(this.btnDecryptSeleced_Click);
            // 
            // bntEncryptSelected
            // 
            this.bntEncryptSelected.AutoSize = true;
            this.bntEncryptSelected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntEncryptSelected.Depth = 0;
            this.bntEncryptSelected.Icon = ((System.Drawing.Image)(resources.GetObject("bntEncryptSelected.Icon")));
            this.bntEncryptSelected.Location = new System.Drawing.Point(7, 308);
            this.bntEncryptSelected.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bntEncryptSelected.MouseState = MaterialSkin.MouseState.Hover;
            this.bntEncryptSelected.Name = "bntEncryptSelected";
            this.bntEncryptSelected.Primary = false;
            this.bntEncryptSelected.Size = new System.Drawing.Size(143, 36);
            this.bntEncryptSelected.TabIndex = 30;
            this.bntEncryptSelected.Text = "Encrypt file";
            this.bntEncryptSelected.UseVisualStyleBackColor = true;
            this.bntEncryptSelected.Click += new System.EventHandler(this.bntEncryptSelected_Click);
            // 
            // btnDestPath
            // 
            this.btnDestPath.AutoSize = true;
            this.btnDestPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDestPath.Depth = 0;
            this.btnDestPath.Icon = ((System.Drawing.Image)(resources.GetObject("btnDestPath.Icon")));
            this.btnDestPath.Location = new System.Drawing.Point(558, 80);
            this.btnDestPath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDestPath.MouseState = MaterialSkin.MouseState.Hover;
            this.btnDestPath.Name = "btnDestPath";
            this.btnDestPath.Primary = false;
            this.btnDestPath.Size = new System.Drawing.Size(44, 36);
            this.btnDestPath.TabIndex = 28;
            this.btnDestPath.UseVisualStyleBackColor = true;
            this.btnDestPath.Click += new System.EventHandler(this.btnDestPath_Click);
            // 
            // btnOrgPath
            // 
            this.btnOrgPath.AutoSize = true;
            this.btnOrgPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrgPath.Depth = 0;
            this.btnOrgPath.Icon = ((System.Drawing.Image)(resources.GetObject("btnOrgPath.Icon")));
            this.btnOrgPath.Location = new System.Drawing.Point(558, 35);
            this.btnOrgPath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrgPath.MouseState = MaterialSkin.MouseState.Hover;
            this.btnOrgPath.Name = "btnOrgPath";
            this.btnOrgPath.Primary = false;
            this.btnOrgPath.Size = new System.Drawing.Size(44, 36);
            this.btnOrgPath.TabIndex = 27;
            this.btnOrgPath.UseVisualStyleBackColor = true;
            this.btnOrgPath.Click += new System.EventHandler(this.btnOrgPath_Click);
            // 
            // lbEncryptedFiles
            // 
            this.lbEncryptedFiles.FormattingEnabled = true;
            this.lbEncryptedFiles.HorizontalScrollbar = true;
            this.lbEncryptedFiles.Location = new System.Drawing.Point(7, 353);
            this.lbEncryptedFiles.Name = "lbEncryptedFiles";
            this.lbEncryptedFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbEncryptedFiles.Size = new System.Drawing.Size(595, 160);
            this.lbEncryptedFiles.Sorted = true;
            this.lbEncryptedFiles.TabIndex = 24;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 88);
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
            this.materialLabel3.Location = new System.Drawing.Point(6, 46);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.Hover;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(143, 23);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "Path to original folder";
            // 
            // tbSrcPath
            // 
            this.tbSrcPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSrcPath.Location = new System.Drawing.Point(156, 44);
            this.tbSrcPath.Multiline = true;
            this.tbSrcPath.Name = "tbSrcPath";
            this.tbSrcPath.ReadOnly = true;
            this.tbSrcPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSrcPath.Size = new System.Drawing.Size(395, 25);
            this.tbSrcPath.TabIndex = 20;
            this.tbSrcPath.MouseHover += new System.EventHandler(this.tbSrcPath_MouseHover);
            // 
            // tbDstPath
            // 
            this.tbDstPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDstPath.Location = new System.Drawing.Point(156, 89);
            this.tbDstPath.Multiline = true;
            this.tbDstPath.Name = "tbDstPath";
            this.tbDstPath.ReadOnly = true;
            this.tbDstPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDstPath.Size = new System.Drawing.Size(395, 25);
            this.tbDstPath.TabIndex = 19;
            this.tbDstPath.MouseHover += new System.EventHandler(this.tbDstPath_MouseHover);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(318, 519);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.Hover;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(285, 48);
            this.materialRaisedButton2.TabIndex = 3;
            this.materialRaisedButton2.Text = "Download";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(6, 519);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.Hover;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(304, 48);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Upload";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // lbFilesToEncrypt
            // 
            this.lbFilesToEncrypt.FormattingEnabled = true;
            this.lbFilesToEncrypt.HorizontalScrollbar = true;
            this.lbFilesToEncrypt.Location = new System.Drawing.Point(7, 139);
            this.lbFilesToEncrypt.Name = "lbFilesToEncrypt";
            this.lbFilesToEncrypt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFilesToEncrypt.Size = new System.Drawing.Size(596, 160);
            this.lbFilesToEncrypt.Sorted = true;
            this.lbFilesToEncrypt.TabIndex = 0;
            // 
            // CryptoClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 696);
            this.Controls.Add(this.gbFiles);
            this.Controls.Add(this.gbAlgorithm);
            this.MaximumSize = new System.Drawing.Size(1430, 696);
            this.MinimumSize = new System.Drawing.Size(1430, 696);
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
        private System.Windows.Forms.ListBox lbFilesToEncrypt;
        private System.Windows.Forms.ListBox lbEncryptedFiles;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox tbSrcPath;
        private System.Windows.Forms.TextBox tbDstPath;
        private MaterialSkin.Controls.MaterialFlatButton btnDestPath;
        private MaterialSkin.Controls.MaterialFlatButton btnOrgPath;
        private MaterialSkin.Controls.MaterialFlatButton btnDecryptSeleced;
        private MaterialSkin.Controls.MaterialFlatButton bntEncryptSelected;
        private MaterialSkin.Controls.MaterialFlatButton btnDecryptAll;
        private MaterialSkin.Controls.MaterialFlatButton btnEncryptAll;
    }
}

