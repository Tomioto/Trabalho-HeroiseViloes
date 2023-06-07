using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroisViloes.Model.Entities
{
    class SuperVilao : Pessoa
    {
        //Atributos
        private string nomeVilao;
        private string planetaOrigem;
        private string parceiro;
        private string superPoder;

        //Construtor
        public SuperVilao() : base()
        {
            nomeVilao = null;
            planetaOrigem = null;
            parceiro = null;
            superPoder = null;
        }

        //Propriedades

        public string NomeVilao
        {
            get { return nomeVilao; }
            set { nomeVilao = value; }
        }

        public string PlanetaOrigem
        {
            get { return planetaOrigem; }
            set { planetaOrigem = value; }
        }

        public string Parceiro
        {
            get { return parceiro; }
            set { parceiro = value; }
        }

        public string SuperPoder
        {
            get { return superPoder; }
            set { superPoder = value; }
        }

        public override void calcularIdade(int anoAtual)
        {
            base.Idade = (anoAtual - base.AnoNasc);
        }
    }
}