
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
            this.buttonString0 = new System.Windows.Forms.Button();
            this.buttonString1 = new System.Windows.Forms.Button();
            this.buttonString2 = new System.Windows.Forms.Button();
            this.buttonString3 = new System.Windows.Forms.Button();
            this.buttonString4 = new System.Windows.Forms.Button();
            this.buttonString5 = new System.Windows.Forms.Button();
            this.buttonChord10 = new GordGuitar.ChordButton();
            this.buttonChord9 = new GordGuitar.ChordButton();
            this.buttonChord8 = new GordGuitar.ChordButton();
            this.buttonChord7 = new GordGuitar.ChordButton();
            this.buttonChord6 = new GordGuitar.ChordButton();
            this.buttonChord5 = new GordGuitar.ChordButton();
            this.buttonChord4 = new GordGuitar.ChordButton();
            this.buttonChord3 = new GordGuitar.ChordButton();
            this.buttonChord2 = new GordGuitar.ChordButton();
            this.buttonChord1 = new GordGuitar.ChordButton();
            this.SuspendLayout();
            // 
            // optionsButton
            // 
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Location = new System.Drawing.Point(12, 12);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 23);
            this.optionsButton.TabIndex = 0;
            this.optionsButton.TabStop = false;
            this.optionsButton.Text = "Chords";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // buttonString0
            // 
            this.buttonString0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonString0.Location = new System.Drawing.Point(12, 162);
            this.buttonString0.Name = "buttonString0";
            this.buttonString0.Size = new System.Drawing.Size(502, 23);
            this.buttonString0.TabIndex = 20;
            this.buttonString0.TabStop = false;
            this.buttonString0.Tag = "1";
            this.buttonString0.UseVisualStyleBackColor = true;
            this.buttonString0.MouseEnter += new System.EventHandler(this.PullGuitarString);
            // 
            // buttonString1
            // 
            this.buttonString1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonString1.Location = new System.Drawing.Point(12, 200);
            this.buttonString1.Name = "buttonString1";
            this.buttonString1.Size = new System.Drawing.Size(502, 23);
            this.buttonString1.TabIndex = 21;
            this.buttonString1.TabStop = false;
            this.buttonString1.Tag = "2";
            this.buttonString1.UseVisualStyleBackColor = true;
            this.buttonString1.MouseEnter += new System.EventHandler(this.PullGuitarString);
            // 
            // buttonString2
            // 
            this.buttonString2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonString2.Location = new System.Drawing.Point(12, 229);
            this.buttonString2.Name = "buttonString2";
            this.buttonString2.Size = new System.Drawing.Size(502, 23);
            this.buttonString2.TabIndex = 22;
            this.buttonString2.TabStop = false;
            this.buttonString2.Tag = "3";
            this.buttonString2.UseVisualStyleBackColor = true;
            this.buttonString2.MouseEnter += new System.EventHandler(this.PullGuitarString);
            // 
            // buttonString3
            // 
            this.buttonString3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonString3.Location = new System.Drawing.Point(12, 265);
            this.buttonString3.Name = "buttonString3";
            this.buttonString3.Size = new System.Drawing.Size(502, 23);
            this.buttonString3.TabIndex = 23;
            this.buttonString3.TabStop = false;
            this.buttonString3.Tag = "4";
            this.buttonString3.UseVisualStyleBackColor = true;
            this.buttonString3.MouseEnter += new System.EventHandler(this.PullGuitarString);
            // 
            // buttonString4
            // 
            this.buttonString4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonString4.Location = new System.Drawing.Point(12, 298);
            this.buttonString4.Name = "buttonString4";
            this.buttonString4.Size = new System.Drawing.Size(502, 23);
            this.buttonString4.TabIndex = 24;
            this.buttonString4.TabStop = false;
            this.buttonString4.Tag = "5";
            this.buttonString4.UseVisualStyleBackColor = true;
            this.buttonString4.MouseEnter += new System.EventHandler(this.PullGuitarString);
            // 
            // buttonString5
            // 
            this.buttonString5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonString5.Location = new System.Drawing.Point(12, 337);
            this.buttonString5.Name = "buttonString5";
            this.buttonString5.Size = new System.Drawing.Size(502, 23);
            this.buttonString5.TabIndex = 25;
            this.buttonString5.TabStop = false;
            this.buttonString5.Tag = "6";
            this.buttonString5.UseVisualStyleBackColor = true;
            this.buttonString5.MouseEnter += new System.EventHandler(this.PullGuitarString);
            // 
            // buttonChord10
            // 
            this.buttonChord10.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChord10.chord = null;
            this.buttonChord10.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonChord10.FlatAppearance.BorderSize = 3;
            this.buttonChord10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonChord10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonChord10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChord10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChord10.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonChord10.Location = new System.Drawing.Point(434, 462);
            this.buttonChord10.Name = "buttonChord10";
            this.buttonChord10.Size = new System.Drawing.Size(80, 45);
            this.buttonChord10.TabIndex = 9;
            this.buttonChord10.UseVisualStyleBackColor = false;
            this.buttonChord10.Click += new System.EventHandler(this.ChangeActiveChord);
            // 
            // buttonChord9
            // 
            this.buttonChord9.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChord9.chord = null;
            this.buttonChord9.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonChord9.FlatAppearance.BorderSize = 3;
            this.buttonChord9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonChord9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonChord9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChord9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChord9.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonChord9.Location = new System.Drawing.Point(348, 462);
            this.buttonChord9.Name = "buttonChord9";
            this.buttonChord9.Size = new System.Drawing.Size(80, 45);
            this.buttonChord9.TabIndex = 8;
            this.buttonChord9.UseVisualStyleBackColor = false;
            this.buttonChord9.Click += new System.EventHandler(this.ChangeActiveChord);
            // 
            // buttonChord8
            // 
            this.buttonChord8.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChord8.chord = null;
            this.buttonChord8.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonChord8.FlatAppearance.BorderSize = 3;
            this.buttonChord8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonChord8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonChord8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChord8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChord8.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonChord8.Location = new System.Drawing.Point(262, 462);
            this.buttonChord8.Name = "buttonChord8";
            this.buttonChord8.Size = new System.Drawing.Size(80, 45);
            this.buttonChord8.TabIndex = 7;
            this.buttonChord8.UseVisualStyleBackColor = false;
            this.buttonChord8.Click += new System.EventHandler(this.ChangeActiveChord);
            // 
            // buttonChord7
            // 
            this.buttonChord7.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChord7.chord = null;
            this.buttonChord7.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonChord7.FlatAppearance.BorderSize = 3;
            this.buttonChord7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonChord7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonChord7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChord7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChord7.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonChord7.Location = new System.Drawing.Point(176, 462);
            this.buttonChord7.Name = "buttonChord7";
            this.buttonChord7.Size = new System.Drawing.Size(80, 45);
            this.buttonChord7.TabIndex = 6;
            this.buttonChord7.UseVisualStyleBackColor = false;
            this.buttonChord7.Click += new System.EventHandler(this.ChangeActiveChord);
            // 
            // buttonChord6
            // 
            this.buttonChord6.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChord6.chord = null;
            this.buttonChord6.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonChord6.FlatAppearance.BorderSize = 3;
            this.buttonChord6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonChord6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonChord6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChord6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChord6.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonChord6.Location = new System.Drawing.Point(90, 462);
            this.buttonChord6.Name = "buttonChord6";
            this.buttonChord6.Size = new System.Drawing.Size(80, 45);
            this.buttonChord6.TabIndex = 5;
            this.buttonChord6.UseVisualStyleBackColor = false;
            this.buttonChord6.Click += new System.EventHandler(this.ChangeActiveChord);
            // 
            // buttonChord5
            // 
            this.buttonChord5.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChord5.chord = null;
            this.buttonChord5.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonChord5.FlatAppearance.BorderSize = 3;
            this.buttonChord5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonChord5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonChord5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChord5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChord5.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonChord5.Location = new System.Drawing.Point(4, 462);
            this.buttonChord5.Name = "buttonChord5";
            this.buttonChord5.Size = new System.Drawing.Size(80, 45);
            this.buttonChord5.TabIndex = 4;
            this.buttonChord5.UseVisualStyleBackColor = false;
            this.buttonChord5.Click += new System.EventHandler(this.ChangeActiveChord);
            // 
            // buttonChord4
            // 
            this.buttonChord4.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChord4.chord = null;
            this.buttonChord4.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonChord4.FlatAppearance.BorderSize = 3;
            this.buttonChord4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonChord4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonChord4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChord4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChord4.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonChord4.Location = new System.Drawing.Point(434, 411);
            this.buttonChord4.Name = "buttonChord4";
            this.buttonChord4.Size = new System.Drawing.Size(80, 45);
            this.buttonChord4.TabIndex = 3;
            this.buttonChord4.UseVisualStyleBackColor = false;
            this.buttonChord4.Click += new System.EventHandler(this.ChangeActiveChord);
            // 
            // buttonChord3
            // 
            this.buttonChord3.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChord3.chord = null;
            this.buttonChord3.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonChord3.FlatAppearance.BorderSize = 3;
            this.buttonChord3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonChord3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonChord3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChord3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChord3.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonChord3.Location = new System.Drawing.Point(348, 411);
            this.buttonChord3.Name = "buttonChord3";
            this.buttonChord3.Size = new System.Drawing.Size(80, 45);
            this.buttonChord3.TabIndex = 2;
            this.buttonChord3.UseVisualStyleBackColor = false;
            this.buttonChord3.Click += new System.EventHandler(this.ChangeActiveChord);
            // 
            // buttonChord2
            // 
            this.buttonChord2.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChord2.chord = null;
            this.buttonChord2.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonChord2.FlatAppearance.BorderSize = 3;
            this.buttonChord2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonChord2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonChord2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChord2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChord2.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonChord2.Location = new System.Drawing.Point(90, 411);
            this.buttonChord2.Name = "buttonChord2";
            this.buttonChord2.Size = new System.Drawing.Size(80, 45);
            this.buttonChord2.TabIndex = 1;
            this.buttonChord2.UseVisualStyleBackColor = false;
            this.buttonChord2.Click += new System.EventHandler(this.ChangeActiveChord);
            // 
            // buttonChord1
            // 
            this.buttonChord1.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChord1.chord = null;
            this.buttonChord1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonChord1.FlatAppearance.BorderSize = 3;
            this.buttonChord1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonChord1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonChord1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChord1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChord1.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonChord1.Location = new System.Drawing.Point(4, 411);
            this.buttonChord1.Name = "buttonChord1";
            this.buttonChord1.Size = new System.Drawing.Size(80, 45);
            this.buttonChord1.TabIndex = 0;
            this.buttonChord1.UseVisualStyleBackColor = false;
            this.buttonChord1.Click += new System.EventHandler(this.ChangeActiveChord);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GordGuitar.Properties.Resources.MainImage;
            this.ClientSize = new System.Drawing.Size(519, 519);
            this.Controls.Add(this.buttonString5);
            this.Controls.Add(this.buttonString4);
            this.Controls.Add(this.buttonString3);
            this.Controls.Add(this.buttonString2);
            this.Controls.Add(this.buttonString1);
            this.Controls.Add(this.buttonString0);
            this.Controls.Add(this.buttonChord10);
            this.Controls.Add(this.buttonChord9);
            this.Controls.Add(this.buttonChord8);
            this.Controls.Add(this.buttonChord7);
            this.Controls.Add(this.buttonChord6);
            this.Controls.Add(this.buttonChord5);
            this.Controls.Add(this.buttonChord4);
            this.Controls.Add(this.buttonChord3);
            this.Controls.Add(this.buttonChord2);
            this.Controls.Add(this.buttonChord1);
            this.Controls.Add(this.optionsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GordGuitar";
            this.Shown += new System.EventHandler(this.GameForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optionsButton;
        
        private ChordButton buttonChord1;
        private ChordButton buttonChord2;
        private ChordButton buttonChord3;
        private ChordButton buttonChord4;
        private ChordButton buttonChord5;
        private ChordButton buttonChord6;
        private ChordButton buttonChord7;
        private ChordButton buttonChord8;
        private ChordButton buttonChord9;
        private ChordButton buttonChord10;
        private System.Windows.Forms.Button buttonString0;
        private System.Windows.Forms.Button buttonString1;
        private System.Windows.Forms.Button buttonString2;
        private System.Windows.Forms.Button buttonString3;
        private System.Windows.Forms.Button buttonString4;
        private System.Windows.Forms.Button buttonString5;
    }
}

