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

            //CUSTOMER TABLE------------------------------------------------------

            //customer cus1 = new customer();
            //cus1.name1 = "Patcharaphon";
            //cus1.name2 = "Boss";
            //cus1.sex = "M";
            //cus1.age = 18;
            //db.Customer.Add(cus1);
            //db.SaveChanges();

            //customer cus2 = new customer();
            //cus2.name1 = "Pongsakorn";
            //cus2.name2 = "Tee";
            //cus2.sex = "M";
            //cus2.age = 17;
            //db.Customer.Add(cus2);
            //db.SaveChanges();

            //customer cus3 = new customer();
            //cus3.name1 = "Hurasu";
            //cus3.name2 = "Kio";
            //cus3.sex = "F";
            //cus3.age = 24;
            //db.Customer.Add(cus3);
            //db.SaveChanges();

            //customer cus4 = new customer();
            //cus4.name1 = "Chanachai";
            //cus4.name2 = "Em";
            //cus4.sex = "M";
            //cus4.age = 52;
            //db.Customer.Add(cus4);
            //db.SaveChanges();

            //customer cus5 = new customer();
            //cus5.name1 = "Teera";
            //cus5.name2 = "Fuka";
            //cus5.sex = "F";
            //cus5.age = 16;
            //db.Customer.Add(cus5);
            //db.SaveChanges();

            //PRODUCT TABLE------------------------------------------------------
            //product pd = new product();
            //pd.code = "a001";
            //pd.name1 = "tangerine";
            //pd.name2 = "ส้มเขียวหวาน";
            //pd.price = 50;
            //db.Product.Add(pd);
            //db.SaveChanges();

            //product pd2 = new product();
            //pd2.code = "a002";
            //pd2.name1 = "shogun_orange";
            //pd2.name2 = "ส้มโชกุน";
            //pd2.price = 70;
            //db.Product.Add(pd2);
            //db.SaveChanges();

            //product pd3 = new product();
            //pd3.code = "a003";
            //pd3.name1 = "sai_nam_phueng_orange";
            //pd3.name2 = "ส้มสายน้ำผึ้ง";
            //pd3.price = 90;
            //db.Product.Add(pd3);
            //db.SaveChanges();

            //product pd4 = new product();
            //pd4.code = "a004";
            //pd4.name1 = "north_orange";
            //pd4.name2 = "ส้มเหนือ";
            //pd4.price = 25;
            //db.Product.Add(pd4);
            //db.SaveChanges();

            //product pd5 = new product();
            //pd5.code = "b001";
            //pd5.name1 = "yuzu_juice";
            //pd5.name2 = "น้ำส้มยูสุ";
            //pd5.price = 250;
            //db.Product.Add(pd5);
            //db.SaveChanges();

        }
    }
}
