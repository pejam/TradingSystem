using kashka.Data_Access_Layer.Repositories;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;
using Microsoft.Data.SqlClient;
using kashka.Business_Logic_Layer.Models;

namespace kashka.Presentation_Layer.Forms
{
    partial class MainForm : Form
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtNumber = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelVersion = new ToolStripStatusLabel();
            tabCtrl = new TabControl();
            tabPageFinalConsumer = new TabPage();
            dataGridViewFinalConsumer = new DataGridView();
            CheckBoxFinalConsumer = new DataGridViewCheckBoxColumn();
            toolStripFinalConsumer = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            tabPageTajer = new TabPage();
            dataGridViewTajer = new DataGridView();
            CheckBox = new DataGridViewCheckBoxColumn();
            toolStripTajer = new ToolStrip();
            toolStripButtonDeselectAll = new ToolStripButton();
            toolStripButtonSellectAll = new ToolStripButton();
            toolStripButtonDeleteInvoices = new ToolStripButton();
            toolStripButtonRefreshDB = new ToolStripButton();
            toolStripButtonShowDetails = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabelLastSended = new ToolStripLabel();
            toolStripLabelLastSendedNo = new ToolStripLabel();
            btnSend = new Button();
            txtStockRoom = new TextBox();
            txtFiscalPeriod = new TextBox();
            btnStockRoom = new Button();
            btnFiscalPeriod = new Button();
            txtWorkSpace = new TextBox();
            btnWorkSpace = new Button();
            lblStockRoom = new Label();
            lblFiscalPeriod = new Label();
            lblWorkSpace = new Label();
            fromDatePicker = new PersianDatePicker();
            lblFrom = new Label();
            lblUntil = new Label();
            untilDatePicker = new PersianDatePicker();
            btnReport = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            progressBar = new ProgressBar();
            statusStrip1.SuspendLayout();
            tabCtrl.SuspendLayout();
            tabPageFinalConsumer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinalConsumer).BeginInit();
            toolStripFinalConsumer.SuspendLayout();
            tabPageTajer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTajer).BeginInit();
            toolStripTajer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(100, 100);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(150, 23);
            txtNumber.TabIndex = 0;
            txtNumber.KeyPress += txtNumber_KeyPress;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelVersion });
            statusStrip1.Location = new Point(0, 516);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(8, 0, 1, 0);
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(989, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelVersion
            // 
            toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
            toolStripStatusLabelVersion.Padding = new Padding(0, 0, 50, 0);
            toolStripStatusLabelVersion.Size = new Size(102, 17);
            toolStripStatusLabelVersion.Tag = "";
            toolStripStatusLabelVersion.Text = "نسخه 1.0";
            // 
            // tabCtrl
            // 
            tabCtrl.Controls.Add(tabPageFinalConsumer);
            tabCtrl.Controls.Add(tabPageTajer);
            tabCtrl.Dock = DockStyle.Fill;
            tabCtrl.Location = new Point(0, 0);
            tabCtrl.Margin = new Padding(2, 1, 2, 1);
            tabCtrl.Name = "tabCtrl";
            tabCtrl.RightToLeft = RightToLeft.Yes;
            tabCtrl.RightToLeftLayout = true;
            tabCtrl.SelectedIndex = 0;
            tabCtrl.Size = new Size(989, 363);
            tabCtrl.TabIndex = 3;
            // 
            // tabPageFinalConsumer
            // 
            tabPageFinalConsumer.Controls.Add(dataGridViewFinalConsumer);
            tabPageFinalConsumer.Controls.Add(toolStripFinalConsumer);
            tabPageFinalConsumer.Location = new Point(4, 24);
            tabPageFinalConsumer.Margin = new Padding(2, 1, 2, 1);
            tabPageFinalConsumer.Name = "tabPageFinalConsumer";
            tabPageFinalConsumer.Padding = new Padding(2, 1, 2, 1);
            tabPageFinalConsumer.Size = new Size(981, 335);
            tabPageFinalConsumer.TabIndex = 1;
            tabPageFinalConsumer.Text = "گزارش مصرف کننده نهایی";
            tabPageFinalConsumer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFinalConsumer
            // 
            dataGridViewFinalConsumer.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewFinalConsumer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinalConsumer.Columns.AddRange(new DataGridViewColumn[] { CheckBoxFinalConsumer });
            dataGridViewFinalConsumer.Dock = DockStyle.Fill;
            dataGridViewFinalConsumer.Location = new Point(2, 1);
            dataGridViewFinalConsumer.Margin = new Padding(1);
            dataGridViewFinalConsumer.Name = "dataGridViewFinalConsumer";
            dataGridViewFinalConsumer.ReadOnly = true;
            dataGridViewFinalConsumer.RowHeadersVisible = false;
            dataGridViewFinalConsumer.RowHeadersWidth = 82;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewFinalConsumer.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFinalConsumer.RowTemplate.Height = 55;
            dataGridViewFinalConsumer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFinalConsumer.Size = new Size(977, 333);
            dataGridViewFinalConsumer.TabIndex = 15;
            // 
            // CheckBoxFinalConsumer
            // 
            CheckBoxFinalConsumer.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            CheckBoxFinalConsumer.FalseValue = "";
            CheckBoxFinalConsumer.Frozen = true;
            CheckBoxFinalConsumer.HeaderText = "";
            CheckBoxFinalConsumer.MinimumWidth = 10;
            CheckBoxFinalConsumer.Name = "CheckBoxFinalConsumer";
            CheckBoxFinalConsumer.ReadOnly = true;
            CheckBoxFinalConsumer.Resizable = DataGridViewTriState.False;
            CheckBoxFinalConsumer.TrueValue = "";
            CheckBoxFinalConsumer.Visible = false;
            // 
            // toolStripFinalConsumer
            // 
            toolStripFinalConsumer.ImageScalingSize = new Size(25, 25);
            toolStripFinalConsumer.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripSeparator2, toolStripLabel1, toolStripLabel2 });
            toolStripFinalConsumer.Location = new Point(2, 1);
            toolStripFinalConsumer.Name = "toolStripFinalConsumer";
            toolStripFinalConsumer.Padding = new Padding(0, 0, 2, 0);
            toolStripFinalConsumer.Size = new Size(931, 18);
            toolStripFinalConsumer.TabIndex = 14;
            toolStripFinalConsumer.Text = "toolStrip1";
            toolStripFinalConsumer.Visible = false;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 15);
            toolStripButton1.Text = "لغو انتخاب ها";
            // 
            // toolStripButton2
            // 
            toolStripButton2.BackColor = Color.Transparent;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 15);
            toolStripButton2.Text = "انتخاب همه موارد";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 15);
            toolStripButton3.Text = "حذف موارد";
            // 
            // toolStripButton4
            // 
            toolStripButton4.Alignment = ToolStripItemAlignment.Right;
            toolStripButton4.BackgroundImageLayout = ImageLayout.Stretch;
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 15);
            toolStripButton4.Text = "بازیابی اطلاعات از دیتابیس";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 15);
            toolStripButton5.Text = "مشاهده تمامی فیلدها";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 18);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(153, 15);
            toolStripLabel1.Text = "شماره آخرین مورد ارسال شده:";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(0, 15);
            // 
            // tabPageTajer
            // 
            tabPageTajer.Controls.Add(dataGridViewTajer);
            tabPageTajer.Controls.Add(toolStripTajer);
            tabPageTajer.Location = new Point(4, 24);
            tabPageTajer.Margin = new Padding(2, 1, 2, 1);
            tabPageTajer.Name = "tabPageTajer";
            tabPageTajer.Padding = new Padding(2, 1, 2, 1);
            tabPageTajer.Size = new Size(981, 335);
            tabPageTajer.TabIndex = 0;
            tabPageTajer.Text = "گزارش تاجر";
            tabPageTajer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTajer
            // 
            dataGridViewTajer.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewTajer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTajer.Columns.AddRange(new DataGridViewColumn[] { CheckBox });
            dataGridViewTajer.Dock = DockStyle.Fill;
            dataGridViewTajer.Location = new Point(2, 1);
            dataGridViewTajer.Margin = new Padding(1);
            dataGridViewTajer.Name = "dataGridViewTajer";
            dataGridViewTajer.ReadOnly = true;
            dataGridViewTajer.RowHeadersVisible = false;
            dataGridViewTajer.RowHeadersWidth = 82;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewTajer.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTajer.RowTemplate.Height = 55;
            dataGridViewTajer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTajer.Size = new Size(977, 333);
            dataGridViewTajer.TabIndex = 14;
            // 
            // CheckBox
            // 
            CheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            CheckBox.FalseValue = "";
            CheckBox.Frozen = true;
            CheckBox.HeaderText = "";
            CheckBox.MinimumWidth = 10;
            CheckBox.Name = "CheckBox";
            CheckBox.ReadOnly = true;
            CheckBox.Resizable = DataGridViewTriState.False;
            CheckBox.TrueValue = "";
            CheckBox.Visible = false;
            // 
            // toolStripTajer
            // 
            toolStripTajer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTajer.ImageScalingSize = new Size(25, 25);
            toolStripTajer.Items.AddRange(new ToolStripItem[] { toolStripButtonDeselectAll, toolStripButtonSellectAll, toolStripButtonDeleteInvoices, toolStripButtonRefreshDB, toolStripButtonShowDetails, toolStripSeparator1, toolStripLabelLastSended, toolStripLabelLastSendedNo });
            toolStripTajer.Location = new Point(2, 1);
            toolStripTajer.Name = "toolStripTajer";
            toolStripTajer.Padding = new Padding(0, 0, 2, 0);
            toolStripTajer.Size = new Size(931, 18);
            toolStripTajer.TabIndex = 13;
            toolStripTajer.Text = "toolStripHeader";
            toolStripTajer.Visible = false;
            // 
            // toolStripButtonDeselectAll
            // 
            toolStripButtonDeselectAll.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeselectAll.Image = (Image)resources.GetObject("toolStripButtonDeselectAll.Image");
            toolStripButtonDeselectAll.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeselectAll.Name = "toolStripButtonDeselectAll";
            toolStripButtonDeselectAll.Size = new Size(29, 15);
            toolStripButtonDeselectAll.Text = "لغو انتخاب ها";
            // 
            // toolStripButtonSellectAll
            // 
            toolStripButtonSellectAll.BackColor = Color.Transparent;
            toolStripButtonSellectAll.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSellectAll.Image = (Image)resources.GetObject("toolStripButtonSellectAll.Image");
            toolStripButtonSellectAll.ImageTransparentColor = Color.Magenta;
            toolStripButtonSellectAll.Name = "toolStripButtonSellectAll";
            toolStripButtonSellectAll.Size = new Size(29, 15);
            toolStripButtonSellectAll.Text = "انتخاب همه موارد";
            // 
            // toolStripButtonDeleteInvoices
            // 
            toolStripButtonDeleteInvoices.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonDeleteInvoices.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeleteInvoices.Image = (Image)resources.GetObject("toolStripButtonDeleteInvoices.Image");
            toolStripButtonDeleteInvoices.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeleteInvoices.Name = "toolStripButtonDeleteInvoices";
            toolStripButtonDeleteInvoices.Size = new Size(29, 15);
            toolStripButtonDeleteInvoices.Text = "حذف موارد";
            // 
            // toolStripButtonRefreshDB
            // 
            toolStripButtonRefreshDB.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonRefreshDB.BackgroundImageLayout = ImageLayout.Stretch;
            toolStripButtonRefreshDB.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRefreshDB.Image = (Image)resources.GetObject("toolStripButtonRefreshDB.Image");
            toolStripButtonRefreshDB.ImageTransparentColor = Color.Magenta;
            toolStripButtonRefreshDB.Name = "toolStripButtonRefreshDB";
            toolStripButtonRefreshDB.Size = new Size(29, 15);
            toolStripButtonRefreshDB.Text = "بازیابی اطلاعات از دیتابیس";
            // 
            // toolStripButtonShowDetails
            // 
            toolStripButtonShowDetails.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonShowDetails.Image = (Image)resources.GetObject("toolStripButtonShowDetails.Image");
            toolStripButtonShowDetails.ImageTransparentColor = Color.Magenta;
            toolStripButtonShowDetails.Name = "toolStripButtonShowDetails";
            toolStripButtonShowDetails.Size = new Size(29, 15);
            toolStripButtonShowDetails.Text = "مشاهده تمامی فیلدها";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 18);
            // 
            // toolStripLabelLastSended
            // 
            toolStripLabelLastSended.Name = "toolStripLabelLastSended";
            toolStripLabelLastSended.Size = new Size(204, 15);
            toolStripLabelLastSended.Text = "شماره آخرین مورد ارسال شده:";
            // 
            // toolStripLabelLastSendedNo
            // 
            toolStripLabelLastSendedNo.Name = "toolStripLabelLastSendedNo";
            toolStripLabelLastSendedNo.Size = new Size(0, 15);
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Location = new Point(6, 13);
            btnSend.Margin = new Padding(1);
            btnSend.Name = "btnSend";
            btnSend.RightToLeft = RightToLeft.Yes;
            btnSend.Size = new Size(59, 25);
            btnSend.TabIndex = 10;
            btnSend.Tag = "ارسال";
            btnSend.Text = "ارسال";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtStockRoom
            // 
            txtStockRoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtStockRoom.Location = new Point(693, 76);
            txtStockRoom.Margin = new Padding(2);
            txtStockRoom.Name = "txtStockRoom";
            txtStockRoom.Size = new Size(167, 23);
            txtStockRoom.TabIndex = 29;
            txtStockRoom.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFiscalPeriod
            // 
            txtFiscalPeriod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFiscalPeriod.Location = new Point(693, 39);
            txtFiscalPeriod.Margin = new Padding(2);
            txtFiscalPeriod.Name = "txtFiscalPeriod";
            txtFiscalPeriod.Size = new Size(167, 23);
            txtFiscalPeriod.TabIndex = 28;
            txtFiscalPeriod.TextAlign = HorizontalAlignment.Center;
            // 
            // btnStockRoom
            // 
            btnStockRoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStockRoom.Location = new Point(539, 76);
            btnStockRoom.Margin = new Padding(2);
            btnStockRoom.Name = "btnStockRoom";
            btnStockRoom.Size = new Size(79, 26);
            btnStockRoom.TabIndex = 27;
            btnStockRoom.Text = "انتخاب";
            btnStockRoom.UseVisualStyleBackColor = true;
            btnStockRoom.Click += btnStockRoom_Click;
            // 
            // btnFiscalPeriod
            // 
            btnFiscalPeriod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiscalPeriod.Location = new Point(539, 40);
            btnFiscalPeriod.Margin = new Padding(2);
            btnFiscalPeriod.Name = "btnFiscalPeriod";
            btnFiscalPeriod.Size = new Size(79, 26);
            btnFiscalPeriod.TabIndex = 26;
            btnFiscalPeriod.Text = "انتخاب";
            btnFiscalPeriod.UseVisualStyleBackColor = true;
            btnFiscalPeriod.Click += btnFiscalPeriod_Click;
            // 
            // txtWorkSpace
            // 
            txtWorkSpace.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtWorkSpace.Location = new Point(693, 5);
            txtWorkSpace.Margin = new Padding(2);
            txtWorkSpace.Name = "txtWorkSpace";
            txtWorkSpace.Size = new Size(167, 23);
            txtWorkSpace.TabIndex = 25;
            txtWorkSpace.TextAlign = HorizontalAlignment.Center;
            // 
            // btnWorkSpace
            // 
            btnWorkSpace.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWorkSpace.Location = new Point(539, 6);
            btnWorkSpace.Margin = new Padding(2);
            btnWorkSpace.Name = "btnWorkSpace";
            btnWorkSpace.Size = new Size(79, 26);
            btnWorkSpace.TabIndex = 24;
            btnWorkSpace.Text = "انتخاب";
            btnWorkSpace.UseVisualStyleBackColor = true;
            btnWorkSpace.Click += btnWorkSpace_Click;
            // 
            // lblStockRoom
            // 
            lblStockRoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStockRoom.AutoSize = true;
            lblStockRoom.Location = new Point(917, 78);
            lblStockRoom.Margin = new Padding(2, 0, 2, 0);
            lblStockRoom.Name = "lblStockRoom";
            lblStockRoom.Size = new Size(26, 15);
            lblStockRoom.TabIndex = 23;
            lblStockRoom.Text = "انبار";
            // 
            // lblFiscalPeriod
            // 
            lblFiscalPeriod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFiscalPeriod.AutoSize = true;
            lblFiscalPeriod.Location = new Point(886, 42);
            lblFiscalPeriod.Margin = new Padding(2, 0, 2, 0);
            lblFiscalPeriod.Name = "lblFiscalPeriod";
            lblFiscalPeriod.Size = new Size(56, 15);
            lblFiscalPeriod.TabIndex = 22;
            lblFiscalPeriod.Text = "دوره مالی";
            // 
            // lblWorkSpace
            // 
            lblWorkSpace.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWorkSpace.AutoSize = true;
            lblWorkSpace.Location = new Point(904, 8);
            lblWorkSpace.Margin = new Padding(2, 0, 2, 0);
            lblWorkSpace.Name = "lblWorkSpace";
            lblWorkSpace.Size = new Size(37, 15);
            lblWorkSpace.TabIndex = 21;
            lblWorkSpace.Text = "شرکت";
            // 
            // fromDatePicker
            // 
            fromDatePicker.AutoSize = true;
            fromDatePicker.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fromDatePicker.BackColor = Color.White;
            fromDatePicker.GeorgianDate = null;
            fromDatePicker.Location = new Point(25, 7);
            fromDatePicker.Margin = new Padding(0);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.PersianDate.Day = 0;
            fromDatePicker.PersianDate.Month = 0;
            fromDatePicker.PersianDate.Year = 0;
            fromDatePicker.RightToLeft = RightToLeft.Yes;
            fromDatePicker.Size = new Size(288, 24);
            fromDatePicker.TabIndex = 33;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(350, 12);
            lblFrom.Margin = new Padding(2, 0, 2, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(60, 15);
            lblFrom.TabIndex = 32;
            lblFrom.Text = "تاریخ شروع";
            // 
            // lblUntil
            // 
            lblUntil.AutoSize = true;
            lblUntil.Location = new Point(355, 46);
            lblUntil.Margin = new Padding(2, 0, 2, 0);
            lblUntil.Name = "lblUntil";
            lblUntil.Size = new Size(56, 15);
            lblUntil.TabIndex = 31;
            lblUntil.Text = "تاریخ پایان";
            // 
            // untilDatePicker
            // 
            untilDatePicker.AutoSize = true;
            untilDatePicker.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            untilDatePicker.BackColor = Color.White;
            untilDatePicker.GeorgianDate = null;
            untilDatePicker.Location = new Point(25, 43);
            untilDatePicker.Margin = new Padding(0);
            untilDatePicker.Name = "untilDatePicker";
            untilDatePicker.PersianDate.Day = 0;
            untilDatePicker.PersianDate.Month = 0;
            untilDatePicker.PersianDate.Year = 0;
            untilDatePicker.RightToLeft = RightToLeft.Yes;
            untilDatePicker.Size = new Size(288, 24);
            untilDatePicker.TabIndex = 30;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(25, 76);
            btnReport.Margin = new Padding(2);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(170, 26);
            btnReport.TabIndex = 34;
            btnReport.Text = "نمایش گزارش";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnReport);
            splitContainer1.Panel1.Controls.Add(untilDatePicker);
            splitContainer1.Panel1.Controls.Add(lblUntil);
            splitContainer1.Panel1.Controls.Add(txtStockRoom);
            splitContainer1.Panel1.Controls.Add(txtFiscalPeriod);
            splitContainer1.Panel1.Controls.Add(lblFrom);
            splitContainer1.Panel1.Controls.Add(txtWorkSpace);
            splitContainer1.Panel1.Controls.Add(fromDatePicker);
            splitContainer1.Panel1.Controls.Add(lblStockRoom);
            splitContainer1.Panel1.Controls.Add(btnStockRoom);
            splitContainer1.Panel1.Controls.Add(lblFiscalPeriod);
            splitContainer1.Panel1.Controls.Add(btnWorkSpace);
            splitContainer1.Panel1.Controls.Add(lblWorkSpace);
            splitContainer1.Panel1.Controls.Add(btnFiscalPeriod);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(989, 516);
            splitContainer1.SplitterDistance = 106;
            splitContainer1.TabIndex = 36;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tabCtrl);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(progressBar);
            splitContainer2.Panel2.Controls.Add(btnSend);
            splitContainer2.Size = new Size(989, 406);
            splitContainer2.SplitterDistance = 363;
            splitContainer2.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Top;
            progressBar.Location = new Point(0, 0);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(989, 10);
            progressBar.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 538);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabCtrl.ResumeLayout(false);
            tabPageFinalConsumer.ResumeLayout(false);
            tabPageFinalConsumer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinalConsumer).EndInit();
            toolStripFinalConsumer.ResumeLayout(false);
            toolStripFinalConsumer.PerformLayout();
            tabPageTajer.ResumeLayout(false);
            tabPageTajer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTajer).EndInit();
            toolStripTajer.ResumeLayout(false);
            toolStripTajer.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        private TextBox txtNumber;
        private StatusStrip statusStrip1;
        private TabControl tabCtrl;
        private TabPage tabPageTejari;
        private TabPage tabPageFinalConsumer;
        private TabPage tabPageTajer;
        private ToolStrip toolStripTajer;
        private ToolStripButton toolStripButtonDeselectAll;
        private ToolStripButton toolStripButtonSellectAll;
        private ToolStripButton toolStripButtonDeleteInvoices;
        private ToolStripButton toolStripButtonRefreshDB;
        private ToolStripButton toolStripButtonShowDetails;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabelLastSended;
        private ToolStripLabel toolStripLabelLastSendedNo;
        private ToolStripStatusLabel toolStripStatusLabelVersion;
        private Button btnSend;
        private DataGridView dataGridViewTajer;
        private DataGridViewCheckBoxColumn CheckBox;
        private ToolStrip toolStripFinalConsumer;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private DataGridView dataGridViewFinalConsumer;
        private DataGridViewCheckBoxColumn CheckBoxFinalConsumer;
        private TextBox txtStockRoom;
        private TextBox txtFiscalPeriod;
        private Button btnStockRoom;
        private Button btnFiscalPeriod;
        private TextBox txtWorkSpace;
        private Button btnWorkSpace;
        private Label lblStockRoom;
        private Label lblFiscalPeriod;
        private Label lblWorkSpace;
        private PersianDatePicker fromDatePicker;
        private Label lblFrom;
        private Label lblUntil;
        private PersianDatePicker untilDatePicker;
        private Button btnReport;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ProgressBar progressBar;
    }
}