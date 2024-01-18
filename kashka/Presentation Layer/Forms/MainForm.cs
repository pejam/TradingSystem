using kashka.Business_Logic_Layer.Models;
using kashka.Services;
using Microsoft.Data.SqlClient;
using System.Configuration;
using kashka.Enums;

namespace kashka.Presentation_Layer.Forms
{
    public partial class MainForm : Form
    {
        internal int userId;

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                    ConfigurationManager.ConnectionStrings["connection"].ConnectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connected to the database!");
                    // Perform database operations here
                    // ...
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
    }
}
