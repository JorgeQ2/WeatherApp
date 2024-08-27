namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblWeather;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCity = new TextBox();
            btnGetWeather = new Button();
            lblWeather = new Label();
            SuspendLayout();
            // 
            // txtCity
            // 
            txtCity.Location = new Point(14, 14);
            txtCity.Margin = new Padding(4, 3, 4, 3);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(303, 23);
            txtCity.TabIndex = 0;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(14, 44);
            btnGetWeather.Margin = new Padding(4, 3, 4, 3);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(303, 27);
            btnGetWeather.TabIndex = 1;
            btnGetWeather.Text = "Get Weather";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // lblWeather
            // 
            lblWeather.AutoSize = true;
            lblWeather.Location = new Point(14, 74);
            lblWeather.Margin = new Padding(4, 0, 4, 0);
            lblWeather.Name = "lblWeather";
            lblWeather.Size = new Size(0, 15);
            lblWeather.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 301);
            Controls.Add(lblWeather);
            Controls.Add(btnGetWeather);
            Controls.Add(txtCity);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Weather App";
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion
    }
}
