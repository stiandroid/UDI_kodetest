using UDI_kodetest.Shared.Models.Enums;

namespace UDI_kodetest.Shared.Models.Entities
{
    public class Vedtak
    {
        public Guid Id { get; set; }
        public string Authority { get; set; } = string.Empty;
        public VedtakStatusEnum Status { get; set; } = VedtakStatusEnum.Ubehandlet;
        public DateTime GyldigFra { get; set; }
        public DateTime GyldigTil { get; set; }
    }
}
