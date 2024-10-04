 namespace Controle
     {
      public class Universitarios: IAjuda
       {
        public override void RealizaAjuda(Questione questione)
           {
            var porcentagem = 100;
               for(int i=0; i<5; i++)
               {
                  int numAleatorio=0;
                  if (porcentagem>0)
                {
                numAleatorio=Random.Shared.Next(0,porcentagem);
                porcentagem-=numAleatorio;  
                 }
              switch(i)
              {
                case 0:
                     buttonResposta01.Text+="-"+numAleatorio.ToString()+"%";
                    break;
                  case 1:
                      buttonResposta02.Text+="-"+numAleatorio.ToString()+"%";
                      break;  
                  case 2:
                      buttonResposta03.Text+="-"+numAleatorio.ToString()+"%";
                      break;  
                  case 3:
                     buttonResposta04.Text+="-"+numAleatorio.ToString()+"%";
                      break;   
                  case 4:
                      buttonResposta05.Text+="-"+numAleatorio.ToString()+"%";
                    break;     
             }
             }
        }
     }
            
 }