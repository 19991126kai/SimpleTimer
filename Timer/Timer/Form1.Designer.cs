﻿namespace Timer
{
    partial class FormTimer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textSetTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textRemainingTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timerControl = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "時間設定";
            // 
            // textSetTime
            // 
            this.textSetTime.Location = new System.Drawing.Point(116, 21);
            this.textSetTime.Name = "textSetTime";
            this.textSetTime.Size = new System.Drawing.Size(100, 25);
            this.textSetTime.TabIndex = 1;
            this.textSetTime.Text = "10";
            this.textSetTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "秒";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "スタート";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "残り時間";
            // 
            // textRemainingTime
            // 
            this.textRemainingTime.Location = new System.Drawing.Point(116, 120);
            this.textRemainingTime.Name = "textRemainingTime";
            this.textRemainingTime.Size = new System.Drawing.Size(100, 25);
            this.textRemainingTime.TabIndex = 5;
            this.textRemainingTime.Text = "10";
            this.textRemainingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "秒";
            // 
            // timerControl
            // 
            this.timerControl.Interval = 1000;
            this.timerControl.Tick += new System.EventHandler(this.timerControl_Tick);
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 183);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textRemainingTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSetTime);
            this.Controls.Add(this.label1);
            this.Name = "FormTimer";
            this.Text = "タイマー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSetTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRemainingTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerControl;
    }
}

