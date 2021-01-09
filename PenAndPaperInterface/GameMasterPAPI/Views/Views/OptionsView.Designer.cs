﻿
namespace PAPIClient.Views
{
    partial class GMOptionsView
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
            this.languageDropdown = new System.Windows.Forms.ComboBox();
            this.designDropdown = new System.Windows.Forms.ComboBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.designLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gmNameLabel = new System.Windows.Forms.Label();
            this.playerNameInputField = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // languageDropdown
            // 
            this.languageDropdown.FormattingEnabled = true;
            this.languageDropdown.Items.AddRange(new object[] {
            "English",
            "Deutsch"});
            this.languageDropdown.Location = new System.Drawing.Point(14, 55);
            this.languageDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.languageDropdown.Name = "languageDropdown";
            this.languageDropdown.Size = new System.Drawing.Size(193, 27);
            this.languageDropdown.TabIndex = 0;
            this.languageDropdown.SelectedIndexChanged += new System.EventHandler(this.languageDropdown_SelectedIndexChanged);
            // 
            // designDropdown
            // 
            this.designDropdown.FormattingEnabled = true;
            this.designDropdown.Items.AddRange(new object[] {
            "medievalDesign",
            "modernDesign"});
            this.designDropdown.Location = new System.Drawing.Point(347, 55);
            this.designDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.designDropdown.Name = "designDropdown";
            this.designDropdown.Size = new System.Drawing.Size(193, 27);
            this.designDropdown.TabIndex = 1;
            this.designDropdown.SelectedIndexChanged += new System.EventHandler(this.designDropdown_SelectedIndexChanged);
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Location = new System.Drawing.Point(13, 393);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(100, 36);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel.Controls.Add(this.designDropdown, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.languageDropdown, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.designLabel, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.languageLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.returnButton, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(784, 453);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // designLabel
            // 
            this.designLabel.AutoSize = true;
            this.designLabel.Location = new System.Drawing.Point(346, 20);
            this.designLabel.Name = "designLabel";
            this.designLabel.Size = new System.Drawing.Size(63, 19);
            this.designLabel.TabIndex = 9;
            this.designLabel.Text = "design";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(13, 20);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(81, 19);
            this.languageLabel.TabIndex = 8;
            this.languageLabel.Text = "language";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gmNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerNameInputField, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 266);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // gmNameLabel
            // 
            this.gmNameLabel.AutoSize = true;
            this.gmNameLabel.Location = new System.Drawing.Point(3, 0);
            this.gmNameLabel.Name = "gmNameLabel";
            this.gmNameLabel.Size = new System.Drawing.Size(63, 19);
            this.gmNameLabel.TabIndex = 0;
            this.gmNameLabel.Text = "gmName";
            // 
            // gmNameInputField
            // 
            this.playerNameInputField.BackColor = System.Drawing.SystemColors.Window;
            this.playerNameInputField.Dock = System.Windows.Forms.DockStyle.Top;
            this.playerNameInputField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.playerNameInputField.Location = new System.Drawing.Point(3, 33);
            this.playerNameInputField.Name = "gmNameInputField";
            this.playerNameInputField.Size = new System.Drawing.Size(321, 26);
            this.playerNameInputField.TabIndex = 1;
            this.playerNameInputField.Text = "GAME MASTER";
            this.playerNameInputField.TextChanged += new System.EventHandler(this.playerNameInputField_TextChanged);
            // 
            // GMOptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 453);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "GMOptionsView";
            this.Text = "GMOptionsView";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox languageDropdown;
        private System.Windows.Forms.ComboBox designDropdown;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label designLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label gmNameLabel;
        private System.Windows.Forms.TextBox playerNameInputField;
    }
}