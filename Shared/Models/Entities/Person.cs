namespace UDI_kodetest.Shared.Models.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Epost { get; set; } = string.Empty;
        public string Fornavn { get; set; } = string.Empty;
        public string Mellomnavn { get; set; } = string.Empty;
        public string Etternavn { get; set; } = string.Empty;
        public string Mobilnummer { get; set; } = string.Empty;
        public string Personnummer { get; set; } = string.Empty;
        public string Reisedokumentnummer { get; set; } = string.Empty;
        public DateTime Fodselsdato { get; set; }
        public string Adresse { get; set; } = string.Empty;
        public string Poststed { get; set; } = string.Empty;
        public string Postnummer { get; set; } = string.Empty;
        public string Land { get; set; } = string.Empty;
    }
}