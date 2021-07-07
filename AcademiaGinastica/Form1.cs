using AcademiaGinastica.ClassPessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaGinastica
{
    public partial class Form1 : Form
    {
        ClassAcademia academia;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIncerir_Click(object sender, EventArgs e)
        {
            academia = new ClassAcademia(
                TxtNome.Text,
                MtbCPF.Text,
                MtbRG.Text,
                CmbTurma.Text,
                decimal.Parse(MtbMensalidade.Text),
                CkbPago.Checked
                );
            
        }
    }
}
