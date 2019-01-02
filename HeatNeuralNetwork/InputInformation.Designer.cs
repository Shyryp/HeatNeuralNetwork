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
            this.button1 = new System.Windows.Forms.Button();
            this.lBPlots = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
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
            this.lBPlots.Location = new System.Drawing.Point(12, 27);
            this.lBPlots.Name = "lBPlots";
            this.lBPlots.Size = new System.Drawing.Size(108, 264);
            this.lBPlots.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Заполнить тестовой информацией";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // InputInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lBPlots);
            this.Controls.Add(this.button1);
            this.Name = "InputInformation";
            this.Text = "InputInformation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lBPlots;
        private System.Windows.Forms.Button button2;
    }
}