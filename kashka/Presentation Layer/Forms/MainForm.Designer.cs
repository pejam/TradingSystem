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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPageFinalConsumer = new System.Windows.Forms.TabPage();
            this.dataGridViewFinalConsumer = new System.Windows.Forms.DataGridView();
            this.CheckBoxFinalConsumer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripFinalConsumer = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tabPageTajer = new System.Windows.Forms.TabPage();
            this.dataGridViewTajer = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripTajer = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDeselectAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSellectAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteInvoices = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefreshDB = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowDetails = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelLastSended = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelLastSendedNo = new System.Windows.Forms.ToolStripLabel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtStockRoom = new System.Windows.Forms.TextBox();
            this.txtFiscalPeriod = new System.Windows.Forms.TextBox();
            this.btnStockRoom = new System.Windows.Forms.Button();
            this.btnFiscalPeriod = new System.Windows.Forms.Button();
            this.txtWorkSpace = new System.Windows.Forms.TextBox();
            this.btnWorkSpace = new System.Windows.Forms.Button();
            this.lblStockRoom = new System.Windows.Forms.Label();
            this.lblFiscalPeriod = new System.Windows.Forms.Label();
            this.lblWorkSpace = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.PersianDatePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblUntil = new System.Windows.Forms.Label();
            this.untilDatePicker = new System.Windows.Forms.PersianDatePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusStrip1.SuspendLayout();
            this.tabCtrl.SuspendLayout();
            this.tabPageFinalConsumer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinalConsumer)).BeginInit();
            this.toolStripFinalConsumer.SuspendLayout();
            this.tabPageTajer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTajer)).BeginInit();
            this.toolStripTajer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(100, 100);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(150, 27);
            this.txtNumber.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 691);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(9, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1130, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelVersion
            // 
            this.toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
            this.toolStripStatusLabelVersion.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.toolStripStatusLabelVersion.Size = new System.Drawing.Size(112, 20);
            this.toolStripStatusLabelVersion.Tag = "";
            this.toolStripStatusLabelVersion.Text = "نسخه 1.0";
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPageFinalConsumer);
            this.tabCtrl.Controls.Add(this.tabPageTajer);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCtrl.RightToLeftLayout = true;
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(1130, 487);
            this.tabCtrl.TabIndex = 3;
            // 
            // tabPageFinalConsumer
            // 
            this.tabPageFinalConsumer.Controls.Add(this.dataGridViewFinalConsumer);
            this.tabPageFinalConsumer.Controls.Add(this.toolStripFinalConsumer);
            this.tabPageFinalConsumer.Location = new System.Drawing.Point(4, 29);
            this.tabPageFinalConsumer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageFinalConsumer.Name = "tabPageFinalConsumer";
            this.tabPageFinalConsumer.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageFinalConsumer.Size = new System.Drawing.Size(1122, 454);
            this.tabPageFinalConsumer.TabIndex = 1;
            this.tabPageFinalConsumer.Text = "گزارش مصرف کننده نهایی";
            this.tabPageFinalConsumer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFinalConsumer
            // 
            this.dataGridViewFinalConsumer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewFinalConsumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinalConsumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxFinalConsumer});
            this.dataGridViewFinalConsumer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFinalConsumer.Location = new System.Drawing.Point(2, 1);
            this.dataGridViewFinalConsumer.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewFinalConsumer.Name = "dataGridViewFinalConsumer";
            this.dataGridViewFinalConsumer.ReadOnly = true;
            this.dataGridViewFinalConsumer.RowHeadersVisible = false;
            this.dataGridViewFinalConsumer.RowHeadersWidth = 82;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewFinalConsumer.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewFinalConsumer.RowTemplate.Height = 55;
            this.dataGridViewFinalConsumer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFinalConsumer.Size = new System.Drawing.Size(1118, 452);
            this.dataGridViewFinalConsumer.TabIndex = 15;
            // 
            // CheckBoxFinalConsumer
            // 
            this.CheckBoxFinalConsumer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.CheckBoxFinalConsumer.FalseValue = "";
            this.CheckBoxFinalConsumer.Frozen = true;
            this.CheckBoxFinalConsumer.HeaderText = "";
            this.CheckBoxFinalConsumer.MinimumWidth = 10;
            this.CheckBoxFinalConsumer.Name = "CheckBoxFinalConsumer";
            this.CheckBoxFinalConsumer.ReadOnly = true;
            this.CheckBoxFinalConsumer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckBoxFinalConsumer.TrueValue = "";
            this.CheckBoxFinalConsumer.Visible = false;
            this.CheckBoxFinalConsumer.Width = 125;
            // 
            // toolStripFinalConsumer
            // 
            this.toolStripFinalConsumer.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStripFinalConsumer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStripFinalConsumer.Location = new System.Drawing.Point(2, 1);
            this.toolStripFinalConsumer.Name = "toolStripFinalConsumer";
            this.toolStripFinalConsumer.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripFinalConsumer.Size = new System.Drawing.Size(1064, 24);
            this.toolStripFinalConsumer.TabIndex = 14;
            this.toolStripFinalConsumer.Text = "toolStrip1";
            this.toolStripFinalConsumer.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 21);
            this.toolStripButton1.Text = "لغو انتخاب ها";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 21);
            this.toolStripButton2.Text = "انتخاب همه موارد";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 21);
            this.toolStripButton3.Text = "حذف موارد";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 21);
            this.toolStripButton4.Text = "بازیابی اطلاعات از دیتابیس";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 21);
            this.toolStripButton5.Text = "مشاهده تمامی فیلدها";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(197, 21);
            this.toolStripLabel1.Text = "شماره آخرین مورد ارسال شده:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 21);
            // 
            // tabPageTajer
            // 
            this.tabPageTajer.Controls.Add(this.dataGridViewTajer);
            this.tabPageTajer.Controls.Add(this.toolStripTajer);
            this.tabPageTajer.Location = new System.Drawing.Point(4, 29);
            this.tabPageTajer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageTajer.Name = "tabPageTajer";
            this.tabPageTajer.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageTajer.Size = new System.Drawing.Size(1122, 451);
            this.tabPageTajer.TabIndex = 0;
            this.tabPageTajer.Text = "گزارش تاجر";
            this.tabPageTajer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTajer
            // 
            this.dataGridViewTajer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTajer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTajer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox});
            this.dataGridViewTajer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTajer.Location = new System.Drawing.Point(2, 1);
            this.dataGridViewTajer.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewTajer.Name = "dataGridViewTajer";
            this.dataGridViewTajer.ReadOnly = true;
            this.dataGridViewTajer.RowHeadersVisible = false;
            this.dataGridViewTajer.RowHeadersWidth = 82;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewTajer.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTajer.RowTemplate.Height = 55;
            this.dataGridViewTajer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTajer.Size = new System.Drawing.Size(1118, 449);
            this.dataGridViewTajer.TabIndex = 14;
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.CheckBox.FalseValue = "";
            this.CheckBox.Frozen = true;
            this.CheckBox.HeaderText = "";
            this.CheckBox.MinimumWidth = 10;
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.ReadOnly = true;
            this.CheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckBox.TrueValue = "";
            this.CheckBox.Visible = false;
            this.CheckBox.Width = 125;
            // 
            // toolStripTajer
            // 
            this.toolStripTajer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripTajer.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStripTajer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDeselectAll,
            this.toolStripButtonSellectAll,
            this.toolStripButtonDeleteInvoices,
            this.toolStripButtonRefreshDB,
            this.toolStripButtonShowDetails,
            this.toolStripSeparator1,
            this.toolStripLabelLastSended,
            this.toolStripLabelLastSendedNo});
            this.toolStripTajer.Location = new System.Drawing.Point(2, 1);
            this.toolStripTajer.Name = "toolStripTajer";
            this.toolStripTajer.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripTajer.Size = new System.Drawing.Size(1064, 24);
            this.toolStripTajer.TabIndex = 13;
            this.toolStripTajer.Text = "toolStripHeader";
            this.toolStripTajer.Visible = false;
            // 
            // toolStripButtonDeselectAll
            // 
            this.toolStripButtonDeselectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeselectAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeselectAll.Image")));
            this.toolStripButtonDeselectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeselectAll.Name = "toolStripButtonDeselectAll";
            this.toolStripButtonDeselectAll.Size = new System.Drawing.Size(29, 21);
            this.toolStripButtonDeselectAll.Text = "لغو انتخاب ها";
            // 
            // toolStripButtonSellectAll
            // 
            this.toolStripButtonSellectAll.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonSellectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSellectAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSellectAll.Image")));
            this.toolStripButtonSellectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSellectAll.Name = "toolStripButtonSellectAll";
            this.toolStripButtonSellectAll.Size = new System.Drawing.Size(29, 21);
            this.toolStripButtonSellectAll.Text = "انتخاب همه موارد";
            // 
            // toolStripButtonDeleteInvoices
            // 
            this.toolStripButtonDeleteInvoices.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonDeleteInvoices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteInvoices.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteInvoices.Image")));
            this.toolStripButtonDeleteInvoices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteInvoices.Name = "toolStripButtonDeleteInvoices";
            this.toolStripButtonDeleteInvoices.Size = new System.Drawing.Size(29, 21);
            this.toolStripButtonDeleteInvoices.Text = "حذف موارد";
            // 
            // toolStripButtonRefreshDB
            // 
            this.toolStripButtonRefreshDB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonRefreshDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonRefreshDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefreshDB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefreshDB.Image")));
            this.toolStripButtonRefreshDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefreshDB.Name = "toolStripButtonRefreshDB";
            this.toolStripButtonRefreshDB.Size = new System.Drawing.Size(29, 21);
            this.toolStripButtonRefreshDB.Text = "بازیابی اطلاعات از دیتابیس";
            // 
            // toolStripButtonShowDetails
            // 
            this.toolStripButtonShowDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowDetails.Image")));
            this.toolStripButtonShowDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowDetails.Name = "toolStripButtonShowDetails";
            this.toolStripButtonShowDetails.Size = new System.Drawing.Size(29, 21);
            this.toolStripButtonShowDetails.Text = "مشاهده تمامی فیلدها";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripLabelLastSended
            // 
            this.toolStripLabelLastSended.Name = "toolStripLabelLastSended";
            this.toolStripLabelLastSended.Size = new System.Drawing.Size(254, 21);
            this.toolStripLabelLastSended.Text = "شماره آخرین مورد ارسال شده:";
            // 
            // toolStripLabelLastSendedNo
            // 
            this.toolStripLabelLastSendedNo.Name = "toolStripLabelLastSendedNo";
            this.toolStripLabelLastSendedNo.Size = new System.Drawing.Size(0, 21);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Location = new System.Drawing.Point(7, 18);
            this.btnSend.Margin = new System.Windows.Forms.Padding(1);
            this.btnSend.Name = "btnSend";
            this.btnSend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSend.Size = new System.Drawing.Size(67, 33);
            this.btnSend.TabIndex = 10;
            this.btnSend.Tag = "ارسال";
            this.btnSend.Text = "ارسال";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtStockRoom
            // 
            this.txtStockRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockRoom.Location = new System.Drawing.Point(792, 101);
            this.txtStockRoom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStockRoom.Name = "txtStockRoom";
            this.txtStockRoom.Size = new System.Drawing.Size(190, 27);
            this.txtStockRoom.TabIndex = 29;
            this.txtStockRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiscalPeriod
            // 
            this.txtFiscalPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiscalPeriod.Location = new System.Drawing.Point(792, 52);
            this.txtFiscalPeriod.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFiscalPeriod.Name = "txtFiscalPeriod";
            this.txtFiscalPeriod.Size = new System.Drawing.Size(190, 27);
            this.txtFiscalPeriod.TabIndex = 28;
            this.txtFiscalPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStockRoom
            // 
            this.btnStockRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockRoom.Location = new System.Drawing.Point(616, 101);
            this.btnStockRoom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStockRoom.Name = "btnStockRoom";
            this.btnStockRoom.Size = new System.Drawing.Size(90, 35);
            this.btnStockRoom.TabIndex = 27;
            this.btnStockRoom.Text = "انتخاب";
            this.btnStockRoom.UseVisualStyleBackColor = true;
            this.btnStockRoom.Click += new System.EventHandler(this.btnStockRoom_Click);
            // 
            // btnFiscalPeriod
            // 
            this.btnFiscalPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiscalPeriod.Location = new System.Drawing.Point(616, 53);
            this.btnFiscalPeriod.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFiscalPeriod.Name = "btnFiscalPeriod";
            this.btnFiscalPeriod.Size = new System.Drawing.Size(90, 35);
            this.btnFiscalPeriod.TabIndex = 26;
            this.btnFiscalPeriod.Text = "انتخاب";
            this.btnFiscalPeriod.UseVisualStyleBackColor = true;
            this.btnFiscalPeriod.Click += new System.EventHandler(this.btnFiscalPeriod_Click);
            // 
            // txtWorkSpace
            // 
            this.txtWorkSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkSpace.Location = new System.Drawing.Point(792, 7);
            this.txtWorkSpace.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtWorkSpace.Name = "txtWorkSpace";
            this.txtWorkSpace.Size = new System.Drawing.Size(190, 27);
            this.txtWorkSpace.TabIndex = 25;
            this.txtWorkSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnWorkSpace
            // 
            this.btnWorkSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkSpace.Location = new System.Drawing.Point(616, 8);
            this.btnWorkSpace.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnWorkSpace.Name = "btnWorkSpace";
            this.btnWorkSpace.Size = new System.Drawing.Size(90, 35);
            this.btnWorkSpace.TabIndex = 24;
            this.btnWorkSpace.Text = "انتخاب";
            this.btnWorkSpace.UseVisualStyleBackColor = true;
            this.btnWorkSpace.Click += new System.EventHandler(this.btnWorkSpace_Click);
            // 
            // lblStockRoom
            // 
            this.lblStockRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockRoom.AutoSize = true;
            this.lblStockRoom.Location = new System.Drawing.Point(1048, 104);
            this.lblStockRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockRoom.Name = "lblStockRoom";
            this.lblStockRoom.Size = new System.Drawing.Size(33, 20);
            this.lblStockRoom.TabIndex = 23;
            this.lblStockRoom.Text = "انبار";
            // 
            // lblFiscalPeriod
            // 
            this.lblFiscalPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiscalPeriod.AutoSize = true;
            this.lblFiscalPeriod.Location = new System.Drawing.Point(1013, 56);
            this.lblFiscalPeriod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiscalPeriod.Name = "lblFiscalPeriod";
            this.lblFiscalPeriod.Size = new System.Drawing.Size(73, 20);
            this.lblFiscalPeriod.TabIndex = 22;
            this.lblFiscalPeriod.Text = "دوره مالی";
            // 
            // lblWorkSpace
            // 
            this.lblWorkSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorkSpace.AutoSize = true;
            this.lblWorkSpace.Location = new System.Drawing.Point(1033, 11);
            this.lblWorkSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkSpace.Name = "lblWorkSpace";
            this.lblWorkSpace.Size = new System.Drawing.Size(47, 20);
            this.lblWorkSpace.TabIndex = 21;
            this.lblWorkSpace.Text = "شرکت";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.AutoSize = true;
            this.fromDatePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fromDatePicker.BackColor = System.Drawing.Color.White;
            this.fromDatePicker.GeorgianDate = null;
            this.fromDatePicker.Location = new System.Drawing.Point(29, 9);
            this.fromDatePicker.Margin = new System.Windows.Forms.Padding(0);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.PersianDate.Day = 0;
            this.fromDatePicker.PersianDate.Month = 0;
            this.fromDatePicker.PersianDate.Year = 0;
            this.fromDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromDatePicker.Size = new System.Drawing.Size(327, 31);
            this.fromDatePicker.TabIndex = 33;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(400, 16);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(76, 20);
            this.lblFrom.TabIndex = 32;
            this.lblFrom.Text = "تاریخ شروع";
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.Location = new System.Drawing.Point(406, 61);
            this.lblUntil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(71, 20);
            this.lblUntil.TabIndex = 31;
            this.lblUntil.Text = "تاریخ پایان";
            // 
            // untilDatePicker
            // 
            this.untilDatePicker.AutoSize = true;
            this.untilDatePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.untilDatePicker.BackColor = System.Drawing.Color.White;
            this.untilDatePicker.GeorgianDate = null;
            this.untilDatePicker.Location = new System.Drawing.Point(29, 57);
            this.untilDatePicker.Margin = new System.Windows.Forms.Padding(0);
            this.untilDatePicker.Name = "untilDatePicker";
            this.untilDatePicker.PersianDate.Day = 0;
            this.untilDatePicker.PersianDate.Month = 0;
            this.untilDatePicker.PersianDate.Year = 0;
            this.untilDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.untilDatePicker.Size = new System.Drawing.Size(327, 31);
            this.untilDatePicker.TabIndex = 30;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(29, 101);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(194, 35);
            this.btnReport.TabIndex = 34;
            this.btnReport.Text = "نمایش گزارش";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnReport);
            this.splitContainer1.Panel1.Controls.Add(this.untilDatePicker);
            this.splitContainer1.Panel1.Controls.Add(this.lblUntil);
            this.splitContainer1.Panel1.Controls.Add(this.txtStockRoom);
            this.splitContainer1.Panel1.Controls.Add(this.txtFiscalPeriod);
            this.splitContainer1.Panel1.Controls.Add(this.lblFrom);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkSpace);
            this.splitContainer1.Panel1.Controls.Add(this.fromDatePicker);
            this.splitContainer1.Panel1.Controls.Add(this.lblStockRoom);
            this.splitContainer1.Panel1.Controls.Add(this.btnStockRoom);
            this.splitContainer1.Panel1.Controls.Add(this.lblFiscalPeriod);
            this.splitContainer1.Panel1.Controls.Add(this.btnWorkSpace);
            this.splitContainer1.Panel1.Controls.Add(this.lblWorkSpace);
            this.splitContainer1.Panel1.Controls.Add(this.btnFiscalPeriod);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1130, 691);
            this.splitContainer1.SplitterDistance = 141;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 36;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabCtrl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.progressBar);
            this.splitContainer2.Panel2.Controls.Add(this.btnSend);
            this.splitContainer2.Size = new System.Drawing.Size(1130, 545);
            this.splitContainer2.SplitterDistance = 487;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1130, 13);
            this.progressBar.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 717);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabCtrl.ResumeLayout(false);
            this.tabPageFinalConsumer.ResumeLayout(false);
            this.tabPageFinalConsumer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinalConsumer)).EndInit();
            this.toolStripFinalConsumer.ResumeLayout(false);
            this.toolStripFinalConsumer.PerformLayout();
            this.tabPageTajer.ResumeLayout(false);
            this.tabPageTajer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTajer)).EndInit();
            this.toolStripTajer.ResumeLayout(false);
            this.toolStripTajer.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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