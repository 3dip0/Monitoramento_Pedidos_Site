using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoramento_Pedidos_Site
{
    public partial class Monitor : Form
    {

        MySQL instanciaMySql = new MySQL();

        string sql;

        int i;
        int thread=0;
        public Monitor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

        }
        string Venda;
        string Cliente;
        string Carrinho;
        string Pagamento;
        string taxa;
        int rowsCar;
        Boolean semEnd;


        int pedido=0;
        int numeroPedido;
        int numeroPedidoUpdate;

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                thread = 2000;
                Thread.Sleep(thread);


                CarregarDados();
                

                //impressaoPedido.ShowDialog();
                // Some call to your data access layer to get dt

            }
        }
        private void CarregarDados()
        {

            MySqlConnection conn = instanciaMySql.GetConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                sql = "SELECT cliente.nome as \"Nome\", " +
                   "venda.numero_venda_site as \"Numero Pedido Site\", " +
                   "cliente.telefone as \"Telefone\", " +
                   "cliente.endereco as \"Endereco\", " +
                   "cliente.numero as \"Numero\", " +
                   "cliente.bairro as \"Bairro\", " +
                   "venda.valor_total as \"Valor Total\", " +
                   "venda.pedidoAceito as \"Status Pedido\" " +
                   "from Venda as venda " +
                   "inner join Cliente as cliente " +
                   $"on venda.id_cliente = cliente.id where venda.pedidoAceito=0 order by venda.numero_venda_site desc";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                
                dgvVendas.Invoke((Action)(() => dgvVendas.DataSource = ds));
                dgvVendas.Invoke((Action)(() => dgvVendas.ClearSelection()));

                dgvVendas.Invoke((Action)(() => i = dgvVendas.Rows.Count));
                MySqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    pedido = Convert.ToInt32(leitor["Status Pedido"].ToString());
                    numeroPedido = Convert.ToInt32(leitor["Numero Pedido Site"].ToString());
                    if (Convert.ToInt32(leitor["Numero Pedido Site"].ToString()) > i)
                    {
                        
                        playSimpleSound();
                        Thread.Sleep(3000);
                    }
                    i = Convert.ToInt32(leitor["Numero Pedido Site"].ToString());
                    if (leitor != null)
                        leitor.Close();
                    
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void aceitarPedido_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = instanciaMySql.GetConnection();

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();



                sql = "UPDATE Venda " +
                    " SET pedidoAceito=@pedidoAceito" +
                    
                    $" WHERE numero_venda_site=@numero_venda_site";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("pedidoAceito", 1);
                cmd.Parameters.AddWithValue("numero_venda_site", numeroPedidoUpdate);

                cmd.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            aceitarPedido.Visible = false;
            
        }

        private void playSimpleSound()
            
        {
           
                SoundPlayer simpleSound = new SoundPlayer("novoPedido.wav");
                simpleSound.Play();
            
           
        }

        private void dgvVendas_DoubleClick(object sender, EventArgs e)
        {
            numeroPedido = Convert.ToInt32(dgvVendas.SelectedCells[1].Value.ToString());
            pedido = Convert.ToInt32(dgvVendas.SelectedCells[7].Value.ToString());
            aceitarPedido.Visible = true;
            aceitarPedido.Text = "Aceitar Pedido numero: " + numeroPedido;
            numeroPedidoUpdate = numeroPedido;
            thread = 0;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
            playSimpleSound();
            
        }
    }
}
