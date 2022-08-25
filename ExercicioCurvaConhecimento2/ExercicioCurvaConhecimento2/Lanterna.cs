using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste2
{
    public partial class Form1 : Form
    {
        public Lanterna lanterna { get; set; }
        System.Timers.Timer aTimer { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.lanterna = new Lanterna();
            this.aTimer = new System.Timers.Timer();
            aTimer.Interval = 1000;
            aTimer.Elapsed += LigandoBateria;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trocarLabel_Ligar_Desligar();
            atualizarPorcentagemBateria();
        }

        private void btnLigarDesligar_Click(object sender, EventArgs e)
        {
            if (this.lanterna.status == 'D')
            {
                this.lanterna.ligar();
                aTimer.Enabled = true;
                ativarDestivarTrocaDeBateria(false);
                backColor.BackColor = Color.White;
            }
            else
            {
                this.lanterna.desligar();
                aTimer.Enabled = false;
                ativarDestivarTrocaDeBateria(true);
                backColor.BackColor = Color.Black;
            }
            trocarLabel_Ligar_Desligar();
        }

        private void LigandoBateria(Object source, System.Timers.ElapsedEventArgs e)
        {
            trocarLabel_Ligar_Desligar();
            if (this.lanterna.bateria.tem_bateria() && this.lanterna.status == 'L')
            {
                this.lanterna.bateria.gastar();
                atualizarPorcentagemBateria();
            }
            else
            {
                backColor.BackColor = Color.Black;
                this.lanterna.desligar();
                ativarDestivarTrocaDeBateria(true);
            }
        }

        private void ativarDestivarTrocaDeBateria(bool ligar)
        {
            btnRecarregar.Invoke((MethodInvoker)delegate {
                btnRecarregar.Enabled = ligar;
            });
        }

        private void trocarLabel_Ligar_Desligar()
        {
            btnLigarDesligar.Invoke((MethodInvoker)delegate {
                btnLigarDesligar.Text = this.lanterna.status == 'D' ? "Ligar" : "Desligar";
            });
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            this.lanterna.trocar_bateria();
            atualizarPorcentagemBateria();
        }

        private void atualizarPorcentagemBateria()
        {
            lblPorcentagemBateria.Invoke((MethodInvoker)delegate {
                lblPorcentagemBateria.Text = this.lanterna.retorna_bateria().ToString() + "%";
            });
        }
    }

    public class Lanterna
    {
        public Bateria bateria { get; set; }

        // Status: D - Desligada | L - Ligada
        public char status { get; set; }

        public Lanterna()
        {
            this.status = 'D';
            bateria = new Bateria();
        }

        public void ligar()
        {
            this.status = 'L';
        }

        public void desligar()
        {
            this.status = 'D';
        }

        public int retorna_bateria()
        {
            if (this.bateria.quantidade == 0)
                this.desligar();

            return this.bateria.quantidade;
        }

        public void trocar_bateria()
        {
            bateria = new Bateria();
        }

    }

    public class Bateria
    {
        public int quantidade { get; set; }

        public Bateria()
        {
            this.quantidade = 100;
        }

        public bool tem_bateria()
        {
            return this.quantidade > 0;
        }

        public int gastar()
        {
            this.quantidade--;
            return this.quantidade;
        }
    }
}
