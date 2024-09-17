namespace Controle
{
    public class Questione
    {
       public string Question;

       public string FirstQuestion;

       public string SecondQuestion;

       public string ThirdQuestion;

       public string FourthQuestion;

        public string FiveQuestion;

       public int respostacoreta =0;

       public int QuestioneLevel;

       private Label labelPergunta;

       private Button buttonResposta01;

       private Button buttonResposta02;

       private Button buttonResposta03;

       private Button buttonResposta04; 

       private Button buttonResposta05;


        public Questione()
        {

        }
       
        public Questione(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
                {
                    labelPergunta = lp;
                    buttonResposta01 = BT01;
                    buttonResposta02 = BT02;
                    buttonResposta03 = BT03;
                    buttonResposta04 = BT04;
                    buttonResposta05 = BT05;
                }
       public void ConfigurarDesenho(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
                {
                    labelPergunta = lp;
                    buttonResposta01 = BT01;
                    buttonResposta02 = BT02;
                    buttonResposta03 = BT03;
                    buttonResposta04 = BT04;
                    buttonResposta05 = BT05;
                }
       public void Desenhar ()
                {
                    labelPergunta.Text = Question;
                    buttonResposta01.Text = FirstQuestion;
                    buttonResposta02.Text = SecondQuestion;
                    buttonResposta03.Text = ThirdQuestion;
                    buttonResposta04.Text = FourthQuestion;
                    buttonResposta05.Text = FiveQuestion;
                }
       public bool VerificarSeEstaCorreta(int RR )
                {
                if (respostacoreta == RR)
                    { 
                        var btn = QualBTN( RR);
                        btn.BackgroundColor = Colors.Green;
                        return true;
                    }
                    else 
                    {
                        var btnCorreto =  QualBTN(respostacoreta);
                        var btnIncorreto = QualBTN(RR);
                        btnCorreto.BackgroundColor = Colors.Yellow;
                        btnIncorreto.BackgroundColor = Colors.Red;
                        return false;
                    }
                }
            private  Button  QualBTN(int RR)
            {
                    if (RR == 1) return buttonResposta01;
                     else if (RR == 2) return buttonResposta02;
                    else if (RR == 3) return buttonResposta03;
                     else if (RR == 4) return buttonResposta04;
                    else if (RR == 5) return buttonResposta05;
                     else return null;
            }
 }
}