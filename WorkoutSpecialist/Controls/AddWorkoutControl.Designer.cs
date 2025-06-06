namespace WorkoutSpecialist.Controls
{
    partial class AddWorkoutControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            exercisesQuantity = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            noteBox = new TextBox();
            button1 = new Button();
            exercisesPanel = new FlowLayoutPanel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)exercisesQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(134, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 32);
            label1.TabIndex = 0;
            label1.Text = "Dodaj nowy trening";
            // 
            // exercisesQuantity
            // 
            exercisesQuantity.Location = new Point(132, 37);
            exercisesQuantity.Name = "exercisesQuantity";
            exercisesQuantity.Size = new Size(32, 23);
            exercisesQuantity.TabIndex = 1;
            exercisesQuantity.ValueChanged += exercisesQuantity_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 39);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 2;
            label2.Text = "Podaj ilość ćwiczeń:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 48);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 3;
            label3.Text = "Wpisz notatkę (opcjonalnie):";
            // 
            // noteBox
            // 
            noteBox.Location = new Point(360, 66);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(128, 194);
            noteBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(377, 266);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 5;
            button1.Text = "Zapisz trening";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // exercisesPanel
            // 
            exercisesPanel.Location = new Point(14, 92);
            exercisesPanel.Name = "exercisesPanel";
            exercisesPanel.Size = new Size(340, 197);
            exercisesPanel.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 74);
            label4.Name = "label4";
            label4.Size = new Size(253, 15);
            label4.TabIndex = 0;
            label4.Text = "(nazwa ćwiczenia, serii, powtórzeń, obciążenie)";
            // 
            // AddWorkoutControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(exercisesPanel);
            Controls.Add(button1);
            Controls.Add(noteBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exercisesQuantity);
            Controls.Add(label1);
            Name = "AddWorkoutControl";
            Size = new Size(500, 322);
            ((System.ComponentModel.ISupportInitialize)exercisesQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown exercisesQuantity;
        private Label label2;
        private Label label3;
        private TextBox noteBox;
        private Button button1;
        private FlowLayoutPanel exercisesPanel;
        private Label label4;
    }
}
