using kashka.Business_Logic_Layer.Models;
using kashka.Services;
using Microsoft.Data.SqlClient;
using System.Configuration;
using kashka.Enums;
using kashka.Data_Access_Layer.Repositories;
using System.Data;
using kashka.Business_Logic_Layer;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;

namespace kashka.Presentation_Layer.Forms
{
    public partial class MainForm : Form
    {
        private ICodepageConvertor _codepageService;
        private string _connectionString;

        private List<SubmitRetailReport> submitRetailReportList;
        private List<TransferOwnershipPlaceReport> transferOwnershipPlaceReportList;

        private readonly DataRepository dataRepository;


        public MainForm()
        {
            InitializeComponent();

            // Initialize the repository with your connection string
            /*dataRepository = new DataRepository(
                ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);*/

            _codepageService = new CodepageConvertor();
            InitializeVariables();
        }

        private void InitializeVariables()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.WorkSpaceName))
            {
                txtWorkSpace.Text = Properties.Settings.Default.WorkSpaceName;
                _connectionString = ReplaceDatabaseName(
                    ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString,
                    Properties.Settings.Default.WorkSpaceEnName);

                if (!string.IsNullOrEmpty(Properties.Settings.Default.FiscalPeriodName))
                {
                    txtFiscalPeriod.Text = Properties.Settings.Default.FiscalPeriodName;
                }

                if (!string.IsNullOrEmpty(Properties.Settings.Default.StockRoomName))
                {
                    txtStockRoom.Text = Properties.Settings.Default.StockRoomName;
                }
            }
        }

        private void btnWorkSpace_Click(object sender, EventArgs e)
        {
            WorkSpace workSpace = ShowListDialog<WorkSpace>(GetWorkSpaceData());
            if (workSpace != null && (
                    Properties.Settings.Default.WorkSpaceId != workSpace.Id &&
                        !Properties.Settings.Default.WorkSpaceName.Equals(workSpace.Name)
                ))
            {
                Properties.Settings.Default.WorkSpaceId = workSpace.Id;
                Properties.Settings.Default.WorkSpaceName = workSpace.Name;
                Properties.Settings.Default.WorkSpaceEnName =
                    GetFileNameWithExtension(workSpace.MdbPath);
                Properties.Settings.Default.Save();

                _connectionString = ReplaceDatabaseName(
                    ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString,
                    Properties.Settings.Default.WorkSpaceEnName);

                txtWorkSpace.Text = workSpace.Name;

                InitFiscalPeriod(null);
                InitStockRoom(null);
            }
        }

        private void btnFiscalPeriod_Click(object sender, EventArgs e)
        {
            FiscalPeriod fiscalPeriod = ShowListDialog<FiscalPeriod>(GetFiscalPeriodData());
            if (fiscalPeriod != null)
            {
                InitFiscalPeriod(fiscalPeriod);
                txtFiscalPeriod.Text = fiscalPeriod.Name;
            }
        }

        private void InitFiscalPeriod(FiscalPeriod fiscalPeriod)
        {
            if (fiscalPeriod != null)
            {
                Properties.Settings.Default.FiscalPeriodId = fiscalPeriod.Id;
                Properties.Settings.Default.FiscalPeriodName = fiscalPeriod.Name;
                txtFiscalPeriod.Text = fiscalPeriod.Name;
            }
            else
            {
                Properties.Settings.Default.FiscalPeriodId = 0;
                Properties.Settings.Default.FiscalPeriodName = null;
                txtFiscalPeriod.Text = null;
            }
            Properties.Settings.Default.Save();
        }

        private void btnStockRoom_Click(object sender, EventArgs e)
        {
            StockRoom stockRoom = ShowListDialog<StockRoom>(GetStockRoomData());
            if (stockRoom != null)
            {
                InitStockRoom(stockRoom);
                txtStockRoom.Text = stockRoom.Name;
            }
        }

        private void InitStockRoom(StockRoom stockRoom)
        {
            if (stockRoom != null)
            {
                Properties.Settings.Default.StockRoomId = stockRoom.Id;
                Properties.Settings.Default.StockRoomName = stockRoom.Name;
                txtStockRoom.Text = stockRoom.Name;
            }
            else
            {
                Properties.Settings.Default.StockRoomId = 0;
                Properties.Settings.Default.StockRoomName = null;
                txtStockRoom.Text = null;
            }
            Properties.Settings.Default.Save();
        }

        private T ShowListDialog<T>(List<T> itemList) where T : class
        {
            using (var listDialog = new List())
            {
                listDialog.SetItemList(itemList);

                DialogResult result = listDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return listDialog.SelectedListItem as T;
                }
            }

            return null;
        }

        static string GetFileNameWithExtension(string filePath)
        {
            // Get the filename without extension
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);

            // Get the extension
            string extension = Path.GetExtension(filePath);

            // Concatenate the filename and extension
            string fileNameWithExtension = fileNameWithoutExtension;

            return fileNameWithExtension;
        }

        static string ReplaceDatabaseName(string connectionString, string newDatabaseName)
        {

            int databaseIndex = connectionString.IndexOf("Database=");

            if (databaseIndex >= 0)
            {
                int endIndex = connectionString.IndexOf(';', databaseIndex);

                if (endIndex < 0)
                {
                    endIndex = connectionString.Length;
                }


                string oldDatabaseName = connectionString.Substring(databaseIndex + "Database=".Length, endIndex - (databaseIndex + "Database=".Length));

                return connectionString.Replace($"Database={oldDatabaseName}", $"Database={newDatabaseName}");
            }

            return connectionString;
        }

        private List<WorkSpace> GetWorkSpaceData()
        {
            // Retrieve the connection string from the app.config
            string connectionString = ConfigurationManager
                .ConnectionStrings["SysConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    List<WorkSpace> workspaces = new List<WorkSpace>();

                    string query = "SELECT * FROM [__Sys__].[dbo].[__WorkSpace__]";

                    using (SqlDataReader reader = new SqlCommand(query, connection).ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            WorkSpace workspace = new WorkSpace();

                            // Map each property from the reader to the WorkSpace class
                            workspace.Id = Convert.ToInt32(reader["Id"]);
                            workspace.Name = reader["Name"].ToString();
                            workspace.MdbPath = reader["MdbPath"].ToString();
                            workspace.MdbPath1 = reader["MdbPath1"].ToString();
                            workspace.MdbPath2 = reader["MdbPath2"].ToString();
                            workspace.MdbPath3 = reader["MdbPath3"].ToString();
                            workspace.MdbPath4 = reader["MdbPath4"].ToString();
                            workspace.WSType = Convert.ToInt32(reader["WSType"]);

                            workspaces.Add(
                                CodePageReflection<WorkSpace>.fromTadbir(_codepageService, workspace));
                        }
                    }

                    return workspaces;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private List<FiscalPeriod> GetFiscalPeriodData()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    List<FiscalPeriod> fiscalPeriods = new List<FiscalPeriod>();

                    string query = "SELECT * FROM __FiscalPeriod__ WHERE Id > 0";

                    using (SqlDataReader reader = new SqlCommand(query, connection).ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FiscalPeriod fiscalPeriod = new FiscalPeriod();

                            // Map each property from the reader to the WorkSpace class
                            fiscalPeriod.Id = Convert.ToInt32(reader["Id"]);
                            fiscalPeriod.FPNo = Convert.ToInt32(reader["FPNo"]);
                            fiscalPeriod.Name = reader["Name"].ToString();
                            fiscalPeriod.StartDate = (DateTime)reader["StartDate"];
                            fiscalPeriod.EndDate = (DateTime)reader["EndDate"];
                            fiscalPeriod.FPDesc = reader["FPDesc"].ToString();
                            fiscalPeriod.SType = Convert.ToInt32(reader["SType"]);
                            /*fiscalPeriod.LRes = Convert.ToInt32(reader["LRes"]);
                            fiscalPeriod.DRes = Convert.ToDouble(reader["DRes"]);
                            fiscalPeriod.TRes = reader["TRes"].ToString();*/

                            fiscalPeriods.Add(
                                CodePageReflection<FiscalPeriod>.fromTadbir(_codepageService, fiscalPeriod));
                        }
                    }

                    return fiscalPeriods;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private List<StockRoom> GetStockRoomData()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    List<StockRoom> stockRooms = new List<StockRoom>();

                    string query = $"SELECT * FROM __StockRoom__ WHERE Id > 0 AND " +
                                   $"FPId = {Properties.Settings.Default.FiscalPeriodId}";

                    using (SqlDataReader reader = new SqlCommand(query, connection).ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StockRoom stockRoom = new StockRoom();

                            stockRoom.Id = Convert.ToInt32(reader["Id"]);
                            stockRoom.Code = Convert.ToInt32(reader["Code"]);
                            stockRoom.Name = reader["Name"].ToString();
                            stockRoom.ManagerName = reader["ManagerName"].ToString();
                            stockRoom.SRDesc = reader["SRDesc"].ToString();
                            /*stockRoom.LRes = Convert.ToInt32(reader["LRes"]);
                            stockRoom.DRes = Convert.ToDouble(reader["DRes"]);
                            stockRoom.TRes = reader["TRes"].ToString();*/
                            stockRoom.AccountId = reader["AccountId"].ToString();
                            stockRoom.FPId = Convert.ToInt32(reader["FPId"]);
                            stockRoom.FAccId = Convert.ToInt32(reader["FAccId"]);
                            stockRoom.CCId = Convert.ToInt32(reader["CCId"]);
                            stockRoom.PrjId = Convert.ToInt32(reader["PrjId"]);

                            stockRooms.Add(
                                CodePageReflection<StockRoom>.fromTadbir(_codepageService, stockRoom));
                        }
                    }

                    return stockRooms;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateParameters();
            if (errorMessage.IsNullOrEmpty())
            {
                string fromDateGeorgian;
                string untilDateGeorgian;

                if (fromDatePicker.PersianDate.Year < 2000)
                {
                    PersianCalendar p = new PersianCalendar();
                    DateTime x = p.ToDateTime(
                        fromDatePicker.PersianDate.Year,
                        fromDatePicker.PersianDate.Month,
                        fromDatePicker.PersianDate.Day,
                        0, 0, 0, 0);

                    fromDateGeorgian = $"{x.Year:D4}-{x.Month:D2}-{x.Day:D2}";
                }
                else
                {
                    fromDateGeorgian = fromDatePicker.GeorgianDate.ToString();
                }

                if (untilDatePicker.PersianDate.Year < 2000)
                {
                    PersianCalendar p = new PersianCalendar();
                    DateTime x = p.ToDateTime(
                        untilDatePicker.PersianDate.Year,
                        untilDatePicker.PersianDate.Month,
                        untilDatePicker.PersianDate.Day,
                        0, 0, 0, 0);

                    untilDateGeorgian = $"{x.Year:D4}-{x.Month:D2}-{x.Day:D2}";
                }
                else
                {
                    untilDateGeorgian = untilDatePicker.GeorgianDate.ToString();
                }


                if (tabCtrl.SelectedIndex == 0)
                {
                    BindTajerReportData(
                        Properties.Settings.Default.FiscalPeriodId,
                        fromDateGeorgian, untilDateGeorgian,
                        Properties.Settings.Default.StockRoomId
                    );
                }
                else if (tabCtrl.SelectedIndex == 1)
                {
                    BindFinalConsumerReportData(
                        Properties.Settings.Default.FiscalPeriodId,
                        fromDateGeorgian, untilDateGeorgian,
                        Properties.Settings.Default.StockRoomId
                    );
                }
            }
            else
            {
                MessageBox.Show("خطای اعتبار سنجی:\n" + errorMessage, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateParameters()
        {
            List<string> errors = new List<string>();

            if (Properties.Settings.Default.WorkSpaceId == 0)
            {
                errors.Add("لطفا شرکت را انتخاب کنید");
            }

            if (Properties.Settings.Default.FiscalPeriodId == 0)
            {
                errors.Add("لطفا دوره مالی را نتخاب کنید");
            }

            if (Properties.Settings.Default.StockRoomId == 0)
            {
                errors.Add("لطفا انبار را نتخاب کنید");
            }

            if (fromDatePicker.GeorgianDate == null)
            {
                errors.Add("لطفا تاریخ شروع را وارد کنید.");
            }

            if (untilDatePicker.GeorgianDate == null)
            {
                errors.Add("لطفا تاریخ پایان را وارد کنید.");
            }


            string errorMessage = string.Join("\n", errors);

            return errorMessage;
        }














        private void BindFinalConsumerReportData(
            int pFPID, string pSTARTDATE, string pENDDATE, int pSTOCKID
            )
        {
            submitRetailReportList = GetFinalConsumerReportData(
                pFPID, pSTARTDATE, pENDDATE, pSTOCKID
            );
            dataGridViewFinalConsumer.DataSource = submitRetailReportList;
            PrepareFinalConsumerGrid();
        }

        public List<SubmitRetailReport> GetFinalConsumerReportData(
            int pFPID, string pSTARTDATE, string pENDDATE, int pSTOCKID
            )
        {
            submitRetailReportList = new List<SubmitRetailReport>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UD_REPORTSPFATORSERIALS", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.AddWithValue("@pFPID", pFPID);
                    command.Parameters.AddWithValue("@pSTARTDATE", pSTARTDATE);
                    command.Parameters.AddWithValue("@pENDDATE", pENDDATE);
                    command.Parameters.AddWithValue("@pSTOCKID", pSTOCKID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SubmitRetailReport reportData = new SubmitRetailReport
                            {
                                DocumentDate = reader["تاريخ سند"].ToString(),
                                InvoiceNumber = reader["شماره صورتحساب"].ToString(),
                                BuyerNationalId = reader["کد/شناسه ملي خريدار"].ToString(),
                                BuyerName = reader["نام خريدار"].ToString(),
                                MobileNumber = reader["تلفن همراه"].ToString(),
                                SourceWarehousePostalCode = reader["کد پستي انبار مبدا"].ToString(),
                                DocumentDescription = reader["شرح سند"].ToString(),
                                ItemId = reader["شناسه کالا"].ToString(),
                                TrackingId = reader["شناسه رهگيري"].ToString(),
                                UnitPrice = Convert.ToDecimal(reader["مبلغ واحد"])
                            };

                            submitRetailReportList.Add(CodePageReflection<SubmitRetailReport>.fromTadbir(_codepageService, reportData));
                        }
                    }
                }
            }

            return submitRetailReportList;
        }

        private void BindTajerReportData(
            int pFPID, string pSTARTDATE, string pENDDATE, int pSTOCKID
                )
        {
            transferOwnershipPlaceReportList = GetTajerReportData(
                pFPID, pSTARTDATE, pENDDATE, pSTOCKID
            );
            dataGridViewTajer.DataSource = transferOwnershipPlaceReportList;
            PrepareTajerGrid();
        }

        public List<TransferOwnershipPlaceReport> GetTajerReportData(
            int pFPID, string pSTARTDATE, string pENDDATE, int pStockId
            )
        {
            transferOwnershipPlaceReportList = new List<TransferOwnershipPlaceReport>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UD_REPORTSPFATOR", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.AddWithValue("@pFPID", pFPID);
                    command.Parameters.AddWithValue("@pSTARTDATE", pSTARTDATE);
                    command.Parameters.AddWithValue("@pENDDATE", pENDDATE);
                    command.Parameters.AddWithValue("@pStockId", pStockId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TransferOwnershipPlaceReport reportData = new TransferOwnershipPlaceReport();

                            // Map columns to properties of YourReportDataClass
                            reportData.DocumentDate = reader["تاريخ سند"].ToString();
                            reportData.InvoiceNumber = reader["شماره صورتحساب"].ToString();
                            reportData.BuyerNationalId = reader["کد/شناسه ملي خريدار"].ToString();
                            reportData.BuyerBusinessRoleCode = reader["کد نقش تجاري خريدار"].ToString();
                            reportData.BuyerName = reader["نام خريدار"].ToString();
                            reportData.MobileNumber = reader["تلفن همراه"].ToString();
                            reportData.SourceWarehousePostalCode = reader["کد پستي انبار مبدا"].ToString();
                            reportData.DestinationWarehousePostalCode = reader["کد پستي انبار مقصد"].ToString();
                            reportData.StockExchangeContractNumber = reader["شماره قرارداد بورس"].ToString();
                            reportData.TransportStatus = reader["وضعيت حمل"].ToString();
                            reportData.WaybillNumber = reader["شماره بارنامه"].ToString();
                            reportData.WaybillDate = reader["تاريخ بارنامه"].ToString();
                            reportData.WaybillSerial = reader["سريال بارنامه"].ToString();
                            reportData.DocumentDescription = reader["شرح سند"].ToString();
                            reportData.ItemId = reader["شناسه کالا"].ToString();
                            reportData.Quantity = Convert.ToDecimal(reader["تعداد / مقدار"]);
                            reportData.UnitPrice = Convert.ToDecimal(reader["مبلغ واحد"]);
                            reportData.DiscountAmount = Convert.ToDecimal(reader["مبلغ تخفيف"]);
                            reportData.TaxAndDutyAmount = Convert.ToDecimal(reader["مبلغ ماليات و عوارض"]);

                            transferOwnershipPlaceReportList.Add(CodePageReflection<TransferOwnershipPlaceReport>.fromTadbir(_codepageService, reportData));
                        }
                    }
                }
            }

            return transferOwnershipPlaceReportList;
        }

        public void PrepareTajerGrid()
        {
            dataGridViewTajer.Columns["CheckBox"].Visible = true;
            dataGridViewTajer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewTajer.AllowUserToResizeColumns = true;
            dataGridViewTajer.ColumnHeadersHeight = 40; // Increase or decrease the value to adjust the height
            dataGridViewTajer.RowTemplate.Height = 35;
            dataGridViewTajer.AllowUserToResizeRows = true;
            dataGridViewTajer.AllowUserToAddRows = false;
            dataGridViewTajer.DefaultCellStyle.Font = new Font("Arial", 9);

            foreach (KeyValuePair<string, GridRowModel> HGI in Dics.TajerGridInfo)
            {
                if (dataGridViewTajer.Columns[HGI.Key] == null) continue;
                dataGridViewTajer.Columns[HGI.Key].HeaderText = HGI.Value.Title;
                dataGridViewTajer.Columns[HGI.Key].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridViewTajer.Columns[HGI.Key].Visible = (!HGI.Value.IsDetail || Properties.Settings.Default.ShowDetails);
            }
        }

        public void PrepareFinalConsumerGrid()
        {
            dataGridViewFinalConsumer.Columns["CheckBoxFinalConsumer"].Visible = true;
            dataGridViewFinalConsumer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewFinalConsumer.AllowUserToResizeColumns = true;
            dataGridViewFinalConsumer.ColumnHeadersHeight = 40; // Increase or decrease the value to adjust the height
            dataGridViewFinalConsumer.RowTemplate.Height = 35;
            dataGridViewFinalConsumer.AllowUserToResizeRows = true;
            dataGridViewFinalConsumer.AllowUserToAddRows = false;
            dataGridViewFinalConsumer.DefaultCellStyle.Font = new Font("Arial", 9);

            foreach (KeyValuePair<string, GridRowModel> HGI in Dics.TajerGridInfo)
            {
                if (dataGridViewFinalConsumer.Columns[HGI.Key] == null) continue;
                dataGridViewFinalConsumer.Columns[HGI.Key].HeaderText = HGI.Value.Title;
                dataGridViewFinalConsumer.Columns[HGI.Key].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridViewFinalConsumer.Columns[HGI.Key].Visible = (!HGI.Value.IsDetail || Properties.Settings.Default.ShowDetails);
            }
        }

        private async void CallSubmitRetailService()
        {
            try
            {
                // Set your service URL
                string serviceUrl = "https://pub-cix.ntsw.ir/services/InternalTradeServices?wsdl";

                // Create an instance of the InternalTradeService
                InternalTradeService tradeService = new InternalTradeService(serviceUrl);

                // Populate the request variable with the required data
                var request = new SubmitRetailRequest
                {
                    username = "your_username",
                    srvPass = "your_srvPass",
                    password_otpCode = "your_password_otpCode",
                    PersonNationalID = "seller_national_id",
                    UserRoleIDstr = "seller_role_id",
                    UserRoleExtraFields = new UserRoleExtraFields
                    {
                        PostalCode = 1234567890,
                        LicenseNumber = 1234567890,
                        ActivityType = (int)ActivityType.Wholesaler // Use the appropriate activity type from the enum
                    },
                    DocumentDate = DateTime.Now, // Replace with the actual document date
                    Description = "your_description",
                    BuyerDatiles = new BuyerDatiles
                    {
                        BuyerName = "buyer_name",
                        BuyerNationalID = "buyer_national_id",
                        BuyerMobile = "buyer_mobile"
                    },
                    PostalCode = "seller_postal_code",
                    Stuffs_In = new List<StuffIn>
                    {
                        new StuffIn { Code = "item_code_1", Count = 10, Price = 100 },
                        new StuffIn { Code = "item_code_2", Count = 5, Price = 50 }
                        // Add more items as needed
                    },
                    DocNumber = "your_document_number",
                    statusAppointment = 0, // or 7, based on your requirement
                    TraceCode = "your_trace_code"
                };

                // Call the SubmitRetail method
                ApiResult<SubmitRetailResult> result = await tradeService.SubmitRetailAsync(request);

                // Check the result
                if (result.ResultCode == 0)
                {
                    // Handle successful result
                    MessageBox.Show("SubmitRetail method called successfully!");
                }
                else
                {
                    // Handle API error
                    MessageBox.Show($"API Error - Result Code: {result.ResultCode}, Result Message: {result.ResultMessage}");
                }
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP request exceptions
                MessageBox.Show($"HTTP request error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void tabPageTajer_Enter(object sender, EventArgs e)
        {
            //BindTajerReportData();
        }

        private void tabPageFinalConsumer_Enter(object sender, EventArgs e)
        {
            //BindFinalConsumerReportData();
        }



        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFiscalPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
