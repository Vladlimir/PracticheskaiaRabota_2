using System;
using System.Windows.Forms;

namespace Практическая_работа_2
{
    public partial class Form1 : Form
    {
        private Material[] materials;

        public Form1()
        {
            InitializeComponent();
            InitializeMaterials();
        }

        private void InitializeMaterials()
        {
            materials = new Material[]
            {
                new Material { Name = "Материал1", Sort = "Сорт1", Profile = "Профиль1", Size = "Размер1", UnitOfMeasurement = "Единица1", NomenclatureNumber = "Номенклатурный номер1", Price = 10.5, ReserveNorm = 5 },
                new Material { Name = "Материал2", Sort = "Сорт2", Profile = "Профиль2", Size = "Размер2", UnitOfMeasurement = "Единица2", NomenclatureNumber = "Номенклатурный номер2", Price = 20.5, ReserveNorm = 10 },
                // Add more materials here...
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string materialName = textBoxSearch.Text;
            Material foundMaterial = Array.Find(materials, m => m.Name == materialName);
            if (foundMaterial != null)
            {
                textBoxMaterialName.Text = foundMaterial.Name;
                textBoxSort.Text = foundMaterial.Sort;
                textBoxProfile.Text = foundMaterial.Profile;
                textBoxSize.Text = foundMaterial.Size;
                textBoxUnitOfMeasurement.Text = foundMaterial.UnitOfMeasurement;
                textBoxNomenclatureNumber.Text = foundMaterial.NomenclatureNumber;
                textBoxPrice.Text = foundMaterial.Price.ToString();
                textBoxReserveNorm.Text = foundMaterial.ReserveNorm.ToString();
            }
            else
            {
                MessageBox.Show("Материал не найден");
            }
        }
    }

    public class Material
    {
        public string Name { get; set; }
        public string Sort { get; set; }
        public string Profile { get; set; }
        public string Size { get; set; }
        public string UnitOfMeasurement { get; set; }
        public string NomenclatureNumber { get; set; }
        public double Price { get; set; }
        public int ReserveNorm { get; set; }
    }
}