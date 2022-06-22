namespace AvaliacaoTres
{
    public partial class frmMovimento : Form
    {
        static List<contaBancaria> _listConta = new List<contaBancaria>();
        private contaBancaria _contaAtual = null;
        private int operacao = 0;

        public frmConta()
        {
            InitializeComponent();
            this.Size = new Size(685, 255);
            _listConta = contaBancaria.geraContas();
        }
    }
}