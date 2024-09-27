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
    Random random = new Random();

    // Lista de 100 perguntas de texto para intercalar
    string[] perguntasTexto = {
        "Qual é a capital do Brasil?",
        "Quem foi o primeiro homem a pisar na Lua?",
        "Em que ano começou a Primeira Guerra Mundial?",
        "Qual é o maior país do mundo em extensão territorial?",
        "Quem escreveu 'Dom Quixote'?",
        "Qual é o elemento químico representado pelo símbolo 'O'?",
        "Quem pintou o teto da Capela Sistina?",
        "Qual é o animal mais rápido do mundo?",
        "Qual é o rio mais extenso do mundo?",
        "Quem é o autor de 'Harry Potter'?",
        "Qual é a moeda do Japão?",
        "Quem inventou a lâmpada elétrica?",
        "Em que continente fica o Deserto do Saara?",
        "Qual é o nome do maior oceano do mundo?",
        "Quem descobriu a América?",
        "Qual país é conhecido como a terra do sol nascente?",
        "Quem é o autor de 'O Senhor dos Anéis'?",
        "Qual é o país mais populoso do mundo?",
        "Em que ano o Brasil ganhou sua primeira Copa do Mundo?",
        "Qual é a fórmula química da água?",
        "Em que ano aconteceu o Descobrimento do Brasil?",
        "Quem é o autor de 'Romeu e Julieta'?",
        "Qual é o nome do planeta mais próximo do Sol?",
        "Qual é o nome da galáxia onde a Terra está localizada?",
        "Qual foi a primeira mulher a ganhar um Prêmio Nobel?",
        "Qual é o nome da principal praça de Moscou?",
        "Qual é a capital da Itália?",
        "Qual é o nome do monte mais alto do mundo?",
        "Quem foi o fundador do Facebook?",
        "Quem pintou 'A Última Ceia'?",
        "Qual é a capital da Argentina?",
        "Em que país fica a cidade de Jerusalém?",
        "Quem escreveu 'Os Miseráveis'?",
        "Qual é o maior planeta do Sistema Solar?",
        "Quem inventou o avião?",
        "Qual é o nome do primeiro satélite artificial lançado ao espaço?",
        "Qual é a capital da Alemanha?",
        "Quem foi o primeiro presidente dos Estados Unidos?",
        "Qual é o órgão humano responsável pelo bombeamento de sangue?",
        "Em que país as pirâmides de Gizé estão localizadas?",
        "Quem descobriu a penicilina?",
        "Qual é o nome da maior floresta tropical do mundo?",
        "Qual é a capital da França?",
        "Quem foi o primeiro imperador de Roma?",
        "Qual é o menor país do mundo em território?",
        "Quem foi o responsável pela teoria da relatividade?",
        "Qual é a língua oficial do Brasil?",
        "Quem escreveu 'Cem Anos de Solidão'?",
        "Qual é o maior deserto do mundo?",
        "Qual é o nome da montanha mais alta da América do Sul?",
        "Quem descobriu o Brasil?",
        "Qual é a capital da Inglaterra?",
        "Qual é o nome da primeira estação espacial internacional?",
        "Quem foi o criador da Microsoft?",
        "Qual é o país mais frio do mundo?",
        "Qual é o símbolo químico do ouro?",
        "Quem foi o primeiro homem a circunavegar a Terra?",
        "Qual é o maior arquipélago do mundo?",
        "Qual é o nome da constelação em forma de urso?",
        "Qual foi o primeiro filme animado da Disney?",
        "Quem foi o primeiro santo canonizado pelo Vaticano?",
        "Em que ano caiu o muro de Berlim?",
        "Qual é a capital da China?",
        "Quem foi o primeiro ser humano a realizar um voo espacial?",
        "Qual é o nome da nave que levou o homem à Lua?",
        "Qual foi o primeiro presidente negro dos Estados Unidos?",
        "Qual é o nome do mar que separa a Europa da África?",
        "Quem foi o responsável pela Teoria da Evolução?",
        "Em que país foram realizados os primeiros Jogos Olímpicos?",
        "Qual é o nome da língua falada na maior parte da América do Sul?",
        "Quem foi o primeiro rei de Portugal?",
        "Qual é a altura do Monte Everest?",
        "Quem escreveu 'A Revolução dos Bichos'?",
        "Qual é o nome da segunda maior floresta tropical do mundo?",
        "Quem foi o pintor de 'Guernica'?",
        "Em que continente está localizada a Austrália?",
        "Quem foi o criador do iPhone?",
        "Qual é o nome da maior catedral gótica do mundo?",
        "Quem escreveu 'Orgulho e Preconceito'?",
        "Qual é o nome da praça central de Paris?",
        "Quem foi o criador do Google?",
        "Qual é o nome do continente onde se encontra o Polo Sul?",
        "Qual foi a primeira mulher a ser eleita presidente do Brasil?",
        "Quem inventou o telégrafo?",
        "Em que país fica o Taj Mahal?",
        "Qual é o nome do satélite natural da Terra?",
        "Quem foi o autor de 'Dom Casmurro'?",
        "Qual é o nome do maior lago da América do Sul?",
        "Qual é o nome da capital do México?",
        "Quem foi o criador da teoria da seleção natural?",
        "Qual é o nome do maior vulcão ativo do mundo?",
        "Quem foi o responsável pela criação da vacina da varíola?"
    };

    // Respostas para perguntas de texto
    Dictionary<string, string[]> respostasTexto = new Dictionary<string, string[]>()
    {
       { "Qual é a capital do Brasil?", new[] { "Brasília", "São Paulo", "Rio de Janeiro", "Salvador", "Curitiba" } },
        { "Quem foi o primeiro homem a pisar na Lua?", new[] { "Neil Armstrong", "Buzz Aldrin", "Yuri Gagarin", "John Glenn", "Michael Collins" } },
        { "Em que ano começou a Primeira Guerra Mundial?", new[] { "1914", "1918", "1939", "1945", "1905" } },
        { "Qual é o maior país do mundo em extensão territorial?", new[] { "Rússia", "China", "Estados Unidos", "Canadá", "Brasil" } },
        { "Quem escreveu 'Dom Quixote'?", new[] { "Miguel de Cervantes", "William Shakespeare", "Jorge Luis Borges", "Gabriel García Márquez", "Camões" } },
        { "Qual é o elemento químico representado pelo símbolo 'O'?", new[] { "Oxigênio", "Ouro", "Osmium", "Zinco", "Hélio" } },
        { "Quem pintou o teto da Capela Sistina?", new[] { "Michelangelo", "Leonardo da Vinci", "Rafael", "Donatello", "Botticelli" } },
        { "Qual é o animal mais rápido do mundo?", new[] { "Falcão-peregrino", "Guepardo", "Cavalo", "Leopardo", "Águia" } },
        { "Qual é o rio mais extenso do mundo?", new[] { "Rio Nilo", "Rio Amazonas", "Rio Yangtze", "Rio Mississippi", "Rio Ganges" } },
        { "Quem é o autor de 'Harry Potter'?", new[] { "J.K. Rowling", "Stephen King", "George R.R. Martin", "J.R.R. Tolkien", "Agatha Christie" } },
        { "Qual é a moeda do Japão?", new[] { "Iene", "Dólar", "Euro", "Yuan", "Peso" } },
        { "Quem inventou a lâmpada elétrica?", new[] { "Thomas Edison", "Nikola Tesla", "Alexander Graham Bell", "Benjamin Franklin", "Isaac Newton" } },
        { "Em que continente fica o Deserto do Saara?", new[] { "África", "Ásia", "América do Sul", "América do Norte", "Europa" } },
        { "Qual é o nome do maior oceano do mundo?", new[] { "Oceano Pacífico", "Oceano Atlântico", "Oceano Índico", "Oceano Ártico", "Oceano Antártico" } },
        { "Quem descobriu a América?", new[] { "Cristóvão Colombo", "Vasco da Gama", "Pedro Álvares Cabral", "Américo Vespúcio", "Leif Erikson" } },
        { "Qual país é conhecido como a terra do sol nascente?", new[] { "Japão", "China", "Coreia do Sul", "Vietnã", "Tailândia" } },
        { "Quem é o autor de 'O Senhor dos Anéis'?", new[] { "J.R.R. Tolkien", "C.S. Lewis", "George R.R. Martin", "J.K. Rowling", "Isaac Asimov" } },
        { "Qual é o país mais populoso do mundo?", new[] { "China", "Índia", "Estados Unidos", "Indonésia", "Brasil" } },
        { "Em que ano o Brasil ganhou sua primeira Copa do Mundo?", new[] { "1958", "1962", "1970", "1994", "2002" } },
        { "Qual é a fórmula química da água?", new[] { "H2O", "CO2", "O2", "N2", "HCl" } },
        { "Em que ano aconteceu o Descobrimento do Brasil?", new[] { "1500", "1492", "1808", "1600", "1532" } },
        { "Quem é o autor de 'Romeu e Julieta'?", new[] { "William Shakespeare", "Miguel de Cervantes", "Camões", "Jane Austen", "Edgar Allan Poe" } },
        // Adicione as demais perguntas e respostas aqui no mesmo formato
    };

    // Função para perguntas mais complexas para níveis mais altos
    string GerarPerguntaComplexa(int level)
    {
        int a = random.Next(10, 100 * level);
        int b = random.Next(10, 100 * level);
        int c = random.Next(10, 100 * level);
        return $"{a} * {b} + {c}";
    }

    // Função para perguntas muito difíceis (nível 10)
    string GerarPerguntaImpossivel()
    {
        int a = random.Next(1000, 10000);
        int b = random.Next(1000, 10000);
        return $"{a} * {b} % 37";
    }

    int perguntasTextoIndex = 0;

    for (int level = 1; level <= 10; level++)
    {
        for (int i = 0; i < 10; i++) // 10 perguntas por nível
        {
            var questao = new Questione();
            questao.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            questao.Level = level;

            if (level <= 5 && perguntasTextoIndex < perguntasTexto.Length)
            {
                // Níveis 1 a 5: perguntas de texto
                string perguntaTexto = perguntasTexto[perguntasTextoIndex++];
                questao.Question = perguntaTexto;
                string[] opcoes = respostasTexto[perguntaTexto];
                questao.FirstQuestion = opcoes[0];
                questao.SecondQuestion = opcoes[1];
                questao.ThirdQuestion = opcoes[2];
                questao.FourthQuestion = opcoes[3];
                questao.FiveQuestion = opcoes[4];
                questao.respostacoreta = 1; // A primeira é correta
            }
            else if (level <= 9)
            {
                // Níveis 6 a 9: perguntas complexas
                questao.Question = GerarPerguntaComplexa(level);
                questao.FirstQuestion = (random.Next(10, 100 * level)).ToString();
                questao.SecondQuestion = (random.Next(10, 100 * level)).ToString();
                questao.ThirdQuestion = (random.Next(10, 100 * level)).ToString();
                questao.FourthQuestion = (random.Next(10, 100 * level)).ToString();
                questao.FiveQuestion = (random.Next(10, 100 * level)).ToString();
                questao.respostacoreta = random.Next(1, 5);
            }
            else
            {
                // Nível 10: perguntas muito difíceis
                questao.Question = GerarPerguntaImpossivel();
                questao.FirstQuestion = random.Next(10000, 100000).ToString();
                questao.SecondQuestion = random.Next(10000, 100000).ToString();
                questao.ThirdQuestion = random.Next(10000, 100000).ToString();
                questao.FourthQuestion = random.Next(10000, 100000).ToString();
                questao.FiveQuestion = random.Next(10000, 100000).ToString();
                questao.respostacoreta = random.Next(1, 5);
            }

            ListaQuestoes.Add(questao); // Adicionando à lista
        }
    }

    ProximaQuestao();
}


   }
}
