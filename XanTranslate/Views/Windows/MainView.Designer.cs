using System.ComponentModel;

namespace XanTranslate.Views.Windows;

partial class MainView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.panel1 = new System.Windows.Forms.Panel();
        this.translateButton = new System.Windows.Forms.Button();
        this.panel2 = new System.Windows.Forms.Panel();
        this.reverseButton = new System.Windows.Forms.Button();
        this.panel4 = new System.Windows.Forms.Panel();
        this.destinationLanguageTextBox = new System.Windows.Forms.TextBox();
        this.destinationLanguageComboBox = new System.Windows.Forms.ComboBox();
        this.panel3 = new System.Windows.Forms.Panel();
        this.sourceLanguageTextBox = new System.Windows.Forms.TextBox();
        this.sourceLanguageComboBox = new System.Windows.Forms.ComboBox();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.panel4.SuspendLayout();
        this.panel3.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.translateButton);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.panel1.Location = new System.Drawing.Point(0, 427);
        this.panel1.Margin = new System.Windows.Forms.Padding(4);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(1064, 129);
        this.panel1.TabIndex = 0;
        // 
        // translateButton
        // 
        this.translateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
        this.translateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.translateButton.Location = new System.Drawing.Point(427, 47);
        this.translateButton.Margin = new System.Windows.Forms.Padding(4);
        this.translateButton.Name = "translateButton";
        this.translateButton.Size = new System.Drawing.Size(208, 49);
        this.translateButton.TabIndex = 0;
        this.translateButton.Text = "Translate";
        this.translateButton.UseVisualStyleBackColor = true;
        this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.reverseButton);
        this.panel2.Controls.Add(this.panel4);
        this.panel2.Controls.Add(this.panel3);
        this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel2.Location = new System.Drawing.Point(0, 0);
        this.panel2.Margin = new System.Windows.Forms.Padding(4);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(1064, 427);
        this.panel2.TabIndex = 1;
        // 
        // reverseButton
        // 
        this.reverseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
        this.reverseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.reverseButton.Location = new System.Drawing.Point(455, 57);
        this.reverseButton.Margin = new System.Windows.Forms.Padding(4);
        this.reverseButton.Name = "reverseButton";
        this.reverseButton.Size = new System.Drawing.Size(143, 51);
        this.reverseButton.TabIndex = 1;
        this.reverseButton.Text = "Reverse";
        this.reverseButton.UseVisualStyleBackColor = true;
        this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
        // 
        // panel4
        // 
        this.panel4.Controls.Add(this.destinationLanguageTextBox);
        this.panel4.Controls.Add(this.destinationLanguageComboBox);
        this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
        this.panel4.Location = new System.Drawing.Point(623, 0);
        this.panel4.Margin = new System.Windows.Forms.Padding(4);
        this.panel4.Name = "panel4";
        this.panel4.Size = new System.Drawing.Size(441, 427);
        this.panel4.TabIndex = 1;
        // 
        // destinationLanguageTextBox
        // 
        this.destinationLanguageTextBox.BackColor = System.Drawing.SystemColors.Window;
        this.destinationLanguageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.destinationLanguageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.destinationLanguageTextBox.Location = new System.Drawing.Point(0, 33);
        this.destinationLanguageTextBox.Margin = new System.Windows.Forms.Padding(4);
        this.destinationLanguageTextBox.Multiline = true;
        this.destinationLanguageTextBox.Name = "destinationLanguageTextBox";
        this.destinationLanguageTextBox.ReadOnly = true;
        this.destinationLanguageTextBox.Size = new System.Drawing.Size(441, 394);
        this.destinationLanguageTextBox.TabIndex = 2;
        // 
        // destinationLanguageComboBox
        // 
        this.destinationLanguageComboBox.Dock = System.Windows.Forms.DockStyle.Top;
        this.destinationLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.destinationLanguageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.destinationLanguageComboBox.FormattingEnabled = true;
        this.destinationLanguageComboBox.Location = new System.Drawing.Point(0, 0);
        this.destinationLanguageComboBox.Margin = new System.Windows.Forms.Padding(4);
        this.destinationLanguageComboBox.Name = "destinationLanguageComboBox";
        this.destinationLanguageComboBox.Size = new System.Drawing.Size(441, 33);
        this.destinationLanguageComboBox.TabIndex = 2;
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.sourceLanguageTextBox);
        this.panel3.Controls.Add(this.sourceLanguageComboBox);
        this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
        this.panel3.Location = new System.Drawing.Point(0, 0);
        this.panel3.Margin = new System.Windows.Forms.Padding(4);
        this.panel3.Name = "panel3";
        this.panel3.Size = new System.Drawing.Size(431, 427);
        this.panel3.TabIndex = 0;
        // 
        // sourceLanguageTextBox
        // 
        this.sourceLanguageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.sourceLanguageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.sourceLanguageTextBox.Location = new System.Drawing.Point(0, 33);
        this.sourceLanguageTextBox.Margin = new System.Windows.Forms.Padding(4);
        this.sourceLanguageTextBox.Multiline = true;
        this.sourceLanguageTextBox.Name = "sourceLanguageTextBox";
        this.sourceLanguageTextBox.Size = new System.Drawing.Size(431, 394);
        this.sourceLanguageTextBox.TabIndex = 0;
        // 
        // sourceLanguageComboBox
        // 
        this.sourceLanguageComboBox.Dock = System.Windows.Forms.DockStyle.Top;
        this.sourceLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.sourceLanguageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.sourceLanguageComboBox.FormattingEnabled = true;
        this.sourceLanguageComboBox.Location = new System.Drawing.Point(0, 0);
        this.sourceLanguageComboBox.Margin = new System.Windows.Forms.Padding(4);
        this.sourceLanguageComboBox.Name = "sourceLanguageComboBox";
        this.sourceLanguageComboBox.Size = new System.Drawing.Size(431, 33);
        this.sourceLanguageComboBox.TabIndex = 0;
        // 
        // MainView
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1064, 556);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.Margin = new System.Windows.Forms.Padding(4);
        this.Name = "MainView";
        this.Text = "MainView";
        this.panel1.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.panel4.ResumeLayout(false);
        this.panel4.PerformLayout();
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button reverseButton;

    private System.Windows.Forms.Button translateButton;

    private System.Windows.Forms.TextBox destinationLanguageTextBox;

    private System.Windows.Forms.ComboBox destinationLanguageComboBox;

    private System.Windows.Forms.TextBox sourceLanguageTextBox;

    private System.Windows.Forms.ComboBox sourceLanguageComboBox;

    private System.Windows.Forms.Panel panel4;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    #endregion
}