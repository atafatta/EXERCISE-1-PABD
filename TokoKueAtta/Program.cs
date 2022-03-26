using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TokoKueAtta
{
    class Program
    {
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ROG-GL552JX;database=TokoKueAtta;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand
                    ("insert into Produk (Id_Produk, Nama_Kue, Harga, Stok) values ('0001','Kue Pelangi',18000,'10')"
                    + "insert into Produk (Id_Produk, Nama_Kue, Harga, Stok) values ('0002','Bolu Pandan',20000,'5')"
                    + "insert into Produk (Id_Produk, Nama_Kue, Harga, Stok) values ('0003','Cup Cake',10000,'15')"
                    + "insert into Produk (Id_Produk, Nama_Kue, Harga, Stok) values ('0004','Bolu Brownis',15000,'50')"
                    + "insert into Produk (Id_Produk, Nama_Kue, Harga, Stok) values ('0005','Bika Ambon',25000,'60')"

                    + "insert into Transaksi (Id_Transaksi, Id_Pelanggan, Tgl_Pesan, Total_Pesanan) values ('T001','0123','2022-01-05','100')"
                    + "insert into Transaksi (Id_Transaksi, Id_Pelanggan, Tgl_Pesan, Total_Pesanan) values ('T002','0124','2022-02-02','50')"
                    + "insert into Transaksi (Id_Transaksi, Id_Pelanggan, Tgl_Pesan, Total_Pesanan) values ('T003','0125','2022-03-15','20')"
                    + "insert into Transaksi (Id_Transaksi, Id_Pelanggan, Tgl_Pesan, Total_Pesanan) values ('T004','0126','2022-01-21','35')"
                    + "insert into Transaksi (Id_Transaksi, Id_Pelanggan, Tgl_Pesan, Total_Pesanan) values ('T005','0127','2022-02-26','60')"

                    + "insert into Detail_Transaksi (Id_Detail, Id_Transaksi, Id_Produk, Jumlah, Harga) values ('0012','T001','0001','20',18000)"
                    + "insert into Detail_Transaksi (Id_Detail, Id_Transaksi, Id_Produk, Jumlah, Harga) values ('0013','T002','0002','15',20000)"
                    + "insert into Detail_Transaksi (Id_Detail, Id_Transaksi, Id_Produk, Jumlah, Harga) values ('0014','T003','0003','40',10000)"
                    + "insert into Detail_Transaksi (Id_Detail, Id_Transaksi, Id_Produk, Jumlah, Harga) values ('0015','T004','0004','30',15000)"
                    + "insert into Detail_Transaksi (Id_Detail, Id_Transaksi, Id_Produk, Jumlah, Harga) values ('0016','T005','0005','10',25000)"

                    + "insert into Orderr (Order_Id, Order_value) values ('O001','0011')"
                    + "insert into Orderr (Order_Id, Order_value) values ('O002','0022')"
                    + "insert into Orderr (Order_Id, Order_value) values ('O003','0033')"
                    + "insert into Orderr (Order_Id, Order_value) values ('O004','0044')"
                    + "insert into Orderr (Order_Id, Order_value) values ('O005','0055')"

                    + "insert into Kasir (Id_Kasir, Nama_Kasir, Order_Id) values ('K012','Siti','O001')"
                    + "insert into Kasir (Id_Kasir, Nama_Kasir, Order_Id) values ('K013','Hermanu','O002')"
                    + "insert into Kasir (Id_Kasir, Nama_Kasir, Order_Id) values ('K014','Prasetyo','O003')"
                    + "insert into Kasir (Id_Kasir, Nama_Kasir, Order_Id) values ('K015','Ramdhani','O004')"
                    + "insert into Kasir (Id_Kasir, Nama_Kasir, Order_Id) values ('K016','Asti','O005')"

                    + "insert into Pelanggan (Id_Pelanggan, Nama_Pelanggan, Alamat,No_Hp, Id_Transaksi, Id_Produk, Order_Id) values ('P112','Reza','Magelang','085955592721','T001','0001','O001')"
                    + "insert into Pelanggan (Id_Pelanggan, Nama_Pelanggan, Alamat,No_Hp, Id_Transaksi, Id_Produk, Order_Id) values ('P113','Della','Bantul','083851241214','T002','0002','O002')"
                    + "insert into Pelanggan (Id_Pelanggan, Nama_Pelanggan, Alamat,No_Hp, Id_Transaksi, Id_Produk, Order_Id) values ('P114','Yuni','Sleman','085674209412','T003','0003','O003')"
                    + "insert into Pelanggan (Id_Pelanggan, Nama_Pelanggan, Alamat,No_Hp, Id_Transaksi, Id_Produk, Order_Id) values ('P115','Bagas','Kasihan','081235904219','T004','0005','O004')"
                    + "insert into Pelanggan (Id_Pelanggan, Nama_Pelanggan, Alamat,No_Hp, Id_Transaksi, Id_Produk, Order_Id) values ('P116','Bagus','Borobudur','085721432157','T005','0006','O005')", con);
                cm.ExecuteNonQuery();


                Console.WriteLine("Data berhasil ditambahkan!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("yahh datamu ada yang salah...." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            new Program().InsertData();
        }
    }

}
