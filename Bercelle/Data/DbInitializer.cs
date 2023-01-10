using System;
using Bercelle.Models;

namespace Bercelle.Data
{
    public class DbInitializer
    {
        public static void Initialize(BercelleContext context)
        {
            context.Database.EnsureCreated();

            if (context!.Admin.Any())
            {
                return;   // DB has been seeded
            }
            var admin = new Admin[]
            {
                  new Admin{id_admin=11110000,username="admin1",password="admin2003"}
            };
            foreach (Admin s in admin)
            {
                context.Admin.Add(s);
            }
            context.SaveChanges();

            var category = new Category[]
            {
                  new Category{namectg="hoa"},
                  new Category{namectg="cay canh"},
                  new Category{namectg="bonsai"},
            };
            foreach (Category c in category)
            {
                context.Categorys.Add(c);
            }
            context.SaveChanges();

            var product = new Product[]
            {
                  new Product{namectg= category.Single(i => i.namectg =="hoa").namectg, nameprd="cay canh",price=100000,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                  new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh",price=200000,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                  new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="cay canh",price=300000,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                  new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh",price=400000,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                  new Product{namectg= category.Single(i => i.namectg =="hoa").namectg,nameprd="cay canh",price=500000,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                  new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh",price=600000,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                  new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="cay canh",price=700000,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                  new Product{namectg= category.Single(i => i.namectg =="hoa").namectg,nameprd="cay canh",price=700000,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                  new Product{namectg= category.Single(i => i.namectg =="hoa").namectg,nameprd="cay canh",price=800000,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                  new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh",price=900000,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
            };
            foreach (Product s in product)
            {
                context.Products.Add(s);
            }
            context.SaveChanges();

            var customer = new Customer[]
            {
                  new Customer{name="khach hang 1",username="khdangnhap1",password="khdn1",address="mai dich,cau giay, ha noi",email="khdn1@gmail.com"},
                  new Customer{name="khach hang 2",username="khdangnhap2",password="khdn2",address="dich vong,cau giay, ha noi",email="khdn2@gmail.com"},
                  new Customer{name="khach hang 3",username="khdangnhap3",password="khdn3",address="co nhue,cau giay, ha noi",email="khdn3@gmail.com"},
                  new Customer{name="khach hang 4",username="khdangnhap4",password="khdn4",address="nhan hoa,cau giay, ha noi",email="khdn4@gmail.com"},
                  new Customer{name="khach hang 5",username="khdangnhap5",password="khdn5",address="quan nhan,cau giay, ha noi",email="khdn5@gmail.com"},
            };
            foreach (Customer a in customer)
            {
                context.Customers.Add(a);
            }
            context.SaveChanges();

            

        }
    }
}

