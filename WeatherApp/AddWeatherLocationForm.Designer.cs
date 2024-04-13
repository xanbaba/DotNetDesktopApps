using System.ComponentModel;

namespace WeatherApp;

partial class AddWeatherLocationForm
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
        this.cityNamePanel = new System.Windows.Forms.Panel();
        this.cityNameTextBox = new System.Windows.Forms.TextBox();
        this.coordsPanel = new System.Windows.Forms.Panel();
        this.longitudeTextBox = new System.Windows.Forms.TextBox();
        this.latitudeTextBox = new System.Windows.Forms.TextBox();
        this.cityNameRadioButton = new System.Windows.Forms.RadioButton();
        this.coordsRadioButton = new System.Windows.Forms.RadioButton();
        this.panel3 = new System.Windows.Forms.Panel();
        this.cancelButton = new System.Windows.Forms.Button();
        this.addButton = new System.Windows.Forms.Button();
        this.errorLabel = new System.Windows.Forms.Label();
        this.cityNamePanel.SuspendLayout();
        this.coordsPanel.SuspendLayout();
        this.panel3.SuspendLayout();
        this.SuspendLayout();
        // 
        // cityNamePanel
        // 
        this.cityNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.cityNamePanel.Controls.Add(this.cityNameTextBox);
        this.cityNamePanel.Location = new System.Drawing.Point(16, 53);
        this.cityNamePanel.Margin = new System.Windows.Forms.Padding(4);
        this.cityNamePanel.Name = "cityNamePanel";
        this.cityNamePanel.Size = new System.Drawing.Size(551, 205);
        this.cityNamePanel.TabIndex = 0;
        // 
        // cityNameTextBox
        // 
        this.cityNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.cityNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.cityNameTextBox.Location = new System.Drawing.Point(19, 47);
        this.cityNameTextBox.Margin = new System.Windows.Forms.Padding(4);
        this.cityNameTextBox.Multiline = true;
        this.cityNameTextBox.Name = "cityNameTextBox";
        this.cityNameTextBox.Size = new System.Drawing.Size(514, 86);
        this.cityNameTextBox.TabIndex = 0;
        // 
        // coordsPanel
        // 
        this.coordsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.coordsPanel.Controls.Add(this.longitudeTextBox);
        this.coordsPanel.Controls.Add(this.latitudeTextBox);
        this.coordsPanel.Enabled = false;
        this.coordsPanel.Location = new System.Drawing.Point(16, 303);
        this.coordsPanel.Margin = new System.Windows.Forms.Padding(4);
        this.coordsPanel.Name = "coordsPanel";
        this.coordsPanel.Size = new System.Drawing.Size(551, 237);
        this.coordsPanel.TabIndex = 1;
        // 
        // longitudeTextBox
        // 
        this.longitudeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.longitudeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.longitudeTextBox.Location = new System.Drawing.Point(19, 134);
        this.longitudeTextBox.Margin = new System.Windows.Forms.Padding(4);
        this.longitudeTextBox.Multiline = true;
        this.longitudeTextBox.Name = "longitudeTextBox";
        this.longitudeTextBox.Size = new System.Drawing.Size(514, 86);
        this.longitudeTextBox.TabIndex = 2;
        // 
        // latitudeTextBox
        // 
        this.latitudeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.latitudeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.latitudeTextBox.Location = new System.Drawing.Point(19, 23);
        this.latitudeTextBox.Margin = new System.Windows.Forms.Padding(4);
        this.latitudeTextBox.Multiline = true;
        this.latitudeTextBox.Name = "latitudeTextBox";
        this.latitudeTextBox.Size = new System.Drawing.Size(514, 86);
        this.latitudeTextBox.TabIndex = 1;
        // 
        // cityNameRadioButton
        // 
        this.cityNameRadioButton.Checked = true;
        this.cityNameRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.cityNameRadioButton.Location = new System.Drawing.Point(16, 16);
        this.cityNameRadioButton.Margin = new System.Windows.Forms.Padding(4);
        this.cityNameRadioButton.Name = "cityNameRadioButton";
        this.cityNameRadioButton.Size = new System.Drawing.Size(176, 30);
        this.cityNameRadioButton.TabIndex = 2;
        this.cityNameRadioButton.TabStop = true;
        this.cityNameRadioButton.Text = "By city name";
        this.cityNameRadioButton.UseVisualStyleBackColor = true;
        this.cityNameRadioButton.CheckedChanged += new System.EventHandler(this.cityNameRadioButton_CheckedChanged);
        // 
        // coordsRadioButton
        // 
        this.coordsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.coordsRadioButton.Location = new System.Drawing.Point(16, 266);
        this.coordsRadioButton.Margin = new System.Windows.Forms.Padding(4);
        this.coordsRadioButton.Name = "coordsRadioButton";
        this.coordsRadioButton.Size = new System.Drawing.Size(176, 30);
        this.coordsRadioButton.TabIndex = 3;
        this.coordsRadioButton.Text = "By coords";
        this.coordsRadioButton.UseVisualStyleBackColor = true;
        this.coordsRadioButton.CheckedChanged += new System.EventHandler(this.coordsRadioButton_CheckedChanged);
        // 
        // panel3
        // 
        this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panel3.Controls.Add(this.cancelButton);
        this.panel3.Controls.Add(this.addButton);
        this.panel3.Location = new System.Drawing.Point(16, 561);
        this.panel3.Margin = new System.Windows.Forms.Padding(4);
        this.panel3.Name = "panel3";
        this.panel3.Size = new System.Drawing.Size(551, 78);
        this.panel3.TabIndex = 2;
        // 
        // cancelButton
        // 
        this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.cancelButton.Location = new System.Drawing.Point(388, 4);
        this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new System.Drawing.Size(145, 71);
        this.cancelButton.TabIndex = 1;
        this.cancelButton.Text = "CANCEL";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
        // 
        // addButton
        // 
        this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.addButton.Location = new System.Drawing.Point(19, 4);
        this.addButton.Margin = new System.Windows.Forms.Padding(4);
        this.addButton.Name = "addButton";
        this.addButton.Size = new System.Drawing.Size(145, 71);
        this.addButton.TabIndex = 0;
        this.addButton.Text = "ADD";
        this.addButton.UseVisualStyleBackColor = true;
        this.addButton.Click += new System.EventHandler(this.addButton_Click);
        // 
        // errorLabel
        // 
        this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.errorLabel.ForeColor = System.Drawing.Color.Brown;
        this.errorLabel.Location = new System.Drawing.Point(16, 656);
        this.errorLabel.Name = "errorLabel";
        this.errorLabel.Size = new System.Drawing.Size(551, 27);
        this.errorLabel.TabIndex = 4;
        // 
        // AddWeatherLocationForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(584, 692);
        this.Controls.Add(this.errorLabel);
        this.Controls.Add(this.panel3);
        this.Controls.Add(this.coordsRadioButton);
        this.Controls.Add(this.cityNameRadioButton);
        this.Controls.Add(this.coordsPanel);
        this.Controls.Add(this.cityNamePanel);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Margin = new System.Windows.Forms.Padding(4);
        this.Name = "AddWeatherLocationForm";
        this.Text = "AddWeatherLocationForm";
        this.cityNamePanel.ResumeLayout(false);
        this.cityNamePanel.PerformLayout();
        this.coordsPanel.ResumeLayout(false);
        this.coordsPanel.PerformLayout();
        this.panel3.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label errorLabel;

    private System.Windows.Forms.TextBox latitudeTextBox;
    private System.Windows.Forms.TextBox longitudeTextBox;

    private System.Windows.Forms.TextBox cityNameTextBox;

    private System.Windows.Forms.Button cancelButton;

    private System.Windows.Forms.Button addButton;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.RadioButton coordsRadioButton;

    private System.Windows.Forms.RadioButton cityNameRadioButton;

    private System.Windows.Forms.Panel cityNamePanel;
    private System.Windows.Forms.Panel coordsPanel;

    #endregion
}