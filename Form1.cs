using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalcularPreco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txt_ValorProduto.Text.ToString(), CultureInfo.InvariantCulture);
            double quantidade = double.Parse(txt_Quantidade.Text.ToString(), CultureInfo.InvariantCulture);
            double res = valor * quantidade;
            btn_Calcular.BackColor = Color.AliceBlue;
            btn_Calcular.ForeColor = Color.Green;

            //lb_Resultado.ForeColor = Color.Red;
            //lb_Resultado.Text = "Os campos de valores não podem ser vazios";
            //txt_ValorProduto.Focus();

            lb_Resultado.Text = $"O produto com valor de {valor} multiplicado pela quantidade de {quantidade} equivale a R${res.ToString("F2", CultureInfo.InvariantCulture)} da moeda Virgente";
        }
    }
}
