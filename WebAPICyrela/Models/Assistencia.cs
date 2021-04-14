using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICyrela.Models
{

    [Table("ASSISTENCIA")]
    public class Assistencia
    {
        [Key]
        [Column("IDASSISTENCIA")]
        public int IdAssistencia { get; set; }

        [Column("NOMEATIVIDADE")]
        public String NomeAtividade { get; set; }

        [Column("DTINICIO")]
        public String DtInicio { get; set; }

        [Column("DTTERMINO")]
        public String DtFim { get; set; }

        [Column("TIPOATIVIDADE")]
        public String TipoAtividade { get; set; }

        [Column("ASSUNTO")]
        public String Assunto { get; set; }

        [Column("EMPREENDIMENTO")]
        public String Empreendimento { get; set; }

        [Column("BLOCO")]
        public String Bloco { get; set; }

        [Column("UNIDADE")]
        public String Unidade { get; set; }

        public Assistencia(int idAssistencia, string nomeAtvidade, string dtInicio, string dtFim, string tipoAtividade, string assunto, string empreendimento, string bloco, string unidade)
        {
            IdAssistencia = idAssistencia;
            NomeAtividade = nomeAtvidade;
            DtInicio = dtInicio;
            DtFim = dtFim;
            TipoAtividade = tipoAtividade;
            Assunto = assunto;
            Empreendimento = empreendimento;
            Bloco = bloco;
            Unidade = unidade;
        }

        public Assistencia()
        {
        }
    }
}
