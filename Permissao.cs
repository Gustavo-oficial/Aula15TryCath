using System;

namespace Aula15TryCatch
{
    public class Permissao
    {
        
        private bool Acesso { get; set; }

        public void Autorizar(){
        
          try{

                Console.WriteLine("Qual senha?");
                Acesso = Boolean.Parse( Console.ReadLine() );

                if(Acesso == true){
                   Console.WriteLine("Acesso permiitido");
                }

            }catch(Exception ex){

                Console.WriteLine("Erro nos dados inseridos"+ex);

            }
            
           


        }

    }
}