using System;

using System.Data;



using MySql.Data;

using MySql.Data.MySqlClient;



namespace File2 {
	
	class File2 {
		
		static void Main(string[] args) {
			
			string caraKoneksi;
			
			caraKoneksi = "server=127.0.0.1;uid=steven;pwd=kucing;database=latihan";
			
			MySql.Data.MySqlClient.MySqlConnection koneksi = new MySql.Data.MySqlClient.MySqlConnection(caraKoneksi);
			
			
			try {
				
				
				koneksi.Open();
				
				string perintahSql = "CREATE TABLE kompdapatkasperskyanvir(iddatakompterhubung INTEGER NOT NULL, tanggaldatakompterhubung DATE, kodebarang VARCHAR(5), nip VARCHAR(3), namapengguna VARCHAR(80), divisisubdivisi VARCHAR(100), ipaddress VARCHAR(50), macaddress1 VARCHAR(50), macaddress2 VARCHAR(50), macaddress3 VARCHAR(50), pcrakitan VARCHAR(20), minipc VARCHAR(20), laptop VARCHAR(20), terkoneksiserverantivirus VARCHAR(10));";
				
				MySqlCommand membuatTabel = new MySqlCommand(perintahSql,koneksi);
				
				
				membuatTabel.ExecuteNonQuery();
				
				
				
			}
			
			
			catch (MySql.Data.MySqlClient.MySqlException ex) {
				
				Console.WriteLine(ex.Message);
				
				
			}
			
				koneksi.Close();
			
		}
		
		
		
	}
	
	
}
