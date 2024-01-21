﻿using kashka.Data_Access_Layer.Repositories;
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtNumber = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelVersion = new ToolStripStatusLabel();
            toolStripStatusLabelNetWorkStatus = new ToolStripStatusLabel();
            tabCtrl = new TabControl();
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
            statusStrip1.SuspendLayout();
            tabCtrl.SuspendLayout();
            tabPageTajer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTajer).BeginInit();
            toolStripTajer.SuspendLayout();
            tabPageFinalConsumer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinalConsumer).BeginInit();
            toolStripFinalConsumer.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(100, 100);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(150, 39);
            txtNumber.TabIndex = 0;
            txtNumber.KeyPress += txtNumber_KeyPress;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelVersion, toolStripStatusLabelNetWorkStatus });
            statusStrip1.Location = new Point(0, 1019);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(1762, 42);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelVersion
            // 
            toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
            toolStripStatusLabelVersion.Padding = new Padding(0, 0, 50, 0);
            toolStripStatusLabelVersion.Size = new Size(147, 32);
            toolStripStatusLabelVersion.Tag = "";
            toolStripStatusLabelVersion.Text = "نسخه 1.0";
            // 
            // toolStripStatusLabelNetWorkStatus
            // 
            toolStripStatusLabelNetWorkStatus.ForeColor = Color.DarkOrange;
            toolStripStatusLabelNetWorkStatus.Name = "toolStripStatusLabelNetWorkStatus";
            toolStripStatusLabelNetWorkStatus.Size = new Size(220, 32);
            toolStripStatusLabelNetWorkStatus.Text = "وضعیت اتصال شبکه";
            // 
            // tabCtrl
            // 
            tabCtrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabCtrl.Controls.Add(tabPageFinalConsumer);
            tabCtrl.Controls.Add(tabPageTajer);
            tabCtrl.Location = new Point(12, 299);
            tabCtrl.Name = "tabCtrl";
            tabCtrl.RightToLeft = RightToLeft.Yes;
            tabCtrl.RightToLeftLayout = true;
            tabCtrl.SelectedIndex = 0;
            tabCtrl.Size = new Size(1751, 648);
            tabCtrl.TabIndex = 3;
            // 
            // tabPageTajer
            // 
            tabPageTajer.Controls.Add(dataGridViewTajer);
            tabPageTajer.Controls.Add(toolStripTajer);
            tabPageTajer.Controls.Add(btnSend);
            tabPageTajer.Location = new Point(8, 46);
            tabPageTajer.Name = "tabPageTajer";
            tabPageTajer.Padding = new Padding(3, 3, 3, 3);
            tabPageTajer.Size = new Size(1735, 594);
            tabPageTajer.TabIndex = 0;
            tabPageTajer.Text = "گزارش تاجر";
            tabPageTajer.UseVisualStyleBackColor = true;
            tabPageTajer.Enter += tabPageTajer_Enter;
            // 
            // dataGridViewTajer
            // 
            dataGridViewTajer.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewTajer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTajer.Columns.AddRange(new DataGridViewColumn[] { CheckBox });
            dataGridViewTajer.Dock = DockStyle.Fill;
            dataGridViewTajer.Location = new Point(3, 3);
            dataGridViewTajer.Margin = new Padding(1, 2, 1, 2);
            dataGridViewTajer.Name = "dataGridViewTajer";
            dataGridViewTajer.RowHeadersVisible = false;
            dataGridViewTajer.RowHeadersWidth = 82;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewTajer.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTajer.RowTemplate.Height = 55;
            dataGridViewTajer.Size = new Size(1729, 588);
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
            CheckBox.Resizable = DataGridViewTriState.False;
            CheckBox.TrueValue = "";
            CheckBox.Visible = false;
            CheckBox.Width = 200;
            // 
            // toolStripTajer
            // 
            toolStripTajer.ImageScalingSize = new Size(25, 25);
            toolStripTajer.Items.AddRange(new ToolStripItem[] { toolStripButtonDeselectAll, toolStripButtonSellectAll, toolStripButtonDeleteInvoices, toolStripButtonRefreshDB, toolStripButtonShowDetails, toolStripSeparator1, toolStripLabelLastSended, toolStripLabelLastSendedNo });
            toolStripTajer.Location = new Point(3, 3);
            toolStripTajer.Name = "toolStripTajer";
            toolStripTajer.Padding = new Padding(0, 0, 3, 0);
            toolStripTajer.Size = new Size(1729, 38);
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
            toolStripButtonDeselectAll.Size = new Size(46, 32);
            toolStripButtonDeselectAll.Text = "لغو انتخاب ها";
            // 
            // toolStripButtonSellectAll
            // 
            toolStripButtonSellectAll.BackColor = Color.Transparent;
            toolStripButtonSellectAll.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSellectAll.Image = (Image)resources.GetObject("toolStripButtonSellectAll.Image");
            toolStripButtonSellectAll.ImageTransparentColor = Color.Magenta;
            toolStripButtonSellectAll.Name = "toolStripButtonSellectAll";
            toolStripButtonSellectAll.Size = new Size(46, 32);
            toolStripButtonSellectAll.Text = "انتخاب همه موارد";
            // 
            // toolStripButtonDeleteInvoices
            // 
            toolStripButtonDeleteInvoices.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonDeleteInvoices.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeleteInvoices.Image = (Image)resources.GetObject("toolStripButtonDeleteInvoices.Image");
            toolStripButtonDeleteInvoices.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeleteInvoices.Name = "toolStripButtonDeleteInvoices";
            toolStripButtonDeleteInvoices.Size = new Size(46, 32);
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
            toolStripButtonRefreshDB.Size = new Size(46, 32);
            toolStripButtonRefreshDB.Text = "بازیابی اطلاعات از دیتابیس";
            // 
            // toolStripButtonShowDetails
            // 
            toolStripButtonShowDetails.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonShowDetails.Image = (Image)resources.GetObject("toolStripButtonShowDetails.Image");
            toolStripButtonShowDetails.ImageTransparentColor = Color.Magenta;
            toolStripButtonShowDetails.Name = "toolStripButtonShowDetails";
            toolStripButtonShowDetails.Size = new Size(46, 32);
            toolStripButtonShowDetails.Text = "مشاهده تمامی فیلدها";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // toolStripLabelLastSended
            // 
            toolStripLabelLastSended.Name = "toolStripLabelLastSended";
            toolStripLabelLastSended.Size = new Size(309, 32);
            toolStripLabelLastSended.Text = "شماره آخرین مورد ارسال شده:";
            // 
            // toolStripLabelLastSendedNo
            // 
            toolStripLabelLastSendedNo.Name = "toolStripLabelLastSendedNo";
            toolStripLabelLastSendedNo.Size = new Size(0, 32);
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSend.BackgroundImage = (Image)resources.GetObject("btnSend.BackgroundImage");
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Location = new Point(198, 372);
            btnSend.Margin = new Padding(1, 2, 1, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(62, 180);
            btnSend.TabIndex = 10;
            btnSend.Tag = "ارسال";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // tabPageFinalConsumer
            // 
            tabPageFinalConsumer.Controls.Add(dataGridViewFinalConsumer);
            tabPageFinalConsumer.Controls.Add(toolStripFinalConsumer);
            tabPageFinalConsumer.Location = new Point(8, 46);
            tabPageFinalConsumer.Name = "tabPageFinalConsumer";
            tabPageFinalConsumer.Padding = new Padding(3, 3, 3, 3);
            tabPageFinalConsumer.Size = new Size(1735, 594);
            tabPageFinalConsumer.TabIndex = 1;
            tabPageFinalConsumer.Text = "گزارش مصرف کننده نهایی";
            tabPageFinalConsumer.UseVisualStyleBackColor = true;
            tabPageFinalConsumer.Enter += tabPageFinalConsumer_Enter;
            // 
            // dataGridViewFinalConsumer
            // 
            dataGridViewFinalConsumer.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewFinalConsumer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinalConsumer.Columns.AddRange(new DataGridViewColumn[] { CheckBoxFinalConsumer });
            dataGridViewFinalConsumer.Dock = DockStyle.Fill;
            dataGridViewFinalConsumer.Location = new Point(3, 3);
            dataGridViewFinalConsumer.Margin = new Padding(1, 2, 1, 2);
            dataGridViewFinalConsumer.Name = "dataGridViewFinalConsumer";
            dataGridViewFinalConsumer.RowHeadersVisible = false;
            dataGridViewFinalConsumer.RowHeadersWidth = 82;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewFinalConsumer.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFinalConsumer.RowTemplate.Height = 55;
            dataGridViewFinalConsumer.Size = new Size(1729, 588);
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
            CheckBoxFinalConsumer.Resizable = DataGridViewTriState.False;
            CheckBoxFinalConsumer.TrueValue = "";
            CheckBoxFinalConsumer.Visible = false;
            CheckBoxFinalConsumer.Width = 200;
            // 
            // toolStripFinalConsumer
            // 
            toolStripFinalConsumer.ImageScalingSize = new Size(25, 25);
            toolStripFinalConsumer.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripSeparator2, toolStripLabel1, toolStripLabel2 });
            toolStripFinalConsumer.Location = new Point(3, 3);
            toolStripFinalConsumer.Name = "toolStripFinalConsumer";
            toolStripFinalConsumer.Padding = new Padding(0, 0, 3, 0);
            toolStripFinalConsumer.Size = new Size(1729, 38);
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
            toolStripButton1.Size = new Size(46, 32);
            toolStripButton1.Text = "لغو انتخاب ها";
            // 
            // toolStripButton2
            // 
            toolStripButton2.BackColor = Color.Transparent;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(46, 32);
            toolStripButton2.Text = "انتخاب همه موارد";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(46, 32);
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
            toolStripButton4.Size = new Size(46, 32);
            toolStripButton4.Text = "بازیابی اطلاعات از دیتابیس";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(46, 32);
            toolStripButton5.Text = "مشاهده تمامی فیلدها";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(309, 32);
            toolStripLabel1.Text = "شماره آخرین مورد ارسال شده:";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(0, 32);
            // 
            // txtStockRoom
            // 
            txtStockRoom.Location = new Point(1242, 192);
            txtStockRoom.Margin = new Padding(4, 5, 4, 5);
            txtStockRoom.Name = "txtStockRoom";
            txtStockRoom.Size = new Size(306, 39);
            txtStockRoom.TabIndex = 29;
            txtStockRoom.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFiscalPeriod
            // 
            txtFiscalPeriod.Location = new Point(1242, 114);
            txtFiscalPeriod.Margin = new Padding(4, 5, 4, 5);
            txtFiscalPeriod.Name = "txtFiscalPeriod";
            txtFiscalPeriod.Size = new Size(306, 39);
            txtFiscalPeriod.TabIndex = 28;
            txtFiscalPeriod.TextAlign = HorizontalAlignment.Center;
            // 
            // btnStockRoom
            // 
            btnStockRoom.Location = new Point(1024, 184);
            btnStockRoom.Margin = new Padding(4, 5, 4, 5);
            btnStockRoom.Name = "btnStockRoom";
            btnStockRoom.Size = new Size(146, 56);
            btnStockRoom.TabIndex = 27;
            btnStockRoom.Text = "انتخاب";
            btnStockRoom.UseVisualStyleBackColor = true;
            btnStockRoom.Click += btnStockRoom_Click;
            // 
            // btnFiscalPeriod
            // 
            btnFiscalPeriod.Location = new Point(1024, 107);
            btnFiscalPeriod.Margin = new Padding(4, 5, 4, 5);
            btnFiscalPeriod.Name = "btnFiscalPeriod";
            btnFiscalPeriod.Size = new Size(146, 56);
            btnFiscalPeriod.TabIndex = 26;
            btnFiscalPeriod.Text = "انتخاب";
            btnFiscalPeriod.UseVisualStyleBackColor = true;
            btnFiscalPeriod.Click += btnFiscalPeriod_Click;
            // 
            // txtWorkSpace
            // 
            txtWorkSpace.Location = new Point(1242, 41);
            txtWorkSpace.Margin = new Padding(4, 5, 4, 5);
            txtWorkSpace.Name = "txtWorkSpace";
            txtWorkSpace.Size = new Size(306, 39);
            txtWorkSpace.TabIndex = 25;
            txtWorkSpace.TextAlign = HorizontalAlignment.Center;
            // 
            // btnWorkSpace
            // 
            btnWorkSpace.Location = new Point(1024, 34);
            btnWorkSpace.Margin = new Padding(4, 5, 4, 5);
            btnWorkSpace.Name = "btnWorkSpace";
            btnWorkSpace.Size = new Size(146, 56);
            btnWorkSpace.TabIndex = 24;
            btnWorkSpace.Text = "انتخاب";
            btnWorkSpace.UseVisualStyleBackColor = true;
            btnWorkSpace.Click += btnWorkSpace_Click;
            // 
            // lblStockRoom
            // 
            lblStockRoom.AutoSize = true;
            lblStockRoom.Location = new Point(1658, 197);
            lblStockRoom.Margin = new Padding(4, 0, 4, 0);
            lblStockRoom.Name = "lblStockRoom";
            lblStockRoom.Size = new Size(52, 32);
            lblStockRoom.TabIndex = 23;
            lblStockRoom.Text = "انبار";
            // 
            // lblFiscalPeriod
            // 
            lblFiscalPeriod.AutoSize = true;
            lblFiscalPeriod.Location = new Point(1600, 119);
            lblFiscalPeriod.Margin = new Padding(4, 0, 4, 0);
            lblFiscalPeriod.Name = "lblFiscalPeriod";
            lblFiscalPeriod.Size = new Size(113, 32);
            lblFiscalPeriod.TabIndex = 22;
            lblFiscalPeriod.Text = "دوره مالی";
            // 
            // lblWorkSpace
            // 
            lblWorkSpace.AutoSize = true;
            lblWorkSpace.Location = new Point(1635, 46);
            lblWorkSpace.Margin = new Padding(4, 0, 4, 0);
            lblWorkSpace.Name = "lblWorkSpace";
            lblWorkSpace.Size = new Size(74, 32);
            lblWorkSpace.TabIndex = 21;
            lblWorkSpace.Text = "شرکت";
            // 
            // fromDatePicker
            // 
            fromDatePicker.AutoSize = true;
            fromDatePicker.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fromDatePicker.BackColor = Color.White;
            fromDatePicker.GeorgianDate = null;
            fromDatePicker.Location = new Point(82, 37);
            fromDatePicker.Margin = new Padding(0);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.PersianDate.Day = 0;
            fromDatePicker.PersianDate.Month = 0;
            fromDatePicker.PersianDate.Year = 0;
            fromDatePicker.RightToLeft = RightToLeft.Yes;
            fromDatePicker.Size = new Size(530, 48);
            fromDatePicker.TabIndex = 33;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(686, 46);
            lblFrom.Margin = new Padding(4, 0, 4, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(121, 32);
            lblFrom.TabIndex = 32;
            lblFrom.Text = "تاریخ شروع";
            // 
            // lblUntil
            // 
            lblUntil.AutoSize = true;
            lblUntil.Location = new Point(695, 119);
            lblUntil.Margin = new Padding(4, 0, 4, 0);
            lblUntil.Name = "lblUntil";
            lblUntil.Size = new Size(113, 32);
            lblUntil.TabIndex = 31;
            lblUntil.Text = "تاریخ پایان";
            // 
            // untilDatePicker
            // 
            untilDatePicker.AutoSize = true;
            untilDatePicker.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            untilDatePicker.BackColor = Color.White;
            untilDatePicker.GeorgianDate = null;
            untilDatePicker.Location = new Point(82, 114);
            untilDatePicker.Margin = new Padding(0);
            untilDatePicker.Name = "untilDatePicker";
            untilDatePicker.PersianDate.Day = 0;
            untilDatePicker.PersianDate.Month = 0;
            untilDatePicker.PersianDate.Year = 0;
            untilDatePicker.RightToLeft = RightToLeft.Yes;
            untilDatePicker.Size = new Size(530, 48);
            untilDatePicker.TabIndex = 30;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(82, 184);
            btnReport.Margin = new Padding(4, 5, 4, 5);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(316, 56);
            btnReport.TabIndex = 34;
            btnReport.Text = "نمایش گزارش";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1762, 1061);
            Controls.Add(btnReport);
            Controls.Add(fromDatePicker);
            Controls.Add(lblFrom);
            Controls.Add(lblUntil);
            Controls.Add(untilDatePicker);
            Controls.Add(txtStockRoom);
            Controls.Add(txtFiscalPeriod);
            Controls.Add(btnStockRoom);
            Controls.Add(btnFiscalPeriod);
            Controls.Add(txtWorkSpace);
            Controls.Add(btnWorkSpace);
            Controls.Add(lblStockRoom);
            Controls.Add(lblFiscalPeriod);
            Controls.Add(lblWorkSpace);
            Controls.Add(tabCtrl);
            Controls.Add(statusStrip1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "MainForm";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabCtrl.ResumeLayout(false);
            tabPageTajer.ResumeLayout(false);
            tabPageTajer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTajer).EndInit();
            toolStripTajer.ResumeLayout(false);
            toolStripTajer.PerformLayout();
            tabPageFinalConsumer.ResumeLayout(false);
            tabPageFinalConsumer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinalConsumer).EndInit();
            toolStripFinalConsumer.ResumeLayout(false);
            toolStripFinalConsumer.PerformLayout();
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
        private ToolStripStatusLabel toolStripStatusLabelNetWorkStatus;
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
    }
}