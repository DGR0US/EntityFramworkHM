using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramworkHM.Model
{
    public class orderid
    {
        [Key]
        public int id { get; set; }
        public int orderhid { get; set; }
        public int itemid { get; set; }
        [ForeignKey("itemid")]
        public product product { get; set; }
        [MaxLength(255)]
        public string item_desc { get; set; }
        public double price { get; set; }
        public double qty { get; set; }
        public double vat { get; set; }
        public double net_amount { get; set; }




    }
}
