# CSharp

Kode dasar untuk terhubung ke server Mysql : 


```C#

using System;

using MySql.Data;

using MySql.Data.MySqlClient;

namespace File2 {
	
	class File2 {
		
		static void Main(string[] args) {
			
			// MySql.Data.MySqlClient koneksi;
			
			string caraKoneksi;
			
			caraKoneksi = "server=127.0.0.1;uid=steven;pwd=kucing;database=latihan";
			
			MySql.Data.MySqlClient.MySqlConnection koneksi = new MySql.Data.MySqlClient.MySqlConnection(caraKoneksi);
			
			
			try {
				
				
				
				koneksi.Open();
					
			}
			
			
			catch (MySql.Data.MySqlClient.MySqlException ex) {
				
				Console.WriteLine(ex.Message);
				
				
				
			}
			
			
				koneksi.Close();
			
			
		}
			
	}
	
	
}


// source code yang ini bisa jalan tanpa error, tapi tidak muncul pesan apa apa.

// tapi kayaknya berhasil, kalau di rubah username nya ada pesan error di masalah username


```


untuk instal library .Net yang bisa terkoneksi ke server mysql : 

**dotnet add package MySql.Data --version 9.0.0**

Lokasi librarynya di sini:

[Situs Nuget](https://www.nuget.org/)

[Situs Nuget untuk Mysql.Data - Konektor MySQL untuk .Net](https://www.nuget.org/packages/MySql.Data)

Contoh perintahnya:

> dotnet add package MySql.Data --version 9.0.0


## Mencoba MySqlCommand

Kita akan mencoba **MySqlCommand** untuk membuat tabel **MySQL**

Berikut ini adalah source code untuk membuat tabel menggunakan **MySqlCommand** : 

```C#

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





```


## Menampilkan Jendela Baru

Berikut ini adalah perintah untuk membuat jendela baru, ini adalah [Perintah CLI nya](https://docs.avaloniaui.net/docs/0.10.x/getting-started/windows) : 

> dotnet new avalonia.window -na [namespace] -n [name]



