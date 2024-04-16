using System.ComponentModel;

namespace MVPPattern.Views.Windows;

partial class AddView
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
        this.loginTextBox = new System.Windows.Forms.TextBox();
        this.passwordTextBox = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.addButton = new System.Windows.Forms.Button();
        this.cancelButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // loginTextBox
        // 
        this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.loginTextBox.Location = new System.Drawing.Point(112, 12);
        this.loginTextBox.Multiline = true;
        this.loginTextBox.Name = "loginTextBox";
        this.loginTextBox.Size = new System.Drawing.Size(381, 46);
        this.loginTextBox.TabIndex = 0;
        // 
        // passwordTextBox
        // 
        this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.passwordTextBox.Location = new System.Drawing.Point(112, 78);
        this.passwordTextBox.Multiline = true;
        this.passwordTextBox.Name = "passwordTextBox";
        this.passwordTextBox.Size = new System.Drawing.Size(381, 46);
        this.passwordTextBox.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label1.Location = new System.Drawing.Point(6, 20);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(100, 23);
        this.label1.TabIndex = 2;
        this.label1.Text = "Login:";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label2.Location = new System.Drawing.Point(6, 91);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(100, 23);
        this.label2.TabIndex = 3;
        this.label2.Text = "Password:";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // addButton
        // 
        this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.addButton.Location = new System.Drawing.Point(275, 365);
        this.addButton.Name = "addButton";
        this.addButton.Size = new System.Drawing.Size(101, 39);
        this.addButton.TabIndex = 4;
        this.addButton.Text = "Add";
        this.addButton.UseVisualStyleBackColor = true;
        this.addButton.Click += new System.EventHandler(this.addButton_Click);
        // 
        // cancelButton
        // 
        this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.cancelButton.Location = new System.Drawing.Point(382, 365);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new System.Drawing.Size(101, 39);
        this.cancelButton.TabIndex = 5;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
        // 
        // AddView
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(505, 423);
        this.Controls.Add(this.cancelButton);
        this.Controls.Add(this.addButton);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.passwordTextBox);
        this.Controls.Add(this.loginTextBox);
        this.Name = "AddView";
        this.Text = "AddView";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button cancelButton;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button addButton;

    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox loginTextBox;

    #endregion
}