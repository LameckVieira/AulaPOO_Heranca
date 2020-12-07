namespace classes
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string inscicaoEstadual;

        public bool ValidarCNPJ(string documento){

            if(documento != ""){
                return true;
            }

            return false;
        }
    }
}