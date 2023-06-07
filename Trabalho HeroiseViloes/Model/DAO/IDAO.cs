using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroisViloes.Model.DAO
{
    interface IDao
    {
        bool atualizar(object objeto);
        bool excluir(int id);
        bool inserir(object objeto);
        void consultar(DataGridView dt_view, string filtro);
    }
}