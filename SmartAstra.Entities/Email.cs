namespace SmartAstra.Entities
{
    public class Email : Message
    {
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public string TextBody { get; set; }
        public string HtmlBody { get; set; }
        public bool IsHtml { get; set; }
        public int MessageId { get; set; }

    }
}
