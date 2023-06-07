using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroisViloes.Model.Entities
{
    class AmigoHeroi : Pessoa
    {
        //Atributos
        private string nomeAmigo;
        private string atividadeProfissional;
        private string hobby;

        //Construtor
        public AmigoHeroi() : base()
        {
            nomeAmigo = null;
            atividadeProfissional = null;
            hobby = null;
        }

        //Propriedades

        public string NomeAmigo
        {
            get { return nomeAmigo; }
            set { nomeAmigo = value; }
        }

        public string AtividadeProfissional
        {
            get { return atividadeProfissional; }
            set { atividadeProfissional = value; }
        }

        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }

        }

        public override void calcularIdade(int anoAtual)
        {
            base.Idade = anoAtual - base.AnoNasc;
        }
    }
}
