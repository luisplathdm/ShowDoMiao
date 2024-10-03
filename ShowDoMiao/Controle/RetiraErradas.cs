namespace Controle
{
    public class RetiraErrada : IAjuda
    {
        public override void RealizaAjuda (Questione questione)
        { 
            switch (questione.respostacoreta)
            {
                case 1:
                    buttonResposta02.IsVisible = false;
                    buttonResposta03.IsVisible = false;
                    buttonResposta04.IsVisible = false;
                 break;

                case 2:
                     buttonResposta01.IsVisible = false;
                     buttonResposta03.IsVisible = false;
                     buttonResposta05.IsVisible = false;
                 break;

            }
        }
    }
}