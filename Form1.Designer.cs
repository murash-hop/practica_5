namespace practica_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userControl31 = new practica_5.FolderforModel.UserControl3();
            this.userControl32 = new practica_5.FolderforModel.UserControl3();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(723, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 212);
            this.button1.TabIndex = 0;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 212);
            this.button2.TabIndex = 1;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(73, 0);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(319, 325);
            this.userControl31.TabIndex = 2;
            this.userControl31.Load += new System.EventHandler(this.userControl31_Load);
            // 
            // userControl32
            // 
            this.userControl32.Location = new System.Drawing.Point(398, 0);
            this.userControl32.Name = "userControl32";
            this.userControl32.Size = new System.Drawing.Size(319, 325);
            this.userControl32.TabIndex = 3;
            this.userControl32.Load += new System.EventHandler(this.userControl32_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl32);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FolderforModel.UserControl3 userControl31;
        private FolderforModel.UserControl3 userControl32;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

