namespace EntityFramworkHM.Model
{
    public class initData
    {
        public static void GenData(CustomerContext db)
        {
            db.Database.EnsureCreated();
            if (db.Customer.Any())
            {
                //return;
            }

            //CUSTOMER TABLE----------------------------------------------------------

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

            //PRODUCT TABLE-----------------------------------------------------------

            product pd = new product();
            pd.code = "a001";
            pd.name1 = "tangerine";
            pd.name2 = "ส้มเขียวหวาน";
            pd.price = 50;
            db.Product.Add(pd);
            db.SaveChanges();

            product pd2 = new product();
            pd2.code = "a002";
            pd2.name1 = "shogun_orange";
            pd2.name2 = "ส้มโชกุน";
            pd2.price = 70;
            db.Product.Add(pd2);
            db.SaveChanges();

            product pd3 = new product();
            pd3.code = "a003";
            pd3.name1 = "sai_nam_phueng_orange";
            pd3.name2 = "ส้มสายน้ำผึ้ง";
            pd3.price = 90;
            db.Product.Add(pd3);
            db.SaveChanges();

            product pd4 = new product();
            pd4.code = "a004";
            pd4.name1 = "north_orange";
            pd4.name2 = "ส้มเหนือ";
            pd4.price = 25;
            db.Product.Add(pd4);
            db.SaveChanges();

            product pd5 = new product();
            pd5.code = "b001";
            pd5.name1 = "yuzu_juice";
            pd5.name2 = "น้ำส้มยูสุ";
            pd5.price = 250;
            db.Product.Add(pd5);
            db.SaveChanges();

            //ORDERH TABLE------------------------------------------------------------

            orderh oh = new orderh();
            oh.doc_no = "dn001";
            oh.doc_date = new DateTime(2022 , 08 , 09);
            oh.amount = 50;
            oh.vat = (oh.amount * 7) / 100;
            oh.net_amount = oh.amount + oh.vat;
            oh.customerid = cus3.id;
            db.Orderh.Add(oh);
            db.SaveChanges();

            orderh oh2 = new orderh();
            oh2.doc_no = "dn002";
            oh2.doc_date = new DateTime(2022 , 10 , 05);
            oh2.amount = 90;
            oh2.vat = (oh2.amount * 7) / 100;
            oh2.net_amount = oh2.amount + oh2.vat;
            oh2.customerid = cus1.id;
            db.Orderh.Add(oh2);
            db.SaveChanges();

            orderh oh3 = new orderh();
            oh3.doc_no = "dn003";
            oh3.doc_date = new DateTime(2022 , 01 , 30);
            oh3.amount = 250;
            oh3.vat = (oh3.amount * 7) / 100;
            oh3.net_amount = oh3.amount + oh3.vat;
            oh3.customerid = cus4.id;
            db.Orderh.Add(oh3);
            db.SaveChanges();

            orderh oh4 = new orderh();
            oh4.doc_no = "dn004";
            oh4.doc_date = new DateTime(2022 , 02 , 20);
            oh4.amount = 70;
            oh4.vat = (oh4.amount * 7) / 100;
            oh4.net_amount = oh4.amount + oh4.vat;
            oh4.customerid = cus2.id;
            db.Orderh.Add(oh4);
            db.SaveChanges();

            orderh oh5 = new orderh();
            oh5.doc_no = "dn005";
            oh5.doc_date = new DateTime(2021 , 04 , 12);
            oh5.amount = 25;
            oh5.vat = (oh5.amount * 7) / 100;
            oh5.net_amount = oh5.amount + oh5.vat;
            oh5.customerid = cus4.id;
            db.Orderh.Add(oh5);
            db.SaveChanges();

            //ORDERID TABLE-----------------------------------------------------------

            orderid oid = new orderid();
            oid.orderhid = oh.id;
            oid.itemid = pd.id;
            oid.item_desc = "tangerine_2kg";
            oid.price = 50;
            oid.qty = 2;
            oid.vat = ((oid.price * oid.qty) * 7) / 100;
            oid.net_amount = (oid.price * oid.qty) + oid.vat;
            db.Orderid.Add(oid);
            db.SaveChanges();

            orderid oid2 = new orderid();
            oid2.orderhid = oh3.id;
            oid2.itemid = pd5.id;
            oid2.item_desc = "yuzu_juice_1";
            oid2.price = 250;
            oid2.qty = 1;
            oid2.vat = ((oid2.price * oid2.qty) * 7) / 100;
            oid2.net_amount = (oid2.price * oid2.qty) + oid2.vat;
            db.Orderid.Add(oid2);
            db.SaveChanges();

            orderid oid3 = new orderid();
            oid3.orderhid = oh5.id;
            oid3.itemid = pd4.id;
            oid3.item_desc = "north_orange_2kg";
            oid3.price = 25;
            oid3.qty = 2;
            oid3.vat = ((oid3.price * oid3.qty) * 7) / 100;
            oid3.net_amount = (oid3.price * oid3.qty) + oid3.vat;
            db.Orderid.Add(oid3);
            db.SaveChanges();

            orderid oid4 = new orderid();
            oid4.orderhid = oh2.id;
            oid4.itemid = pd3.id;
            oid4.item_desc = "sai_nam_phueng_orange_1kg";
            oid4.price = 90;
            oid4.qty = 1;
            oid4.vat = ((oid4.price * oid4.qty) * 7) / 100;
            oid4.net_amount = (oid4.price * oid4.qty) + oid4.vat;
            db.Orderid.Add(oid4);
            db.SaveChanges();

            orderid oid5 = new orderid();
            oid5.orderhid = oh4.id;
            oid5.itemid = pd2.id;
            oid5.item_desc = "shogun_orange_1kg";
            oid5.price = 90;
            oid5.qty = 1;
            oid5.vat = ((oid5.price * oid5.qty) * 7) / 100;
            oid5.net_amount = (oid5.price * oid5.qty) + oid5.vat;
            db.Orderid.Add(oid5);
            db.SaveChanges();
        }
    }
}
