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

            customer cus1 = new customer();
            cus1.name1 = "Patcharaphon";
            cus1.name2 = "Boss";
            cus1.sex = "M";
            cus1.age = 18;
            db.Customer.Add(cus1);
            db.SaveChanges();

            customer cus2 = new customer();
            cus2.name1 = "Pongsakorn";
            cus2.name2 = "Tee";
            cus2.sex = "M";
            cus2.age = 17;
            db.Customer.Add(cus2);
            db.SaveChanges();

            customer cus3 = new customer();
            cus3.name1 = "Hurasu";
            cus3.name2 = "Kio";
            cus3.sex = "F";
            cus3.age = 24;
            db.Customer.Add(cus3);
            db.SaveChanges();

            customer cus4 = new customer();
            cus4.name1 = "Chanachai";
            cus4.name2 = "Em";
            cus4.sex = "M";
            cus4.age = 52;
            db.Customer.Add(cus4);
            db.SaveChanges();

            customer cus5 = new customer();
            cus5.name1 = "Teera";
            cus5.name2 = "Fuka";
            cus5.sex = "F";
            cus5.age = 16;
            db.Customer.Add(cus5);
            db.SaveChanges();
        }
    }
}
