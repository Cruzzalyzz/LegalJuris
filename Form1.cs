using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LegalJuris
{
    public partial class Form1 : Form
    {

        public Contexto Contexto { get; set; }
        public Form1()
        {
            InitializeComponent();

            Contexto = new Contexto();

            var clientes = Contexto.ObjetoCliente.ToArray();
            var casos = Contexto.ObjetoCaso.ToArray();
            var comarcas = Contexto.ObjetoComarca.ToArray();
            var foros = Contexto.ObjetoForo.ToArray();
            var varas = Contexto.ObjetoVara.ToArray();
            var responsaveis = Contexto.ObjetoResponsavel.ToArray();

            comboCliente.Items.AddRange(clientes);
            comboCliente.DisplayMember = "ClienteNome";
            comboCliente.ValueMember = "ClienteId";

            comboCaso.Items.AddRange(casos);
            comboCaso.DisplayMember = "CasoNome";
            comboCaso.ValueMember = "CasoeId";

            comboComarca.Items.AddRange(comarcas);
            comboComarca.DisplayMember = "ComarcaNome";
            comboComarca.ValueMember = "ComarcaId";

            comboForo.Items.AddRange(foros);
            comboForo.DisplayMember = "ForoNome";
            comboForo.ValueMember = "ForoId";

            comboVara.Items.AddRange(varas);
            comboVara.DisplayMember = "VaraNome";
            comboVara.ValueMember = "VaraId";

            comboResponsavel.Items.AddRange(responsaveis);
            comboResponsavel.DisplayMember = "NomeResponsavel";
            comboResponsavel.ValueMember = "ResonsavelId";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            var caso = comboCaso.SelectedItem as Caso;
            var comarca = comboComarca.SelectedItem as Comarca;
            var responsavel = comboResponsavel.SelectedItem as Responsavel;
            var numeroProcessoValue = numeroProcesso.Text;

            var processo = new Processo()
            {
                CasoId = caso.CasoId,
                ComarcaId = comarca.ComarcaId,
                NumeroProcesso = numeroProcesso.Text,
                ResonsavelId = responsavel.ResonsavelId,
            };

            Contexto.ObjetoProcesso.Add(processo);
            Contexto.SaveChanges();

            MessageBox.Show("Processo incluído com sucesso.", null, MessageBoxButtons.OK);

            comboCliente.SelectedItem = null;
            comboCaso.SelectedItem = null;
            comboComarca.SelectedItem = null;
            comboForo.SelectedItem = null;
            comboVara.SelectedItem = null;
            comboResponsavel.SelectedItem = null;
            numeroProcesso.Text = string.Empty;

        }
    }
}
