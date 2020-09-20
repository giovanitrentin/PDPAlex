using DAO;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care22Aula71
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            de.SelectedItem = "USD";
            para.SelectedItem = "BRL";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var db = new MyContext())
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.nomeFantasia = "Eu mesmo";
                fornecedor.cNPJ = "0000000";
                fornecedor.endereço = "Rua Lá em Baixo 778";
                fornecedor.cricao = DateTime.Now;

                try
                {
                    db.Add(fornecedor);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir!" + ex.Message);
                }
               
            }
            AtualizaGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {

                    using (var db = new MyContext())
                    {
                        try
                        {
                            db.Remove(db.fornecedor.Single(a => a.id == Int32.Parse(row.Cells[0].Value.ToString())));
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao deletar!" + ex.Message);
                        }

                    }

                }
            }
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            using (var db = new MyContext())
            {
                try
                {
                    List<Fornecedor> data = db.fornecedor.OrderBy(a => a.id).ToList();
                    this.dataGridView1.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir o grid!" + ex.Message);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {

                    using (var db = new MyContext())
                    {
                        try
                        {
                            Fornecedor fornecedor = db.fornecedor.Single(a => a.id == Int32.Parse(row.Cells[0].Value.ToString()));
                            fornecedor.cNPJ = total.Text;
                            db.Update(fornecedor);
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao alterar!" + ex.Message);
                        }

                    }

                }
            }
            AtualizaGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal USD = decimal.Parse(taxaUSD.Text);
            decimal EUR = decimal.Parse(taxaEUR.Text);
            decimal BRL = decimal.Parse(taxaBRL.Text);

            decimal deMoeda = 0;
            decimal paraMoeda = 0;
            if (de.Text.Equals("USD"))
            {
                deMoeda = USD;
            }

            if (de.Text.Equals("EUR"))
            {
                deMoeda = EUR;
            }

            if (de.Text.Equals("BRL"))
            {
                deMoeda = BRL;
            }

            if (para.Text.Equals("USD"))
            {
                paraMoeda = USD;
            }

            if (para.Text.Equals("EUR"))
            {
                paraMoeda = EUR;
            }

            if (para.Text.Equals("BRL"))
            {
                paraMoeda = BRL;
            }

            decimal taxaValor = 0;
            if (deMoeda >= paraMoeda)
            {
                taxaValor = (deMoeda / paraMoeda);
                taxa.Text = taxaValor.ToString();
            }
            else
            {
                taxaValor = (paraMoeda / deMoeda);
                taxa.Text = taxaValor.ToString();
            }

            total.Text = (decimal.Parse(quantidade.Text) * taxaValor).ToString();


        }
    }
}
