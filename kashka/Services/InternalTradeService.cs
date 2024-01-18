using kashka.Business_Logic_Layer.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using kashka.Enums;

namespace kashka.Services
{
    public class InternalTradeService
    {
        private readonly string serviceUrl;

        public InternalTradeService(string serviceUrl)
        {
            this.serviceUrl = serviceUrl;
        }

        public async Task<ApiResult> SubmitRetailAsync(SubmitRetailRequest request)
        {
            try
            {
                // Create the SOAP request
                string soapRequest = $@"
                                    <soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:int='http://internalTradeServices'>
                                        <soapenv:Header/>
                                        <soapenv:Body>
                                            <int:SubmitRetail>
                                                <!-- Include your input parameters here -->
                                                <int:username>{request.username}</int:username>
                                                <int:srvPass>{request.srvPass}</int:srvPass>
                                                <int:password_otpCode>{request.password_otpCode}</int:password_otpCode>
                                                <int:PersonNationalID>{request.PersonNationalID}</int:PersonNationalID>
                                                <int:UserRoleIDstr>{request.UserRoleIDstr}</int:UserRoleIDstr>
                                                <int:UserRoleExtraFields>
                                                    <int:PostalCode>{request.UserRoleExtraFields.PostalCode}</int:PostalCode>
                                                    <int:LicenseNumber>{request.UserRoleExtraFields.LicenseNumber}</int:LicenseNumber>
                                                    <int:ActivityType>{request.UserRoleExtraFields.ActivityType}</int:ActivityType>
                                                </int:UserRoleExtraFields>
                                                <int:DocumentDate>{request.DocumentDate.ToString("yyyy-MM-dd")}</int:DocumentDate>
                                                <int:Description>{request.Description}</int:Description>
                                                <int:BuyerDatiles>
                                                    <int:BuyerName>{request.BuyerDatiles.BuyerName}</int:BuyerName>
                                                    <int:BuyerNationalID>{request.BuyerDatiles.BuyerNationalID}</int:BuyerNationalID>
                                                    <int:BuyerMobile>{request.BuyerDatiles.BuyerMobile}</int:BuyerMobile>
                                                </int:BuyerDatiles>
                                                <int:PostalCode>{request.PostalCode}</int:PostalCode>
                                                <int:Stuffs_In>
                                                    <!-- Add elements for each item in the list -->
                                                    {string.Join("", request.Stuffs_In.Select(stuff => $@"
                                                        <int:Code>{stuff.Code}</int:Code>
                                                        <int:Count>{stuff.Count}</int:Count>
                                                        <int:Price>{stuff.Price}</int:Price>"))}
                                                </int:Stuffs_In>
                                                <int:DocNumber>{request.DocNumber}</int:DocNumber>
                                                <int:statusAppointment>{request.statusAppointment}</int:statusAppointment>
                                                <int:TraceCode>{request.TraceCode}</int:TraceCode>
                                            </int:SubmitRetail>
                                        </soapenv:Body>
                                    </soapenv:Envelope>";


                // Create the HTTP client
                using (HttpClient client = new HttpClient())
                {
                    // Set the content type and SOAPAction header
                    client.DefaultRequestHeaders.Add("Content-Type", "text/xml");
                    client.DefaultRequestHeaders.Add("SOAPAction", "http://internalTradeServices/SubmitRetail");

                    // Make the API call
                    HttpResponseMessage response = await client.PostAsync(serviceUrl, new StringContent(soapRequest, Encoding.UTF8, "text/xml"));

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string responseXml = await response.Content.ReadAsStringAsync();
                        ApiResult apiResult = DeserializeResponse(responseXml);

                        // Check ResultCode for errors
                        if (apiResult.ResultCode != (int)ResultCodeType.Success)
                        {
                            HandleApiError(apiResult.ResultCode, apiResult.ResultMessage);
                        }

                        return apiResult;
                    }
                    else
                    {
                        // Handle the error
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        HandleApiError((int)response.StatusCode, errorMessage);

                        // You can throw an exception or return an error message based on your requirements
                        throw new Exception("API request failed.");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP request exceptions
                Console.WriteLine($"HTTP request error: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        private ApiResult DeserializeResponse(string responseXml)
        {
            // Implement deserialization logic using XmlSerializer or other methods based on your response structure
            // Example using XmlSerializer:
            XmlSerializer serializer = new XmlSerializer(typeof(ApiResult));
            using (XmlReader reader = XmlReader.Create(new System.IO.StringReader(responseXml)))
            {
                return (ApiResult)serializer.Deserialize(reader);
            }
        }

        private void HandleApiError(int resultCode, string resultMessage)
        {
            // Add your custom error handling logic here
            Console.WriteLine($"API Error - Result Code: {resultCode}, Result Message: {resultMessage}");
        }
    }
}
