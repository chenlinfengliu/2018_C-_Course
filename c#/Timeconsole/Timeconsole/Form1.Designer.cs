﻿namespace Timeconsole
{
    partial class Time_console
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_test = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_test
            // 
            this.timer_test.Enabled = true;
            this.timer_test.Interval = 10000;
            this.timer_test.Tick += new System.EventHandler(this.timer_test_Tick);
            // 
            // Time_console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Time_console";
            this.Text = "Timeconsole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_test;
    }
}

