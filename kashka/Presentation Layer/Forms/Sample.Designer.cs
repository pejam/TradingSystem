namespace kashka.Presentation_Layer.Forms
{
    partial class Sample
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
            dataGridView = new DataGridView();
            radioKhorde = new RadioButton();
            radioTajer = new RadioButton();
            btnTajer = new Button();
            btnKhorde = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(48, 156);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 31;
            dataGridView.Size = new Size(1175, 479);
            dataGridView.TabIndex = 0;
            // 
            // radioKhorde
            // 
            radioKhorde.AutoSize = true;
            radioKhorde.Location = new Point(590, 104);
            radioKhorde.Name = "radioKhorde";
            radioKhorde.Size = new Size(59, 25);
            radioKhorde.TabIndex = 1;
            radioKhorde.TabStop = true;
            radioKhorde.Text = "خرده";
            radioKhorde.UseVisualStyleBackColor = true;
            radioKhorde.CheckedChanged += radioKhorde_CheckedChanged;
            // 
            // radioTajer
            // 
            radioTajer.AutoSize = true;
            radioTajer.Location = new Point(209, 104);
            radioTajer.Name = "radioTajer";
            radioTajer.Size = new Size(53, 25);
            radioTajer.TabIndex = 2;
            radioTajer.TabStop = true;
            radioTajer.Text = "تاجر";
            radioTajer.UseVisualStyleBackColor = true;
            radioTajer.CheckedChanged += radioTajer_CheckedChanged;
            // 
            // btnTajer
            // 
            btnTajer.Location = new Point(48, 657);
            btnTajer.Name = "btnTajer";
            btnTajer.Size = new Size(214, 46);
            btnTajer.TabIndex = 3;
            btnTajer.Text = "تاجر";
            btnTajer.UseVisualStyleBackColor = true;
            // 
            // btnKhorde
            // 
            btnKhorde.Location = new Point(452, 657);
            btnKhorde.Name = "btnKhorde";
            btnKhorde.Size = new Size(197, 46);
            btnKhorde.TabIndex = 4;
            btnKhorde.Text = "خرده";
            btnKhorde.UseVisualStyleBackColor = true;
            // 
            // Sample
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 731);
            Controls.Add(btnKhorde);
            Controls.Add(btnTajer);
            Controls.Add(radioTajer);
            Controls.Add(radioKhorde);
            Controls.Add(dataGridView);
            Name = "Sample";
            RightToLeft = RightToLeft.Yes;
            Text = "Sample";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private RadioButton radioKhorde;
        private RadioButton radioTajer;
        private Button btnTajer;
        private Button btnKhorde;
    }
}