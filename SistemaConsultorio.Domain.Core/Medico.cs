using System;

namespace SistemaConsultorio.Domain.Core
{
    public class Medico
    {
        public int IdMedico { get; set; }
        public int IdEspecialidade { get; set; }
        public string NomeMedico { get; set; }
        public string NumeroCRM { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual Especialidade Especialidade { get; set; }
    }
}
