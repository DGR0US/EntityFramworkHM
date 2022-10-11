namespace EntityFramworkHM.Model
{
    public class initData
    {
        public static void GenData(CustomerContext db)
        {
            db.Database.EnsureCreated();
                if (db.Customer.Any())
            {
                //return
            }
        }
    }
}
