using Avalonia.Controls;

using Avalonia.Interactivity;

using System.Diagnostics;


namespace latihan3;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
	
	
	// di bawah ini adalah source code untuk menutup jendela

 // perintah yang dijalankan dengan memencet tombol di avalonia ui
	
	public void tutupJendela(object source, RoutedEventArgs args) {
		
		
		this.Close();
		
	}
}
