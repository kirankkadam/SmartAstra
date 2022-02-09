namespace SmartAstra.Entities
{
    public class SMS : BaseEntity
    {
        public string RecepientAddress { get; set; }
        public string Content { get; set; }
        public int MessageId { get; set; }
        public int SendMessage()
        {
            throw new System.NotImplementedException();
        }
    }
}
