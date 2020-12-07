using System;

namespace classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;
        public bool validarCPF(string documento){
            
            if(cpf != ""){
                return true;
            }


            return true;
        }
    }
}