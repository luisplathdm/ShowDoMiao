using Controle;

namespace ShowDoMiao;

public partial class MainPage : ContentPage
{
	private Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
	}
	private void OnBtnResposta01Clicked(object sender, EventArgs e)
	{
		gerenciador!.VerificarSeEstaCorreta(1);
	}

	private void OnBtnResposta02Clicked(object sender, EventArgs e)
	{
		gerenciador!.VerificarSeEstaCorreta(2);
	}

	private void OnBtnResposta03Clicked(object sender, EventArgs e)
	{
		gerenciador!.VerificarSeEstaCorreta(3);
	}

	private void OnBtnResposta04Clicked(object sender, EventArgs e)
	{
		gerenciador!.VerificarSeEstaCorreta(4);
	}

	private void OnBtnResposta05Clicked(object sender, EventArgs e)
	{
		gerenciador!.VerificarSeEstaCorreta(5);
	}
}

