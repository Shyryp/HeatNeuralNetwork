namespace HeatNeuralNetwork
{
    partial class MainWindow
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
            this.bPlot1 = new System.Windows.Forms.Button();
            this.bPlot2 = new System.Windows.Forms.Button();
            this.bPlot3 = new System.Windows.Forms.Button();
            this.bPlot6 = new System.Windows.Forms.Button();
            this.bPlot5 = new System.Windows.Forms.Button();
            this.bPlot4 = new System.Windows.Forms.Button();
            this.bPlot9 = new System.Windows.Forms.Button();
            this.bPlot8 = new System.Windows.Forms.Button();
            this.bPlot7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teachNNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bPlot1
            // 
            this.bPlot1.Location = new System.Drawing.Point(22, 47);
            this.bPlot1.Name = "bPlot1";
            this.bPlot1.Size = new System.Drawing.Size(143, 66);
            this.bPlot1.TabIndex = 0;
            this.bPlot1.Text = "Участок 1";
            this.bPlot1.UseVisualStyleBackColor = true;
            this.bPlot1.Click += new System.EventHandler(this.bPlot1_Click);
            // 
            // bPlot2
            // 
            this.bPlot2.Location = new System.Drawing.Point(180, 47);
            this.bPlot2.Name = "bPlot2";
            this.bPlot2.Size = new System.Drawing.Size(146, 66);
            this.bPlot2.TabIndex = 1;
            this.bPlot2.Text = "Участок 2";
            this.bPlot2.UseVisualStyleBackColor = true;
            this.bPlot2.Click += new System.EventHandler(this.bPlot2_Click);
            // 
            // bPlot3
            // 
            this.bPlot3.Location = new System.Drawing.Point(341, 47);
            this.bPlot3.Name = "bPlot3";
            this.bPlot3.Size = new System.Drawing.Size(141, 66);
            this.bPlot3.TabIndex = 2;
            this.bPlot3.Text = "Участок 3";
            this.bPlot3.UseVisualStyleBackColor = true;
            this.bPlot3.Click += new System.EventHandler(this.bPlot3_Click);
            // 
            // bPlot6
            // 
            this.bPlot6.Location = new System.Drawing.Point(341, 119);
            this.bPlot6.Name = "bPlot6";
            this.bPlot6.Size = new System.Drawing.Size(141, 66);
            this.bPlot6.TabIndex = 5;
            this.bPlot6.Text = "Участок 6";
            this.bPlot6.UseVisualStyleBackColor = true;
            this.bPlot6.Click += new System.EventHandler(this.bPlot6_Click);
            // 
            // bPlot5
            // 
            this.bPlot5.Location = new System.Drawing.Point(180, 119);
            this.bPlot5.Name = "bPlot5";
            this.bPlot5.Size = new System.Drawing.Size(146, 66);
            this.bPlot5.TabIndex = 4;
            this.bPlot5.Text = "Участок 5";
            this.bPlot5.UseVisualStyleBackColor = true;
            this.bPlot5.Click += new System.EventHandler(this.bPlot5_Click);
            // 
            // bPlot4
            // 
            this.bPlot4.Location = new System.Drawing.Point(22, 119);
            this.bPlot4.Name = "bPlot4";
            this.bPlot4.Size = new System.Drawing.Size(143, 66);
            this.bPlot4.TabIndex = 3;
            this.bPlot4.Text = "Участок 4";
            this.bPlot4.UseVisualStyleBackColor = true;
            this.bPlot4.Click += new System.EventHandler(this.bPlot4_Click);
            // 
            // bPlot9
            // 
            this.bPlot9.Location = new System.Drawing.Point(341, 191);
            this.bPlot9.Name = "bPlot9";
            this.bPlot9.Size = new System.Drawing.Size(141, 66);
            this.bPlot9.TabIndex = 8;
            this.bPlot9.Text = "Участок 9";
            this.bPlot9.UseVisualStyleBackColor = true;
            this.bPlot9.Click += new System.EventHandler(this.bPlot9_Click);
            // 
            // bPlot8
            // 
            this.bPlot8.Location = new System.Drawing.Point(180, 191);
            this.bPlot8.Name = "bPlot8";
            this.bPlot8.Size = new System.Drawing.Size(146, 66);
            this.bPlot8.TabIndex = 7;
            this.bPlot8.Text = "Участок 8";
            this.bPlot8.UseVisualStyleBackColor = true;
            this.bPlot8.Click += new System.EventHandler(this.bPlot8_Click);
            // 
            // bPlot7
            // 
            this.bPlot7.Location = new System.Drawing.Point(22, 191);
            this.bPlot7.Name = "bPlot7";
            this.bPlot7.Size = new System.Drawing.Size(143, 66);
            this.bPlot7.TabIndex = 6;
            this.bPlot7.Text = "Участок 7";
            this.bPlot7.UseVisualStyleBackColor = true;
            this.bPlot7.Click += new System.EventHandler(this.bPlot7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teachNNToolStripMenuItem,
            this.fillToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.resetAllToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teachNNToolStripMenuItem
            // 
            this.teachNNToolStripMenuItem.Name = "teachNNToolStripMenuItem";
            this.teachNNToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.teachNNToolStripMenuItem.Text = "Обучить НС";
            this.teachNNToolStripMenuItem.Click += new System.EventHandler(this.teachNNToolStripMenuItem_Click);
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.fillToolStripMenuItem.Text = "Заполнить";
            this.fillToolStripMenuItem.Click += new System.EventHandler(this.fillToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.calculateToolStripMenuItem.Text = "Рассчитать";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem2
            // 
            this.resetAllToolStripMenuItem2.Name = "resetAllToolStripMenuItem2";
            this.resetAllToolStripMenuItem2.Size = new System.Drawing.Size(93, 20);
            this.resetAllToolStripMenuItem2.Text = "Сбросить всё";
            this.resetAllToolStripMenuItem2.Click += new System.EventHandler(this.resetAllToolStripMenuItem2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 314);
            this.Controls.Add(this.bPlot9);
            this.Controls.Add(this.bPlot8);
            this.Controls.Add(this.bPlot7);
            this.Controls.Add(this.bPlot6);
            this.Controls.Add(this.bPlot5);
            this.Controls.Add(this.bPlot4);
            this.Controls.Add(this.bPlot3);
            this.Controls.Add(this.bPlot2);
            this.Controls.Add(this.bPlot1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "HeatNeuralNetwork";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPlot1;
        private System.Windows.Forms.Button bPlot2;
        private System.Windows.Forms.Button bPlot3;
        private System.Windows.Forms.Button bPlot6;
        private System.Windows.Forms.Button bPlot5;
        private System.Windows.Forms.Button bPlot4;
        private System.Windows.Forms.Button bPlot9;
        private System.Windows.Forms.Button bPlot8;
        private System.Windows.Forms.Button bPlot7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teachNNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem2;
    }
}

