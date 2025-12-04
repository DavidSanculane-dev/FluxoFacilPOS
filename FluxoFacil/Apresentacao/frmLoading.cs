using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxoFacil.Apresentacao
{
    public partial class frmLoading : Form
    {
        public string LoadingText
        {
            get { return lblNome.Text; }
            set { lblNome.Text = value; }
        }

        public frmLoading()
        {
            InitializeComponent();
        }

       
        private void frmLoading_Load(object sender, EventArgs e)
        {

        }
    }
}
