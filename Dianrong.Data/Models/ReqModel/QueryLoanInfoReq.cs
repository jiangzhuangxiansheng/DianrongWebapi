using Newtonsoft.Json;

namespace Dianrong.Data.Models.ReqModel
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryLoanInfoReq:DianrongBaseReqModel
    {
        /// <summary>
        /// 贷款申请id
        /// </summary>
        /// <returns></returns>
        [JsonProperty("loanAppId")]
        public string LoanAppId { get; set; }

    }
}