using PlantsLibrary.Application;
using PlantsLibrary.Model;

namespace PlantsAdderUI
{
	public partial class Form1 : Form
	{
		List<string> list = new();
		private readonly PlantsLibrary.Database.ApplicationContext _context = new();


		private readonly PlantWorker _worker;
		private List<PlantModel> plantModels;

		private IList<string> _plantNamesList;

		public Form1()
		{
			InitializeComponent();

			_worker = new PlantWorker(_context);

			UpdatePlantsListBox();


			ChangeEnabledOfRightSide(enabled: false);



			listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;




		}

		private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
		{

			labelSelectedImage.Text = "";


			// if selected last item then we want to add new plant
			if (plantModels.Count == listBox1.SelectedIndex + 1)
			{
				textBoxPlantHandling.Text = "";
				textBoxPlantName.Text = "";
				textBoxPlantLink.Text = "";
				textBoxPlantDesc.Text = "";
				pictureBox1.Image = null;
				ChangeEnabledOfRightSide(enabled: true);
				ChangeStateBotButtons(enabled: false);
			}

			// else selected any of database item and we display info about it
			else
			{
				ChangeEnabledOfRightSide(enabled: false);
				ChangeStateBotButtons(enabled: true);

				textBoxPlantName.Text = plantModels[listBox1.SelectedIndex].Name;
				textBoxPlantLink.Text = plantModels[listBox1.SelectedIndex].Link;
				textBoxPlantDesc.Text = plantModels[listBox1.SelectedIndex].Description;
				textBoxPlantHandling.Text = plantModels[listBox1.SelectedIndex].Handling;


				// checking if the image is present
				if (plantModels[listBox1.SelectedIndex].ImageBytes.Length > 0)
				{
					MemoryStream stream = new MemoryStream(plantModels[listBox1.SelectedIndex].ImageBytes);
					pictureBox1.Image = Image.FromStream(stream);
				}
				else
				{
					pictureBox1.Image = null;
				}

			}

		}

		private void ButtonSelectImg_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Image files | *.jpg; *.png | All files | *.*";
			if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				var chosenFile = openFileDialog1.FileName;
				labelSelectedImage.Text = chosenFile;
				Image newImage = Image.FromFile(chosenFile);
				pictureBox1.Image = newImage;
			}


		}


		private void ChangeEnabledOfRightSide(bool enabled)
		{
			textBoxPlantHandling.Enabled = enabled;
			textBoxPlantName.Enabled = enabled;
			textBoxPlantLink.Enabled = enabled;
			textBoxPlantDesc.Enabled = enabled;
			buttonAddPlant.Enabled = enabled;
			buttonSelectImage.Enabled = enabled;
		}

		private void ChangeStateBotButtons(bool enabled)
		{
			buttonEditPlant.Enabled = enabled;
			buttonDelPlant.Enabled = enabled;
		}

		private void ButtonAddPlant_Click(object sender, EventArgs e)
		{
			var newPlant = new PlantModel()
			{
				Name = textBoxPlantName.Text,
				Link = textBoxPlantLink.Text,
				Description = textBoxPlantDesc.Text,
				Handling = textBoxPlantHandling.Text,
				ImageBytes = ImageToBytes(labelSelectedImage.Text),

			};

			var result = new PlantWorker(_context).AddPlantToDBAsync(newPlant).GetAwaiter().GetResult();

			if (result)
			{
				MessageBox.Show("plant added to db");
				ClearTextBoxes();

				UpdatePlantsListBox();

			}
		}


		private byte[] ImageToBytes(string imgName)
		{


			byte[] imgdata;

			if (imgName == "")
				return Array.Empty<byte>();

			using var fs = new FileStream(imgName, FileMode.Open, FileAccess.Read);
			using var br = new BinaryReader(fs);
			imgdata = br.ReadBytes((int)fs.Length);
			return imgdata;
		}


		private void ClearTextBoxes()
		{
			textBoxPlantHandling.Text = "";
			textBoxPlantName.Text = "";
			textBoxPlantLink.Text = "";
			textBoxPlantDesc.Text = "";
			labelSelectedImage.Text = "";
			pictureBox1.Image = null;

		}


		private void UpdatePlantsListBox()
		{
			plantModels = _worker.GetAllPlants();
			plantModels.Add(new PlantModel()
			{
				Name = "...",
			});

			listBox1.DataSource = plantModels;
			listBox1.DisplayMember = "Name";
		}

		private void buttonDelPlant_Click(object sender, EventArgs e)
		{
			var choice = MessageBox.Show("delete?", "???", MessageBoxButtons.OKCancel);
			if (choice == DialogResult.OK)
			{
				new PlantWorker(_context).DeletePlantByName(plantModels[listBox1.SelectedIndex]).GetAwaiter().GetResult();

				UpdatePlantsListBox();
			}

			
		}
	}
}