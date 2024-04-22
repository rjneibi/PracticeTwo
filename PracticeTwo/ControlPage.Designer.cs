namespace PracticeTwo
{
    partial class ControlPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPage));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_rentals = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.MediumSlateBlue;
            chartArea1.AxisX.Title = "Cars";
            chartArea1.AxisY.Title = "Rentals";
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend2";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(85, 170);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend2";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(848, 458);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "TOTAL RENTALS BY CAR";
            this.chart1.Titles.Add(title1);
            // 
            // btn_rentals
            // 
            this.btn_rentals.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_rentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rentals.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_rentals.Location = new System.Drawing.Point(146, 663);
            this.btn_rentals.Name = "btn_rentals";
            this.btn_rentals.Size = new System.Drawing.Size(203, 37);
            this.btn_rentals.TabIndex = 1;
            this.btn_rentals.Text = "Rentals";
            this.btn_rentals.UseVisualStyleBackColor = false;
            this.btn_rentals.Click += new System.EventHandler(this.btn_rentals_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_logout.Location = new System.Drawing.Point(646, 663);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(203, 37);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ControlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 725);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_rentals);
            this.Controls.Add(this.chart1);
            this.Name = "ControlPage";
            this.Text = "ControlPage";
            this.Load += new System.EventHandler(this.ControlPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_rentals;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}