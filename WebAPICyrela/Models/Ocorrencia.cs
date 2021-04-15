using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICyrela.Models
{
    [Table("OCORRENCIA")]
    public class Ocorrencia
    {
        [Key]
        [Column("IDOCORRENCIA")]
        public int IdOcorrencia { get; set; }
        [Column("TICKETNUMBER")]
        public int TickerNumber { get; set; }
        [Column("CLIENTEUNIDADE")]
        public String ClienteUnidade { get; set; }
        [Column("DESCRICAO")]
        public String Descricao { get; set; }
        [Column("EMPREENDIMENTO")]
        public String Empreendimento { get; set; }
        [Column("BLOCO")]
        public String Bloco { get; set; }
        [Column("UNIDADE")]
        public String Unidade { get; set; }
        [Column("BANDEIRA")]
        public String Bandeira { get; set; }

        public Ocorrencia()
        {
        }

        public Ocorrencia(int idOcorrencia, int tickerNumber, string clienteUnidade, string descricao, string empreendimento, string bloco, string unidade, string bandeira)
        {
            IdOcorrencia = idOcorrencia;
            TickerNumber = tickerNumber;
            ClienteUnidade = clienteUnidade;
            Descricao = descricao;
            Empreendimento = empreendimento;
            Bloco = bloco;
            Unidade = unidade;
            Bandeira = bandeira;
        }

    }
}
