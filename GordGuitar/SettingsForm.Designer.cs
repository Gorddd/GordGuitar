
namespace GordGuitar
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proButton = new System.Windows.Forms.RadioButton();
            this.oldButton = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(72, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "What sound do you prefer?";
            // 
            // proButton
            // 
            this.proButton.AutoSize = true;
            this.proButton.BackColor = System.Drawing.Color.Transparent;
            this.proButton.Checked = true;
            this.proButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.proButton.Location = new System.Drawing.Point(53, 84);
            this.proButton.Name = "proButton";
            this.proButton.Size = new System.Drawing.Size(114, 29);
            this.proButton.TabIndex = 6;
            this.proButton.TabStop = true;
            this.proButton.Text = "pro guitar";
            this.proButton.UseVisualStyleBackColor = false;
            // 
            // oldButton
            // 
            this.oldButton.AutoSize = true;
            this.oldButton.BackColor = System.Drawing.Color.Transparent;
            this.oldButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oldButton.Location = new System.Drawing.Point(246, 84);
            this.oldButton.Name = "oldButton";
            this.oldButton.Size = new System.Drawing.Size(112, 29);
            this.oldButton.TabIndex = 7;
            this.oldButton.Text = "old guitar";
            this.oldButton.UseVisualStyleBackColor = false;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Coral;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(130, 135);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(130, 29);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.OK_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GordGuitar.Properties.Resources.ChordOptionsBack;
            this.ClientSize = new System.Drawing.Size(409, 177);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.oldButton);
            this.Controls.Add(this.proButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton proButton;
        private System.Windows.Forms.RadioButton oldButton;
        private System.Windows.Forms.Button okButton;
    }
}