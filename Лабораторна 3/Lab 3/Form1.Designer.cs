using System.Drawing;
namespace OKnCANCEL
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
            this.XCoord = new System.Windows.Forms.Label();
            this.YCoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(0,0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 108);
            this.button1.TabIndex = 0;
            this.button1.Text = "CANCEL";
            this.button1.BackColor = Color.Black;
           // this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.Location = new System.Drawing.Point(385, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 81);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "OK";
            this.button2.ForeColor = Color.White;
            this.button2.BackColor = Color.Green;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // XCoord
            // 
            this.XCoord.AutoSize = true;
            this.XCoord.Location = new System.Drawing.Point(845, 18);
            this.XCoord.Name = "XCoord";
            this.XCoord.Size = new System.Drawing.Size(25, 17);
            this.XCoord.TabIndex = 1;
            this.XCoord.Text = "X: ";
            // 
            // YCoord
            // 
            this.YCoord.AutoSize = true;
            this.YCoord.Location = new System.Drawing.Point(845, 48);
            this.YCoord.Name = "YCoord";
            this.YCoord.Size = new System.Drawing.Size(21, 17);
            this.YCoord.TabIndex = 2;
            this.YCoord.Text = "Y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 542);
            this.Controls.Add(this.YCoord);
            this.Controls.Add(this.XCoord);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLICK \'OK\' BUTTON!";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label XCoord;
        private System.Windows.Forms.Label YCoord;
    }
}

