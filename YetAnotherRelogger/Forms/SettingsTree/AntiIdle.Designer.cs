﻿namespace YetAnotherRelogger.Forms.SettingsTree
{
    partial class AntiIdle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkboxGoldTimer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goldTimerMaxDuration = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goldTimerMaxDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkboxGoldTimer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.goldTimerMaxDuration);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AntiIdle";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::YetAnotherRelogger.Properties.Settings.Default.GoldInfoLogging;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::YetAnotherRelogger.Properties.Settings.Default, "GoldInfoLogging", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(151, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Log info every 30 seconds";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkboxGoldTimer
            // 
            this.checkboxGoldTimer.AutoSize = true;
            this.checkboxGoldTimer.Checked = global::YetAnotherRelogger.Properties.Settings.Default.UseGoldTimer;
            this.checkboxGoldTimer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxGoldTimer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::YetAnotherRelogger.Properties.Settings.Default, "UseGoldTimer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkboxGoldTimer.Location = new System.Drawing.Point(6, 19);
            this.checkboxGoldTimer.Name = "checkboxGoldTimer";
            this.checkboxGoldTimer.Size = new System.Drawing.Size(93, 17);
            this.checkboxGoldTimer.TabIndex = 3;
            this.checkboxGoldTimer.Text = "Use gold timer";
            this.toolTip1.SetToolTip(this.checkboxGoldTimer, "If gold does not change in this time, AntiIdle actions will be taken.");
            this.checkboxGoldTimer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "sec.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gold timer";
            this.toolTip1.SetToolTip(this.label1, "If gold does not change in this time, AntiIdle actions will be taken.");
            // 
            // goldTimerMaxDuration
            // 
            this.goldTimerMaxDuration.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::YetAnotherRelogger.Properties.Settings.Default, "GoldTimer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.goldTimerMaxDuration.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.goldTimerMaxDuration.Location = new System.Drawing.Point(66, 63);
            this.goldTimerMaxDuration.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.goldTimerMaxDuration.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.goldTimerMaxDuration.Name = "goldTimerMaxDuration";
            this.goldTimerMaxDuration.Size = new System.Drawing.Size(60, 20);
            this.goldTimerMaxDuration.TabIndex = 0;
            this.toolTip1.SetToolTip(this.goldTimerMaxDuration, "If gold does not change in this time, AntiIdle actions will be taken.");
            this.goldTimerMaxDuration.Value = global::YetAnotherRelogger.Properties.Settings.Default.GoldTimer;
            // 
            // AntiIdle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AntiIdle";
            this.Size = new System.Drawing.Size(503, 411);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goldTimerMaxDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown goldTimerMaxDuration;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkboxGoldTimer;
        private System.Windows.Forms.CheckBox checkBox2;

    }
}
