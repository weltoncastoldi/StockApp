using StockApp.Busines.Entties;
using StockApp.Busines.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp.WindowsForms.Cadastros
{
    public partial class frmCategoria : Form
    {
        private readonly ICategoriaRepository _categoriaRepositorio;
        public frmCategoria()
        {
            InitializeComponent();

        }
        public frmCategoria(ICategoriaRepository categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novaCategoria = new Categoria();
            novaCategoria.Nome = txtCategoria.Text;
            novaCategoria.Status = chkStatus.Checked;

            var resultado = _categoriaRepositorio.Incluir(novaCategoria);
            if (resultado)
            {
                MessageBox.Show("Categoria cadastrada com Sucesso!!");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastra Tente Novamente");
            }
        }
    }
}
