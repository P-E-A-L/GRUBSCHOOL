using System;

namespace GRUBSCHOOL.Domain.Shared.Entidades
{
    public class Identificacao 
    {
        public int PessoaID { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public int TipoIdentificacaoID { get; set; }
        public virtual TipoIdentificacao TipoIdentificacao { get; set; }
        public string Numero { get; set; }
        public const int TamanhoMaximoNumero = 30;
        public int LocalEmissaoId { get; set; }
        public virtual Municipio LocalEmissao { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
