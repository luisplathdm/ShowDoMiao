namespace ShowDoMiao;

public partial class MainPage : ContentPage
{	public MainPage()
	{
		InitializeComponent();
	}
	 private void AAAClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EntradaPage();
        }

}

