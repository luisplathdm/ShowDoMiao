namespace Controle
{
     public class Gerenciador
     {
        List<Questione> ListaQuestoes=new List<Questione>();
        List<int> ListaQuestoesRespondidas=new List<int>();
        Questione QuestaoCorrente;
        public Gerenciador (Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05);
          {
             CriarPerguntas(lp,BT01, BT02, BT03, BT04, BT05);
          }
         
        void ProximaQuestao()
        {
          var numAleatorio = Random.Shared.Next(0, ListaQuestoes.Count);
          while(ListaQuestoesRespondidas.Contains(numAleatorio))
          numAleatorio = Random.Shared.Next(0,ListaQuestoes.Count);
          ListaQuestoesRespondidas.Add(numAleatorio);
          QuestaoCorrente = ListaQuestoes [numAleatorio];
          QuestaoCorrente.Desenhar();
        }
         public async void VerificarSeEstaCorreta(int RR)
         {
            if (QuestaoCorrente.VerificarSeEstaCorreta(RR))
            {
               await Task.Delay(1000);
               ProximaQuestao();
            }
         }
         public void AdicionaPergunta(Questao questao)
            {
               listaQuestoes.Add(questao);
            }
        
        void CriarPerguntas(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05);
          {
            var Q1 =new Questione();
            Q1.ConfigurarDesenho(lp,BT01, BT02, BT03, BT04, BT05);
            Q1.Question="2+2";
            Q1.FirstQuestion="5";
            Q1.SecondQuestion="12";
            Q1.ThirdQuestion="22";
            Q1.FourthQuestion="4";
            Q1.FiveQuestion="17";
            ProximaQuestao();
          }
     }
}
