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
                new Product{namectg= category.Single(i => i.namectg =="hoa").namectg, nameprd="hoa1",price=1035,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="hoa").namectg, nameprd="hoa2",price=1035,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="hoa").namectg, nameprd="hoa3",price=1035,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="hoa").namectg, nameprd="hoa4",price=1035,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="hoa").namectg, nameprd="hoa5",price=1035,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="hoa").namectg, nameprd="hoa6",price=1035,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="hoa").namectg, nameprd="hoa7",price=1035,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="hoa").namectg, nameprd="hoa8",price=1035,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="hoa").namectg, nameprd="hoa9",price=1035,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="hoa").namectg, nameprd="hoa10",price=1035,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},

                new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh1",price=262,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh2",price=262,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh3",price=262,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh4",price=262,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh5",price=262,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh6",price=262,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh7",price=262,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh8",price=262,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh9",price=262,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="cay canh").namectg,nameprd="cay canh10",price=262,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},

                new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="bonsai1",price=336,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="bonsai2",price=336,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="bonsai3",price=336,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="bonsai4",price=336,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="bonsai5",price=336,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="bonsai6",price=336,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="bonsai7",price=336,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="bonsai8",price=336,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="bonsai9",price=336,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},
                new Product{namectg= category.Single(i => i.namectg =="bonsai").namectg,nameprd="bonsai10",price=336,description="cay canh duoc trang tri trong cac khong gian thong thoang",quantity=100},

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

