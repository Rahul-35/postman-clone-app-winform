
namespace PostmanCloneUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formHeader = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            apiClick = new Button();
            resultsText = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 19F);
            formHeader.Location = new Point(58, 18);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(234, 45);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Font = new Font("Segoe UI", 16F);
            apiLabel.Location = new Point(58, 72);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(62, 37);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            // 
            // apiText
            // 
            apiText.Font = new Font("Segoe UI", 12F);
            apiText.Location = new Point(112, 75);
            apiText.Name = "apiText";
            apiText.Size = new Size(810, 34);
            apiText.TabIndex = 2;
            // 
            // apiClick
            // 
            apiClick.BackColor = Color.FromArgb(255, 128, 0);
            apiClick.Font = new Font("Segoe UI", 12F);
            apiClick.Location = new Point(938, 72);
            apiClick.Name = "apiClick";
            apiClick.Size = new Size(94, 43);
            apiClick.TabIndex = 3;
            apiClick.Text = "Go";
            apiClick.UseVisualStyleBackColor = false;
            apiClick.Click += apiClick_Click;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.Font = new Font("Segoe UI", 14F);
            resultsText.Location = new Point(58, 169);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(1058, 438);
            resultsText.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 618);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1217, 34);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 12F);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(65, 28);
            systemStatus.Text = "Ready";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new Font("Segoe UI", 16F);
            resultsLabel.Location = new Point(58, 129);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(99, 37);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1217, 652);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(resultsText);
            Controls.Add(apiClick);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 18F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Postman Clone by RCH";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private Button apiClick;
        private TextBox resultsText;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
