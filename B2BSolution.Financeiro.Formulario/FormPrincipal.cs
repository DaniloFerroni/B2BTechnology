using System;
using System.Linq;
using System.Windows.Forms;

namespace B2BSolution.Financeiro.Formulario
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            //Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height - 40;
            //WindowState = FormWindowState.Maximized;
        }

        private void CarregarForm(Form formulario)
        {
            MdiChildren.ToList().ForEach(m => m.Close());
            
            formulario.MdiParent = this;
            formulario.Show();
            formulario.WindowState = FormWindowState.Maximized;
        }
        
        private void tsbCliente_Click(object sender, EventArgs e)
        {
            CarregarForm(new FormCadastro());
        }

        private void tsbVendedores_Click(object sender, EventArgs e)
        {
            CarregarForm(new FormVendedores());
        }

        private void tsbGrupos_Click(object sender, EventArgs e)
        {
            CarregarForm(new FormEquipamentos());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CarregarForm(new FormPagamentos());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CarregarForm(new FormComissao());
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tsbListarClientes_Click(object sender, EventArgs e)
        {
            CarregarForm(new FormListarClientes());
        }

        private bool IsMouseUp = true;

        private int mX;
        private int mY;

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseUp) return;

            // note "this" will refer to the Form here
            // note e.X, and e.Y co-ordinates will be in MenuStrip co-ordinate space
            // we're just calculating an offset that we can use to move the Form
            this.Left += e.X - mX;
            this.Top += e.Y - mY;
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseUp = true;
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseUp = false;
            // note these co-ordinates will be in MenuStrip co-ordinate space
            mX = e.X;
            mY = e.Y;
        }
    }
}
