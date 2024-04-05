namespace Controls
{
    partial class Form1
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
            this.fraction = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.eraseLast = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.remainder = new System.Windows.Forms.Button();
            this.notes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fraction
            // 
            this.fraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fraction.Location = new System.Drawing.Point(310, 461);
            this.fraction.Name = "fraction";
            this.fraction.Size = new System.Drawing.Size(141, 82);
            this.fraction.TabIndex = 1;
            this.fraction.Text = ".";
            this.fraction.UseVisualStyleBackColor = true;
            this.fraction.Click += new System.EventHandler(this.fraction_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.Location = new System.Drawing.Point(163, 197);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(141, 82);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.NumberClick);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.Location = new System.Drawing.Point(310, 197);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(141, 82);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.NumberClick);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.Location = new System.Drawing.Point(310, 285);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(141, 82);
            this.six.TabIndex = 4;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.NumberClick);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(163, 285);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(141, 82);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.NumberClick);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(16, 285);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(141, 82);
            this.four.TabIndex = 6;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.NumberClick);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.Location = new System.Drawing.Point(16, 197);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(141, 82);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.NumberClick);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(310, 109);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(141, 82);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.OperatorClick);
            // 
            // power
            // 
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.power.Location = new System.Drawing.Point(163, 109);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(141, 82);
            this.power.TabIndex = 9;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.OperatorClick);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(16, 373);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(141, 82);
            this.one.TabIndex = 10;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.NumberClick);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate.Location = new System.Drawing.Point(457, 461);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(141, 82);
            this.calculate.TabIndex = 11;
            this.calculate.Text = "=";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(163, 373);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(141, 82);
            this.two.TabIndex = 12;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.NumberClick);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(310, 373);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(141, 82);
            this.three.TabIndex = 13;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.NumberClick);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(457, 373);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(141, 82);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.OperatorClick);
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtract.Location = new System.Drawing.Point(457, 285);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(141, 82);
            this.subtract.TabIndex = 15;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(457, 197);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(141, 82);
            this.add.TabIndex = 16;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.OperatorClick);
            // 
            // erase
            // 
            this.erase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erase.Location = new System.Drawing.Point(457, 109);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(141, 82);
            this.erase.TabIndex = 17;
            this.erase.Text = "C";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.Location = new System.Drawing.Point(16, 461);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(141, 82);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.NumberClick);
            // 
            // eraseLast
            // 
            this.eraseLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eraseLast.Location = new System.Drawing.Point(16, 109);
            this.eraseLast.Name = "eraseLast";
            this.eraseLast.Size = new System.Drawing.Size(141, 82);
            this.eraseLast.TabIndex = 19;
            this.eraseLast.Text = "⌫";
            this.eraseLast.UseVisualStyleBackColor = true;
            this.eraseLast.Click += new System.EventHandler(this.eraseLast_Click);
            // 
            // result
            // 
            this.result.AutoEllipsis = true;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(16, 27);
            this.result.Name = "result";
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(582, 72);
            this.result.TabIndex = 0;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // remainder
            // 
            this.remainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remainder.Location = new System.Drawing.Point(163, 461);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(141, 82);
            this.remainder.TabIndex = 20;
            this.remainder.Text = "%";
            this.remainder.UseVisualStyleBackColor = true;
            this.remainder.Click += new System.EventHandler(this.OperatorClick);
            // 
            // notes
            // 
            this.notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notes.Location = new System.Drawing.Point(28, 561);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(523, 23);
            this.notes.TabIndex = 21;
            this.notes.Text = "% - is an operator which finds the remainder of the division";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(616, 620);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.remainder);
            this.Controls.Add(this.eraseLast);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.add);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.one);
            this.Controls.Add(this.power);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.fraction);
            this.Controls.Add(this.result);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label notes;

        private System.Windows.Forms.Button remainder;

        private System.Windows.Forms.Label result;

        private System.Windows.Forms.Button eraseLast;

        private System.Windows.Forms.Button zero;

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button erase;

        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button one;

        private System.Windows.Forms.Button fraction;

        #endregion
    }
}