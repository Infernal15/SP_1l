namespace WindowsForms
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RunCalcButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StartedAssemblies = new System.Windows.Forms.ListBox();
            this.AvailableAssemblies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RunCalcButton
            // 
            this.RunCalcButton.Location = new System.Drawing.Point(327, 261);
            this.RunCalcButton.Name = "RunCalcButton";
            this.RunCalcButton.Size = new System.Drawing.Size(157, 31);
            this.RunCalcButton.TabIndex = 13;
            this.RunCalcButton.Text = "RunCalc";
            this.RunCalcButton.UseVisualStyleBackColor = true;
            this.RunCalcButton.Click += new System.EventHandler(this.RunCalc_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(327, 210);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(157, 31);
            this.RefreshButton.TabIndex = 12;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(327, 155);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(157, 31);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "CloseWindow";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(327, 104);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(157, 31);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(327, 49);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(157, 31);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StartedAssemblies
            // 
            this.StartedAssemblies.FormattingEnabled = true;
            this.StartedAssemblies.Location = new System.Drawing.Point(490, 12);
            this.StartedAssemblies.Name = "StartedAssemblies";
            this.StartedAssemblies.Size = new System.Drawing.Size(303, 420);
            this.StartedAssemblies.TabIndex = 8;
            // 
            // AvailableAssemblies
            // 
            this.AvailableAssemblies.FormattingEnabled = true;
            this.AvailableAssemblies.Location = new System.Drawing.Point(18, 13);
            this.AvailableAssemblies.Name = "AvailableAssemblies";
            this.AvailableAssemblies.Size = new System.Drawing.Size(303, 420);
            this.AvailableAssemblies.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 452);
            this.Controls.Add(this.RunCalcButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StartedAssemblies);
            this.Controls.Add(this.AvailableAssemblies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button RunCalcButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListBox StartedAssemblies;
        private System.Windows.Forms.ListBox AvailableAssemblies;
    }
}

