using kashka.Business_Logic_Layer.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using kashka.Enums;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using kashka.Utilities;

namespace kashka.Services
{
    public class InternalTradeService
    {
        private readonly string serviceUrl;

        public InternalTradeService(string serviceUrl)
        {
            this.serviceUrl = serviceUrl;
        }

        public async Task<ApiResult<SubmitRetailResult>> SubmitRetailAsync(SubmitRetailRequest request)
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
                        ApiResult<SubmitRetailResult> apiResult = DeserializeResponse<SubmitRetailResult>(responseXml);

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

        public async Task<ApiResult<TransferOwnershipPlaceResult>> CallTransferOwnershipPlaceServiceAsync(
            TransferOwnershipPlaceRequest request)
        {

            /*client.ClientCredentials.UserName.UserName = "6- L< eL";
            client.ClientCredentials.UserName.Password = ",J1gj1f";

            GetLegalPersonInfoDB.ServiceReferenceLegal.Result result;

            using (OpcrationContextscope scope = ncw OperationContextscope(client.Innerchannel))
            {

                var httpRequestProperty = new HttpRequestMessageProperty();
                httpRequestProperty.Headers[System.Net.HttpRequestHeader.Authorization] = "Basic " +
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(client.ClientCredentials.UserName.UserName + ":" +
                                                                   client.ClientCredentials.UserName.Password));

                OperationContext.Current.OutgoingNessageProperties[HttpRequestMessageProperty.Name] =
                    httpRequestProperty;
                result = client.InquiryByNationalcode(p);
            }*/


            /*try
            {
                // Create the SOAP request
                string soapRequest = $@"
                    <soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' 
                                      xmlns:int='http://internalTradeServices'>
                        <soapenv:Header/>
                        <soapenv:Body>
                            <int:TransferOwnershipPlace_SI>
                                <int:Username>{request.Username}</int:Username>
                                <int:srvPass>{request.SrvPass}</int:srvPass>
                                <int:password_otpCode>{request.PasswordOtpCode}</int:password_otpCode>
                                <int:PersonNationalCode>{request.PersonNationalCode}</int:PersonNationalCode>                                
                                <int:UserRoleIDstr>{request.UserRoleIDstr}</int:UserRoleIDstr>
                                <int:userSellType>{request.UserSellType}</int:userSellType>
                                <int:documentDate>{request.DocumentDate:yyyy-MM-dd}</int:documentDate>
                                <int:fromPostalCode>{request.FromPostalCode}</int:fromPostalCode>
                                <int:OwnershipTransfer>
                                    <!-- Include elements for OwnershipTransfer object -->
                                    <int:buyerNationalID>{request.OwnershipTransfer.BuyerNationalID}</int:buyerNationalID>
                                    <int:buyerUserRoleIDStr>{request.OwnershipTransfer.BuyerUserRoleIDStr}</int:buyerUserRoleIDStr>
                                    <int:buyerName>{request.OwnershipTransfer.BuyerName}</int:buyerName>
                                    <int:buyerMobile>{request.OwnershipTransfer.BuyerMobile}</int:buyerMobile>
                                </int:OwnershipTransfer>
                                <int:PlaceTransfer>
                                    <!-- Include elements for PlaceTransfer object -->
                                    <int:ToPostalCode>{request.PlaceTransfer.ToPostalCode}</int:ToPostalCode>
                                    <int:wayBillHas>{request.PlaceTransfer.WayBillHas}</int:wayBillHas>
                                    <int:wayBillNumber>{request.PlaceTransfer.WayBillNumber}</int:wayBillNumber>
                                    <int:wayBillSerial>{request.PlaceTransfer.WayBillSerial}</int:wayBillSerial>
                                    <int:wayBillDate>{request.PlaceTransfer.WayBillDate.ToString("yyyy-MM-dd")}</int:wayBillDate>
                                </int:PlaceTransfer>
                                <int:Seller_UserRoleExtraFields>
                                    <!-- Include elements for Seller_UserRoleExtraFields object -->
                                    <int:PostalCode>{request.Seller_UserRoleExtraFields.PostalCode}</int:PostalCode>
                                    <int:LicenseNumber>{request.Seller_UserRoleExtraFields.LicenseNumber}</int:LicenseNumber>
                                    <int:ActivityType>{request.Seller_UserRoleExtraFields.ActivityType}</int:ActivityType>
                                </int:Seller_UserRoleExtraFields>
                                <int:Buyer_UserRoleExtraFields>
                                    <!-- Include elements for Buyer_UserRoleExtraFields object -->
                                    <int:PostalCode>{request.Buyer_UserRoleExtraFields.PostalCode}</int:PostalCode>
                                    <int:LicenseNumber>{request.Buyer_UserRoleExtraFields.LicenseNumber}</int:LicenseNumber>
                                    <int:ActivityType>{request.Buyer_UserRoleExtraFields.ActivityType}</int:ActivityType>
                                </int:Buyer_UserRoleExtraFields>
                                <int:Stuffs_In>
                                    <!-- Add elements for each item in the list -->
                                    {string.Join("", request.Stuffs_In.Select(stuff => $@"
                                        <int:Code>{stuff.Code}</int:Code>
                                        <int:Count>{stuff.Count}</int:Count>
                                        <int:Price>{stuff.Price}</int:Price>
                                        <int:Discount>{stuff.Discount}</int:Discount>
                                        <int:VAT>{stuff.VAT}</int:VAT>"))}
                                </int:Stuffs_In>
                                <int:DocumentDescription>{request.DocumentDescription}</int:DocumentDescription>
                                <int:statusAppointment>{request.StatusAppointment}</int:statusAppointment>
                                <int:DocNumber>{request.DocNumber}</int:DocNumber>
                                <int:RelatedDocNumber>{request.RelatedDocNumber}</int:RelatedDocNumber>
                                <int:StockExchangeCode>{request.StockExchangeCode}</int:StockExchangeCode>
                            </int:TransferOwnershipPlace_SI>
                        </soapenv:Body>
                    </soapenv:Envelope>";

                //Create the HTTP client
                using (HttpClient client = new HttpClient())
                {
                    // Set the content type and SOAPAction header
                    /*client.DefaultRequestHeaders.Add("Content-Type", "text/xml");
                    client.DefaultRequestHeaders.Add("SOAPAction",
                        "http://internalTradeServices/TransferOwnershipPlace_SI");#1#

                    // Add Authentication 
                    string username = "internalservice";
                    string password = "ESBesb12?";

                    // Convert the credentials to Base64
                    string base64Credentials = Convert.ToBase64String(
                        Encoding.ASCII.GetBytes($"{username}:{password}"));

                    // Set the Authorization header
                    client.DefaultRequestHeaders.Authorization = 
                        new AuthenticationHeaderValue("Basic", base64Credentials);


                    // Make the API call
                    HttpResponseMessage response = await client.PostAsync(serviceUrl, 
                        new StringContent(soapRequest, Encoding.UTF8, "text/xml"));

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and deserialize the response content
                        string responseXml = await response.Content.ReadAsStringAsync();
                        ApiResult<TransferOwnershipPlaceResult> apiResult = 
                            DeserializeResponse<TransferOwnershipPlaceResult>(responseXml);

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
            }*/


            return null;
        }

        private ApiResult<T> DeserializeResponse<T>(string responseXml)
        {
            // Implement deserialization logic using XmlSerializer or other methods based on your response structure
            // Example using XmlSerializer:
            XmlSerializer serializer = new XmlSerializer(typeof(ApiResult<T>));
            using (XmlReader reader = XmlReader.Create(new System.IO.StringReader(responseXml)))
            {
                return (ApiResult<T>)serializer.Deserialize(reader);
            }
        }

        private void HandleApiError(int resultCode, string resultMessage)
        {
            // Add your custom error handling logic here
            Console.WriteLine($"API Error - Result Code: {resultCode}, Result Message: {resultMessage}");
            MessageBox.Show($"API Error - Result Code: {resultCode}, Result Message: {resultMessage}");
        }

    }
}
