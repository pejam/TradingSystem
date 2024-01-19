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
            untilDatePicker = new PersianDatePicker();
            lblUntil = new Label();
            lblFrom = new Label();
            fromDatePicker = new PersianDatePicker();
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
            radioKhorde.Location = new Point(481, 12);
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
            radioTajer.Location = new Point(209, 12);
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
            btnTajer.Click += btnTajer_Click;
            // 
            // btnKhorde
            // 
            btnKhorde.Location = new Point(343, 657);
            btnKhorde.Name = "btnKhorde";
            btnKhorde.Size = new Size(197, 46);
            btnKhorde.TabIndex = 4;
            btnKhorde.Text = "خرده";
            btnKhorde.UseVisualStyleBackColor = true;
            // 
            // untilDatePicker
            // 
            untilDatePicker.AutoSize = true;
            untilDatePicker.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            untilDatePicker.BackColor = Color.White;
            untilDatePicker.GeorgianDate = null;
            untilDatePicker.Location = new Point(48, 105);
            untilDatePicker.Margin = new Padding(0);
            untilDatePicker.Name = "untilDatePicker";
            untilDatePicker.PersianDate.Day = 0;
            untilDatePicker.PersianDate.Month = 0;
            untilDatePicker.PersianDate.Year = 0;
            untilDatePicker.RightToLeft = RightToLeft.Yes;
            untilDatePicker.Size = new Size(368, 32);
            untilDatePicker.TabIndex = 5;
            // 
            // lblUntil
            // 
            lblUntil.AutoSize = true;
            lblUntil.Location = new Point(447, 111);
            lblUntil.Name = "lblUntil";
            lblUntil.Size = new Size(19, 21);
            lblUntil.TabIndex = 6;
            lblUntil.Text = "تا";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(949, 111);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(21, 21);
            lblFrom.TabIndex = 7;
            lblFrom.Text = "از";
            // 
            // fromDatePicker
            // 
            fromDatePicker.AutoSize = true;
            fromDatePicker.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fromDatePicker.BackColor = Color.White;
            fromDatePicker.GeorgianDate = null;
            fromDatePicker.Location = new Point(540, 105);
            fromDatePicker.Margin = new Padding(0);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.PersianDate.Day = 0;
            fromDatePicker.PersianDate.Month = 0;
            fromDatePicker.PersianDate.Year = 0;
            fromDatePicker.RightToLeft = RightToLeft.Yes;
            fromDatePicker.Size = new Size(368, 32);
            fromDatePicker.TabIndex = 8;
            // 
            // Sample
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 731);
            Controls.Add(fromDatePicker);
            Controls.Add(lblFrom);
            Controls.Add(lblUntil);
            Controls.Add(untilDatePicker);
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
        private PersianDatePicker untilDatePicker;
        private Label lblUntil;
        private Label lblFrom;
        private PersianDatePicker fromDatePicker;
    }
}