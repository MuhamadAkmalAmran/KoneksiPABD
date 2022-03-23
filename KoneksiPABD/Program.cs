using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KoneksiPABD
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }

        public void Connecting()//membuat method koneksi
        {
            using (
                SqlConnection con = new SqlConnection("data source=LENOVO\\AKMALAMRAN;database=akmal_exe2;User ID=sa;Password=uzumaki")
                )
            {
                con.Open();
                Console.WriteLine("Berhasil terhubung ke database!");
            }    
            
        }
    }
}
