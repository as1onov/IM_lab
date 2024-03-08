namespace лаба1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label_height = new System.Windows.Forms.Label();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.label_angle = new System.Windows.Forms.Label();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.label_size = new System.Windows.Forms.Label();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.label_speed = new System.Windows.Forms.Label();
            this.edWeight = new System.Windows.Forms.NumericUpDown();
            this.label_weight = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_start = new System.Windows.Forms.Button();
            this.edStep = new System.Windows.Forms.NumericUpDown();
            this.label_step = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_TimeStep = new System.Windows.Forms.Label();
            this.label_Distance = new System.Windows.Forms.Label();
            this.label_Max_height = new System.Windows.Forms.Label();
            this.labe_end_point = new System.Windows.Forms.Label();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.textBox_distance = new System.Windows.Forms.TextBox();
            this.textBox_max_height = new System.Windows.Forms.TextBox();
            this.textBox1_speed_end_point = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).BeginInit();
            this.SuspendLayout();
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(22, 30);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(55, 16);
            this.label_height.TabIndex = 0;
            this.label_height.Text = "Высота";
            this.label_height.Click += new System.EventHandler(this.height_Click);
            // 
            // edHeight
            // 
            this.edHeight.BackColor = System.Drawing.Color.White;
            this.edHeight.Location = new System.Drawing.Point(83, 26);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(120, 22);
            this.edHeight.TabIndex = 1;
            this.edHeight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.edHeight.ValueChanged += new System.EventHandler(this.edHeight_ValueChanged);
            // 
            // edAngle
            // 
            this.edAngle.BackColor = System.Drawing.Color.White;
            this.edAngle.Location = new System.Drawing.Point(292, 30);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(120, 22);
            this.edAngle.TabIndex = 3;
            this.edAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label_angle
            // 
            this.label_angle.AutoSize = true;
            this.label_angle.Location = new System.Drawing.Point(248, 32);
            this.label_angle.Name = "label_angle";
            this.label_angle.Size = new System.Drawing.Size(38, 16);
            this.label_angle.TabIndex = 2;
            this.label_angle.Text = "Угол";
            this.label_angle.Click += new System.EventHandler(this.label1_Click);
            // 
            // edSize
            // 
            this.edSize.BackColor = System.Drawing.Color.White;
            this.edSize.Location = new System.Drawing.Point(710, 30);
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(120, 22);
            this.edSize.TabIndex = 7;
            this.edSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(641, 32);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(57, 16);
            this.label_size.TabIndex = 6;
            this.label_size.Text = "Размер";
            // 
            // edSpeed
            // 
            this.edSpeed.BackColor = System.Drawing.Color.White;
            this.edSpeed.Location = new System.Drawing.Point(490, 30);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(120, 22);
            this.edSpeed.TabIndex = 5;
            this.edSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Location = new System.Drawing.Point(421, 32);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(68, 16);
            this.label_speed.TabIndex = 4;
            this.label_speed.Text = "Скорость";
            // 
            // edWeight
            // 
            this.edWeight.BackColor = System.Drawing.Color.White;
            this.edWeight.Location = new System.Drawing.Point(920, 28);
            this.edWeight.Name = "edWeight";
            this.edWeight.Size = new System.Drawing.Size(120, 22);
            this.edWeight.TabIndex = 9;
            this.edWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Location = new System.Drawing.Point(866, 30);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(48, 16);
            this.label_weight.TabIndex = 8;
            this.label_weight.Text = "Масса";
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(431, 65);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.LabelAngle = 3;
            series1.LabelBorderWidth = 3;
            series1.LabelForeColor = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 3;
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.MarkerStep = 3;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 3;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(829, 439);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Lime;
            this.button_start.Location = new System.Drawing.Point(275, 67);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(150, 33);
            this.button_start.TabIndex = 11;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // edStep
            // 
            this.edStep.BackColor = System.Drawing.Color.White;
            this.edStep.Location = new System.Drawing.Point(83, 65);
            this.edStep.Name = "edStep";
            this.edStep.Size = new System.Drawing.Size(120, 22);
            this.edStep.TabIndex = 13;
            this.edStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label_step
            // 
            this.label_step.AutoSize = true;
            this.label_step.Location = new System.Drawing.Point(22, 67);
            this.label_step.Name = "label_step";
            this.label_step.Size = new System.Drawing.Size(32, 16);
            this.label_step.TabIndex = 12;
            this.label_step.Text = "Шаг";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_TimeStep
            // 
            this.label_TimeStep.AutoSize = true;
            this.label_TimeStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeStep.Location = new System.Drawing.Point(17, 118);
            this.label_TimeStep.Name = "label_TimeStep";
            this.label_TimeStep.Size = new System.Drawing.Size(98, 25);
            this.label_TimeStep.TabIndex = 14;
            this.label_TimeStep.Text = "Time step";
            // 
            // label_Distance
            // 
            this.label_Distance.AutoSize = true;
            this.label_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Distance.Location = new System.Drawing.Point(17, 152);
            this.label_Distance.Name = "label_Distance";
            this.label_Distance.Size = new System.Drawing.Size(88, 25);
            this.label_Distance.TabIndex = 15;
            this.label_Distance.Text = "Distance";
            this.label_Distance.Click += new System.EventHandler(this.label_Distance_Click);
            // 
            // label_Max_height
            // 
            this.label_Max_height.AutoSize = true;
            this.label_Max_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Max_height.Location = new System.Drawing.Point(17, 177);
            this.label_Max_height.Name = "label_Max_height";
            this.label_Max_height.Size = new System.Drawing.Size(108, 25);
            this.label_Max_height.TabIndex = 16;
            this.label_Max_height.Text = "Max height";
            // 
            // labe_end_point
            // 
            this.labe_end_point.AutoSize = true;
            this.labe_end_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labe_end_point.Location = new System.Drawing.Point(17, 202);
            this.labe_end_point.Name = "labe_end_point";
            this.labe_end_point.Size = new System.Drawing.Size(208, 25);
            this.labe_end_point.TabIndex = 17;
            this.labe_end_point.Text = "Speed at the end point";
            this.labe_end_point.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox_step
            // 
            this.textBox_step.Location = new System.Drawing.Point(251, 122);
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(100, 22);
            this.textBox_step.TabIndex = 18;
            this.textBox_step.TextChanged += new System.EventHandler(this.textBox_step_TextChanged);
            // 
            // textBox_distance
            // 
            this.textBox_distance.Location = new System.Drawing.Point(251, 150);
            this.textBox_distance.Name = "textBox_distance";
            this.textBox_distance.Size = new System.Drawing.Size(100, 22);
            this.textBox_distance.TabIndex = 19;
            // 
            // textBox_max_height
            // 
            this.textBox_max_height.Location = new System.Drawing.Point(251, 178);
            this.textBox_max_height.Name = "textBox_max_height";
            this.textBox_max_height.Size = new System.Drawing.Size(100, 22);
            this.textBox_max_height.TabIndex = 20;
            // 
            // textBox1_speed_end_point
            // 
            this.textBox1_speed_end_point.Location = new System.Drawing.Point(251, 206);
            this.textBox1_speed_end_point.Name = "textBox1_speed_end_point";
            this.textBox1_speed_end_point.Size = new System.Drawing.Size(100, 22);
            this.textBox1_speed_end_point.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 535);
            this.Controls.Add(this.textBox1_speed_end_point);
            this.Controls.Add(this.textBox_max_height);
            this.Controls.Add(this.textBox_distance);
            this.Controls.Add(this.textBox_step);
            this.Controls.Add(this.labe_end_point);
            this.Controls.Add(this.label_Max_height);
            this.Controls.Add(this.label_Distance);
            this.Controls.Add(this.label_TimeStep);
            this.Controls.Add(this.edStep);
            this.Controls.Add(this.label_step);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.edWeight);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.edSize);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.edSpeed);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.edAngle);
            this.Controls.Add(this.label_angle);
            this.Controls.Add(this.edHeight);
            this.Controls.Add(this.label_height);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.Label label_angle;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.NumericUpDown edWeight;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.NumericUpDown edStep;
        private System.Windows.Forms.Label label_step;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_TimeStep;
        private System.Windows.Forms.Label label_Distance;
        private System.Windows.Forms.Label label_Max_height;
        private System.Windows.Forms.Label labe_end_point;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.TextBox textBox_distance;
        private System.Windows.Forms.TextBox textBox_max_height;
        private System.Windows.Forms.TextBox textBox1_speed_end_point;
    }
}

