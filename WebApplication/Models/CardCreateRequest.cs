using System;

namespace WebApplication.Models
{
    public class CardCreateRequest
    {
        public string DocKind { get; set; }
        public string DocNumber { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? MainAccount { get; set; }
        public int? CorrespondentAccount { get; set; }
        public string PartnerCode { get; set; }
        public int? OrderNumber { get; set; }
        public string ExtraInfo { get; set; }
        public int? Warehouse { get; set; }
        public string ShortContent { get; set; }
        public string ProvidingNumber { get; set; }
        public DateTime? LoadDate { get; set; }
        public FileData Attachment { get; set; }
    }
}