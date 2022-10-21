
namespace Course_Work
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.bStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput_first_num = new System.Windows.Forms.TextBox();
            this.tClock = new System.Windows.Forms.Timer(this.components);
            this.tbInput_second_num = new System.Windows.Forms.TextBox();
            this.tbInput_third_num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(141, 268);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(254, 53);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Пуск";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result: ...";
            // 
            // tbInput_first_num
            // 
            this.tbInput_first_num.Enabled = false;
            this.tbInput_first_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput_first_num.Location = new System.Drawing.Point(51, 168);
            this.tbInput_first_num.Name = "tbInput_first_num";
            this.tbInput_first_num.Size = new System.Drawing.Size(109, 38);
            this.tbInput_first_num.TabIndex = 2;
            this.tbInput_first_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // tClock
            // 
            this.tClock.Interval = 25000;
            this.tClock.Tick += new System.EventHandler(this.tClock_Tick);
            // 
            // tbInput_second_num
            // 
            this.tbInput_second_num.Enabled = false;
            this.tbInput_second_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput_second_num.Location = new System.Drawing.Point(219, 168);
            this.tbInput_second_num.Name = "tbInput_second_num";
            this.tbInput_second_num.Size = new System.Drawing.Size(109, 38);
            this.tbInput_second_num.TabIndex = 3;
            this.tbInput_second_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_second_num_KeyPress);
            // 
            // tbInput_third_num
            // 
            this.tbInput_third_num.Enabled = false;
            this.tbInput_third_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput_third_num.Location = new System.Drawing.Point(380, 168);
            this.tbInput_third_num.Name = "tbInput_third_num";
            this.tbInput_third_num.Size = new System.Drawing.Size(109, 38);
            this.tbInput_third_num.TabIndex = 4;
            this.tbInput_third_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_third_num_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 370);
            this.Controls.Add(this.tbInput_third_num);
            this.Controls.Add(this.tbInput_second_num);
            this.Controls.Add(this.tbInput_first_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput_first_num;
        private System.Windows.Forms.Timer tClock;
        private System.Windows.Forms.TextBox tbInput_second_num;
        private System.Windows.Forms.TextBox tbInput_third_num;
    }
}

