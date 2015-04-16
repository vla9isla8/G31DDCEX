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
            this.textBoxFrequencyRange = new System.Windows.Forms.TextBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxInterface = new System.Windows.Forms.TextBox();
            this.labelFrequencyRange = new System.Windows.Forms.Label();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelInterface = new System.Windows.Forms.Label();
            this.progressBarAudioLevel = new System.Windows.Forms.ProgressBar();
            this.groupBoxSignalLevel = new System.Windows.Forms.GroupBox();
            this.textBoxSignalLevel = new System.Windows.Forms.TextBox();
            this.groupBoxFrequency = new System.Windows.Forms.GroupBox();
            this.labelFrequencyUnit = new System.Windows.Forms.Label();
            this.numericUpDownFrequency = new System.Windows.Forms.NumericUpDown();
            this.trackBarFrequency = new System.Windows.Forms.TrackBar();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.workTimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerConnection = new System.Windows.Forms.Timer(this.components);
            this.buttonConnection = new System.Windows.Forms.Button();
            this.SignalDataGroupBox = new System.Windows.Forms.GroupBox();
            this.IQDataListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.groupBoxSignalLevel.SuspendLayout();
            this.groupBoxFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SignalDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.textBoxFrequencyRange);
            this.panelMain.Controls.Add(this.textBoxSerialNumber);
            this.panelMain.Controls.Add(this.textBoxInterface);
            this.panelMain.Controls.Add(this.labelFrequencyRange);
            this.panelMain.Controls.Add(this.labelSerialNumber);
            this.panelMain.Controls.Add(this.labelInterface);
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelMain.Location = new System.Drawing.Point(9, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(459, 95);
            this.panelMain.TabIndex = 0;
            // 
            // textBoxFrequencyRange
            // 
            this.textBoxFrequencyRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFrequencyRange.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFrequencyRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFrequencyRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFrequencyRange.Location = new System.Drawing.Point(259, 64);
            this.textBoxFrequencyRange.Name = "textBoxFrequencyRange";
            this.textBoxFrequencyRange.Size = new System.Drawing.Size(194, 20);
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
            this.textBoxSerialNumber.Location = new System.Drawing.Point(259, 3);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(194, 20);
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
            this.textBoxInterface.Location = new System.Drawing.Point(259, 33);
            this.textBoxInterface.Name = "textBoxInterface";
            this.textBoxInterface.ReadOnly = true;
            this.textBoxInterface.Size = new System.Drawing.Size(194, 20);
            this.textBoxInterface.TabIndex = 3;
            this.textBoxInterface.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFrequencyRange
            // 
            this.labelFrequencyRange.AutoSize = true;
            this.labelFrequencyRange.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.labelFrequencyRange.Location = new System.Drawing.Point(8, 66);
            this.labelFrequencyRange.Name = "labelFrequencyRange";
            this.labelFrequencyRange.Size = new System.Drawing.Size(100, 14);
            this.labelFrequencyRange.TabIndex = 2;
            this.labelFrequencyRange.Text = "Frequency range";
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSerialNumber.Location = new System.Drawing.Point(8, 5);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(73, 14);
            this.labelSerialNumber.TabIndex = 1;
            this.labelSerialNumber.Text = "Serial number";
            // 
            // labelInterface
            // 
            this.labelInterface.AutoSize = true;
            this.labelInterface.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.labelInterface.Location = new System.Drawing.Point(8, 35);
            this.labelInterface.Name = "labelInterface";
            this.labelInterface.Size = new System.Drawing.Size(56, 14);
            this.labelInterface.TabIndex = 0;
            this.labelInterface.Text = "Interface";
            // 
            // progressBarAudioLevel
            // 
            this.progressBarAudioLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarAudioLevel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBarAudioLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBarAudioLevel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.progressBarAudioLevel.Location = new System.Drawing.Point(11, 52);
            this.progressBarAudioLevel.Maximum = 1200;
            this.progressBarAudioLevel.Name = "progressBarAudioLevel";
            this.progressBarAudioLevel.Size = new System.Drawing.Size(439, 24);
            this.progressBarAudioLevel.Step = 1;
            this.progressBarAudioLevel.TabIndex = 8;
            // 
            // groupBoxSignalLevel
            // 
            this.groupBoxSignalLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSignalLevel.Controls.Add(this.progressBarAudioLevel);
            this.groupBoxSignalLevel.Controls.Add(this.textBoxSignalLevel);
            this.groupBoxSignalLevel.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.groupBoxSignalLevel.Location = new System.Drawing.Point(9, 242);
            this.groupBoxSignalLevel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.groupBoxSignalLevel.Name = "groupBoxSignalLevel";
            this.groupBoxSignalLevel.Size = new System.Drawing.Size(459, 84);
            this.groupBoxSignalLevel.TabIndex = 7;
            this.groupBoxSignalLevel.TabStop = false;
            this.groupBoxSignalLevel.Text = "Signal level";
            // 
            // textBoxSignalLevel
            // 
            this.textBoxSignalLevel.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSignalLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSignalLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSignalLevel.Location = new System.Drawing.Point(11, 23);
            this.textBoxSignalLevel.Name = "textBoxSignalLevel";
            this.textBoxSignalLevel.ReadOnly = true;
            this.textBoxSignalLevel.Size = new System.Drawing.Size(107, 23);
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
            this.groupBoxFrequency.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.groupBoxFrequency.Location = new System.Drawing.Point(9, 113);
            this.groupBoxFrequency.Name = "groupBoxFrequency";
            this.groupBoxFrequency.Size = new System.Drawing.Size(459, 123);
            this.groupBoxFrequency.TabIndex = 6;
            this.groupBoxFrequency.TabStop = false;
            this.groupBoxFrequency.Text = "Frequency";
            // 
            // labelFrequencyUnit
            // 
            this.labelFrequencyUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFrequencyUnit.AutoSize = true;
            this.labelFrequencyUnit.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.labelFrequencyUnit.Location = new System.Drawing.Point(415, 33);
            this.labelFrequencyUnit.Name = "labelFrequencyUnit";
            this.labelFrequencyUnit.Size = new System.Drawing.Size(38, 23);
            this.labelFrequencyUnit.TabIndex = 4;
            this.labelFrequencyUnit.Text = "Hz";
            // 
            // numericUpDownFrequency
            // 
            this.numericUpDownFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownFrequency.Location = new System.Drawing.Point(259, 30);
            this.numericUpDownFrequency.Name = "numericUpDownFrequency";
            this.numericUpDownFrequency.Size = new System.Drawing.Size(150, 30);
            this.numericUpDownFrequency.TabIndex = 3;
            this.numericUpDownFrequency.ValueChanged += new System.EventHandler(this.OnNumericUpDownFrequencyValueChanged);
            // 
            // trackBarFrequency
            // 
            this.trackBarFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarFrequency.Enabled = false;
            this.trackBarFrequency.Location = new System.Drawing.Point(6, 66);
            this.trackBarFrequency.Maximum = 0;
            this.trackBarFrequency.Name = "trackBarFrequency";
            this.trackBarFrequency.Size = new System.Drawing.Size(447, 45);
            this.trackBarFrequency.TabIndex = 0;
            this.trackBarFrequency.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFrequency.ValueChanged += new System.EventHandler(this.OnTrackBarFrequencyValueChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.workTimeStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 541);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(477, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // workTimeStatusLabel
            // 
            this.workTimeStatusLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.workTimeStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.workTimeStatusLabel.Name = "workTimeStatusLabel";
            this.workTimeStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.workTimeStatusLabel.Text = "0";
            this.workTimeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerConnection
            // 
            this.timerConnection.Interval = 500;
            this.timerConnection.Tick += new System.EventHandler(this.OnTimerConnectionTick);
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(9, 508);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(113, 30);
            this.buttonConnection.TabIndex = 2;
            this.buttonConnection.Text = "Connect";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.OnButtonConnectionClick);
            // 
            // SignalDataGroupBox
            // 
            this.SignalDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignalDataGroupBox.Controls.Add(this.IQDataListBox);
            this.SignalDataGroupBox.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.SignalDataGroupBox.Location = new System.Drawing.Point(9, 329);
            this.SignalDataGroupBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.SignalDataGroupBox.Name = "SignalDataGroupBox";
            this.SignalDataGroupBox.Size = new System.Drawing.Size(460, 176);
            this.SignalDataGroupBox.TabIndex = 7;
            this.SignalDataGroupBox.TabStop = false;
            this.SignalDataGroupBox.Text = "Signal IQ-Data";
            // 
            // IQDataListBox
            // 
            this.IQDataListBox.FormattingEnabled = true;
            this.IQDataListBox.ItemHeight = 14;
            this.IQDataListBox.Location = new System.Drawing.Point(1, 19);
            this.IQDataListBox.Name = "IQDataListBox";
            this.IQDataListBox.Size = new System.Drawing.Size(453, 144);
            this.IQDataListBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(361, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save I/Q-Data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "Graphic";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 563);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonConnection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxFrequency);
            this.Controls.Add(this.SignalDataGroupBox);
            this.Controls.Add(this.groupBoxSignalLevel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Cordia New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "G31DDCExample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormClosing);
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupBoxSignalLevel.ResumeLayout(false);
            this.groupBoxSignalLevel.PerformLayout();
            this.groupBoxFrequency.ResumeLayout(false);
            this.groupBoxFrequency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.SignalDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
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
        private System.Windows.Forms.GroupBox SignalDataGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel workTimeStatusLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox IQDataListBox;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.Button button3;
    }
}

