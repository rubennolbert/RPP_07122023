namespace WinFormsApp1
{
    partial class frmPpal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPpal));
            lstItems = new ListBox();
            cmbSabores = new ComboBox();
            btnFabricar = new Button();
            btnEliminar = new Button();
            lblSabor = new Label();
            pcbFrasco = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFrasco).BeginInit();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 15;
            lstItems.Location = new Point(22, 31);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(476, 394);
            lstItems.TabIndex = 0;
            // 
            // cmbSabores
            // 
            cmbSabores.FormattingEnabled = true;
            cmbSabores.Location = new Point(572, 57);
            cmbSabores.Name = "cmbSabores";
            cmbSabores.Size = new Size(184, 23);
            cmbSabores.TabIndex = 1;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(563, 293);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(193, 23);
            btnFabricar.TabIndex = 2;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(563, 360);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(193, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblSabor
            // 
            lblSabor.AutoSize = true;
            lblSabor.Location = new Point(572, 31);
            lblSabor.Name = "lblSabor";
            lblSabor.Size = new Size(37, 15);
            lblSabor.TabIndex = 4;
            lblSabor.Text = "Sabor";
            // 
            // pcbFrasco
            // 
            pcbFrasco.Image = Properties.Resources.jar_fruits_icon;
            pcbFrasco.Location = new Point(596, 117);
            pcbFrasco.Name = "pcbFrasco";
            pcbFrasco.Size = new Size(129, 154);
            pcbFrasco.TabIndex = 5;
            pcbFrasco.TabStop = false;
            // 
            // frmMermelandia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pcbFrasco);
            Controls.Add(lblSabor);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(cmbSabores);
            Controls.Add(lstItems);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMermelandia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mermelandia";
            Load += frmPpal_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFrasco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstItems;
        private ComboBox cmbSabores;
        private Button btnFabricar;
        private Button btnEliminar;
        private Label lblSabor;
        private PictureBox pcbFrasco;
    }
}