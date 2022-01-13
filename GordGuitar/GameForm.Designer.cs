
namespace GordGuitar
{
    partial class GameForm
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
            this.optionsButton = new System.Windows.Forms.Button();
            this.buttonChord1 = new ChordButton();
            this.SuspendLayout();
            // 
            // optionsButton
            // 
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Location = new System.Drawing.Point(12, 12);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 23);
            this.optionsButton.TabIndex = 0;
            this.optionsButton.Text = "Chords";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // buttonChord1
            // 
            this.buttonChord1.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChord1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonChord1.FlatAppearance.BorderSize = 3;
            this.buttonChord1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonChord1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonChord1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChord1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChord1.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonChord1.Location = new System.Drawing.Point(12, 397);
            this.buttonChord1.Name = "buttonChord1";
            this.buttonChord1.Size = new System.Drawing.Size(80, 45);
            this.buttonChord1.TabIndex = 10;
            this.buttonChord1.UseVisualStyleBackColor = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GordGuitar.Properties.Resources.MainImage;
            this.ClientSize = new System.Drawing.Size(519, 519);
            this.Controls.Add(this.buttonChord1);
            this.Controls.Add(this.optionsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GordGuitar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optionsButton;

        private System.Windows.Forms.Button buttonChord1;
    }
}

