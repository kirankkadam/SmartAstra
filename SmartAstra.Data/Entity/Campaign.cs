using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAstra.Data.Entity
{
    public class Campaign: BaseEntityWithCreatedUpdatedInfo
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int RecepientListId { get; set; }

        [ForeignKey("FK_Campaign_Company")]
        public int CompanyId { get; set; }    
        protected Company CompanyDetails { get; set; }
    }
}
