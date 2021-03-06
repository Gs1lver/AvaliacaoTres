namespace AvaliacaoTres
{
    public partial class frmMovimento : Form
    {
        static List<contaBancaria> lstConta = new List<contaBancaria>();
        private contaBancaria _contaAtual = null;
        private int operacao = 0; //1 para Depositar e 2 para Sacar


        public frmMovimento()
        {
            InitializeComponent();
            this.Size = new Size(685, 255);
            lstConta = contaBancaria.geraContas();
        }

        private void frmMovimento_Load(object sender, EventArgs e)
        {
            rdComum.Enabled = false;
            rdEspecial.Enabled = false;
            txtLimite.Enabled = false;
            txtSaldo.Enabled = false;

        }

        private void bloqueiaGrpSuperior()
        {
            grpSuperior.Enabled = false;
            btnDepositar.Enabled = false;
            btnSacar.Enabled = false;
            btnSair.Enabled = false;
            this.Size = new Size(685, 365);
            grpMovimento.Visible = true;
            grpMovimento.Enabled = true;

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            bloqueiaGrpSuperior();
            operacao = 1;
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            bloqueiaGrpSuperior();
            operacao = 2;
        }
        private void dtMovimento_Leave(object sender, EventArgs e)
        {
            if ((dtMovimento.Value.DayOfWeek == DayOfWeek.Sunday) ||
                (dtMovimento.Value.DayOfWeek == DayOfWeek.Saturday))
            {
                MessageBox.Show("N?o ? poss?vel lan?ar dados aos s?bados e aos domingos!","Data Inv?lida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtMovimento.Focus();
            }

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtValor.Text) < 0)
            {
                MessageBox.Show("N?o ? poss?vel lan?ar valores negativos!", "Valor Inv?lido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if(operacao == 1)
            {
                double Saldo = Convert.ToDouble(txtSaldo.Text);
                Saldo += Convert.ToDouble(txtValor.Text);
                txtSaldo.Text = Convert.ToString(Saldo);
            }
            else if(operacao == 2)
            {
                double Saldo = Convert.ToDouble(txtSaldo.Text);
                Saldo -= Convert.ToDouble(txtValor.Text);
                txtSaldo.Text = Convert.ToString(Saldo);
            }
            else
            {
                MessageBox.Show("PQP DEU MUITO ERRO");
            }

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}