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


Di bawah ini adalah source code untuk membuat jendela yang di dalamnya ada tombol , yang jika di klik maka akan menampilkan jendela baru:

```xaml
<Window xmlns="https://github.com/avaloniaui"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        mc:Ignorable="d" d:DesignWidth="800" d:DesignHeight="450"
        x:Class="latihan5.MainWindow"
        Title="Halaman Login">
		
		
		<StackPanel Margin="20">
		
			<TextBlock Margin="0 5">Nama Pengguna : </TextBlock>
			<TextBox Watermark="Isikan Nama Pengguna Anda"/>
			<TextBlock Margin="0 5">Password : </TextBlock>
			<TextBox Watermark="Isikan Password Anda" />
			<TextBlock Margin="0 5">Alamat IP : </TextBlock>
			<TextBox Watermark="Isikan Alamat IP Server" />
			<Button Click="bukaJendela1">Membuka Jendela</Button>
			
			
		</StackPanel>
    
</Window>



```



