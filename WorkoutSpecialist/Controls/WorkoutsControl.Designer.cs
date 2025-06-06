namespace WorkoutSpecialist.Controls
{
    partial class WorkoutsControl
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
            workoutsDataGridView = new DataGridView();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            btnFilter = new Button();
            workoutDetailsDataGridView = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)workoutsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workoutDetailsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // workoutsDataGridView
            // 
            workoutsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            workoutsDataGridView.Location = new Point(3, 33);
            workoutsDataGridView.Name = "workoutsDataGridView";
            workoutsDataGridView.Size = new Size(514, 146);
            workoutsDataGridView.TabIndex = 0;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(3, 4);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(200, 23);
            dateTimePickerFrom.TabIndex = 1;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(209, 4);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(200, 23);
            dateTimePickerTo.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(415, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(102, 23);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Szukaj";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // workoutDetailsDataGridView
            // 
            workoutDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            workoutDetailsDataGridView.Location = new Point(3, 200);
            workoutDetailsDataGridView.Name = "workoutDetailsDataGridView";
            workoutDetailsDataGridView.Size = new Size(514, 119);
            workoutDetailsDataGridView.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 182);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 5;
            label1.Text = "Szczegóły treningu:";
            // 
            // WorkoutsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(workoutDetailsDataGridView);
            Controls.Add(btnFilter);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(workoutsDataGridView);
            Name = "WorkoutsControl";
            Size = new Size(520, 322);
            ((System.ComponentModel.ISupportInitialize)workoutsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)workoutDetailsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView workoutsDataGridView;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Button btnFilter;
        private DataGridView workoutDetailsDataGridView;
        private Label label1;
    }
}
