using Controle;

namespace ShowDoMiao;

public partial class MainPage : ContentPage
{	
	Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
		Gerenciador = new Gerenciador(labelPergunta,buttonResposta01,buttonResposta02,buttonResposta03,buttonResposta04,buttonResposta05);
		gerenciador.ProximaQuestao();
	}
		private void AAAClicked(object sender, EventArgs e)
			{
				Application.Current.MainPage = new EntradaPage();
			}
		private void OnBtnResposta01Clicked(object sender, EventArgs e)
			{
				gerenciador!.VerificaCorreto(1);
			}

		private void OnBtnResposta02Clicked(object sender, EventArgs e)
			{
				gerenciador!.VerificaCorreto(2);
			}

		private void OnBtnResposta03Clicked(object sender, EventArgs e)
			{
				gerenciador!.VerificaCorreto(3);
			}

		private void OnBtnResposta04Clicked(object sender, EventArgs e)
			{
				gerenciador!.VerificaCorreto(4);
			}

		private void OnBtnResposta05Clicked(object sender, EventArgs e)
			{
				gerenciador!.VerificaCorreto(5);
			}

}

