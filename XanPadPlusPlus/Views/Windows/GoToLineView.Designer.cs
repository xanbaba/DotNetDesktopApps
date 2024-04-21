using System.ComponentModel;

namespace XanPadPlusPlus.Views.Windows;

partial class GoToLineView
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
        this.label1 = new System.Windows.Forms.Label();
        this.valueNumericUpDown = new System.Windows.Forms.NumericUpDown();
        this.submitButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label1.Location = new System.Drawing.Point(58, 27);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(100, 23);
        this.label1.TabIndex = 0;
        this.label1.Text = "Go to line";
        // 
        // valueNumericUpDown
        // 
        this.valueNumericUpDown.Location = new System.Drawing.Point(38, 53);
        this.valueNumericUpDown.Name = "valueNumericUpDown";
        this.valueNumericUpDown.Size = new System.Drawing.Size(120, 20);
        this.valueNumericUpDown.TabIndex = 1;
        // 
        // submitButton
        // 
        this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.submitButton.Location = new System.Drawing.Point(58, 79);
        this.submitButton.Name = "submitButton";
        this.submitButton.Size = new System.Drawing.Size(75, 23);
        this.submitButton.TabIndex = 2;
        this.submitButton.Text = "Confirm";
        this.submitButton.UseVisualStyleBackColor = true;
        this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
        // 
        // GoToLineView
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(199, 127);
        this.Controls.Add(this.submitButton);
        this.Controls.Add(this.valueNumericUpDown);
        this.Controls.Add(this.label1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Name = "GoToLineView";
        this.Text = "Go To Line";
        ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button submitButton;

    private System.Windows.Forms.NumericUpDown valueNumericUpDown;

    private System.Windows.Forms.Label label1;

    #endregion
}