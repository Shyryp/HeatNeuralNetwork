namespace HeatNeuralNetwork
{
    partial class InputInformation
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
            this.bSave = new System.Windows.Forms.Button();
            this.lBPlots = new System.Windows.Forms.ListBox();
            this.bInputTestInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tBPipelineLength = new System.Windows.Forms.TextBox();
            this.tBPipelineDiameter = new System.Windows.Forms.TextBox();
            this.tBOperatingPressure = new System.Windows.Forms.TextBox();
            this.tBWorkingTemperature = new System.Windows.Forms.TextBox();
            this.tBLifeCycle = new System.Windows.Forms.TextBox();
            this.tBNumberDays = new System.Windows.Forms.TextBox();
            this.tBNumberBreakdowns = new System.Windows.Forms.TextBox();
            this.tBPlacesBreakdowns = new System.Windows.Forms.TextBox();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.Plot = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(292, 366);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(116, 23);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lBPlots
            // 
            this.lBPlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBPlots.FormattingEnabled = true;
            this.lBPlots.ItemHeight = 20;
            this.lBPlots.Items.AddRange(new object[] {
            "Участок 1",
            "Участок 2",
            "Участок 3",
            "Участок 4",
            "Участок 5",
            "Участок 6",
            "Участок 7",
            "Участок 8",
            "Участок 9"});
            this.lBPlots.Location = new System.Drawing.Point(12, 36);
            this.lBPlots.Name = "lBPlots";
            this.lBPlots.Size = new System.Drawing.Size(108, 324);
            this.lBPlots.TabIndex = 1;
            // 
            // bInputTestInfo
            // 
            this.bInputTestInfo.Location = new System.Drawing.Point(12, 366);
            this.bInputTestInfo.Name = "bInputTestInfo";
            this.bInputTestInfo.Size = new System.Drawing.Size(201, 23);
            this.bInputTestInfo.TabIndex = 2;
            this.bInputTestInfo.Text = "Заполнить тестовой информацией";
            this.bInputTestInfo.UseVisualStyleBackColor = true;
            this.bInputTestInfo.Click += new System.EventHandler(this.bInputTestInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(138, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Длина трубопровода:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(138, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Диаметр трубы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(138, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Рабочее давление:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(138, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Рабочая температура:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(138, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Реком. время эксплуатации:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(138, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Кол. дней в эксплуатации:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(138, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Количество поломок:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(138, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Места предыдущих поломок:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(138, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Средняя цена ремонта:";
            // 
            // tBPipelineLength
            // 
            this.tBPipelineLength.Location = new System.Drawing.Point(292, 45);
            this.tBPipelineLength.Name = "tBPipelineLength";
            this.tBPipelineLength.Size = new System.Drawing.Size(116, 20);
            this.tBPipelineLength.TabIndex = 12;
            this.tBPipelineLength.Text = "0";
            // 
            // tBPipelineDiameter
            // 
            this.tBPipelineDiameter.Location = new System.Drawing.Point(292, 79);
            this.tBPipelineDiameter.Name = "tBPipelineDiameter";
            this.tBPipelineDiameter.Size = new System.Drawing.Size(116, 20);
            this.tBPipelineDiameter.TabIndex = 13;
            this.tBPipelineDiameter.Text = "0";
            // 
            // tBOperatingPressure
            // 
            this.tBOperatingPressure.Location = new System.Drawing.Point(292, 117);
            this.tBOperatingPressure.Name = "tBOperatingPressure";
            this.tBOperatingPressure.Size = new System.Drawing.Size(116, 20);
            this.tBOperatingPressure.TabIndex = 14;
            this.tBOperatingPressure.Text = "0";
            // 
            // tBWorkingTemperature
            // 
            this.tBWorkingTemperature.Location = new System.Drawing.Point(292, 149);
            this.tBWorkingTemperature.Name = "tBWorkingTemperature";
            this.tBWorkingTemperature.Size = new System.Drawing.Size(116, 20);
            this.tBWorkingTemperature.TabIndex = 15;
            this.tBWorkingTemperature.Text = "0";
            // 
            // tBLifeCycle
            // 
            this.tBLifeCycle.Location = new System.Drawing.Point(292, 186);
            this.tBLifeCycle.Name = "tBLifeCycle";
            this.tBLifeCycle.Size = new System.Drawing.Size(116, 20);
            this.tBLifeCycle.TabIndex = 16;
            this.tBLifeCycle.Text = "0";
            // 
            // tBNumberDays
            // 
            this.tBNumberDays.Location = new System.Drawing.Point(292, 222);
            this.tBNumberDays.Name = "tBNumberDays";
            this.tBNumberDays.Size = new System.Drawing.Size(116, 20);
            this.tBNumberDays.TabIndex = 17;
            this.tBNumberDays.Text = "0";
            // 
            // tBNumberBreakdowns
            // 
            this.tBNumberBreakdowns.Location = new System.Drawing.Point(292, 258);
            this.tBNumberBreakdowns.Name = "tBNumberBreakdowns";
            this.tBNumberBreakdowns.Size = new System.Drawing.Size(116, 20);
            this.tBNumberBreakdowns.TabIndex = 18;
            this.tBNumberBreakdowns.Text = "0";
            // 
            // tBPlacesBreakdowns
            // 
            this.tBPlacesBreakdowns.Location = new System.Drawing.Point(292, 296);
            this.tBPlacesBreakdowns.Name = "tBPlacesBreakdowns";
            this.tBPlacesBreakdowns.Size = new System.Drawing.Size(116, 20);
            this.tBPlacesBreakdowns.TabIndex = 19;
            this.tBPlacesBreakdowns.Text = "0";
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(292, 329);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(116, 20);
            this.tBPrice.TabIndex = 20;
            this.tBPrice.Text = "0";
            // 
            // Plot
            // 
            this.Plot.AutoSize = true;
            this.Plot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Plot.Location = new System.Drawing.Point(141, 22);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(49, 13);
            this.Plot.TabIndex = 21;
            this.Plot.Text = "Участок";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(213, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Введите данные:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Выберите:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(127, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 348);
            this.panel1.TabIndex = 24;
            // 
            // InputInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.tBPrice);
            this.Controls.Add(this.tBPlacesBreakdowns);
            this.Controls.Add(this.tBNumberBreakdowns);
            this.Controls.Add(this.tBNumberDays);
            this.Controls.Add(this.tBLifeCycle);
            this.Controls.Add(this.tBWorkingTemperature);
            this.Controls.Add(this.tBOperatingPressure);
            this.Controls.Add(this.tBPipelineDiameter);
            this.Controls.Add(this.tBPipelineLength);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bInputTestInfo);
            this.Controls.Add(this.lBPlots);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(440, 440);
            this.MinimumSize = new System.Drawing.Size(440, 440);
            this.Name = "InputInformation";
            this.Text = "InputInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ListBox lBPlots;
        private System.Windows.Forms.Button bInputTestInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBPipelineLength;
        private System.Windows.Forms.TextBox tBPipelineDiameter;
        private System.Windows.Forms.TextBox tBOperatingPressure;
        private System.Windows.Forms.TextBox tBWorkingTemperature;
        private System.Windows.Forms.TextBox tBLifeCycle;
        private System.Windows.Forms.TextBox tBNumberDays;
        private System.Windows.Forms.TextBox tBNumberBreakdowns;
        private System.Windows.Forms.TextBox tBPlacesBreakdowns;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.Label Plot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
    }
}