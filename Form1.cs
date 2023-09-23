using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F8
{
    public partial class FormCalculoFolhaPagamento : Form
    {
        public FormCalculoFolhaPagamento()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSalarioHora.Text, out decimal salarioHora) &&
                      decimal.TryParse(txtHorasTrabalhadas.Text, out decimal horasTrabalhadas))
            {
                decimal salarioBruto = salarioHora * horasTrabalhadas;
                decimal inss = CalcularINSS(salarioBruto);
                decimal ir = CalcularIR(salarioBruto);
                decimal salarioLiquido = salarioBruto - inss - ir;

                lblSalarioBruto.Text = $"Salário Bruto: {salarioBruto:C}";
                lblINSS.Text = $"INSS: {inss:C}";
                lblIR.Text = $"IR: {ir:C}";
                lblSalarioLiquido.Text = $"Salário Líquido: {salarioLiquido:C}";
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalcularINSS(decimal salarioBruto)
        {
            // Simples cálculo de INSS
            if (salarioBruto <= 1100.00M)
                return salarioBruto * 0.075M;
            else if (salarioBruto <= 2203.48M)
                return salarioBruto * 0.09M;
            else if (salarioBruto <= 3305.22M)
                return salarioBruto * 0.12M;
            else if (salarioBruto <= 6433.57M)
                return salarioBruto * 0.14M;
            else
                return 6433.57M * 0.14M; // Valor máximo de contribuição
        }

        private decimal CalcularIR(decimal salarioBruto)
        {
            // Simples cálculo de IR
            if (salarioBruto <= 1903.98M)
                return 0;
            else if (salarioBruto <= 2826.65M)
                return (salarioBruto * 0.075M) - 142.80M;
            else if (salarioBruto <= 3751.05M)
                return (salarioBruto * 0.15M) - 354.80M;
            else if (salarioBruto <= 4664.68M)
                return (salarioBruto * 0.225M) - 636.13M;
            else
                return (salarioBruto * 0.275M) - 869.36M;
        }
    }
}
