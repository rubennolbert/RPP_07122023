using Entidades;

namespace WinFormsApp1
{
    public partial class frmPpal : Form
    {
        private Fabrica fabrica;
        private Mermelada mermeladas;

        public frmPpal()
        {
            InitializeComponent();
            fabrica = new Fabrica(20);
            mermeladas = new Manzana(Aditivos.Canela);
            
            
        }
        private void frmPpal_Load(object sender, EventArgs e)
        {
            this.cmbSabores.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSabores.Items.AddRange(new object[] { "Manzana", "Pera", "Tomate" });
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = this.lstItems.SelectedIndex;
            this.fabrica = this.fabrica - this.fabrica.Frasco[i];
            this.Refrescas();
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            this.fabrica = this.fabrica + DeterminarMermelada();
            this.Refrescas();
        }

        private Mermelada DeterminarMermelada()
        {
            string tipo = this.cmbSabores.ValueMember;
            switch (tipo)
            {
                case "Manzana":
                    return new Manzana(Aditivos.Mascabo);
                case "Pera":
                    return new Pera(Aditivos.Canela);
                case "Tomate":
                    return new Tomate("Familiar.");
            }
            return new Manzana(Aditivos.Mascabo);
        }

        private void Refrescas()
        {
            this.lstItems.DataSource = null;
            this.lstItems.DataSource = this.fabrica.Frasco;
        }

       
    }
}