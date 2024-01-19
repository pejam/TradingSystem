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
            lblWorkSpace = new Label();
            lblFiscalPeriod = new Label();
            lblStockRoom = new Label();
            btnWorkSpace = new Button();
            txtWorkSpace = new TextBox();
            btnFiscalPeriod = new Button();
            btnStockRoom = new Button();
            txtFiscalPeriod = new TextBox();
            txtStockRoom = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(48, 329);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 31;
            dataGridView.Size = new Size(1175, 306);
            dataGridView.TabIndex = 0;
            // 
            // radioKhorde
            // 
            radioKhorde.AutoSize = true;
            radioKhorde.Location = new Point(481, 198);
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
            radioTajer.Location = new Point(50, 198);
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
            untilDatePicker.Location = new Point(48, 270);
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
            lblUntil.Location = new Point(447, 276);
            lblUntil.Name = "lblUntil";
            lblUntil.Size = new Size(19, 21);
            lblUntil.TabIndex = 6;
            lblUntil.Text = "تا";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(949, 276);
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
            fromDatePicker.Location = new Point(540, 270);
            fromDatePicker.Margin = new Padding(0);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.PersianDate.Day = 0;
            fromDatePicker.PersianDate.Month = 0;
            fromDatePicker.PersianDate.Year = 0;
            fromDatePicker.RightToLeft = RightToLeft.Yes;
            fromDatePicker.Size = new Size(368, 32);
            fromDatePicker.TabIndex = 8;
            // 
            // lblWorkSpace
            // 
            lblWorkSpace.AutoSize = true;
            lblWorkSpace.Location = new Point(1115, 32);
            lblWorkSpace.Name = "lblWorkSpace";
            lblWorkSpace.Size = new Size(51, 21);
            lblWorkSpace.TabIndex = 12;
            lblWorkSpace.Text = "شرکت";
            lblWorkSpace.Click += label1_Click;
            // 
            // lblFiscalPeriod
            // 
            lblFiscalPeriod.AutoSize = true;
            lblFiscalPeriod.Location = new Point(1091, 75);
            lblFiscalPeriod.Name = "lblFiscalPeriod";
            lblFiscalPeriod.Size = new Size(75, 21);
            lblFiscalPeriod.TabIndex = 13;
            lblFiscalPeriod.Text = "دوره مالی";
            // 
            // lblStockRoom
            // 
            lblStockRoom.AutoSize = true;
            lblStockRoom.Location = new Point(1131, 118);
            lblStockRoom.Name = "lblStockRoom";
            lblStockRoom.Size = new Size(35, 21);
            lblStockRoom.TabIndex = 14;
            lblStockRoom.Text = "انبار";
            // 
            // btnWorkSpace
            // 
            btnWorkSpace.Location = new Point(692, 24);
            btnWorkSpace.Name = "btnWorkSpace";
            btnWorkSpace.Size = new Size(101, 37);
            btnWorkSpace.TabIndex = 15;
            btnWorkSpace.Text = "انتخاب";
            btnWorkSpace.UseVisualStyleBackColor = true;
            btnWorkSpace.Click += btnWorkSpace_Click;
            // 
            // txtWorkSpace
            // 
            txtWorkSpace.Location = new Point(843, 29);
            txtWorkSpace.Name = "txtWorkSpace";
            txtWorkSpace.Size = new Size(213, 29);
            txtWorkSpace.TabIndex = 16;
            // 
            // btnFiscalPeriod
            // 
            btnFiscalPeriod.Location = new Point(692, 67);
            btnFiscalPeriod.Name = "btnFiscalPeriod";
            btnFiscalPeriod.Size = new Size(101, 37);
            btnFiscalPeriod.TabIndex = 17;
            btnFiscalPeriod.Text = "انتخاب";
            btnFiscalPeriod.UseVisualStyleBackColor = true;
            btnFiscalPeriod.Click += btnFiscalPeriod_Click;
            // 
            // btnStockRoom
            // 
            btnStockRoom.Location = new Point(692, 110);
            btnStockRoom.Name = "btnStockRoom";
            btnStockRoom.Size = new Size(101, 37);
            btnStockRoom.TabIndex = 18;
            btnStockRoom.Text = "انتخاب";
            btnStockRoom.UseVisualStyleBackColor = true;
            btnStockRoom.Click += btnStockRoom_Click;
            // 
            // txtFiscalPeriod
            // 
            txtFiscalPeriod.Location = new Point(843, 72);
            txtFiscalPeriod.Name = "txtFiscalPeriod";
            txtFiscalPeriod.Size = new Size(213, 29);
            txtFiscalPeriod.TabIndex = 19;
            // 
            // txtStockRoom
            // 
            txtStockRoom.Location = new Point(843, 115);
            txtStockRoom.Name = "txtStockRoom";
            txtStockRoom.Size = new Size(213, 29);
            txtStockRoom.TabIndex = 20;
            // 
            // Sample
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 731);
            Controls.Add(txtStockRoom);
            Controls.Add(txtFiscalPeriod);
            Controls.Add(btnStockRoom);
            Controls.Add(btnFiscalPeriod);
            Controls.Add(txtWorkSpace);
            Controls.Add(btnWorkSpace);
            Controls.Add(lblStockRoom);
            Controls.Add(lblFiscalPeriod);
            Controls.Add(lblWorkSpace);
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
        private Label lblWorkSpace;
        private Label lblFiscalPeriod;
        private Label lblStockRoom;
        private Button btnWorkSpace;
        private TextBox txtWorkSpace;
        private Button btnFiscalPeriod;
        private Button btnStockRoom;
        private TextBox txtFiscalPeriod;
        private TextBox txtStockRoom;
    }
}