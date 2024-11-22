namespace WeatherAppAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtCity = new TextBox();
            label2 = new Label();
            lblTemp = new Label();
            lblWindspeed = new Label();
            lblCondition = new Label();
            pbCondition = new PictureBox();
            lblLocation = new Label();
            pictureBox1 = new PictureBox();
            cmdGetWeather = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblHumidity = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCondition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 25F);
            txtCity.Location = new Point(32, 78);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(270, 52);
            txtCity.TabIndex = 1;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 9);
            label2.Name = "label2";
            label2.Size = new Size(237, 45);
            label2.TabIndex = 0;
            label2.Text = "Weather App";
            label2.Click += label1_Click;
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Bahnschrift Condensed", 45F, FontStyle.Bold);
            lblTemp.ForeColor = SystemColors.ButtonHighlight;
            lblTemp.Location = new Point(9, 163);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(133, 72);
            lblTemp.TabIndex = 3;
            lblTemp.Text = "Temp";
            // 
            // lblWindspeed
            // 
            lblWindspeed.AutoSize = true;
            lblWindspeed.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Bold);
            lblWindspeed.ForeColor = SystemColors.ButtonHighlight;
            lblWindspeed.Location = new Point(63, 277);
            lblWindspeed.Name = "lblWindspeed";
            lblWindspeed.Size = new Size(131, 27);
            lblWindspeed.TabIndex = 4;
            lblWindspeed.Text = "Windspeed (kph)";
            lblWindspeed.Click += lblWindspeed_Click;
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold);
            lblCondition.ForeColor = SystemColors.ButtonHighlight;
            lblCondition.Location = new Point(21, 235);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(87, 29);
            lblCondition.TabIndex = 4;
            lblCondition.Text = "Condition";
            // 
            // pbCondition
            // 
            pbCondition.Location = new Point(236, 178);
            pbCondition.Name = "pbCondition";
            pbCondition.Size = new Size(145, 113);
            pbCondition.TabIndex = 5;
            pbCondition.TabStop = false;
            pbCondition.Click += pbCondition_Click;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Sans Serif Collection", 18F, FontStyle.Bold);
            lblLocation.ForeColor = SystemColors.ButtonHighlight;
            lblLocation.Location = new Point(97, 394);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(190, 59);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 394);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cmdGetWeather
            // 
            cmdGetWeather.BackColor = Color.FromArgb(0, 0, 64);
            cmdGetWeather.FlatStyle = FlatStyle.Popup;
            cmdGetWeather.Image = Properties.Resources.icons8_search_50;
            cmdGetWeather.Location = new Point(308, 78);
            cmdGetWeather.Name = "cmdGetWeather";
            cmdGetWeather.Size = new Size(64, 52);
            cmdGetWeather.TabIndex = 7;
            cmdGetWeather.UseVisualStyleBackColor = false;
            cmdGetWeather.Click += cmdGetWeather_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_wind_symbol_50;
            pictureBox2.Location = new Point(32, 277);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pbCondition_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_humidity_50;
            pictureBox3.Location = new Point(32, 317);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pbCondition_Click;
            // 
            // lblHumidity
            // 
            lblHumidity.AutoSize = true;
            lblHumidity.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Bold);
            lblHumidity.ForeColor = SystemColors.ButtonHighlight;
            lblHumidity.Location = new Point(67, 317);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(75, 27);
            lblHumidity.TabIndex = 4;
            lblHumidity.Text = "Humidity";
            lblHumidity.Click += lblWindspeed_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(404, 511);
            Controls.Add(cmdGetWeather);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pbCondition);
            Controls.Add(lblLocation);
            Controls.Add(lblCondition);
            Controls.Add(lblHumidity);
            Controls.Add(lblWindspeed);
            Controls.Add(lblTemp);
            Controls.Add(txtCity);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbCondition).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCity;
        private Label label2;
        private Label lblTemp;
        private Label lblWindspeed;
        private Label lblCondition;
        private PictureBox pbCondition;
        private Label lblLocation;
        private PictureBox pictureBox1;
        private Button cmdGetWeather;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblHumidity;
    }
}
