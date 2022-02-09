namespace SmartAstra.Framework.Common
{
    public enum MessageType
    {
        Email = 1,
        Facebook = 2,
        WhatsApp = 3,
        SMS = 4
    }

    public enum DeliveryStatus
    {
        InQueue = 1,
        Delivered = 2,
        NotDelivered = 3,
    }

    public enum Status
    {
        Active = 1,
        Disabled = 2,
        Deleted = 3,
        Completed = 4
    }

    public enum Recurrence
    {
        None = 0,
        Daily = 1,
        Weekly = 2,
        Monthly = 3,
        Annualy = 4
    }

    public enum ResponseStatus
    {
        None = 0,
        Success = 1,
        Processing = 2,
        Failed = 3,
        Duplicate = 4
    }
}
