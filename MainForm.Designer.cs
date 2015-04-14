namespace G31DDCExample
{
    partial class MainForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBoxAudioLevel = new System.Windows.Forms.GroupBox();
            this.progressBarAudioLevel = new System.Windows.Forms.ProgressBar();
            this.groupBoxSignalLevel = new System.Windows.Forms.GroupBox();
            this.textBoxSignalLevel = new System.Windows.Forms.TextBox();
            this.groupBoxFrequency = new System.Windows.Forms.GroupBox();
            this.labelFrequencyUnit = new System.Windows.Forms.Label();
            this.numericUpDownFrequency = new System.Windows.Forms.NumericUpDown();
            this.trackBarFrequency = new System.Windows.Forms.TrackBar();
            this.textBoxFrequencyRange = new System.Windows.Forms.TextBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxInterface = new System.Windows.Forms.TextBox();
            this.labelFrequencyRange = new System.Windows.Forms.Label();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelInterface = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerConnection = new System.Windows.Forms.Timer(this.components);
            this.buttonConnection = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.groupBoxAudioLevel.SuspendLayout();
            this.groupBoxSignalLevel.SuspendLayout();
            this.groupBoxFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.groupBoxAudioLevel);
            this.panelMain.Controls.Add(this.groupBoxSignalLevel);
            this.panelMain.Controls.Add(this.groupBoxFrequency);
            this.panelMain.Controls.Add(this.textBoxFrequencyRange);
            this.panelMain.Controls.Add(this.textBoxSerialNumber);
            this.panelMain.Controls.Add(this.textBoxInterface);
            this.panelMain.Controls.Add(this.labelFrequencyRange);
            this.panelMain.Controls.Add(this.labelSerialNumber);
            this.panelMain.Controls.Add(this.labelInterface);
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(333, 219);
            this.panelMain.TabIndex = 0;
            // 
            // groupBoxAudioLevel
            // 
            this.groupBoxAudioLevel.Controls.Add(this.progressBarAudioLevel);
            this.groupBoxAudioLevel.Location = new System.Drawing.Point(233, 158);
            this.groupBoxAudioLevel.Name = "groupBoxAudioLevel";
            this.groupBoxAudioLevel.Size = new System.Drawing.Size(96, 51);
            this.groupBoxAudioLevel.TabIndex = 9;
            this.groupBoxAudioLevel.TabStop = false;
            this.groupBoxAudioLevel.Text = "Audio level";
            // 
            // progressBarAudioLevel
            // 
            this.progressBarAudioLevel.Location = new System.Drawing.Point(6, 19);
            this.progressBarAudioLevel.Maximum = 900;
            this.progressBarAudioLevel.Name = "progressBarAudioLevel";
            this.progressBarAudioLevel.Size = new System.Drawing.Size(84, 23);
            this.progressBarAudioLevel.TabIndex = 8;
            // 
            // groupBoxSignalLevel
            // 
            this.groupBoxSignalLevel.Controls.Add(this.textBoxSignalLevel);
            this.groupBoxSignalLevel.Location = new System.Drawing.Point(233, 92);
            this.groupBoxSignalLevel.Name = "groupBoxSignalLevel";
            this.groupBoxSignalLevel.Size = new System.Drawing.Size(96, 60);
            this.groupBoxSignalLevel.TabIndex = 7;
            this.groupBoxSignalLevel.TabStop = false;
            this.groupBoxSignalLevel.Text = "Signal level";
            // 
            // textBoxSignalLevel
            // 
            this.textBoxSignalLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSignalLevel.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSignalLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSignalLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSignalLevel.Location = new System.Drawing.Point(6, 22);
            this.textBoxSignalLevel.Name = "textBoxSignalLevel";
            this.textBoxSignalLevel.ReadOnly = true;
            this.textBoxSignalLevel.Size = new System.Drawing.Size(84, 23);
            this.textBoxSignalLevel.TabIndex = 2;
            this.textBoxSignalLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxFrequency
            // 
            this.groupBoxFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFrequency.Controls.Add(this.labelFrequencyUnit);
            this.groupBoxFrequency.Controls.Add(this.numericUpDownFrequency);
            this.groupBoxFrequency.Controls.Add(this.trackBarFrequency);
            this.groupBoxFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxFrequency.Location = new System.Drawing.Point(3, 92);
            this.groupBoxFrequency.Name = "groupBoxFrequency";
            this.groupBoxFrequency.Size = new System.Drawing.Size(224, 117);
            this.groupBoxFrequency.TabIndex = 6;
            this.groupBoxFrequency.TabStop = false;
            this.groupBoxFrequency.Text = "Frequency";
            // 
            // labelFrequencyUnit
            // 
            this.labelFrequencyUnit.AutoSize = true;
            this.labelFrequencyUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFrequencyUnit.Location = new System.Drawing.Point(182, 29);
            this.labelFrequencyUnit.Name = "labelFrequencyUnit";
            this.labelFrequencyUnit.Size = new System.Drawing.Size(38, 25);
            this.labelFrequencyUnit.TabIndex = 4;
            this.labelFrequencyUnit.Text = "Hz";
            // 
            // numericUpDownFrequency
            // 
            this.numericUpDownFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownFrequency.Location = new System.Drawing.Point(6, 25);
            this.numericUpDownFrequency.Name = "numericUpDownFrequency";
            this.numericUpDownFrequency.Size = new System.Drawing.Size(170, 30);
            this.numericUpDownFrequency.TabIndex = 3;
            this.numericUpDownFrequency.ValueChanged += new System.EventHandler(this.OnNumericUpDownFrequencyValueChanged);
            // 
            // trackBarFrequency
            // 
            this.trackBarFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarFrequency.Enabled = false;
            this.trackBarFrequency.Location = new System.Drawing.Point(6, 63);
            this.trackBarFrequency.Maximum = 0;
            this.trackBarFrequency.Name = "trackBarFrequency";
            this.trackBarFrequency.Size = new System.Drawing.Size(212, 45);
            this.trackBarFrequency.TabIndex = 0;
            this.trackBarFrequency.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFrequency.ValueChanged += new System.EventHandler(this.OnTrackBarFrequencyValueChanged);
            // 
            // textBoxFrequencyRange
            // 
            this.textBoxFrequencyRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFrequencyRange.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFrequencyRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFrequencyRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFrequencyRange.Location = new System.Drawing.Point(114, 59);
            this.textBoxFrequencyRange.Name = "textBoxFrequencyRange";
            this.textBoxFrequencyRange.Size = new System.Drawing.Size(215, 20);
            this.textBoxFrequencyRange.TabIndex = 5;
            this.textBoxFrequencyRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSerialNumber.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSerialNumber.Location = new System.Drawing.Point(114, 3);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(216, 20);
            this.textBoxSerialNumber.TabIndex = 4;
            this.textBoxSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxInterface
            // 
            this.textBoxInterface.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInterface.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInterface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInterface.Location = new System.Drawing.Point(114, 31);
            this.textBoxInterface.Name = "textBoxInterface";
            this.textBoxInterface.ReadOnly = true;
            this.textBoxInterface.Size = new System.Drawing.Size(216, 20);
            this.textBoxInterface.TabIndex = 3;
            this.textBoxInterface.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFrequencyRange
            // 
            this.labelFrequencyRange.AutoSize = true;
            this.labelFrequencyRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFrequencyRange.Location = new System.Drawing.Point(0, 61);
            this.labelFrequencyRange.Name = "labelFrequencyRange";
            this.labelFrequencyRange.Size = new System.Drawing.Size(102, 13);
            this.labelFrequencyRange.TabIndex = 2;
            this.labelFrequencyRange.Text = "Frequency range";
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSerialNumber.Location = new System.Drawing.Point(0, 5);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(84, 13);
            this.labelSerialNumber.TabIndex = 1;
            this.labelSerialNumber.Text = "Serial number";
            // 
            // labelInterface
            // 
            this.labelInterface.AutoSize = true;
            this.labelInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInterface.Location = new System.Drawing.Point(0, 33);
            this.labelInterface.Name = "labelInterface";
            this.labelInterface.Size = new System.Drawing.Size(58, 13);
            this.labelInterface.TabIndex = 0;
            this.labelInterface.Text = "Interface";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 266);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(357, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // timerConnection
            // 
            this.timerConnection.Interval = 500;
            this.timerConnection.Tick += new System.EventHandler(this.OnTimerConnectionTick);
            // 
            // buttonConnection
            // 
            this.buttonConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnection.Location = new System.Drawing.Point(251, 237);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(91, 23);
            this.buttonConnection.TabIndex = 2;
            this.buttonConnection.Text = "Try to connect";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.OnButtonConnectionClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 288);
            this.Controls.Add(this.buttonConnection);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "G31DDCExample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormClosing);
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupBoxAudioLevel.ResumeLayout(false);
            this.groupBoxSignalLevel.ResumeLayout(false);
            this.groupBoxSignalLevel.PerformLayout();
            this.groupBoxFrequency.ResumeLayout(false);
            this.groupBoxFrequency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelInterface;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelFrequencyRange;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxInterface;
        private System.Windows.Forms.TextBox textBoxFrequencyRange;
        private System.Windows.Forms.GroupBox groupBoxFrequency;
        private System.Windows.Forms.TrackBar trackBarFrequency;
        private System.Windows.Forms.Timer timerConnection;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.GroupBox groupBoxSignalLevel;
        private System.Windows.Forms.TextBox textBoxSignalLevel;
        private System.Windows.Forms.ProgressBar progressBarAudioLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownFrequency;
        private System.Windows.Forms.Label labelFrequencyUnit;
        private System.Windows.Forms.GroupBox groupBoxAudioLevel;
    }
}

