//using Newtonsoft.Json.Linq;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.NetworkInformation;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Timer = System.Windows.Forms.Timer;
//using System.Windows.Forms;
//using System.CodeDom.Compiler;

//namespace Tax.Timers
//{
//    static internal class ReqStatusTimer
//    {
//        public static void SetUp(DataGridView dataGridViewHeaders,ToolStripLabel toolStripLabelLastFactorNo, List<ReqStatusModel>? reqStatuses, int errorCount, int milisecond)
//        {
//            _dataGridView = dataGridViewHeaders;
//            _toolStripLabelLastFactorNo = toolStripLabelLastFactorNo;
//            _errorCount = errorCount;
//            if (reqStatuses != null) _reqStatuses = reqStatuses;
//            _timer.Interval = milisecond; // 1000 milisecond = 1 seconds
//            _timer.Tick += Inquery;

//            RunTimeDataModel.TaxPayerResultMessages = SqliteDataAccess.LoadData<TaxPayerResultMessageModel>();
//        }

//        private static void Inquery(object sender, EventArgs e)
//        {
//            try
//            {
//                if (RunTimeDataModel.TaxPayerHeaders == null) return;

//                foreach (TaxPayerHeaderModel taxPayerheaderItem in RunTimeDataModel.TaxPayerHeaders.Where(h => h.ReqStatus.Contains("صف")))
//                {

//                    var uidAndFiscalId = new UidAndFiscalId(taxPayerheaderItem.UId, RunTimeDataModel.MemoryId);
//                    List<InquiryResultModel>? inquiryResultModels;

//                    inquiryResultModels =
//                        TaxApiService.Instance.TaxApis.InquiryByUidAndFiscalId(new() { uidAndFiscalId });


//                    if (inquiryResultModels != null)
//                    {
//                        InquiryResultModel inquiryResult = inquiryResultModels[0];

//                        if (inquiryResult != null)
//                        {
//                            if (inquiryResult.Data != null)
//                            {
//                                JObject jsons = JObject.Parse(inquiryResult.Data.ToString());

//                                List<TaxPayerResultMessageModel> taxPayerErrors =
//                                    jsons["error"].ToObject<List<TaxPayerResultMessageModel>>();
//                                taxPayerErrors.ToList().ForEach(c => c.Type = 1);
//                                taxPayerErrors.ToList().ForEach(c => c.SPFId = taxPayerheaderItem.SPFId);

//                                List<TaxPayerResultMessageModel> taxPayerWarnings =
//                                    jsons["warning"].ToObject<List<TaxPayerResultMessageModel>>();
//                                taxPayerWarnings.ToList().ForEach(c => c.Type = 2);
//                                taxPayerWarnings.ToList().ForEach(c => c.SPFId = taxPayerheaderItem.SPFId);
//                                _errorCount += taxPayerErrors.Count;

//                                RunTimeDataModel.TaxPayerResultMessages.RemoveAll(m => m.SPFId == taxPayerheaderItem.SPFId);

//                                RunTimeDataModel.TaxPayerResultMessages.AddRange(taxPayerWarnings);
//                                RunTimeDataModel.TaxPayerResultMessages.AddRange(taxPayerErrors);

//                                SqliteDataAccess.SaveList(RunTimeDataModel.TaxPayerResultMessages);
//                            }

//                            if (_errorCount == 0 && inquiryResult.Status.ToLower().Contains("success"))
//                            {
//                                RunTimeDataModel.TaxPayerHeaders.ForEach(h =>
//                                {
//                                    if (h.SPFId == taxPayerheaderItem.SPFId) h.ReqStatus = "ارسال شد";

//                                    if(_toolStripLabelLastFactorNo != null)
//                                        _toolStripLabelLastFactorNo.Text = h.SPFId.ToString() ?? "";
//                                });
//                            }
//                            else if (_errorCount > 0 && inquiryResult.Status.ToLower().Contains("failed"))
//                            {
//                                RunTimeDataModel.TaxPayerHeaders.ForEach(h =>
//                                {
//                                    if (h.SPFId == taxPayerheaderItem.SPFId) h.ReqStatus = "خطا در ارسال";
//                                });
//                            }
//                        }

//                    }

//                    _errorCount = 0;

//                    SqliteDataAccess.SaveList(RunTimeDataModel.TaxPayerHeaders);

//                    _dataGridView.DataSource = "";
//                    _dataGridView.DataSource = RunTimeDataModel.TaxPayerHeaders;
//                    PrepareHeaderGrid();
//                    //_dataGridView.Refresh();
//                }

//            }
//            catch
//            {
//                // Ignore exceptions, just return false
//            }

//        }

//        public static void PrepareHeaderGrid()
//        {
//            _dataGridView.Columns["CheckBox"].Visible = true;
//            _dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
//            _dataGridView.ColumnHeadersHeight = 30; // Increase or decrease the value to adjust the height
//            _dataGridView.RowTemplate.Height = 35;
//            _dataGridView.AllowUserToResizeRows = false;
//            _dataGridView.AllowUserToAddRows = false;
//            _dataGridView.DefaultCellStyle.Font = new Font("Arial", 9);

//            foreach (KeyValuePair<string, GridRowModel> HGI in Dics.HeaderGridInfo)
//            {
//                if (_dataGridView.Columns[HGI.Key] == null) continue;
//                _dataGridView.Columns[HGI.Key].HeaderText = HGI.Value.Title;
//                _dataGridView.Columns[HGI.Key].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
//                _dataGridView.Columns[HGI.Key].Visible = (!HGI.Value.Isdetail || RunTimeDataModel.ShowDetails);
//            }
//        }

//        public static void start()
//        {
//            _timer.Start();
//        }
//        private static readonly Timer _timer = new Timer();
//        private static List<ReqStatusModel>? _reqStatuses;
//        private static DataGridView _dataGridView;
//        private static ToolStripLabel _toolStripLabelLastFactorNo;
//        private static int _errorCount;
//    }
//}
