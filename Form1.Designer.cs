﻿namespace RenameFilesVideo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFolder = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.RenameBox = new System.Windows.Forms.GroupBox();
            this.nbSujetS = new System.Windows.Forms.NumericUpDown();
            this.nbSujetP = new System.Windows.Forms.NumericUpDown();
            this.labelContext = new System.Windows.Forms.Label();
            this.labelNBSS = new System.Windows.Forms.Label();
            this.labelSujetS = new System.Windows.Forms.Label();
            this.labelNBSP = new System.Windows.Forms.Label();
            this.buttonAddContext = new System.Windows.Forms.Button();
            this.addContextBox = new System.Windows.Forms.TextBox();
            this.listContext = new System.Windows.Forms.ListBox();
            this.listSujetS = new System.Windows.Forms.ListBox();
            this.buttonAddSujetS = new System.Windows.Forms.Button();
            this.buttonAddSujetP = new System.Windows.Forms.Button();
            this.addSujetSBox = new System.Windows.Forms.TextBox();
            this.addSujetPBox = new System.Windows.Forms.TextBox();
            this.listSujetP = new System.Windows.Forms.ListBox();
            this.labelSujet = new System.Windows.Forms.Label();
            this.buttonValidRename = new System.Windows.Forms.Button();
            this.labelNomTemp = new System.Windows.Forms.Label();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.deleteButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.RenameBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSujetS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSujetP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerConfigurationToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // chargerConfigurationToolStripMenuItem
            // 
            this.chargerConfigurationToolStripMenuItem.Name = "chargerConfigurationToolStripMenuItem";
            this.chargerConfigurationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.chargerConfigurationToolStripMenuItem.Text = "Charger configuration";
            this.chargerConfigurationToolStripMenuItem.Click += new System.EventHandler(this.chargerConfigurationToolStripMenuItem_Click);
            // 
            // chooseFolder
            // 
            this.chooseFolder.Location = new System.Drawing.Point(12, 27);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(276, 23);
            this.chooseFolder.TabIndex = 1;
            this.chooseFolder.Text = "CHOOSE";
            this.chooseFolder.UseVisualStyleBackColor = true;
            this.chooseFolder.Click += new System.EventHandler(this.ChooseNewFolder);
            // 
            // listFiles
            // 
            this.listFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(12, 56);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(276, 550);
            this.listFiles.TabIndex = 2;
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.ChooseFile);
            // 
            // RenameBox
            // 
            this.RenameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RenameBox.Controls.Add(this.nbSujetS);
            this.RenameBox.Controls.Add(this.nbSujetP);
            this.RenameBox.Controls.Add(this.labelContext);
            this.RenameBox.Controls.Add(this.labelNBSS);
            this.RenameBox.Controls.Add(this.labelSujetS);
            this.RenameBox.Controls.Add(this.labelNBSP);
            this.RenameBox.Controls.Add(this.buttonAddContext);
            this.RenameBox.Controls.Add(this.addContextBox);
            this.RenameBox.Controls.Add(this.listContext);
            this.RenameBox.Controls.Add(this.listSujetS);
            this.RenameBox.Controls.Add(this.buttonAddSujetS);
            this.RenameBox.Controls.Add(this.buttonAddSujetP);
            this.RenameBox.Controls.Add(this.addSujetSBox);
            this.RenameBox.Controls.Add(this.addSujetPBox);
            this.RenameBox.Controls.Add(this.listSujetP);
            this.RenameBox.Controls.Add(this.labelSujet);
            this.RenameBox.Controls.Add(this.buttonValidRename);
            this.RenameBox.Location = new System.Drawing.Point(294, 397);
            this.RenameBox.Name = "RenameBox";
            this.RenameBox.Size = new System.Drawing.Size(752, 205);
            this.RenameBox.TabIndex = 3;
            this.RenameBox.TabStop = false;
            // 
            // nbSujetS
            // 
            this.nbSujetS.Location = new System.Drawing.Point(377, 80);
            this.nbSujetS.Name = "nbSujetS";
            this.nbSujetS.Size = new System.Drawing.Size(41, 20);
            this.nbSujetS.TabIndex = 16;
            this.nbSujetS.ValueChanged += new System.EventHandler(this.nbSujetS_ValueChanged);
            // 
            // nbSujetP
            // 
            this.nbSujetP.Location = new System.Drawing.Point(162, 80);
            this.nbSujetP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSujetP.Name = "nbSujetP";
            this.nbSujetP.Size = new System.Drawing.Size(46, 20);
            this.nbSujetP.TabIndex = 15;
            this.nbSujetP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSujetP.ValueChanged += new System.EventHandler(this.nbSujetP_ValueChanged);
            // 
            // labelContext
            // 
            this.labelContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelContext.Location = new System.Drawing.Point(496, 16);
            this.labelContext.Name = "labelContext";
            this.labelContext.Size = new System.Drawing.Size(141, 16);
            this.labelContext.TabIndex = 14;
            this.labelContext.Text = "Context";
            this.labelContext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNBSS
            // 
            this.labelNBSS.AutoSize = true;
            this.labelNBSS.Location = new System.Drawing.Point(383, 16);
            this.labelNBSS.Name = "labelNBSS";
            this.labelNBSS.Size = new System.Drawing.Size(22, 13);
            this.labelNBSS.TabIndex = 13;
            this.labelNBSS.Text = "NB";
            // 
            // labelSujetS
            // 
            this.labelSujetS.AutoSize = true;
            this.labelSujetS.Location = new System.Drawing.Point(214, 18);
            this.labelSujetS.Name = "labelSujetS";
            this.labelSujetS.Size = new System.Drawing.Size(88, 13);
            this.labelSujetS.TabIndex = 12;
            this.labelSujetS.Text = "Sujet Secondaire";
            this.labelSujetS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNBSP
            // 
            this.labelNBSP.AutoSize = true;
            this.labelNBSP.Location = new System.Drawing.Point(173, 18);
            this.labelNBSP.Name = "labelNBSP";
            this.labelNBSP.Size = new System.Drawing.Size(22, 13);
            this.labelNBSP.TabIndex = 11;
            this.labelNBSP.Text = "NB";
            // 
            // buttonAddContext
            // 
            this.buttonAddContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonAddContext.Location = new System.Drawing.Point(602, 173);
            this.buttonAddContext.Name = "buttonAddContext";
            this.buttonAddContext.Size = new System.Drawing.Size(35, 23);
            this.buttonAddContext.TabIndex = 10;
            this.buttonAddContext.Text = "Add";
            this.buttonAddContext.UseVisualStyleBackColor = true;
            this.buttonAddContext.Click += new System.EventHandler(this.AddContext);
            // 
            // addContextBox
            // 
            this.addContextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addContextBox.Location = new System.Drawing.Point(496, 176);
            this.addContextBox.Name = "addContextBox";
            this.addContextBox.Size = new System.Drawing.Size(100, 20);
            this.addContextBox.TabIndex = 9;
            // 
            // listContext
            // 
            this.listContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listContext.FormattingEnabled = true;
            this.listContext.Location = new System.Drawing.Point(496, 35);
            this.listContext.Name = "listContext";
            this.listContext.Size = new System.Drawing.Size(141, 134);
            this.listContext.TabIndex = 8;
            this.listContext.SelectedIndexChanged += new System.EventHandler(this.listContext_SelectedIndexChanged);
            this.listContext.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listContext_MouseDoubleClick);
            // 
            // listSujetS
            // 
            this.listSujetS.FormattingEnabled = true;
            this.listSujetS.Location = new System.Drawing.Point(214, 35);
            this.listSujetS.Name = "listSujetS";
            this.listSujetS.Size = new System.Drawing.Size(141, 134);
            this.listSujetS.TabIndex = 7;
            this.listSujetS.SelectedIndexChanged += new System.EventHandler(this.listSujetS_SelectedIndexChanged);
            this.listSujetS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSujetS_MouseDoubleClick);
            // 
            // buttonAddSujetS
            // 
            this.buttonAddSujetS.Location = new System.Drawing.Point(320, 177);
            this.buttonAddSujetS.Name = "buttonAddSujetS";
            this.buttonAddSujetS.Size = new System.Drawing.Size(35, 23);
            this.buttonAddSujetS.TabIndex = 6;
            this.buttonAddSujetS.Text = "Add";
            this.buttonAddSujetS.UseVisualStyleBackColor = true;
            this.buttonAddSujetS.Click += new System.EventHandler(this.AddSS);
            // 
            // buttonAddSujetP
            // 
            this.buttonAddSujetP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddSujetP.Location = new System.Drawing.Point(112, 176);
            this.buttonAddSujetP.Name = "buttonAddSujetP";
            this.buttonAddSujetP.Size = new System.Drawing.Size(38, 23);
            this.buttonAddSujetP.TabIndex = 5;
            this.buttonAddSujetP.Text = "Add";
            this.buttonAddSujetP.UseVisualStyleBackColor = true;
            this.buttonAddSujetP.Click += new System.EventHandler(this.AddSP);
            // 
            // addSujetSBox
            // 
            this.addSujetSBox.Location = new System.Drawing.Point(214, 179);
            this.addSujetSBox.Name = "addSujetSBox";
            this.addSujetSBox.Size = new System.Drawing.Size(100, 20);
            this.addSujetSBox.TabIndex = 4;
            // 
            // addSujetPBox
            // 
            this.addSujetPBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addSujetPBox.Location = new System.Drawing.Point(6, 179);
            this.addSujetPBox.Name = "addSujetPBox";
            this.addSujetPBox.Size = new System.Drawing.Size(100, 20);
            this.addSujetPBox.TabIndex = 3;
            // 
            // listSujetP
            // 
            this.listSujetP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listSujetP.FormattingEnabled = true;
            this.listSujetP.Location = new System.Drawing.Point(6, 35);
            this.listSujetP.Name = "listSujetP";
            this.listSujetP.Size = new System.Drawing.Size(144, 134);
            this.listSujetP.TabIndex = 2;
            this.listSujetP.SelectedIndexChanged += new System.EventHandler(this.listSujetP_SelectedIndexChanged);
            this.listSujetP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSujetP_MouseDoubleClick);
            // 
            // labelSujet
            // 
            this.labelSujet.Location = new System.Drawing.Point(6, 16);
            this.labelSujet.Name = "labelSujet";
            this.labelSujet.Size = new System.Drawing.Size(144, 16);
            this.labelSujet.TabIndex = 1;
            this.labelSujet.Text = "Sujet Principal";
            this.labelSujet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonValidRename
            // 
            this.buttonValidRename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValidRename.Location = new System.Drawing.Point(671, 16);
            this.buttonValidRename.Name = "buttonValidRename";
            this.buttonValidRename.Size = new System.Drawing.Size(75, 180);
            this.buttonValidRename.TabIndex = 0;
            this.buttonValidRename.Text = "Rename";
            this.buttonValidRename.UseVisualStyleBackColor = true;
            this.buttonValidRename.Click += new System.EventHandler(this.buttonValidRename_Click);
            // 
            // labelNomTemp
            // 
            this.labelNomTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNomTemp.Location = new System.Drawing.Point(291, 373);
            this.labelNomTemp.Name = "labelNomTemp";
            this.labelNomTemp.Size = new System.Drawing.Size(640, 21);
            this.labelNomTemp.TabIndex = 5;
            this.labelNomTemp.Text = "title";
            this.labelNomTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // videoPlayer
            // 
            this.videoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(294, 27);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(752, 343);
            this.videoPlayer.TabIndex = 6;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(937, 373);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete Video";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 614);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.videoPlayer);
            this.Controls.Add(this.labelNomTemp);
            this.Controls.Add(this.RenameBox);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.chooseFolder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RenameBox.ResumeLayout(false);
            this.RenameBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSujetS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSujetP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Button chooseFolder;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.GroupBox RenameBox;
        private System.Windows.Forms.NumericUpDown nbSujetS;
        private System.Windows.Forms.NumericUpDown nbSujetP;
        private System.Windows.Forms.Label labelContext;
        private System.Windows.Forms.Label labelNBSS;
        private System.Windows.Forms.Label labelSujetS;
        private System.Windows.Forms.Label labelNBSP;
        private System.Windows.Forms.Button buttonAddContext;
        private System.Windows.Forms.TextBox addContextBox;
        private System.Windows.Forms.ListBox listContext;
        private System.Windows.Forms.ListBox listSujetS;
        private System.Windows.Forms.Button buttonAddSujetS;
        private System.Windows.Forms.Button buttonAddSujetP;
        private System.Windows.Forms.TextBox addSujetSBox;
        private System.Windows.Forms.TextBox addSujetPBox;
        private System.Windows.Forms.ListBox listSujetP;
        private System.Windows.Forms.Label labelSujet;
        private System.Windows.Forms.Button buttonValidRename;
        private System.Windows.Forms.Label labelNomTemp;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStripMenuItem chargerConfigurationToolStripMenuItem;
    }
}

