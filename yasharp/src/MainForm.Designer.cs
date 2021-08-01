
namespace Yasharp.src
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.pickButton = new System.Windows.Forms.Button();
            this.acceptCheckBox = new System.Windows.Forms.CheckBox();
            this.pickCheckBox = new System.Windows.Forms.CheckBox();
            this.lockCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.champ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(14, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 19);
            this.label.TabIndex = 0;
            this.label.Text = "Character:";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(18, 31);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(219, 26);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "Teemo";
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // pickButton
            // 
            this.pickButton.Location = new System.Drawing.Point(18, 63);
            this.pickButton.Name = "pickButton";
            this.pickButton.Size = new System.Drawing.Size(75, 23);
            this.pickButton.TabIndex = 2;
            this.pickButton.Text = "Pick";
            this.pickButton.UseVisualStyleBackColor = true;
            this.pickButton.Click += new System.EventHandler(this.pickButton_Click);
            // 
            // acceptCheckBox
            // 
            this.acceptCheckBox.AutoSize = true;
            this.acceptCheckBox.Checked = true;
            this.acceptCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.acceptCheckBox.Location = new System.Drawing.Point(18, 115);
            this.acceptCheckBox.Name = "acceptCheckBox";
            this.acceptCheckBox.Size = new System.Drawing.Size(85, 17);
            this.acceptCheckBox.TabIndex = 3;
            this.acceptCheckBox.Text = "Auto Accept";
            this.acceptCheckBox.UseVisualStyleBackColor = true;
            this.acceptCheckBox.Click += new System.EventHandler(this.autoCheckBox_Click);
            // 
            // pickCheckBox
            // 
            this.pickCheckBox.AutoSize = true;
            this.pickCheckBox.Checked = true;
            this.pickCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pickCheckBox.Location = new System.Drawing.Point(18, 92);
            this.pickCheckBox.Name = "pickCheckBox";
            this.pickCheckBox.Size = new System.Drawing.Size(72, 17);
            this.pickCheckBox.TabIndex = 4;
            this.pickCheckBox.Text = "Auto Pick";
            this.pickCheckBox.UseVisualStyleBackColor = true;
            this.pickCheckBox.Click += new System.EventHandler(this.pickCheckBox_Click);
            // 
            // lockCheckBox
            // 
            this.lockCheckBox.AutoSize = true;
            this.lockCheckBox.Checked = true;
            this.lockCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lockCheckBox.Location = new System.Drawing.Point(18, 138);
            this.lockCheckBox.Name = "lockCheckBox";
            this.lockCheckBox.Size = new System.Drawing.Size(75, 17);
            this.lockCheckBox.TabIndex = 5;
            this.lockCheckBox.Text = "Auto Lock";
            this.lockCheckBox.UseVisualStyleBackColor = true;
            this.lockCheckBox.Click += new System.EventHandler(this.lockCheckBox_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.lockCheckBox);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.pickCheckBox);
            this.panel1.Controls.Add(this.pickButton);
            this.panel1.Controls.Add(this.acceptCheckBox);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 157);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.champ});
            this.dataGridView.Location = new System.Drawing.Point(246, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(218, 157);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stt.FillWeight = 22F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 37;
            // 
            // champ
            // 
            this.champ.FillWeight = 93.7875F;
            this.champ.HeaderText = "Champions";
            this.champ.Name = "champ";
            this.champ.ReadOnly = true;
            this.champ.Width = 138;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 162);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Yasharp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button pickButton;
        private System.Windows.Forms.CheckBox acceptCheckBox;
        private System.Windows.Forms.CheckBox pickCheckBox;
        private System.Windows.Forms.CheckBox lockCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn champ;
    }
}