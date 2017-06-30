namespace CalculatorDate
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDate1 = new System.Windows.Forms.TextBox();
            this.textBoxDate2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMonths = new System.Windows.Forms.Button();
            this.textBoxMonths = new System.Windows.Forms.TextBox();
            this.textBoxWeeks = new System.Windows.Forms.TextBox();
            this.buttonWeeks = new System.Windows.Forms.Button();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.buttonDays = new System.Windows.Forms.Button();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.buttonHours = new System.Windows.Forms.Button();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.buttonMinutes = new System.Windows.Forms.Button();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.buttonSeconds = new System.Windows.Forms.Button();
            this.textBoxProtocol = new System.Windows.Forms.TextBox();
            this.buttonProtocol = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDate1
            // 
            this.textBoxDate1.Location = new System.Drawing.Point(48, 30);
            this.textBoxDate1.Name = "textBoxDate1";
            this.textBoxDate1.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate1.TabIndex = 0;
            // 
            // textBoxDate2
            // 
            this.textBoxDate2.Location = new System.Drawing.Point(249, 30);
            this.textBoxDate2.Name = "textBoxDate2";
            this.textBoxDate2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата 2";
            // 
            // buttonMonths
            // 
            this.buttonMonths.Location = new System.Drawing.Point(12, 60);
            this.buttonMonths.Name = "buttonMonths";
            this.buttonMonths.Size = new System.Drawing.Size(176, 23);
            this.buttonMonths.TabIndex = 4;
            this.buttonMonths.Text = "Кол-во месяцев";
            this.buttonMonths.UseVisualStyleBackColor = true;
            this.buttonMonths.Click += new System.EventHandler(this.buttonMonths_Click);
            // 
            // textBoxMonths
            // 
            this.textBoxMonths.Location = new System.Drawing.Point(194, 62);
            this.textBoxMonths.Name = "textBoxMonths";
            this.textBoxMonths.ReadOnly = true;
            this.textBoxMonths.Size = new System.Drawing.Size(197, 20);
            this.textBoxMonths.TabIndex = 5;
            // 
            // textBoxWeeks
            // 
            this.textBoxWeeks.Location = new System.Drawing.Point(194, 91);
            this.textBoxWeeks.Name = "textBoxWeeks";
            this.textBoxWeeks.ReadOnly = true;
            this.textBoxWeeks.Size = new System.Drawing.Size(197, 20);
            this.textBoxWeeks.TabIndex = 7;
            // 
            // buttonWeeks
            // 
            this.buttonWeeks.Location = new System.Drawing.Point(12, 89);
            this.buttonWeeks.Name = "buttonWeeks";
            this.buttonWeeks.Size = new System.Drawing.Size(176, 23);
            this.buttonWeeks.TabIndex = 6;
            this.buttonWeeks.Text = "Кол-во недель";
            this.buttonWeeks.UseVisualStyleBackColor = true;
            this.buttonWeeks.Click += new System.EventHandler(this.buttonWeeks_Click);
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(194, 119);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.ReadOnly = true;
            this.textBoxDays.Size = new System.Drawing.Size(197, 20);
            this.textBoxDays.TabIndex = 9;
            // 
            // buttonDays
            // 
            this.buttonDays.Location = new System.Drawing.Point(12, 117);
            this.buttonDays.Name = "buttonDays";
            this.buttonDays.Size = new System.Drawing.Size(176, 23);
            this.buttonDays.TabIndex = 8;
            this.buttonDays.Text = "Кол-во дней";
            this.buttonDays.UseVisualStyleBackColor = true;
            this.buttonDays.Click += new System.EventHandler(this.buttonDays_Click);
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(194, 148);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.ReadOnly = true;
            this.textBoxHours.Size = new System.Drawing.Size(197, 20);
            this.textBoxHours.TabIndex = 11;
            // 
            // buttonHours
            // 
            this.buttonHours.Location = new System.Drawing.Point(12, 146);
            this.buttonHours.Name = "buttonHours";
            this.buttonHours.Size = new System.Drawing.Size(176, 23);
            this.buttonHours.TabIndex = 10;
            this.buttonHours.Text = "Кол-во часов";
            this.buttonHours.UseVisualStyleBackColor = true;
            this.buttonHours.Click += new System.EventHandler(this.buttonHours_Click);
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(194, 177);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.ReadOnly = true;
            this.textBoxMinutes.Size = new System.Drawing.Size(197, 20);
            this.textBoxMinutes.TabIndex = 13;
            // 
            // buttonMinutes
            // 
            this.buttonMinutes.Location = new System.Drawing.Point(12, 175);
            this.buttonMinutes.Name = "buttonMinutes";
            this.buttonMinutes.Size = new System.Drawing.Size(176, 23);
            this.buttonMinutes.TabIndex = 12;
            this.buttonMinutes.Text = "Кол-во минут";
            this.buttonMinutes.UseVisualStyleBackColor = true;
            this.buttonMinutes.Click += new System.EventHandler(this.buttonMinutes_Click);
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Location = new System.Drawing.Point(194, 206);
            this.textBoxSeconds.Multiline = true;
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.ReadOnly = true;
            this.textBoxSeconds.Size = new System.Drawing.Size(197, 20);
            this.textBoxSeconds.TabIndex = 15;
            // 
            // buttonSeconds
            // 
            this.buttonSeconds.Location = new System.Drawing.Point(12, 204);
            this.buttonSeconds.Name = "buttonSeconds";
            this.buttonSeconds.Size = new System.Drawing.Size(176, 23);
            this.buttonSeconds.TabIndex = 14;
            this.buttonSeconds.Text = "Кол-во секунд";
            this.buttonSeconds.UseVisualStyleBackColor = true;
            this.buttonSeconds.Click += new System.EventHandler(this.buttonSeconds_Click);
            // 
            // textBoxProtocol
            // 
            this.textBoxProtocol.Location = new System.Drawing.Point(12, 274);
            this.textBoxProtocol.Multiline = true;
            this.textBoxProtocol.Name = "textBoxProtocol";
            this.textBoxProtocol.ReadOnly = true;
            this.textBoxProtocol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxProtocol.Size = new System.Drawing.Size(468, 319);
            this.textBoxProtocol.TabIndex = 16;
            // 
            // buttonProtocol
            // 
            this.buttonProtocol.Location = new System.Drawing.Point(12, 245);
            this.buttonProtocol.Name = "buttonProtocol";
            this.buttonProtocol.Size = new System.Drawing.Size(175, 23);
            this.buttonProtocol.TabIndex = 17;
            this.buttonProtocol.Text = "Показать протокол";
            this.buttonProtocol.UseVisualStyleBackColor = true;
            this.buttonProtocol.Click += new System.EventHandler(this.buttonProtocol_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 599);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(468, 63);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Справочный материал по форматам дат в разных странах:\r\nРоссия: ДД.ММ.ГГГГ\r\nСША: М" +
    "М-ДД-ГГГГ\r\nВеликобритания: ДД/ММ/ГГГГ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 673);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonProtocol);
            this.Controls.Add(this.textBoxProtocol);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.buttonSeconds);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.buttonMinutes);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.buttonHours);
            this.Controls.Add(this.textBoxDays);
            this.Controls.Add(this.buttonDays);
            this.Controls.Add(this.textBoxWeeks);
            this.Controls.Add(this.buttonWeeks);
            this.Controls.Add(this.textBoxMonths);
            this.Controls.Add(this.buttonMonths);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDate2);
            this.Controls.Add(this.textBoxDate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDate1;
        private System.Windows.Forms.TextBox textBoxDate2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMonths;
        private System.Windows.Forms.TextBox textBoxMonths;
        private System.Windows.Forms.TextBox textBoxWeeks;
        private System.Windows.Forms.Button buttonWeeks;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.Button buttonDays;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.Button buttonHours;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.Button buttonMinutes;
        private System.Windows.Forms.TextBox textBoxSeconds;
        private System.Windows.Forms.Button buttonSeconds;
        private System.Windows.Forms.TextBox textBoxProtocol;
        private System.Windows.Forms.Button buttonProtocol;
        private System.Windows.Forms.TextBox textBox1;
    }
}

