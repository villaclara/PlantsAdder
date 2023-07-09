namespace PlantsAdderUI
{
	public partial class Form1 : Form
	{
		List<string> list = new();

		public Form1()
		{
			InitializeComponent();


			ChangeEnabledOfRightSide(enabled: false);

			list.Add("111");
			list.Add("2");
			list.Add("3");
			list.Add("...");

			listBox1.DataSource = list;
			listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;


		}

		private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
		{
			textBoxPlantDesc.Text = list[listBox1.SelectedIndex].ToString();

			// if selected last item then we want to add new plant
			if (list.Count == listBox1.SelectedIndex + 1)
			{
				textBoxPlantHandling.Text = "";
				textBoxPlantName.Text = "";
				textBoxPlantLink.Text = "";
				textBoxPlantDesc.Text = "";

				ChangeEnabledOfRightSide(enabled: true);
				ChangeStateBotButtons(enabled: false);
			}

			else
			{
				ChangeEnabledOfRightSide(enabled: false);
				ChangeStateBotButtons(enabled: true);
			}

		}

		private void ButtonSelectImg_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Image files | *.jpg; *.png | All files | *.*";
			if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				var chosenFile = openFileDialog1.FileName;
				labelSelectedImg.Text = chosenFile;
				Image newImage = Image.FromFile(chosenFile);
				pictureBox2.Image = newImage;
			}


		}

		private void button3_Click(object sender, EventArgs e)
		{

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

		private void buttonAddPlant_Click(object sender, EventArgs e)
		{

		}

		private void ButtonAddPlant1_Click(object sender, EventArgs e)
		{

		}
	}
}