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




