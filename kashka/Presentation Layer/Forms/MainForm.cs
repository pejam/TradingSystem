using kashka.Business_Logic_Layer.Models;
using kashka.Services;
using Microsoft.Data.SqlClient;
using System.Configuration;
using kashka.Enums;
using kashka.Data_Access_Layer.Repositories;
using System.Windows.Forms;
using System.Data;

namespace kashka.Presentation_Layer.Forms
{
    public partial class MainForm : Form
    {
        private ICodepageConvertor _codepageService;
        private List<SubmitRetailReport> submitRetailReportList;
        private List<TransferOwnershipPlaceReport> transferOwnershipPlaceReportList;

        private readonly DataRepository dataRepository;


        public MainForm()
        {
            InitializeComponent();

            // Initialize the repository with your connection string
            dataRepository = new DataRepository(
                ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);

            _codepageService = new CodepageConvertor();

            LoadControls();
        }

        private void LoadControls()
        {
            cmbCompany.SelectedValue = Properties.Settings.Default.SelectedCompany;
            cmbFiscalPeriod.SelectedValue = Properties.Settings.Default.SelectedFiscalPeriod;
            cmbStock.SelectedValue = Properties.Settings.Default.SlecetedStock;
        }

        private void BindFinalConsumerReportData()
        {
            submitRetailReportList = GetFinalConsumerReportData(
                5, "2022-02-02", "2024-02-02", 5
            );
            dataGridViewTajer.DataSource = submitRetailReportList;
            PrepareFinalConsumerGrid();
        }

        public List<SubmitRetailReport> GetFinalConsumerReportData(
            int pFPID, string pSTARTDATE, string pENDDATE, int pSTOCKID
            )
        {
            submitRetailReportList = new List<SubmitRetailReport>();
            string connectionString = ConfigurationManager
                .ConnectionStrings["DBConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
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

        private void BindTajerReportData()
        {
            transferOwnershipPlaceReportList = GetTajerReportData(
                5, "2022-02-02", "2024-02-02", 5
            );
            dataGridViewTajer.DataSource = transferOwnershipPlaceReportList;
            PrepareTajerGrid();
        }

        public List<TransferOwnershipPlaceReport> GetTajerReportData(
            int pFPID, string pSTARTDATE, string pENDDATE, int pStockId
            )
        {
            transferOwnershipPlaceReportList = new List<TransferOwnershipPlaceReport>();

            string connectionString = ConfigurationManager
                .ConnectionStrings["DBConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
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
            BindTajerReportData();
        }

        private void tabPageFinalConsumer_Enter(object sender, EventArgs e)
        {
            BindFinalConsumerReportData();
        }



        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFiscalPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
