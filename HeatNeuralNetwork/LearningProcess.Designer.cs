namespace HeatNeuralNetwork
{
    partial class LearningProcess
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lTrueAnswer1 = new System.Windows.Forms.Label();
            this.lAnswer1 = new System.Windows.Forms.Label();
            this.lTrueAnswer2 = new System.Windows.Forms.Label();
            this.lAnswer2 = new System.Windows.Forms.Label();
            this.lTrueAnswer3 = new System.Windows.Forms.Label();
            this.lAnswer3 = new System.Windows.Forms.Label();
            this.lEra = new System.Windows.Forms.Label();
            this.lTrainingSet = new System.Windows.Forms.Label();
            this.lError = new System.Windows.Forms.Label();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тренировочный сет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Эпоха:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ошибка:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Верные ответы:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ответы нейронной сети:";
            // 
            // lTrueAnswer1
            // 
            this.lTrueAnswer1.AutoSize = true;
            this.lTrueAnswer1.Location = new System.Drawing.Point(182, 133);
            this.lTrueAnswer1.Name = "lTrueAnswer1";
            this.lTrueAnswer1.Size = new System.Drawing.Size(13, 13);
            this.lTrueAnswer1.TabIndex = 5;
            this.lTrueAnswer1.Text = "0";
            // 
            // lAnswer1
            // 
            this.lAnswer1.AutoSize = true;
            this.lAnswer1.Location = new System.Drawing.Point(182, 165);
            this.lAnswer1.Name = "lAnswer1";
            this.lAnswer1.Size = new System.Drawing.Size(13, 13);
            this.lAnswer1.TabIndex = 6;
            this.lAnswer1.Text = "0";
            // 
            // lTrueAnswer2
            // 
            this.lTrueAnswer2.AutoSize = true;
            this.lTrueAnswer2.Location = new System.Drawing.Point(279, 133);
            this.lTrueAnswer2.Name = "lTrueAnswer2";
            this.lTrueAnswer2.Size = new System.Drawing.Size(13, 13);
            this.lTrueAnswer2.TabIndex = 7;
            this.lTrueAnswer2.Text = "0";
            // 
            // lAnswer2
            // 
            this.lAnswer2.AutoSize = true;
            this.lAnswer2.Location = new System.Drawing.Point(279, 165);
            this.lAnswer2.Name = "lAnswer2";
            this.lAnswer2.Size = new System.Drawing.Size(13, 13);
            this.lAnswer2.TabIndex = 8;
            this.lAnswer2.Text = "0";
            // 
            // lTrueAnswer3
            // 
            this.lTrueAnswer3.AutoSize = true;
            this.lTrueAnswer3.Location = new System.Drawing.Point(372, 133);
            this.lTrueAnswer3.Name = "lTrueAnswer3";
            this.lTrueAnswer3.Size = new System.Drawing.Size(13, 13);
            this.lTrueAnswer3.TabIndex = 9;
            this.lTrueAnswer3.Text = "0";
            // 
            // lAnswer3
            // 
            this.lAnswer3.AutoSize = true;
            this.lAnswer3.Location = new System.Drawing.Point(372, 165);
            this.lAnswer3.Name = "lAnswer3";
            this.lAnswer3.Size = new System.Drawing.Size(13, 13);
            this.lAnswer3.TabIndex = 10;
            this.lAnswer3.Text = "0";
            // 
            // lEra
            // 
            this.lEra.AutoSize = true;
            this.lEra.Location = new System.Drawing.Point(81, 41);
            this.lEra.Name = "lEra";
            this.lEra.Size = new System.Drawing.Size(13, 13);
            this.lEra.TabIndex = 11;
            this.lEra.Text = "0";
            // 
            // lTrainingSet
            // 
            this.lTrainingSet.AutoSize = true;
            this.lTrainingSet.Location = new System.Drawing.Point(151, 69);
            this.lTrainingSet.Name = "lTrainingSet";
            this.lTrainingSet.Size = new System.Drawing.Size(13, 13);
            this.lTrainingSet.TabIndex = 12;
            this.lTrainingSet.Text = "0";
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Location = new System.Drawing.Point(90, 99);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(13, 13);
            this.lError.TabIndex = 13;
            this.lError.Text = "0";
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(37, 206);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(140, 23);
            this.bStop.TabIndex = 14;
            this.bStop.Text = "Остановить обучение";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(332, 206);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 15;
            this.bStart.Text = "Старт";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // LearningProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 241);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.lTrainingSet);
            this.Controls.Add(this.lEra);
            this.Controls.Add(this.lAnswer3);
            this.Controls.Add(this.lTrueAnswer3);
            this.Controls.Add(this.lAnswer2);
            this.Controls.Add(this.lTrueAnswer2);
            this.Controls.Add(this.lAnswer1);
            this.Controls.Add(this.lTrueAnswer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LearningProcess";
            this.Text = "LearningProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lTrueAnswer1;
        private System.Windows.Forms.Label lAnswer1;
        private System.Windows.Forms.Label lTrueAnswer2;
        private System.Windows.Forms.Label lAnswer2;
        private System.Windows.Forms.Label lTrueAnswer3;
        private System.Windows.Forms.Label lAnswer3;
        private System.Windows.Forms.Label lEra;
        private System.Windows.Forms.Label lTrainingSet;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
    }
}