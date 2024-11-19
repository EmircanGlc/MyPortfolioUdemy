namespace MyPortfolioUdemy.DAL.Entities
{
    public class Certificate
    {
        public int CertificateId { get; set; }
        public string CertificateName { get; set; } //Sertifika adı
        public string Organisation { get; set; } //Alınan Kurum
        public DateTime ReceivedDate { get; set; } //sertifika tarihi
        

    }
}
