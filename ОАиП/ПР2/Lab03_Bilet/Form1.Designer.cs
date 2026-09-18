namespace Lab03_Bilet
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
            this.lblVozrast = new System.Windows.Forms.Label();
            this.txtVozrast = new System.Windows.Forms.TextBox();
            this.btnRaschet = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVozrast
            // 
            this.lblVozrast.AutoSize = true;
            this.lblVozrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.2F);
            this.lblVozrast.Location = new System.Drawing.Point(86, 9);
            this.lblVozrast.Name = "lblVozrast";
            this.lblVozrast.Size = new System.Drawing.Size(250, 33);
            this.lblVozrast.TabIndex = 0;
            this.lblVozrast.Text = "Возраст зрителя:";
            // 
            // txtVozrast
            // 
            this.txtVozrast.Location = new System.Drawing.Point(156, 54);
            this.txtVozrast.Name = "txtVozrast";
            this.txtVozrast.Size = new System.Drawing.Size(100, 22);
            this.txtVozrast.TabIndex = 1;
            // 
            // btnRaschet
            // 
            this.btnRaschet.Location = new System.Drawing.Point(156, 99);
            this.btnRaschet.Name = "btnRaschet";
            this.btnRaschet.Size = new System.Drawing.Size(100, 23);
            this.btnRaschet.TabIndex = 2;
            this.btnRaschet.Text = "Рассчитать";
            this.btnRaschet.UseVisualStyleBackColor = true;
            this.btnRaschet.Click += new System.EventHandler(this.btnRaschet_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.lblRezultat.Location = new System.Drawing.Point(30, 146);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(322, 29);
            this.lblRezultat.TabIndex = 3;
            this.lblRezultat.Text = "Результат появится здесь";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(502, 233);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.btnRaschet);
            this.Controls.Add(this.txtVozrast);
            this.Controls.Add(this.lblVozrast);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кинотеатр — расчёт билета";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVozrast;
        private System.Windows.Forms.TextBox txtVozrast;
        private System.Windows.Forms.Button btnRaschet;
        private System.Windows.Forms.Label lblRezultat;
    }
}

