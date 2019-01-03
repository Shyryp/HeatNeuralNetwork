namespace HeatNeuralNetwork
{
    partial class TeachNN
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
            this.bTeach = new System.Windows.Forms.Button();
            this.lBTeachPlots = new System.Windows.Forms.ListBox();
            this.bInputTestTeachInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tBTeachPipelineLength = new System.Windows.Forms.TextBox();
            this.tBTeachPipelineDiameter = new System.Windows.Forms.TextBox();
            this.tBTeachOperatingPressure = new System.Windows.Forms.TextBox();
            this.tBTeachWorkingTemperature = new System.Windows.Forms.TextBox();
            this.tBTeachLifeCycle = new System.Windows.Forms.TextBox();
            this.tBTeachNumberDays = new System.Windows.Forms.TextBox();
            this.tBTeachNumberBreakdowns = new System.Windows.Forms.TextBox();
            this.tBTeachPlacesBreakdowns = new System.Windows.Forms.TextBox();
            this.tBTeachPrice = new System.Windows.Forms.TextBox();
            this.lSet = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.tBPriceTrue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tBPointTrue = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tBDaysTrue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tBAmbientTemp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bTeach
            // 
            this.bTeach.Location = new System.Drawing.Point(451, 406);
            this.bTeach.Name = "bTeach";
            this.bTeach.Size = new System.Drawing.Size(116, 23);
            this.bTeach.TabIndex = 0;
            this.bTeach.Text = "Обучить";
            this.bTeach.UseVisualStyleBackColor = true;
            this.bTeach.Click += new System.EventHandler(this.bTeach_Click);
            // 
            // lBTeachPlots
            // 
            this.lBTeachPlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBTeachPlots.FormattingEnabled = true;
            this.lBTeachPlots.ItemHeight = 20;
            this.lBTeachPlots.Items.AddRange(new object[] {
            "Сет 1",
            "Сет 2",
            "Сет 3",
            "Сет 4",
            "Сет 5",
            "Сет 6",
            "Сет 7",
            "Сет 8",
            "Сет 9"});
            this.lBTeachPlots.Location = new System.Drawing.Point(12, 36);
            this.lBTeachPlots.Name = "lBTeachPlots";
            this.lBTeachPlots.Size = new System.Drawing.Size(81, 364);
            this.lBTeachPlots.TabIndex = 1;
            // 
            // bInputTestTeachInfo
            // 
            this.bInputTestTeachInfo.Location = new System.Drawing.Point(12, 406);
            this.bInputTestTeachInfo.Name = "bInputTestTeachInfo";
            this.bInputTestTeachInfo.Size = new System.Drawing.Size(201, 23);
            this.bInputTestTeachInfo.TabIndex = 2;
            this.bInputTestTeachInfo.Text = "Заполнить тестовой информацией";
            this.bInputTestTeachInfo.UseVisualStyleBackColor = true;
            this.bInputTestTeachInfo.Click += new System.EventHandler(this.bInputTestTeachInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Длина трубопровода:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Диаметр трубы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Рабочее давление:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Рабочая температура:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(14, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Реком. время эксплуатации:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(14, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Кол. дней в эксплуатации:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(14, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Количество поломок:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(14, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Места предыдущих поломок:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(14, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Средняя цена ремонта:";
            // 
            // tBTeachPipelineLength
            // 
            this.tBTeachPipelineLength.Location = new System.Drawing.Point(168, 35);
            this.tBTeachPipelineLength.Name = "tBTeachPipelineLength";
            this.tBTeachPipelineLength.Size = new System.Drawing.Size(44, 20);
            this.tBTeachPipelineLength.TabIndex = 12;
            this.tBTeachPipelineLength.Text = "0";
            // 
            // tBTeachPipelineDiameter
            // 
            this.tBTeachPipelineDiameter.Location = new System.Drawing.Point(168, 69);
            this.tBTeachPipelineDiameter.Name = "tBTeachPipelineDiameter";
            this.tBTeachPipelineDiameter.Size = new System.Drawing.Size(44, 20);
            this.tBTeachPipelineDiameter.TabIndex = 13;
            this.tBTeachPipelineDiameter.Text = "0";
            // 
            // tBTeachOperatingPressure
            // 
            this.tBTeachOperatingPressure.Location = new System.Drawing.Point(168, 107);
            this.tBTeachOperatingPressure.Name = "tBTeachOperatingPressure";
            this.tBTeachOperatingPressure.Size = new System.Drawing.Size(44, 20);
            this.tBTeachOperatingPressure.TabIndex = 14;
            this.tBTeachOperatingPressure.Text = "0";
            // 
            // tBTeachWorkingTemperature
            // 
            this.tBTeachWorkingTemperature.Location = new System.Drawing.Point(168, 139);
            this.tBTeachWorkingTemperature.Name = "tBTeachWorkingTemperature";
            this.tBTeachWorkingTemperature.Size = new System.Drawing.Size(44, 20);
            this.tBTeachWorkingTemperature.TabIndex = 15;
            this.tBTeachWorkingTemperature.Text = "0";
            // 
            // tBTeachLifeCycle
            // 
            this.tBTeachLifeCycle.Location = new System.Drawing.Point(168, 176);
            this.tBTeachLifeCycle.Name = "tBTeachLifeCycle";
            this.tBTeachLifeCycle.Size = new System.Drawing.Size(44, 20);
            this.tBTeachLifeCycle.TabIndex = 16;
            this.tBTeachLifeCycle.Text = "0";
            // 
            // tBTeachNumberDays
            // 
            this.tBTeachNumberDays.Location = new System.Drawing.Point(168, 212);
            this.tBTeachNumberDays.Name = "tBTeachNumberDays";
            this.tBTeachNumberDays.Size = new System.Drawing.Size(44, 20);
            this.tBTeachNumberDays.TabIndex = 17;
            this.tBTeachNumberDays.Text = "0";
            // 
            // tBTeachNumberBreakdowns
            // 
            this.tBTeachNumberBreakdowns.Location = new System.Drawing.Point(168, 248);
            this.tBTeachNumberBreakdowns.Name = "tBTeachNumberBreakdowns";
            this.tBTeachNumberBreakdowns.Size = new System.Drawing.Size(44, 20);
            this.tBTeachNumberBreakdowns.TabIndex = 18;
            this.tBTeachNumberBreakdowns.Text = "0";
            // 
            // tBTeachPlacesBreakdowns
            // 
            this.tBTeachPlacesBreakdowns.Location = new System.Drawing.Point(168, 286);
            this.tBTeachPlacesBreakdowns.Name = "tBTeachPlacesBreakdowns";
            this.tBTeachPlacesBreakdowns.Size = new System.Drawing.Size(44, 20);
            this.tBTeachPlacesBreakdowns.TabIndex = 19;
            this.tBTeachPlacesBreakdowns.Text = "0";
            // 
            // tBTeachPrice
            // 
            this.tBTeachPrice.Location = new System.Drawing.Point(168, 319);
            this.tBTeachPrice.Name = "tBTeachPrice";
            this.tBTeachPrice.Size = new System.Drawing.Size(44, 20);
            this.tBTeachPrice.TabIndex = 20;
            this.tBTeachPrice.Text = "0";
            // 
            // lSet
            // 
            this.lSet.AutoSize = true;
            this.lSet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lSet.Location = new System.Drawing.Point(17, 12);
            this.lSet.Name = "lSet";
            this.lSet.Size = new System.Drawing.Size(25, 13);
            this.lSet.TabIndex = 21;
            this.lSet.Text = "Сет";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(89, 12);
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
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tBPriceTrue);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lSet);
            this.panel1.Controls.Add(this.tBPointTrue);
            this.panel1.Controls.Add(this.tBTeachPrice);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tBTeachPlacesBreakdowns);
            this.panel1.Controls.Add(this.tBDaysTrue);
            this.panel1.Controls.Add(this.tBTeachNumberBreakdowns);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tBTeachNumberDays);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tBTeachLifeCycle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBTeachWorkingTemperature);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tBTeachOperatingPressure);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBTeachPipelineDiameter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tBTeachPipelineLength);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(99, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 351);
            this.panel1.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(256, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Верные ответы:";
            // 
            // tBPriceTrue
            // 
            this.tBPriceTrue.Location = new System.Drawing.Point(380, 103);
            this.tBPriceTrue.Name = "tBPriceTrue";
            this.tBPriceTrue.Size = new System.Drawing.Size(45, 20);
            this.tBPriceTrue.TabIndex = 30;
            this.tBPriceTrue.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(253, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Цена ремонта:";
            // 
            // tBPointTrue
            // 
            this.tBPointTrue.Location = new System.Drawing.Point(380, 69);
            this.tBPointTrue.Name = "tBPointTrue";
            this.tBPointTrue.Size = new System.Drawing.Size(45, 20);
            this.tBPointTrue.TabIndex = 29;
            this.tBPointTrue.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(253, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Кол. дней до поломки:";
            // 
            // tBDaysTrue
            // 
            this.tBDaysTrue.Location = new System.Drawing.Point(380, 35);
            this.tBDaysTrue.Name = "tBDaysTrue";
            this.tBDaysTrue.Size = new System.Drawing.Size(45, 20);
            this.tBDaysTrue.TabIndex = 28;
            this.tBDaysTrue.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(253, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Место поломки:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(116, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(225, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Средняя температура окружающей среды:";
            // 
            // tBAmbientTemp
            // 
            this.tBAmbientTemp.Location = new System.Drawing.Point(358, 20);
            this.tBAmbientTemp.Name = "tBAmbientTemp";
            this.tBAmbientTemp.Size = new System.Drawing.Size(100, 20);
            this.tBAmbientTemp.TabIndex = 26;
            // 
            // TeachNN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 441);
            this.Controls.Add(this.tBAmbientTemp);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bInputTestTeachInfo);
            this.Controls.Add(this.lBTeachPlots);
            this.Controls.Add(this.bTeach);
            this.Controls.Add(this.panel1);
            this.Name = "TeachNN";
            this.Text = "TeachNeuralNetwork";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTeach;
        private System.Windows.Forms.ListBox lBTeachPlots;
        private System.Windows.Forms.Button bInputTestTeachInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBTeachPipelineLength;
        private System.Windows.Forms.TextBox tBTeachPipelineDiameter;
        private System.Windows.Forms.TextBox tBTeachOperatingPressure;
        private System.Windows.Forms.TextBox tBTeachWorkingTemperature;
        private System.Windows.Forms.TextBox tBTeachLifeCycle;
        private System.Windows.Forms.TextBox tBTeachNumberDays;
        private System.Windows.Forms.TextBox tBTeachNumberBreakdowns;
        private System.Windows.Forms.TextBox tBTeachPlacesBreakdowns;
        private System.Windows.Forms.TextBox tBTeachPrice;
        private System.Windows.Forms.Label lSet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tBPriceTrue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBPointTrue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBDaysTrue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tBAmbientTemp;
    }
}