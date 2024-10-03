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
      public Questione GetQuestaoCorrente()
      {
         return QuestaoCorrente;
      }
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

         var Q3 = new Questione();
         Q3.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q3.Question = "Qual o resultado de 3 * 3?";
         Q3.FirstQuestion = "6";
         Q3.SecondQuestion = "9";
         Q3.ThirdQuestion = "12";
         Q3.FourthQuestion = "15";
         Q3.FiveQuestion = "3";
         Q3.respostacoreta = 2;
         Q3.Level = 1;
         ListaQuestoes.Add(Q3);

         var Q4 = new Questione();
         Q4.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q4.Question = "Quem descobriu o Brasil?";
         Q4.FirstQuestion = "Cristóvão Colombo";
         Q4.SecondQuestion = "Pedro Álvares Cabral";
         Q4.ThirdQuestion = "Dom Pedro I";
         Q4.FourthQuestion = "Vasco da Gama";
         Q4.FiveQuestion = "Fernão de Magalhães";
         Q4.respostacoreta = 2;
         Q4.Level = 1;
         ListaQuestoes.Add(Q4);

         var Q5 = new Questione();
         Q5.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q5.Question = "Qual o maior planeta do sistema solar?";
         Q5.FirstQuestion = "Terra";
         Q5.SecondQuestion = "Marte";
         Q5.ThirdQuestion = "Júpiter";
         Q5.FourthQuestion = "Saturno";
         Q5.FiveQuestion = "Vênus";
         Q5.respostacoreta = 3;
         Q5.Level = 1;
         ListaQuestoes.Add(Q5);

         var Q6 = new Questione();
         Q6.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q6.Question = "Quanto é 10 / 2?";
         Q6.FirstQuestion = "4";
         Q6.SecondQuestion = "5";
         Q6.ThirdQuestion = "6";
         Q6.FourthQuestion = "10";
         Q6.FiveQuestion = "20";
         Q6.respostacoreta = 2;
         Q6.Level = 1;
         ListaQuestoes.Add(Q6);

         var Q7 = new Questione();
         Q7.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q7.Question = "Qual é o elemento químico de símbolo O?";
         Q7.FirstQuestion = "Oxigênio";
         Q7.SecondQuestion = "Ouro";
         Q7.ThirdQuestion = "Ósmio";
         Q7.FourthQuestion = "Ozônio";
         Q7.FiveQuestion = "Oxalato";
         Q7.respostacoreta = 1;
         Q7.Level = 1;
         ListaQuestoes.Add(Q7);

         var Q8 = new Questione();
         Q8.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q8.Question = "Qual é a capital da Alemanha?";
         Q8.FirstQuestion = "Paris";
         Q8.SecondQuestion = "Berlim";
         Q8.ThirdQuestion = "Viena";
         Q8.FourthQuestion = "Amsterdã";
         Q8.FiveQuestion = "Praga";
         Q8.respostacoreta = 2;
         Q8.Level = 1;
         ListaQuestoes.Add(Q8);

         var Q9 = new Questione();
         Q9.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q9.Question = "Quanto é 50 + 25?";
         Q9.FirstQuestion = "60";
         Q9.SecondQuestion = "70";
         Q9.ThirdQuestion = "75";
         Q9.FourthQuestion = "85";
         Q9.FiveQuestion = "90";
         Q9.respostacoreta = 3;
         Q9.Level = 1;
         ListaQuestoes.Add(Q9);

         var Q10 = new Questione();
         Q10.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q10.Question = "Quem foi o primeiro presidente do Brasil?";
         Q10.FirstQuestion = "Getúlio Vargas";
         Q10.SecondQuestion = "Marechal Deodoro";
         Q10.ThirdQuestion = "Dom Pedro I";
         Q10.FourthQuestion = "Tancredo Neves";
         Q10.FiveQuestion = "Juscelino Kubitschek";
         Q10.respostacoreta = 2;
         Q10.Level = 1;
         ListaQuestoes.Add(Q10);

          var Q11 = new Questione();
         Q11.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q11.Question = "Qual é o valor de PI, aproximadamente?";
         Q11.FirstQuestion = "3.12";
         Q11.SecondQuestion = "3.14";
         Q11.ThirdQuestion = "3.16";
         Q11.FourthQuestion = "3.18";
         Q11.FiveQuestion = "3.20";
         Q11.respostacoreta = 2;
         Q11.Level = 2;
         ListaQuestoes.Add(Q11);

         var Q12 = new Questione();
         Q12.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q12.Question = "Qual é a fórmula química da água?";
         Q12.FirstQuestion = "H2O";
         Q12.SecondQuestion = "O2";
         Q12.ThirdQuestion = "H2O2";
         Q12.FourthQuestion = "CO2";
         Q12.FiveQuestion = "N2";
         Q12.respostacoreta = 1;
         Q12.Level = 2;
         ListaQuestoes.Add(Q12);

         var Q13 = new Questione();
         Q13.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q13.Question = "Quem pintou a Mona Lisa?";
         Q13.FirstQuestion = "Michelangelo";
         Q13.SecondQuestion = "Van Gogh";
         Q13.ThirdQuestion = "Leonardo da Vinci";
         Q13.FourthQuestion = "Raphael";
         Q13.FiveQuestion = "Donatello";
         Q13.respostacoreta = 3;
         Q13.Level = 3;
         ListaQuestoes.Add(Q13);

         var Q14 = new Questione();
         Q14.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q14.Question = "Quantos estados tem o Brasil?";
         Q14.FirstQuestion = "24";
         Q14.SecondQuestion = "25";
         Q14.ThirdQuestion = "26";
         Q14.FourthQuestion = "27";
         Q14.FiveQuestion = "28";
         Q14.respostacoreta = 4;
         Q14.Level = 3;
         ListaQuestoes.Add(Q14);

         var Q15 = new Questione();
         Q15.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q15.Question = "Quantos planetas existem no sistema solar?";
         Q15.FirstQuestion = "7";
         Q15.SecondQuestion = "8";
         Q15.ThirdQuestion = "9";
         Q15.FourthQuestion = "10";
         Q15.FiveQuestion = "11";
         Q15.respostacoreta = 2;
         Q15.Level = 4;
         ListaQuestoes.Add(Q15);

         var Q16 = new Questione();
         Q16.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q16.Question = "Qual foi o ano da Independência do Brasil?";
         Q16.FirstQuestion = "1500";
         Q16.SecondQuestion = "1822";
         Q16.ThirdQuestion = "1889";
         Q16.FourthQuestion = "1910";
         Q16.FiveQuestion = "1930";
         Q16.respostacoreta = 2;
         Q16.Level = 4;
         ListaQuestoes.Add(Q16);

         var Q17 = new Questione();
         Q17.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q17.Question = "Quem escreveu 'Dom Casmurro'?";
         Q17.FirstQuestion = "José de Alencar";
         Q17.SecondQuestion = "Machado de Assis";
         Q17.ThirdQuestion = "Jorge Amado";
         Q17.FourthQuestion = "Carlos Drummond";
         Q17.FiveQuestion = "Clarice Lispector";
         Q17.respostacoreta = 2;
         Q17.Level = 5;
         ListaQuestoes.Add(Q17);

         var Q18 = new Questione();
         Q18.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q18.Question = "Qual é o maior oceano do mundo?";
         Q18.FirstQuestion = "Atlântico";
         Q18.SecondQuestion = "Pacífico";
         Q18.ThirdQuestion = "Índico";
         Q18.FourthQuestion = "Ártico";
         Q18.FiveQuestion = "Antártico";
         Q18.respostacoreta = 2;
         Q18.Level = 5;
         ListaQuestoes.Add(Q18);

         var Q19 = new Questione();
         Q19.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q19.Question = "Qual é a moeda oficial do Japão?";
         Q19.FirstQuestion = "Dólar";
         Q19.SecondQuestion = "Euro";
         Q19.ThirdQuestion = "Iene";
         Q19.FourthQuestion = "Won";
         Q19.FiveQuestion = "Libra";
         Q19.respostacoreta = 3;
         Q19.Level = 6;
         ListaQuestoes.Add(Q19);

         var Q20 = new Questione();
         Q20.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q20.Question = "Quem foi o primeiro homem a pisar na Lua?";
         Q20.FirstQuestion = "Neil Armstrong";
         Q20.SecondQuestion = "Buzz Aldrin";
         Q20.ThirdQuestion = "Yuri Gagarin";
         Q20.FourthQuestion = "Michael Collins";
         Q20.FiveQuestion = "John Glenn";
         Q20.respostacoreta = 1;
         Q20.Level = 6;
         ListaQuestoes.Add(Q20);
         var Q21 = new Questione();
         Q21.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q21.Question = "Qual é o nome do autor de 'O Pequeno Príncipe'?";
         Q21.FirstQuestion = "Charles Dickens";
         Q21.SecondQuestion = "Antoine de Saint-Exupéry";
         Q21.ThirdQuestion = "Victor Hugo";
         Q21.FourthQuestion = "Jules Verne";
         Q21.FiveQuestion = "Albert Camus";
         Q21.respostacoreta = 2;
         Q21.Level = 7;
         ListaQuestoes.Add(Q21);

         var Q22 = new Questione();
         Q22.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q22.Question = "Qual é o maior país em extensão territorial?";
         Q22.FirstQuestion = "Estados Unidos";
         Q22.SecondQuestion = "Canadá";
         Q22.ThirdQuestion = "Brasil";
         Q22.FourthQuestion = "Rússia";
         Q22.FiveQuestion = "China";
         Q22.respostacoreta = 4;
         Q22.Level = 7;
         ListaQuestoes.Add(Q22);

         var Q23 = new Questione();
         Q23.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q23.Question = "Quem foi o primeiro presidente do Brasil?";
         Q23.FirstQuestion = "Getúlio Vargas";
         Q23.SecondQuestion = "Juscelino Kubitschek";
         Q23.ThirdQuestion = "Deodoro da Fonseca";
         Q23.FourthQuestion = "Pedro II";
         Q23.FiveQuestion = "Floriano Peixoto";
         Q23.respostacoreta = 3;
         Q23.Level = 8;
         ListaQuestoes.Add(Q23);

         var Q24 = new Questione();
         Q24.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q24.Question = "Qual é a capital da Austrália?";
         Q24.FirstQuestion = "Sydney";
         Q24.SecondQuestion = "Melbourne";
         Q24.ThirdQuestion = "Perth";
         Q24.FourthQuestion = "Canberra";
         Q24.FiveQuestion = "Brisbane";
         Q24.respostacoreta = 4;
         Q24.Level = 8;
         ListaQuestoes.Add(Q24);

         var Q25 = new Questione();
         Q25.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q25.Question = "Quem escreveu 'Romeu e Julieta'?";
         Q25.FirstQuestion = "Dante Alighieri";
         Q25.SecondQuestion = "William Shakespeare";
         Q25.ThirdQuestion = "Oscar Wilde";
         Q25.FourthQuestion = "John Milton";
         Q25.FiveQuestion = "Mark Twain";
         Q25.respostacoreta = 2;
         Q25.Level = 9;
         ListaQuestoes.Add(Q25);

         var Q26 = new Questione();
         Q26.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q26.Question = "Qual é a camada mais externa da Terra?";
         Q26.FirstQuestion = "Manto";
         Q26.SecondQuestion = "Crosta";
         Q26.ThirdQuestion = "Núcleo Externo";
         Q26.FourthQuestion = "Núcleo Interno";
         Q26.FiveQuestion = "Magnetosfera";
         Q26.respostacoreta = 2;
         Q26.Level = 9;
         ListaQuestoes.Add(Q26);

         var Q27 = new Questione();
         Q27.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q27.Question = "Quantos ossos tem o corpo humano adulto?";
         Q27.FirstQuestion = "204";
         Q27.SecondQuestion = "206";
         Q27.ThirdQuestion = "208";
         Q27.FourthQuestion = "210";
         Q27.FiveQuestion = "212";
         Q27.respostacoreta = 2;
         Q27.Level = 10;
         ListaQuestoes.Add(Q27);

         var Q28 = new Questione();
         Q28.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q28.Question = "Qual é o país com a maior população do mundo?";
         Q28.FirstQuestion = "Índia";
         Q28.SecondQuestion = "Estados Unidos";
         Q28.ThirdQuestion = "Indonésia";
         Q28.FourthQuestion = "China";
         Q28.FiveQuestion = "Rússia";
         Q28.respostacoreta = 4;
         Q28.Level = 10;
         ListaQuestoes.Add(Q28);

         var Q29 = new Questione();
         Q29.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q29.Question = "Em qual país foram realizados os primeiros Jogos Olímpicos modernos?";
         Q29.FirstQuestion = "França";
         Q29.SecondQuestion = "Grécia";
         Q29.ThirdQuestion = "Itália";
         Q29.FourthQuestion = "Inglaterra";
         Q29.FiveQuestion = "Alemanha";
         Q29.respostacoreta = 2;
         Q29.Level = 1;
         ListaQuestoes.Add(Q29);

         var Q30 = new Questione();
         Q30.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q30.Question = "Em que ano o homem pisou na Lua pela primeira vez?";
         Q30.FirstQuestion = "1965";
         Q30.SecondQuestion = "1967";
         Q30.ThirdQuestion = "1969";
         Q30.FourthQuestion = "1971";
         Q30.FiveQuestion = "1973";
         Q30.respostacoreta = 3;
         Q30.Level = 1;
         ListaQuestoes.Add(Q30);

         var Q31 = new Questione();
         Q31.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q31.Question = "Qual planeta é conhecido como o Planeta Vermelho?";
         Q31.FirstQuestion = "Terra";
         Q31.SecondQuestion = "Vênus";
         Q31.ThirdQuestion = "Marte";
         Q31.FourthQuestion = "Júpiter";
         Q31.FiveQuestion = "Saturno";
         Q31.respostacoreta = 3;
         Q31.Level = 2;
         ListaQuestoes.Add(Q31);

         var Q32 = new Questione();
         Q32.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q32.Question = "Quem é conhecido como o 'Pai da Relatividade'?";
         Q32.FirstQuestion = "Isaac Newton";
         Q32.SecondQuestion = "Albert Einstein";
         Q32.ThirdQuestion = "Galileu Galilei";
         Q32.FourthQuestion = "Nikola Tesla";
         Q32.FiveQuestion = "Stephen Hawking";
         Q32.respostacoreta = 2;
         Q32.Level = 2;
         ListaQuestoes.Add(Q32);

         var Q33 = new Questione();
         Q33.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q33.Question = "Em que continente fica o Deserto do Saara?";
         Q33.FirstQuestion = "Ásia";
         Q33.SecondQuestion = "América do Norte";
         Q33.ThirdQuestion = "América do Sul";
         Q33.FourthQuestion = "África";
         Q33.FiveQuestion = "Europa";
         Q33.respostacoreta = 4;
         Q33.Level = 3;
         ListaQuestoes.Add(Q33);

         var Q34 = new Questione();
         Q34.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q34.Question = "Qual foi o primeiro país a enviar um satélite ao espaço?";
         Q34.FirstQuestion = "Estados Unidos";
         Q34.SecondQuestion = "Alemanha";
         Q34.ThirdQuestion = "China";
         Q34.FourthQuestion = "União Soviética";
         Q34.FiveQuestion = "França";
         Q34.respostacoreta = 4;
         Q34.Level = 3;
         ListaQuestoes.Add(Q34);

         var Q35 = new Questione();
         Q35.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q35.Question = "Qual é o maior planeta do sistema solar?";
         Q35.FirstQuestion = "Terra";
         Q35.SecondQuestion = "Vênus";
         Q35.ThirdQuestion = "Júpiter";
         Q35.FourthQuestion = "Saturno";
         Q35.FiveQuestion = "Netuno";
         Q35.respostacoreta = 3;
         Q35.Level = 4;
         ListaQuestoes.Add(Q35);

         var Q36 = new Questione();
         Q36.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q36.Question = "Quem é o autor de '1984'?";
         Q36.FirstQuestion = "George Orwell";
         Q36.SecondQuestion = "Aldous Huxley";
         Q36.ThirdQuestion = "Ray Bradbury";
         Q36.FourthQuestion = "Jules Verne";
         Q36.FiveQuestion = "H.G. Wells";
         Q36.respostacoreta = 1;
         Q36.Level = 4;
         ListaQuestoes.Add(Q36);

         var Q37 = new Questione();
         Q37.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q37.Question = "Qual é a fórmula química do sal de cozinha?";
         Q37.FirstQuestion = "NaCl";
         Q37.SecondQuestion = "H2O";
         Q37.ThirdQuestion = "CO2";
         Q37.FourthQuestion = "O2";
         Q37.FiveQuestion = "C6H12O6";
         Q37.respostacoreta = 1;
         Q37.Level = 5;
         ListaQuestoes.Add(Q37);

         var Q38 = new Questione();
         Q38.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q38.Question = "Em que ano começou a Segunda Guerra Mundial?";
         Q38.FirstQuestion = "1914";
         Q38.SecondQuestion = "1920";
         Q38.ThirdQuestion = "1939";
         Q38.FourthQuestion = "1941";
         Q38.FiveQuestion = "1945";
         Q38.respostacoreta = 3;
         Q38.Level = 5;
         ListaQuestoes.Add(Q38);

         var Q39 = new Questione();
         Q39.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q39.Question = "Quem pintou o teto da Capela Sistina?";
         Q39.FirstQuestion = "Leonardo da Vinci";
         Q39.SecondQuestion = "Michelangelo";
         Q39.ThirdQuestion = "Raphael";
         Q39.FourthQuestion = "Donatello";
         Q39.FiveQuestion = "Van Gogh";
         Q39.respostacoreta = 2;
         Q39.Level = 6;
         ListaQuestoes.Add(Q39);

         var Q40 = new Questione();
         Q40.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q40.Question = "Em que país se localiza Machu Picchu?";
         Q40.FirstQuestion = "Colômbia";
         Q40.SecondQuestion = "Peru";
         Q40.ThirdQuestion = "Bolívia";
         Q40.FourthQuestion = "Chile";
         Q40.FiveQuestion = "Equador";
         Q40.respostacoreta = 2;
         Q40.Level = 6;
         ListaQuestoes.Add(Q40);
         var Q41 = new Questione();
         Q41.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q41.Question = "Quem foi o responsável por desenvolver a teoria da evolução?";
         Q41.FirstQuestion = "Isaac Newton";
         Q41.SecondQuestion = "Charles Darwin";
         Q41.ThirdQuestion = "Albert Einstein";
         Q41.FourthQuestion = "Nikola Tesla";
         Q41.FiveQuestion = "Stephen Hawking";
         Q41.respostacoreta = 2;
         Q41.Level = 7;
         ListaQuestoes.Add(Q41);

         var Q42 = new Questione();
         Q42.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q42.Question = "Qual é o maior oceano do mundo?";
         Q42.FirstQuestion = "Oceano Atlântico";
         Q42.SecondQuestion = "Oceano Índico";
         Q42.ThirdQuestion = "Oceano Pacífico";
         Q42.FourthQuestion = "Oceano Ártico";
         Q42.FiveQuestion = "Oceano Antártico";
         Q42.respostacoreta = 3;
         Q42.Level = 7;
         ListaQuestoes.Add(Q42);

         var Q43 = new Questione();
         Q43.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q43.Question = "Em que ano foi fundado o Facebook?";
         Q43.FirstQuestion = "2000";
         Q43.SecondQuestion = "2002";
         Q43.ThirdQuestion = "2004";
         Q43.FourthQuestion = "2006";
         Q43.FiveQuestion = "2008";
         Q43.respostacoreta = 3;
         Q43.Level = 8;
         ListaQuestoes.Add(Q43);

         var Q44 = new Questione();
         Q44.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q44.Question = "Quem foi o primeiro homem a pisar na Lua?";
         Q44.FirstQuestion = "Yuri Gagarin";
         Q44.SecondQuestion = "Buzz Aldrin";
         Q44.ThirdQuestion = "Neil Armstrong";
         Q44.FourthQuestion = "Alan Shepard";
         Q44.FiveQuestion = "Michael Collins";
         Q44.respostacoreta = 3;
         Q44.Level = 8;
         ListaQuestoes.Add(Q44);

         var Q45 = new Questione();
         Q45.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q45.Question = "Qual é a montanha mais alta do mundo?";
         Q45.FirstQuestion = "Monte Everest";
         Q45.SecondQuestion = "K2";
         Q45.ThirdQuestion = "Kangchenjunga";
         Q45.FourthQuestion = "Monte Kilimanjaro";
         Q45.FiveQuestion = "Makalu";
         Q45.respostacoreta = 1;
         Q45.Level = 9;
         ListaQuestoes.Add(Q45);

         var Q46 = new Questione();
         Q46.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q46.Question = "Qual é o elemento químico com símbolo O?";
         Q46.FirstQuestion = "Oxigênio";
         Q46.SecondQuestion = "Ouro";
         Q46.ThirdQuestion = "Osmium";
         Q46.FourthQuestion = "Ozônio";
         Q46.FiveQuestion = "Óxidos";
         Q46.respostacoreta = 1;
         Q46.Level = 9;
         ListaQuestoes.Add(Q46);

         var Q47 = new Questione();
         Q47.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q47.Question = "Quantos continentes existem no mundo?";
         Q47.FirstQuestion = "4";
         Q47.SecondQuestion = "5";
         Q47.ThirdQuestion = "6";
         Q47.FourthQuestion = "7";
         Q47.FiveQuestion = "8";
         Q47.respostacoreta = 4;
         Q47.Level = 10;
         ListaQuestoes.Add(Q47);

         var Q48 = new Questione();
         Q48.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q48.Question = "Qual é a capital da Alemanha?";
         Q48.FirstQuestion = "Berlim";
         Q48.SecondQuestion = "Munique";
         Q48.ThirdQuestion = "Frankfurt";
         Q48.FourthQuestion = "Hamburgo";
         Q48.FiveQuestion = "Colônia";
         Q48.respostacoreta = 1;
         Q48.Level = 10;
         ListaQuestoes.Add(Q48);

         var Q49 = new Questione();
         Q49.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q49.Question = "Quem escreveu a obra 'Dom Quixote'?";
         Q49.FirstQuestion = "Gabriel García Márquez";
         Q49.SecondQuestion = "Pablo Neruda";
         Q49.ThirdQuestion = "Miguel de Cervantes";
         Q49.FourthQuestion = "Jorge Luis Borges";
         Q49.FiveQuestion = "Mario Vargas Llosa";
         Q49.respostacoreta = 3;
         Q49.Level = 1;
         ListaQuestoes.Add(Q49);

         var Q50 = new Questione();
         Q50.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q50.Question = "Em que ano foi declarada a independência do Brasil?";
         Q50.FirstQuestion = "1820";
         Q50.SecondQuestion = "1822";
         Q50.ThirdQuestion = "1824";
         Q50.FourthQuestion = "1826";
         Q50.FiveQuestion = "1828";
         Q50.respostacoreta = 2;
         Q50.Level = 1;
         ListaQuestoes.Add(Q50);

         var Q51 = new Questione();
         Q51.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q51.Question = "Quem descobriu o Brasil?";
         Q51.FirstQuestion = "Cristóvão Colombo";
         Q51.SecondQuestion = "Pedro Álvares Cabral";
         Q51.ThirdQuestion = "Fernão de Magalhães";
         Q51.FourthQuestion = "Vasco da Gama";
         Q51.FiveQuestion = "Bartolomeu Dias";
         Q51.respostacoreta = 2;
         Q51.Level = 2;
         ListaQuestoes.Add(Q51);

         var Q52 = new Questione();
         Q52.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q52.Question = "Qual é a fórmula da água?";
         Q52.FirstQuestion = "H2O";
         Q52.SecondQuestion = "CO2";
         Q52.ThirdQuestion = "O2";
         Q52.FourthQuestion = "CH4";
         Q52.FiveQuestion = "C6H12O6";
         Q52.respostacoreta = 1;
         Q52.Level = 2;
         ListaQuestoes.Add(Q52);

         var Q53 = new Questione();
         Q53.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q53.Question = "Qual planeta é conhecido como o planeta azul?";
         Q53.FirstQuestion = "Vênus";
         Q53.SecondQuestion = "Terra";
         Q53.ThirdQuestion = "Marte";
         Q53.FourthQuestion = "Netuno";
         Q53.FiveQuestion = "Júpiter";
         Q53.respostacoreta = 2;
         Q53.Level = 3;
         ListaQuestoes.Add(Q53);

         var Q54 = new Questione();
         Q54.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q54.Question = "Quem pintou a Mona Lisa?";
         Q54.FirstQuestion = "Vincent van Gogh";
         Q54.SecondQuestion = "Michelangelo";
         Q54.ThirdQuestion = "Leonardo da Vinci";
         Q54.FourthQuestion = "Pablo Picasso";
         Q54.FiveQuestion = "Claude Monet";
         Q54.respostacoreta = 3;
         Q54.Level = 3;
         ListaQuestoes.Add(Q54);

         var Q55 = new Questione();
         Q55.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q55.Question = "Qual país é conhecido como a Terra do Sol Nascente?";
         Q55.FirstQuestion = "China";
         Q55.SecondQuestion = "Coreia do Sul";
         Q55.ThirdQuestion = "Tailândia";
         Q55.FourthQuestion = "Japão";
         Q55.FiveQuestion = "Vietnã";
         Q55.respostacoreta = 4;
         Q55.Level = 4;
         ListaQuestoes.Add(Q55);

         var Q56 = new Questione();
         Q56.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q56.Question = "Qual é o maior mamífero terrestre?";
         Q56.FirstQuestion = "Leão";
         Q56.SecondQuestion = "Elefante";
         Q56.ThirdQuestion = "Baleia Azul";
         Q56.FourthQuestion = "Rinoceronte";
         Q56.FiveQuestion = "Girafa";
         Q56.respostacoreta = 2;
         Q56.Level = 4;
         ListaQuestoes.Add(Q56);

         var Q57 = new Questione();
         Q57.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q57.Question = "Em que país se localiza o Deserto do Saara?";
         Q57.FirstQuestion = "Egito";
         Q57.SecondQuestion = "Argélia";
         Q57.ThirdQuestion = "Sudão";
         Q57.FourthQuestion = "Líbia";
         Q57.FiveQuestion = "Marrocos";
         Q57.respostacoreta = 2;
         Q57.Level = 5;
         ListaQuestoes.Add(Q57);

         var Q58 = new Questione();
         Q58.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q58.Question = "Quantos estados existem no Brasil?";
         Q58.FirstQuestion = "24";
         Q58.SecondQuestion = "25";
         Q58.ThirdQuestion = "26";
         Q58.FourthQuestion = "27";
         Q58.FiveQuestion = "28";
         Q58.respostacoreta = 4;
         Q58.Level = 5;
         ListaQuestoes.Add(Q58);

         var Q59 = new Questione();
         Q59.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q59.Question = "Qual é o maior país do mundo em extensão territorial?";
         Q59.FirstQuestion = "Canadá";
         Q59.SecondQuestion = "Estados Unidos";
         Q59.ThirdQuestion = "Rússia";
         Q59.FourthQuestion = "China";
         Q59.FiveQuestion = "Brasil";
         Q59.respostacoreta = 3;
         Q59.Level = 6;
         ListaQuestoes.Add(Q59);

         var Q60 = new Questione();
         Q60.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q60.Question = "Quantos planetas existem no Sistema Solar?";
         Q60.FirstQuestion = "7";
         Q60.SecondQuestion = "8";
         Q60.ThirdQuestion = "9";
         Q60.FourthQuestion = "10";
         Q60.FiveQuestion = "11";
         Q60.respostacoreta = 2;
         Q60.Level = 6;
         ListaQuestoes.Add(Q60);
         var Q61 = new Questione();
         Q61.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q61.Question = "Qual é a capital da Austrália?";
         Q61.FirstQuestion = "Sydney";
         Q61.SecondQuestion = "Melbourne";
         Q61.ThirdQuestion = "Brisbane";
         Q61.FourthQuestion = "Camberra";
         Q61.FiveQuestion = "Adelaide";
         Q61.respostacoreta = 4;
         Q61.Level = 6;
         ListaQuestoes.Add(Q61);

         var Q62 = new Questione();
         Q62.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q62.Question = "Quem pintou o teto da Capela Sistina?";
         Q62.FirstQuestion = "Leonardo da Vinci";
         Q62.SecondQuestion = "Michelangelo";
         Q62.ThirdQuestion = "Raphael";
         Q62.FourthQuestion = "Donatello";
         Q62.FiveQuestion = "Botticelli";
         Q62.respostacoreta = 2;
         Q62.Level = 7;
         ListaQuestoes.Add(Q62);

         var Q63 = new Questione();
         Q63.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q63.Question = "Quantos ossos tem o corpo humano adulto?";
         Q63.FirstQuestion = "196";
         Q63.SecondQuestion = "206";
         Q63.ThirdQuestion = "216";
         Q63.FourthQuestion = "226";
         Q63.FiveQuestion = "236";
         Q63.respostacoreta = 2;
         Q63.Level = 7;
         ListaQuestoes.Add(Q63);

         var Q64 = new Questione();
         Q64.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q64.Question = "Quem escreveu 'Romeu e Julieta'?";
         Q64.FirstQuestion = "Jane Austen";
         Q64.SecondQuestion = "Charles Dickens";
         Q64.ThirdQuestion = "William Shakespeare";
         Q64.FourthQuestion = "Victor Hugo";
         Q64.FiveQuestion = "Fiódor Dostoiévski";
         Q64.respostacoreta = 3;
         Q64.Level = 8;
         ListaQuestoes.Add(Q64);

         var Q65 = new Questione();
         Q65.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q65.Question = "Qual é o país mais populoso do mundo?";
         Q65.FirstQuestion = "Índia";
         Q65.SecondQuestion = "Estados Unidos";
         Q65.ThirdQuestion = "China";
         Q65.FourthQuestion = "Indonésia";
         Q65.FiveQuestion = "Brasil";
         Q65.respostacoreta = 3;
         Q65.Level = 8;
         ListaQuestoes.Add(Q65);

         var Q66 = new Questione();
         Q66.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q66.Question = "Quantos litros de sangue um ser humano tem, em média?";
         Q66.FirstQuestion = "3 a 4 litros";
         Q66.SecondQuestion = "4 a 5 litros";
         Q66.ThirdQuestion = "5 a 6 litros";
         Q66.FourthQuestion = "6 a 7 litros";
         Q66.FiveQuestion = "7 a 8 litros";
         Q66.respostacoreta = 3;
         Q66.Level = 9;
         ListaQuestoes.Add(Q66);

         var Q67 = new Questione();
         Q67.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q67.Question = "Qual foi o primeiro país a ganhar a Copa do Mundo?";
         Q67.FirstQuestion = "Brasil";
         Q67.SecondQuestion = "Argentina";
         Q67.ThirdQuestion = "Uruguai";
         Q67.FourthQuestion = "Alemanha";
         Q67.FiveQuestion = "Itália";
         Q67.respostacoreta = 3;
         Q67.Level = 9;
         ListaQuestoes.Add(Q67);

         var Q68 = new Questione();
         Q68.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q68.Question = "Em que ano começou a Primeira Guerra Mundial?";
         Q68.FirstQuestion = "1912";
         Q68.SecondQuestion = "1914";
         Q68.ThirdQuestion = "1916";
         Q68.FourthQuestion = "1918";
         Q68.FiveQuestion = "1920";
         Q68.respostacoreta = 2;
         Q68.Level = 10;
         ListaQuestoes.Add(Q68);

         var Q69 = new Questione();
         Q69.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q69.Question = "Qual é o maior deserto do mundo?";
         Q69.FirstQuestion = "Deserto do Saara";
         Q69.SecondQuestion = "Deserto da Arábia";
         Q69.ThirdQuestion = "Deserto de Gobi";
         Q69.FourthQuestion = "Antártida";
         Q69.FiveQuestion = "Deserto de Kalahari";
         Q69.respostacoreta = 4;
         Q69.Level = 10;
         ListaQuestoes.Add(Q69);

         var Q70 = new Questione();
         Q70.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q70.Question = "Qual é o animal mais rápido do mundo?";
         Q70.FirstQuestion = "Guepardo";
         Q70.SecondQuestion = "Falcão-peregrino";
         Q70.ThirdQuestion = "Leão";
         Q70.FourthQuestion = "Leopardo";
         Q70.FiveQuestion = "Cavalo";
         Q70.respostacoreta = 2;
         Q70.Level = 1;
         ListaQuestoes.Add(Q70);

         var Q71 = new Questione();
         Q71.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q71.Question = "Quem foi o primeiro presidente dos Estados Unidos?";
         Q71.FirstQuestion = "Abraham Lincoln";
         Q71.SecondQuestion = "George Washington";
         Q71.ThirdQuestion = "John Adams";
         Q71.FourthQuestion = "Thomas Jefferson";
         Q71.FiveQuestion = "James Madison";
         Q71.respostacoreta = 2;
         Q71.Level = 1;
         ListaQuestoes.Add(Q71);

         var Q72 = new Questione();
         Q72.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q72.Question = "Quantos segundos tem um minuto?";
         Q72.FirstQuestion = "30";
         Q72.SecondQuestion = "45";
         Q72.ThirdQuestion = "60";
         Q72.FourthQuestion = "90";
         Q72.FiveQuestion = "120";
         Q72.respostacoreta = 3;
         Q72.Level = 2;
         ListaQuestoes.Add(Q72);

         var Q73 = new Questione();
         Q73.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q73.Question = "Qual é o metal líquido à temperatura ambiente?";
         Q73.FirstQuestion = "Ferro";
         Q73.SecondQuestion = "Mercúrio";
         Q73.ThirdQuestion = "Chumbo";
         Q73.FourthQuestion = "Prata";
         Q73.FiveQuestion = "Ouro";
         Q73.respostacoreta = 2;
         Q73.Level = 2;
         ListaQuestoes.Add(Q73);

         var Q74 = new Questione();
         Q74.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q74.Question = "Qual é a menor unidade de medida de tempo?";
         Q74.FirstQuestion = "Segundo";
         Q74.SecondQuestion = "Milissegundo";
         Q74.ThirdQuestion = "Nanosegundo";
         Q74.FourthQuestion = "Femtosegundo";
         Q74.FiveQuestion = "Yoctosegundo";
         Q74.respostacoreta = 5;
         Q74.Level = 3;
         ListaQuestoes.Add(Q74);

         var Q75 = new Questione();
         Q75.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q75.Question = "Em que ano ocorreu a Revolução Francesa?";
         Q75.FirstQuestion = "1776";
         Q75.SecondQuestion = "1789";
         Q75.ThirdQuestion = "1804";
         Q75.FourthQuestion = "1812";
         Q75.FiveQuestion = "1830";
         Q75.respostacoreta = 2;
         Q75.Level = 3;
         ListaQuestoes.Add(Q75);

         var Q76 = new Questione();
         Q76.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q76.Question = "Qual é o maior rio do mundo em extensão?";
         Q76.FirstQuestion = "Rio Nilo";
         Q76.SecondQuestion = "Rio Amazonas";
         Q76.ThirdQuestion = "Rio Yangtzé";
         Q76.FourthQuestion = "Rio Mississipi";
         Q76.FiveQuestion = "Rio Congo";
         Q76.respostacoreta = 1;
         Q76.Level = 4;
         ListaQuestoes.Add(Q76); 
         var Q77 = new Questione();
         Q77.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q77.Question = "Qual é a fórmula química da água?";
         Q77.FirstQuestion = "H2O";
         Q77.SecondQuestion = "CO2";
         Q77.ThirdQuestion = "O2";
         Q77.FourthQuestion = "NaCl";
         Q77.FiveQuestion = "H2SO4";
         Q77.respostacoreta = 1;
         Q77.Level = 4;
         ListaQuestoes.Add(Q77);

         var Q78 = new Questione();
         Q78.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q78.Question = "Qual é o continente mais seco do mundo?";
         Q78.FirstQuestion = "África";
         Q78.SecondQuestion = "Ásia";
         Q78.ThirdQuestion = "Antártica";
         Q78.FourthQuestion = "América do Sul";
         Q78.FiveQuestion = "Oceania";
         Q78.respostacoreta = 3;
         Q78.Level = 5;
         ListaQuestoes.Add(Q78);

         var Q79 = new Questione();
         Q79.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q79.Question = "Qual é a capital da Rússia?";
         Q79.FirstQuestion = "Moscovo";
         Q79.SecondQuestion = "São Petersburgo";
         Q79.ThirdQuestion = "Novosibirsk";
         Q79.FourthQuestion = "Kazan";
         Q79.FiveQuestion = "Samara";
         Q79.respostacoreta = 1;
         Q79.Level = 5;
         ListaQuestoes.Add(Q79);

         var Q80 = new Questione();
         Q80.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q80.Question = "Quantos minutos há em uma hora?";
         Q80.FirstQuestion = "30";
         Q80.SecondQuestion = "60";
         Q80.ThirdQuestion = "90";
         Q80.FourthQuestion = "120";
         Q80.FiveQuestion = "150";
         Q80.respostacoreta = 2;
         Q80.Level = 6;
         ListaQuestoes.Add(Q80);

         var Q81 = new Questione();
         Q81.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q81.Question = "Qual é a capital da França?";
         Q81.FirstQuestion = "Londres";
         Q81.SecondQuestion = "Paris";
         Q81.ThirdQuestion = "Berlim";
         Q81.FourthQuestion = "Madrid";
         Q81.FiveQuestion = "Roma";
         Q81.respostacoreta = 2;
         Q81.Level = 6;
         ListaQuestoes.Add(Q81);

         var Q82 = new Questione();
         Q82.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q82.Question = "Qual é a língua mais falada do mundo?";
         Q82.FirstQuestion = "Inglês";
         Q82.SecondQuestion = "Mandarim";
         Q82.ThirdQuestion = "Espanhol";
         Q82.FourthQuestion = "Árabe";
         Q82.FiveQuestion = "Francês";
         Q82.respostacoreta = 2;
         Q82.Level = 7;
         ListaQuestoes.Add(Q82);

         var Q83 = new Questione();
         Q83.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q83.Question = "Qual é o planeta mais próximo do Sol?";
         Q83.FirstQuestion = "Terra";
         Q83.SecondQuestion = "Marte";
         Q83.ThirdQuestion = "Mercúrio";
         Q83.FourthQuestion = "Vênus";
         Q83.FiveQuestion = "Júpiter";
         Q83.respostacoreta = 3;
         Q83.Level = 7;
         ListaQuestoes.Add(Q83);

         var Q84 = new Questione();
         Q84.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q84.Question = "Qual é o oceano mais profundo do mundo?";
         Q84.FirstQuestion = "Oceano Atlântico";
         Q84.SecondQuestion = "Oceano Índico";
         Q84.ThirdQuestion = "Oceano Pacífico";
         Q84.FourthQuestion = "Oceano Ártico";
         Q84.FiveQuestion = "Oceano Antártico";
         Q84.respostacoreta = 3;
         Q84.Level = 8;
         ListaQuestoes.Add(Q84);

         var Q85 = new Questione();
         Q85.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q85.Question = "Quem descobriu a penicilina?";
         Q85.FirstQuestion = "Louis Pasteur";
         Q85.SecondQuestion = "Alexander Fleming";
         Q85.ThirdQuestion = "Joseph Lister";
         Q85.FourthQuestion = "Marie Curie";
         Q85.FiveQuestion = "Robert Koch";
         Q85.respostacoreta = 2;
         Q85.Level = 8;
         ListaQuestoes.Add(Q85);

         var Q86 = new Questione();
         Q86.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q86.Question = "Qual é a forma mais comum de energia na Terra?";
         Q86.FirstQuestion = "Energia solar";
         Q86.SecondQuestion = "Energia eólica";
         Q86.ThirdQuestion = "Energia térmica";
         Q86.FourthQuestion = "Energia elétrica";
         Q86.FiveQuestion = "Energia cinética";
         Q86.respostacoreta = 1;
         Q86.Level = 9;
         ListaQuestoes.Add(Q86);

         var Q87 = new Questione();
         Q87.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q87.Question = "Qual é a teoria que explica a origem do universo?";
         Q87.FirstQuestion = "Teoria do Big Bang";
         Q87.SecondQuestion = "Teoria da Evolução";
         Q87.ThirdQuestion = "Teoria da Relatividade";
         Q87.FourthQuestion = "Teoria da Gravitação";
         Q87.FiveQuestion = "Teoria do Caos";
         Q87.respostacoreta = 1;
         Q87.Level = 9;
         ListaQuestoes.Add(Q87);

         var Q88 = new Questione();
         Q88.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q88.Question = "Qual foi o primeiro animal a ser clonado?";
         Q88.FirstQuestion = "Ovelha";
         Q88.SecondQuestion = "Gato";
         Q88.ThirdQuestion = "Cão";
         Q88.FourthQuestion = "Rato";
         Q88.FiveQuestion = "Macaco";
         Q88.respostacoreta = 1;
         Q88.Level = 10;
         ListaQuestoes.Add(Q88);

         var Q89 = new Questione();
         Q89.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q89.Question = "Qual é a capital da Itália?";
         Q89.FirstQuestion = "Florença";
         Q89.SecondQuestion = "Roma";
         Q89.ThirdQuestion = "Milão";
         Q89.FourthQuestion = "Veneza";
         Q89.FiveQuestion = "Nápoles";
         Q89.respostacoreta = 2;
         Q89.Level = 10;
         ListaQuestoes.Add(Q89);

         var Q90 = new Questione();
         Q90.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q90.Question = "Qual é a temperatura de ebulição da água?";
         Q90.FirstQuestion = "0°C";
         Q90.SecondQuestion = "50°C";
         Q90.ThirdQuestion = "100°C";
         Q90.FourthQuestion = "150°C";
         Q90.FiveQuestion = "200°C";
         Q90.respostacoreta = 3;
         Q90.Level = 10;
         ListaQuestoes.Add(Q90);

         var Q91 = new Questione();
         Q91.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q91.Question = "Quem foi o primeiro homem a pisar na Lua?";
         Q91.FirstQuestion = "Buzz Aldrin";
         Q91.SecondQuestion = "Neil Armstrong";
         Q91.ThirdQuestion = "Yuri Gagarin";
         Q91.FourthQuestion = "Michael Collins";
         Q91.FiveQuestion = "John Glenn";
         Q91.respostacoreta = 2;
         Q91.Level = 10;
         ListaQuestoes.Add(Q91);

         var Q92 = new Questione();
         Q92.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q92.Question = "Qual é a montanha mais alta do mundo?";
         Q92.FirstQuestion = "K2";
         Q92.SecondQuestion = "Monte Everest";
         Q92.ThirdQuestion = "Kangchenjunga";
         Q92.FourthQuestion = "Lhotse";
         Q92.FiveQuestion = "Makalu";
         Q92.respostacoreta = 2;
         Q92.Level = 10;
         ListaQuestoes.Add(Q92);

         var Q93 = new Questione();
         Q93.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q93.Question = "Qual é o oceano mais extenso do mundo?";
         Q93.FirstQuestion = "Oceano Atlântico";
         Q93.SecondQuestion = "Oceano Índico";
         Q93.ThirdQuestion = "Oceano Pacífico";
         Q93.FourthQuestion = "Oceano Ártico";
         Q93.FiveQuestion = "Oceano Antártico";
         Q93.respostacoreta = 3;
         Q93.Level = 10;
         ListaQuestoes.Add(Q93);

         var Q94 = new Questione();
         Q94.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q94.Question = "Quem escreveu 'O Pequeno Príncipe'?";
         Q94.FirstQuestion = "Jules Verne";
         Q94.SecondQuestion = "Antoine de Saint-Exupéry";
         Q94.ThirdQuestion = "Victor Hugo";
         Q94.FourthQuestion = "Marcel Proust";
         Q94.FiveQuestion = "Albert Camus";
         Q94.respostacoreta = 2;
         Q94.Level = 10;
         ListaQuestoes.Add(Q94);

         var Q95 = new Questione();
         Q95.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q95.Question = "Qual é o maior continente do mundo?";
         Q95.FirstQuestion = "África";
         Q95.SecondQuestion = "Ásia";
         Q95.ThirdQuestion = "América do Norte";
         Q95.FourthQuestion = "Europa";
         Q95.FiveQuestion = "Oceania";
         Q95.respostacoreta = 2;
         Q95.Level = 10;
         ListaQuestoes.Add(Q95);

         var Q96 = new Questione();
         Q96.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q96.Question = "Qual é a maior floresta tropical do mundo?";
         Q96.FirstQuestion = "Floresta Amazônica";
         Q96.SecondQuestion = "Floresta do Congo";
         Q96.ThirdQuestion = "Floresta de Taiga";
         Q96.FourthQuestion = "Floresta de Borneo";
         Q96.FiveQuestion = "Floresta de Nova Guiné";
         Q96.respostacoreta = 1;
         Q96.Level = 10;
         ListaQuestoes.Add(Q96);

         var Q97 = new Questione();
         Q97.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q97.Question = "Qual é a capital do Japão?";
         Q97.FirstQuestion = "Tóquio";
         Q97.SecondQuestion = "Seul";
         Q97.ThirdQuestion = "Pequim";
         Q97.FourthQuestion = "Bangcoc";
         Q97.FiveQuestion = "Hanoi";
         Q97.respostacoreta = 1;
         Q97.Level = 10;
         ListaQuestoes.Add(Q97);

         var Q98 = new Questione();
         Q98.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q98.Question = "Quantos planetas há no sistema solar?";
         Q98.FirstQuestion = "7";
         Q98.SecondQuestion = "8";
         Q98.ThirdQuestion = "9";
         Q98.FourthQuestion = "10";
         Q98.FiveQuestion = "11";
         Q98.respostacoreta = 2;
         Q98.Level = 10;
         ListaQuestoes.Add(Q98);

         var Q99 = new Questione();
         Q99.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q99.Question = "Qual é o nome do primeiro computador do mundo?";
         Q99.FirstQuestion = "ENIAC";
         Q99.SecondQuestion = "Colossus";
         Q99.ThirdQuestion = "Z3";
         Q99.FourthQuestion = "UNIVAC";
         Q99.FiveQuestion = "IBM 701";
         Q99.respostacoreta = 3;
         Q99.Level = 10;
         ListaQuestoes.Add(Q99);

         var Q100 = new Questione();
         Q100.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q100.Question = "Qual é a principal fonte de energia do Sol?";
         Q100.FirstQuestion = "Fusão nuclear";
         Q100.SecondQuestion = "Fissão nuclear";
         Q100.ThirdQuestion = "Energia térmica";
         Q100.FourthQuestion = "Energia solar";
         Q100.FiveQuestion = "Energia elétrica";
         Q100.respostacoreta = 1;
         Q100.Level = 10;
         ListaQuestoes.Add(Q100);
        
         ProximaQuestao();
      }
   }
}
