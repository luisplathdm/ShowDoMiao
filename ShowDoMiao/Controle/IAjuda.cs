using System.Security.Cryptography.X509Certificates;

namespace Controle

{
  public abstract class IAjuda
  {
    protected Button buttonResposta01;
    protected Button buttonResposta02;
    protected Button buttonResposta03;
    protected Button buttonResposta04;
    protected Button buttonResposta05;
    protected Frame FrameAjuda;
      
      public void ConfigurarDesenho(Button buttonResposta01, Button buttonResposta02,Button buttonResposta03, Button buttonResposta04, Button buttonResposta05)
      {
        this.buttonResposta01 = buttonResposta01;
        this.buttonResposta02 = buttonResposta02;
        this.buttonResposta03 = buttonResposta03;
        this.buttonResposta04 = buttonResposta04;
        this.buttonResposta05 = buttonResposta05;
      }
      public void ConfigurarDesenho(Frame FrameAjuda)
      {
         this.FrameAjuda = FrameAjuda; 
      }
       public abstract void RealizaAjuda (Questione questione);  
  }
}
