namespace UDI_kodetest.Shared.Models.Entities
{
    public class Soknad
    {
        public Guid Id { get; set; }
        public string RefNo { get; set; } = string.Empty;
        public string RecNo { get; set; } = string.Empty;
        public string Sakid { get; } = string.Empty;
        public bool SendtSms { get; set; }
        public Guid KontaktId { get; set; }
        public Person? Kontakt { get; set; }
        public string Fullmektig { get; set; } = string.Empty;
        public Guid SokerId { get; set; }
        public Person? Soker { get; set; }
        public Guid VedtakId { get; set; }
        public Vedtak? Vedtak { get; set; }
        public string _rid { get; set; } = string.Empty;
        public string _self { get; set; } = string.Empty;
        public string _etag { get; set; } = string.Empty;
        public string _attachments { get; set; } = string.Empty;
        public string _ts { get; set; } // Unix timestamp
    }
}
