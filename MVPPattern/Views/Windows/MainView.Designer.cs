using System.ComponentModel;

namespace MVPPattern.Views.Windows;

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
        this.usersListBox = new System.Windows.Forms.ListBox();
        this.addButton = new System.Windows.Forms.Button();
        this.updateButton = new System.Windows.Forms.Button();
        this.removeButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // usersListBox
        // 
        this.usersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.usersListBox.FormattingEnabled = true;
        this.usersListBox.ItemHeight = 16;
        this.usersListBox.Location = new System.Drawing.Point(24, 12);
        this.usersListBox.Name = "usersListBox";
        this.usersListBox.Size = new System.Drawing.Size(764, 340);
        this.usersListBox.TabIndex = 0;
        // 
        // addButton
        // 
        this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.addButton.Location = new System.Drawing.Point(24, 391);
        this.addButton.Name = "addButton";
        this.addButton.Size = new System.Drawing.Size(94, 47);
        this.addButton.TabIndex = 1;
        this.addButton.Text = "Add";
        this.addButton.UseVisualStyleBackColor = true;
        this.addButton.Click += new System.EventHandler(this.addButton_Click);
        // 
        // updateButton
        // 
        this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.updateButton.Location = new System.Drawing.Point(124, 391);
        this.updateButton.Name = "updateButton";
        this.updateButton.Size = new System.Drawing.Size(94, 47);
        this.updateButton.TabIndex = 2;
        this.updateButton.Text = "Update";
        this.updateButton.UseVisualStyleBackColor = true;
        this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
        // 
        // removeButton
        // 
        this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.removeButton.Location = new System.Drawing.Point(694, 391);
        this.removeButton.Name = "removeButton";
        this.removeButton.Size = new System.Drawing.Size(94, 47);
        this.removeButton.TabIndex = 3;
        this.removeButton.Text = "Remove";
        this.removeButton.UseVisualStyleBackColor = true;
        this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
        // 
        // MainView
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.removeButton);
        this.Controls.Add(this.updateButton);
        this.Controls.Add(this.addButton);
        this.Controls.Add(this.usersListBox);
        this.Name = "MainView";
        this.Text = "MainView";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button updateButton;
    private System.Windows.Forms.Button removeButton;

    private System.Windows.Forms.ListBox usersListBox;

    #endregion
}