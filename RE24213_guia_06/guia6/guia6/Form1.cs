namespace guia6
{
    public partial class Form1 : Form
    {

        // Listas para almacenar los animales
        List<Mamifero> mamiferos = new List<Mamifero>();
        List<Reptil> reptiles = new List<Reptil>();
        List<Pez> peces = new List<Pez>();
        List<Artropodo> artropodos = new List<Artropodo>();
        public Form1()



        {
            InitializeComponent();
            LlenarComboTipoAnimal(); // Llenar el ComboBox con las especies
            ConfigurarDataGridView();
        }
        private void LlenarComboTipoAnimal()
        {
            cmbTipoAnimal.Items.Add("Mam�fero");
            cmbTipoAnimal.Items.Add("Reptil");
            cmbTipoAnimal.Items.Add("Pez");
            cmbTipoAnimal.Items.Add("Artr�podo");
            cmbTipoAnimal.SelectedIndex = 0;

          
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewAnimales.ColumnCount = 5;
            dataGridViewAnimales.Columns[0].Name = "Nombre Com�n";
            dataGridViewAnimales.Columns[1].Name = "Nombre Cient�fico";
            dataGridViewAnimales.Columns[2].Name = "Familia";
            dataGridViewAnimales.Columns[3].Name = "H�bitat";
            dataGridViewAnimales.Columns[4].Name = "Fecha de Registro";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnAgregarAnimal_Click(object sender, EventArgs e)
        {
            string tipoAnimal = cmbTipoAnimal.SelectedItem.ToString(); // Obtener el tipo de animal seleccionado

            // Crear el animal en base a la especie seleccionada
            switch (tipoAnimal)
            {
                case "Mam�fero":
                    Mamifero nuevoMamifero = new Mamifero(
                        txtNombreComun.Text,
                        txtNombreCientifico.Text,
                        txtFamilia.Text,
                        txtHabitat.Text
                    );
                    mamiferos.Add(nuevoMamifero); // Agregar a la lista de mam�feros
                    break;

                case "Reptil":
                    Reptil nuevoReptil = new Reptil(
                        txtNombreComun.Text,
                        txtNombreCientifico.Text,
                        txtFamilia.Text,
                        txtHabitat.Text
                    );
                    reptiles.Add(nuevoReptil); // Agregar a la lista de reptiles
                    break;

                case "Pez":
                    Pez nuevoPez = new Pez(
                        txtNombreComun.Text,
                        txtNombreCientifico.Text,
                        txtFamilia.Text,
                        txtHabitat.Text
                    );
                    peces.Add(nuevoPez); // Agregar a la lista de peces
                    break;

                case "Artr�podo":
                    Artropodo nuevoArtropodo = new Artropodo(
                        txtNombreComun.Text,
                        txtNombreCientifico.Text,
                        txtFamilia.Text,
                        txtHabitat.Text
                    );
                    artropodos.Add(nuevoArtropodo); // Agregar a la lista de artr�podos
                    break;
            }

            MessageBox.Show($"{tipoAnimal} agregado correctamente.");
            MostrarAnimalesRegistrados(); // Llamar al m�todo para actualizar el DataGridView
        }
        private void MostrarAnimalesRegistrados()
        {
            dataGridViewAnimales.Rows.Clear(); // Limpiar el DataGridView antes de agregar nuevos datos

            // Mostrar los mam�feros
            foreach (Mamifero mamifero in mamiferos)
            {
                dataGridViewAnimales.Rows.Add(
                    mamifero.NombreComun,
                    mamifero.NombreCientifico,
                    mamifero.Familia,
                    mamifero.Habitat,
                    mamifero.FechaRegistro.ToShortDateString()
                );
            }

            // Mostrar los reptiles
            foreach (Reptil reptil in reptiles)
            {
                dataGridViewAnimales.Rows.Add(
                    reptil.NombreComun,
                    reptil.NombreCientifico,
                    reptil.Familia,
                    reptil.Habitat,
                    reptil.FechaRegistro.ToShortDateString()
                );
            }

            // Mostrar los peces
            foreach (Pez pez in peces)
            {
                dataGridViewAnimales.Rows.Add(
                    pez.NombreComun,
                    pez.NombreCientifico,
                    pez.Familia,
                    pez.Habitat,
                    pez.FechaRegistro.ToShortDateString()
                );
            }

            // Mostrar los artr�podos
            foreach (Artropodo artropodo in artropodos)
            {
                dataGridViewAnimales.Rows.Add(
                    artropodo.NombreComun,
                    artropodo.NombreCientifico,
                    artropodo.Familia,
                    artropodo.Habitat,
                    artropodo.FechaRegistro.ToShortDateString()
                );
            }
        }





















    }
}


