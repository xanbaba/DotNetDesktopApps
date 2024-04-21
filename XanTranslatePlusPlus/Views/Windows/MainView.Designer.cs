using System.ComponentModel;

namespace XanTranslatePlusPlus.Views.Windows;

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
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.comboBox2 = new System.Windows.Forms.ComboBox();
        this.panel3 = new System.Windows.Forms.Panel();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.comboBox1 = new System.Windows.Forms.ComboBox();
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
        this.panel1.Location = new System.Drawing.Point(0, 345);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(800, 105);
        this.panel1.TabIndex = 0;
        // 
        // translateButton
        // 
        this.translateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
        this.translateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.translateButton.Location = new System.Drawing.Point(321, 38);
        this.translateButton.Name = "translateButton";
        this.translateButton.Size = new System.Drawing.Size(156, 40);
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
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(800, 345);
        this.panel2.TabIndex = 1;
        // 
        // reverseButton
        // 
        this.reverseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
        this.reverseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.reverseButton.Location = new System.Drawing.Point(342, 46);
        this.reverseButton.Name = "reverseButton";
        this.reverseButton.Size = new System.Drawing.Size(107, 40);
        this.reverseButton.TabIndex = 1;
        this.reverseButton.Text = "Reverse";
        this.reverseButton.UseVisualStyleBackColor = true;
        this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
        // 
        // panel4
        // 
        this.panel4.Controls.Add(this.textBox2);
        this.panel4.Controls.Add(this.comboBox2);
        this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
        this.panel4.Location = new System.Drawing.Point(469, 0);
        this.panel4.Name = "panel4";
        this.panel4.Size = new System.Drawing.Size(331, 345);
        this.panel4.TabIndex = 1;
        // 
        // textBox2
        // 
        this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textBox2.Location = new System.Drawing.Point(0, 21);
        this.textBox2.Multiline = true;
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(331, 324);
        this.textBox2.TabIndex = 2;
        // 
        // comboBox2
        // 
        this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
        this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBox2.FormattingEnabled = true;
        this.comboBox2.Location = new System.Drawing.Point(0, 0);
        this.comboBox2.Name = "comboBox2";
        this.comboBox2.Size = new System.Drawing.Size(331, 21);
        this.comboBox2.TabIndex = 2;
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.textBox1);
        this.panel3.Controls.Add(this.comboBox1);
        this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
        this.panel3.Location = new System.Drawing.Point(0, 0);
        this.panel3.Name = "panel3";
        this.panel3.Size = new System.Drawing.Size(323, 345);
        this.panel3.TabIndex = 0;
        // 
        // textBox1
        // 
        this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textBox1.Location = new System.Drawing.Point(0, 21);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(323, 324);
        this.textBox1.TabIndex = 1;
        // 
        // comboBox1
        // 
        this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Location = new System.Drawing.Point(0, 0);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new System.Drawing.Size(323, 21);
        this.comboBox1.TabIndex = 0;
        // 
        // MainView
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
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

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.ComboBox comboBox2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Panel panel4;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    #endregion
}