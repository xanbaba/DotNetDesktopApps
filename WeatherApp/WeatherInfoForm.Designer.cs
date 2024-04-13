using System.ComponentModel;

namespace WeatherApp;

partial class WeatherInfoForm
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
        this.buttonsPanel = new System.Windows.Forms.Panel();
        this.closeButton = new System.Windows.Forms.Button();
        this.weatherInfoPanel = new System.Windows.Forms.Panel();
        this.label12 = new System.Windows.Forms.Label();
        this.label11 = new System.Windows.Forms.Label();
        this.label10 = new System.Windows.Forms.Label();
        this.label9 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.latitudeLabel = new System.Windows.Forms.Label();
        this.weatherDescriptionLabel = new System.Windows.Forms.Label();
        this.windSpedLabel = new System.Windows.Forms.Label();
        this.humidityLabel = new System.Windows.Forms.Label();
        this.pressureLabel = new System.Windows.Forms.Label();
        this.feelsLikeLabel = new System.Windows.Forms.Label();
        this.longitudeLabel = new System.Windows.Forms.Label();
        this.temperatureLabel = new System.Windows.Forms.Label();
        this.label8 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.buttonsPanel.SuspendLayout();
        this.weatherInfoPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // buttonsPanel
        // 
        this.buttonsPanel.Controls.Add(this.closeButton);
        this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.buttonsPanel.Location = new System.Drawing.Point(0, 596);
        this.buttonsPanel.Name = "buttonsPanel";
        this.buttonsPanel.Size = new System.Drawing.Size(572, 84);
        this.buttonsPanel.TabIndex = 0;
        // 
        // closeButton
        // 
        this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.closeButton.Location = new System.Drawing.Point(0, 0);
        this.closeButton.Name = "closeButton";
        this.closeButton.Size = new System.Drawing.Size(572, 84);
        this.closeButton.TabIndex = 0;
        this.closeButton.Text = "CLOSE";
        this.closeButton.UseVisualStyleBackColor = true;
        this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
        // 
        // weatherInfoPanel
        // 
        this.weatherInfoPanel.Controls.Add(this.label12);
        this.weatherInfoPanel.Controls.Add(this.label11);
        this.weatherInfoPanel.Controls.Add(this.label10);
        this.weatherInfoPanel.Controls.Add(this.label9);
        this.weatherInfoPanel.Controls.Add(this.label1);
        this.weatherInfoPanel.Controls.Add(this.latitudeLabel);
        this.weatherInfoPanel.Controls.Add(this.weatherDescriptionLabel);
        this.weatherInfoPanel.Controls.Add(this.windSpedLabel);
        this.weatherInfoPanel.Controls.Add(this.humidityLabel);
        this.weatherInfoPanel.Controls.Add(this.pressureLabel);
        this.weatherInfoPanel.Controls.Add(this.feelsLikeLabel);
        this.weatherInfoPanel.Controls.Add(this.longitudeLabel);
        this.weatherInfoPanel.Controls.Add(this.temperatureLabel);
        this.weatherInfoPanel.Controls.Add(this.label8);
        this.weatherInfoPanel.Controls.Add(this.label7);
        this.weatherInfoPanel.Controls.Add(this.label6);
        this.weatherInfoPanel.Controls.Add(this.label5);
        this.weatherInfoPanel.Controls.Add(this.label4);
        this.weatherInfoPanel.Controls.Add(this.label3);
        this.weatherInfoPanel.Controls.Add(this.label);
        this.weatherInfoPanel.Controls.Add(this.label2);
        this.weatherInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
        this.weatherInfoPanel.Location = new System.Drawing.Point(0, 0);
        this.weatherInfoPanel.Name = "weatherInfoPanel";
        this.weatherInfoPanel.Size = new System.Drawing.Size(572, 590);
        this.weatherInfoPanel.TabIndex = 1;
        // 
        // label12
        // 
        this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label12.Location = new System.Drawing.Point(366, 343);
        this.label12.Name = "label12";
        this.label12.Size = new System.Drawing.Size(69, 23);
        this.label12.TabIndex = 20;
        this.label12.Text = "m/sec";
        // 
        // label11
        // 
        this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label11.Location = new System.Drawing.Point(366, 290);
        this.label11.Name = "label11";
        this.label11.Size = new System.Drawing.Size(49, 23);
        this.label11.TabIndex = 19;
        this.label11.Text = "%";
        // 
        // label10
        // 
        this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label10.Location = new System.Drawing.Point(366, 236);
        this.label10.Name = "label10";
        this.label10.Size = new System.Drawing.Size(49, 23);
        this.label10.TabIndex = 18;
        this.label10.Text = "hPa";
        // 
        // label9
        // 
        this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label9.Location = new System.Drawing.Point(366, 185);
        this.label9.Name = "label9";
        this.label9.Size = new System.Drawing.Size(49, 23);
        this.label9.TabIndex = 17;
        this.label9.Text = "C";
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label1.Location = new System.Drawing.Point(366, 139);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(49, 23);
        this.label1.TabIndex = 16;
        this.label1.Text = "C";
        // 
        // latitudeLabel
        // 
        this.latitudeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.latitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.latitudeLabel.Location = new System.Drawing.Point(240, 46);
        this.latitudeLabel.Name = "latitudeLabel";
        this.latitudeLabel.Size = new System.Drawing.Size(120, 23);
        this.latitudeLabel.TabIndex = 15;
        // 
        // weatherDescriptionLabel
        // 
        this.weatherDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.weatherDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.weatherDescriptionLabel.Location = new System.Drawing.Point(240, 396);
        this.weatherDescriptionLabel.Name = "weatherDescriptionLabel";
        this.weatherDescriptionLabel.Size = new System.Drawing.Size(120, 23);
        this.weatherDescriptionLabel.TabIndex = 14;
        // 
        // windSpedLabel
        // 
        this.windSpedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.windSpedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.windSpedLabel.Location = new System.Drawing.Point(240, 343);
        this.windSpedLabel.Name = "windSpedLabel";
        this.windSpedLabel.Size = new System.Drawing.Size(120, 23);
        this.windSpedLabel.TabIndex = 13;
        // 
        // humidityLabel
        // 
        this.humidityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.humidityLabel.Location = new System.Drawing.Point(240, 290);
        this.humidityLabel.Name = "humidityLabel";
        this.humidityLabel.Size = new System.Drawing.Size(120, 23);
        this.humidityLabel.TabIndex = 12;
        // 
        // pressureLabel
        // 
        this.pressureLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.pressureLabel.Location = new System.Drawing.Point(240, 236);
        this.pressureLabel.Name = "pressureLabel";
        this.pressureLabel.Size = new System.Drawing.Size(120, 23);
        this.pressureLabel.TabIndex = 11;
        // 
        // feelsLikeLabel
        // 
        this.feelsLikeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.feelsLikeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.feelsLikeLabel.Location = new System.Drawing.Point(240, 185);
        this.feelsLikeLabel.Name = "feelsLikeLabel";
        this.feelsLikeLabel.Size = new System.Drawing.Size(120, 23);
        this.feelsLikeLabel.TabIndex = 10;
        // 
        // longitudeLabel
        // 
        this.longitudeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.longitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.longitudeLabel.Location = new System.Drawing.Point(240, 94);
        this.longitudeLabel.Name = "longitudeLabel";
        this.longitudeLabel.Size = new System.Drawing.Size(120, 23);
        this.longitudeLabel.TabIndex = 9;
        // 
        // temperatureLabel
        // 
        this.temperatureLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.temperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.temperatureLabel.Location = new System.Drawing.Point(240, 139);
        this.temperatureLabel.Name = "temperatureLabel";
        this.temperatureLabel.Size = new System.Drawing.Size(120, 23);
        this.temperatureLabel.TabIndex = 8;
        // 
        // label8
        // 
        this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label8.Location = new System.Drawing.Point(33, 397);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(201, 23);
        this.label8.TabIndex = 7;
        this.label8.Text = "Weather description:";
        // 
        // label7
        // 
        this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label7.Location = new System.Drawing.Point(33, 343);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(201, 23);
        this.label7.TabIndex = 6;
        this.label7.Text = "Wind speed:";
        // 
        // label6
        // 
        this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label6.Location = new System.Drawing.Point(33, 290);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(201, 23);
        this.label6.TabIndex = 5;
        this.label6.Text = "Humidity:";
        // 
        // label5
        // 
        this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label5.Location = new System.Drawing.Point(33, 237);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(201, 23);
        this.label5.TabIndex = 4;
        this.label5.Text = "Pressure:";
        // 
        // label4
        // 
        this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label4.Location = new System.Drawing.Point(33, 186);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(201, 23);
        this.label4.TabIndex = 3;
        this.label4.Text = "Feels like:";
        // 
        // label3
        // 
        this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label3.Location = new System.Drawing.Point(33, 140);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(201, 23);
        this.label3.TabIndex = 2;
        this.label3.Text = "Temperature:";
        // 
        // label
        // 
        this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label.Location = new System.Drawing.Point(33, 95);
        this.label.Name = "label";
        this.label.Size = new System.Drawing.Size(201, 23);
        this.label.TabIndex = 1;
        this.label.Text = "Longitude:";
        // 
        // label2
        // 
        this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label2.Location = new System.Drawing.Point(33, 46);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(201, 23);
        this.label2.TabIndex = 0;
        this.label2.Text = "Latitude:";
        // 
        // WeatherInfoForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(572, 680);
        this.Controls.Add(this.weatherInfoPanel);
        this.Controls.Add(this.buttonsPanel);
        this.Name = "WeatherInfoForm";
        this.Text = "WeatherInfoForm";
        this.buttonsPanel.ResumeLayout(false);
        this.weatherInfoPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Label feelsLikeLabel;
    private System.Windows.Forms.Label pressureLabel;
    private System.Windows.Forms.Label humidityLabel;
    private System.Windows.Forms.Label windSpedLabel;
    private System.Windows.Forms.Label weatherDescriptionLabel;
    private System.Windows.Forms.Label latitudeLabel;

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label temperatureLabel;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label longitudeLabel;

    private System.Windows.Forms.Label label;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button closeButton;

    private System.Windows.Forms.Panel weatherInfoPanel;

    private System.Windows.Forms.Panel buttonsPanel;

    #endregion
}