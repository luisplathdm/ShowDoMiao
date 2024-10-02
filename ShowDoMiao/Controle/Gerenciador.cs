using ShowDoMiao;

namespace Controle
{
   public class Gerenciador
   {
      public int Pontuacao { get; private set; }
      int LevelAtual = 0;
      List<Questione> ListaQuestoes = new List<Questione>();
      List<int> ListaQuestoesRespondidas = new List<int>();
      Questione QuestaoCorrente;
      public Gerenciador(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
      {
         CriarPerguntas(lp, BT01, BT02, BT03, BT04, BT05);

      }

      public void ProximaQuestao()
      {
         var numAleatorio = Random.Shared.Next(0, ListaQuestoes.Count);
         while (ListaQuestoesRespondidas.Contains(numAleatorio))
            numAleatorio = Random.Shared.Next(0, ListaQuestoes.Count);
         ListaQuestoesRespondidas.Add(numAleatorio);
         QuestaoCorrente = ListaQuestoes[numAleatorio];
         QuestaoCorrente.Desenhar();
      }
      void Inicializar()
      {
         Pontuacao = 0;
         LevelAtual = 1;
         ProximaQuestao();
      }
    public async void VerificarSeEstaCorreta(int RR)
{
   if (QuestaoCorrente.respostacoreta == RR)
    {
        await Task.Delay(1000);
        AdicionaPontuacao(LevelAtual);
        LevelAtual++;
        ProximaQuestao();
    }
    else
    {
      await App.Current.MainPage.DisplayAlert("FIM","vOCE eRROU","OK");
      Inicializar();
    }
}
      public void AdicionaPergunta(Questione questao)
      {
         ListaQuestoes.Add(questao);
      }
      void AdicionaPontuacao(int n)
      {
         if (n == 1)
            Pontuacao = 1000;
         else if (n == 2)
            Pontuacao = 2000;
         else if (n == 3)
            Pontuacao = 5000;
         else if (n == 4)
            Pontuacao = 10000;
         else if (n == 5)
            Pontuacao = 20000;
         else if (n == 6)
            Pontuacao = 50000;
         else if (n == 7)
            Pontuacao = 100000;
         else if (n == 8)
            Pontuacao = 200000;
         else if (n == 9)
            Pontuacao = 500000;
         else
            Pontuacao = 1000000;

      }

     void CriarPerguntas(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
      {
         var Q1 = new Questione();
         Q1.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q1.Question = "2+2";
         Q1.FirstQuestion = "5";
         Q1.SecondQuestion = "12";
         Q1.ThirdQuestion = "22";
         Q1.FourthQuestion = "4";
         Q1.FiveQuestion = "17";
         Q1.respostacoreta = 4;
         Q1.Level = 1;
         ListaQuestoes.Add(Q1);

         var Q2 = new Questione();
         Q2.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q2.Question = "Qual é a capital do Brasil?";
         Q2.FirstQuestion = "São Paulo";
         Q2.SecondQuestion = "Rio de Janeiro";
         Q2.ThirdQuestion = "Brasília";
         Q2.FourthQuestion = "Salvador";
         Q2.FiveQuestion = "Recife";
         Q1.respostacoreta = 3;
         Q2.Level = 1;
         ListaQuestoes.Add(Q2);

         ProximaQuestao();
      }


   }
}
