namespace PlantsAdderUI
{
	partial class Form1
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
			tabControl1 = new TabControl();
			PlantTabPage = new TabPage();
			labelDetailedInfo = new Label();
			labelTitle = new Label();
			listBox1 = new ListBox();
			groupBox1 = new GroupBox();
			labelSelectedImage = new Label();
			buttonSelectImage = new Button();
			buttonDelPlant = new Button();
			buttonEditPlant = new Button();
			buttonAddPlant = new Button();
			textBoxPlantHandling = new TextBox();
			textBoxPlantDesc = new TextBox();
			textBoxPlantLink = new TextBox();
			textBoxPlantName = new TextBox();
			pictureBox1 = new PictureBox();
			labelDesc = new Label();
			labelHandling = new Label();
			labelLink = new Label();
			labelName = new Label();
			openFileDialog1 = new OpenFileDialog();
			tabControl1.SuspendLayout();
			PlantTabPage.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(PlantTabPage);
			tabControl1.Location = new Point(-4, -1);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1026, 698);
			tabControl1.TabIndex = 0;
			// 
			// PlantTabPage
			// 
			PlantTabPage.Controls.Add(labelDetailedInfo);
			PlantTabPage.Controls.Add(labelTitle);
			PlantTabPage.Controls.Add(listBox1);
			PlantTabPage.Controls.Add(groupBox1);
			PlantTabPage.Location = new Point(4, 24);
			PlantTabPage.Name = "PlantTabPage";
			PlantTabPage.Padding = new Padding(3);
			PlantTabPage.Size = new Size(1018, 670);
			PlantTabPage.TabIndex = 0;
			PlantTabPage.Text = "Plants";
			PlantTabPage.UseVisualStyleBackColor = true;
			// 
			// labelDetailedInfo
			// 
			labelDetailedInfo.AutoSize = true;
			labelDetailedInfo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			labelDetailedInfo.Location = new Point(454, 3);
			labelDetailedInfo.Name = "labelDetailedInfo";
			labelDetailedInfo.Size = new Size(218, 30);
			labelDetailedInfo.TabIndex = 7;
			labelDetailedInfo.Text = "Detailed information";
			// 
			// labelTitle
			// 
			labelTitle.AutoSize = true;
			labelTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			labelTitle.Location = new Point(61, 3);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(73, 30);
			labelTitle.TabIndex = 6;
			labelTitle.Text = "Plants";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(12, 50);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(184, 604);
			listBox1.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(labelSelectedImage);
			groupBox1.Controls.Add(buttonSelectImage);
			groupBox1.Controls.Add(buttonDelPlant);
			groupBox1.Controls.Add(buttonEditPlant);
			groupBox1.Controls.Add(buttonAddPlant);
			groupBox1.Controls.Add(textBoxPlantHandling);
			groupBox1.Controls.Add(textBoxPlantDesc);
			groupBox1.Controls.Add(textBoxPlantLink);
			groupBox1.Controls.Add(textBoxPlantName);
			groupBox1.Controls.Add(pictureBox1);
			groupBox1.Controls.Add(labelDesc);
			groupBox1.Controls.Add(labelHandling);
			groupBox1.Controls.Add(labelLink);
			groupBox1.Controls.Add(labelName);
			groupBox1.Location = new Point(230, 41);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(788, 628);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			// 
			// labelSelectedImage
			// 
			labelSelectedImage.AutoSize = true;
			labelSelectedImage.Location = new Point(195, 600);
			labelSelectedImage.Name = "labelSelectedImage";
			labelSelectedImage.Size = new Size(86, 15);
			labelSelectedImage.TabIndex = 18;
			labelSelectedImage.Text = "selected image";
			// 
			// buttonSelectImage
			// 
			buttonSelectImage.BackgroundImageLayout = ImageLayout.Center;
			buttonSelectImage.Location = new Point(110, 595);
			buttonSelectImage.Name = "buttonSelectImage";
			buttonSelectImage.Size = new Size(75, 23);
			buttonSelectImage.TabIndex = 17;
			buttonSelectImage.Text = "Select";
			buttonSelectImage.UseVisualStyleBackColor = true;
			buttonSelectImage.Click += ButtonSelectImg_Click;
			// 
			// buttonDelPlant
			// 
			buttonDelPlant.Location = new Point(688, 590);
			buttonDelPlant.Name = "buttonDelPlant";
			buttonDelPlant.Size = new Size(93, 32);
			buttonDelPlant.TabIndex = 16;
			buttonDelPlant.Text = "Delete Plant";
			buttonDelPlant.UseVisualStyleBackColor = true;
			buttonDelPlant.Click += buttonDelPlant_Click;
			// 
			// buttonEditPlant
			// 
			buttonEditPlant.Location = new Point(580, 590);
			buttonEditPlant.Name = "buttonEditPlant";
			buttonEditPlant.Size = new Size(93, 32);
			buttonEditPlant.TabIndex = 15;
			buttonEditPlant.Text = "Edit Plant";
			buttonEditPlant.UseVisualStyleBackColor = true;
			// 
			// buttonAddPlant
			// 
			buttonAddPlant.Location = new Point(471, 590);
			buttonAddPlant.Name = "buttonAddPlant";
			buttonAddPlant.Size = new Size(93, 32);
			buttonAddPlant.TabIndex = 14;
			buttonAddPlant.Text = "Add Plant";
			buttonAddPlant.UseVisualStyleBackColor = true;
			buttonAddPlant.Click += ButtonAddPlant_Click;
			// 
			// textBoxPlantHandling
			// 
			textBoxPlantHandling.Enabled = false;
			textBoxPlantHandling.Location = new Point(110, 360);
			textBoxPlantHandling.Multiline = true;
			textBoxPlantHandling.Name = "textBoxPlantHandling";
			textBoxPlantHandling.Size = new Size(671, 221);
			textBoxPlantHandling.TabIndex = 13;
			textBoxPlantHandling.Text = "bruh";
			// 
			// textBoxPlantDesc
			// 
			textBoxPlantDesc.Enabled = false;
			textBoxPlantDesc.Location = new Point(110, 78);
			textBoxPlantDesc.Multiline = true;
			textBoxPlantDesc.Name = "textBoxPlantDesc";
			textBoxPlantDesc.Size = new Size(301, 269);
			textBoxPlantDesc.TabIndex = 12;
			textBoxPlantDesc.Text = "bruh";
			// 
			// textBoxPlantLink
			// 
			textBoxPlantLink.Enabled = false;
			textBoxPlantLink.Location = new Point(110, 47);
			textBoxPlantLink.Name = "textBoxPlantLink";
			textBoxPlantLink.Size = new Size(301, 23);
			textBoxPlantLink.TabIndex = 11;
			textBoxPlantLink.Text = "bruh";
			// 
			// textBoxPlantName
			// 
			textBoxPlantName.Enabled = false;
			textBoxPlantName.Location = new Point(110, 16);
			textBoxPlantName.Name = "textBoxPlantName";
			textBoxPlantName.Size = new Size(301, 23);
			textBoxPlantName.TabIndex = 10;
			textBoxPlantName.Text = "bruh";
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(417, 16);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(364, 331);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			// 
			// labelDesc
			// 
			labelDesc.AutoSize = true;
			labelDesc.Location = new Point(19, 81);
			labelDesc.Name = "labelDesc";
			labelDesc.Size = new Size(67, 15);
			labelDesc.TabIndex = 2;
			labelDesc.Text = "Description";
			// 
			// labelHandling
			// 
			labelHandling.AutoSize = true;
			labelHandling.Location = new Point(19, 363);
			labelHandling.Name = "labelHandling";
			labelHandling.Size = new Size(56, 15);
			labelHandling.TabIndex = 4;
			labelHandling.Text = "Handling";
			// 
			// labelLink
			// 
			labelLink.AutoSize = true;
			labelLink.Location = new Point(19, 50);
			labelLink.Name = "labelLink";
			labelLink.Size = new Size(29, 15);
			labelLink.TabIndex = 3;
			labelLink.Text = "Link";
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Location = new Point(19, 19);
			labelName.Name = "labelName";
			labelName.Size = new Size(39, 15);
			labelName.TabIndex = 1;
			labelName.Text = "Name";
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1023, 699);
			Controls.Add(tabControl1);
			Name = "Form1";
			Text = "Form1";
			tabControl1.ResumeLayout(false);
			PlantTabPage.ResumeLayout(false);
			PlantTabPage.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage PlantTabPage;
		private ListBox listBox1;
		private Label labelName;
		private Label labelLink;
		private Label labelDesc;
		private GroupBox groupBox1;
		private Label labelHandling;
		private OpenFileDialog openFileDialog1;
		private Label labelDetailedInfo;
		private Label labelTitle;
		private PictureBox pictureBox1;
		private TextBox textBoxPlantName;
		private TextBox textBoxPlantHandling;
		private TextBox textBoxPlantDesc;
		private TextBox textBoxPlantLink;
		private Button buttonDelPlant;
		private Button buttonEditPlant;
		private Button buttonAddPlant;
		private Button buttonSelectImage;
		private Label labelSelectedImage;
	}
}