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
			AddPlantTabPage = new TabPage();
			pictureBox2 = new PictureBox();
			groupBox2 = new GroupBox();
			labelSelectedImg = new Label();
			buttonSelectImg = new Button();
			buttonAddPlant1 = new Button();
			labelImage = new Label();
			textBoxAddHandling = new TextBox();
			textBoxAddDescription = new TextBox();
			textBoxAddLink = new TextBox();
			textBoxAddName = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			openFileDialog1 = new OpenFileDialog();
			tabControl1.SuspendLayout();
			PlantTabPage.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			AddPlantTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(PlantTabPage);
			tabControl1.Controls.Add(AddPlantTabPage);
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
			// 
			// buttonDelPlant
			// 
			buttonDelPlant.Location = new Point(688, 590);
			buttonDelPlant.Name = "buttonDelPlant";
			buttonDelPlant.Size = new Size(93, 32);
			buttonDelPlant.TabIndex = 16;
			buttonDelPlant.Text = "Delete Plant";
			buttonDelPlant.UseVisualStyleBackColor = true;
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
			buttonAddPlant.Click += buttonAddPlant_Click;
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
			// AddPlantTabPage
			// 
			AddPlantTabPage.Controls.Add(pictureBox2);
			AddPlantTabPage.Controls.Add(groupBox2);
			AddPlantTabPage.Location = new Point(4, 24);
			AddPlantTabPage.Name = "AddPlantTabPage";
			AddPlantTabPage.Padding = new Padding(3);
			AddPlantTabPage.Size = new Size(1018, 670);
			AddPlantTabPage.TabIndex = 1;
			AddPlantTabPage.Text = "AddPlant";
			AddPlantTabPage.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			pictureBox2.Location = new Point(664, 146);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(347, 312);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 7;
			pictureBox2.TabStop = false;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(labelSelectedImg);
			groupBox2.Controls.Add(buttonSelectImg);
			groupBox2.Controls.Add(buttonAddPlant1);
			groupBox2.Controls.Add(labelImage);
			groupBox2.Controls.Add(textBoxAddHandling);
			groupBox2.Controls.Add(textBoxAddDescription);
			groupBox2.Controls.Add(textBoxAddLink);
			groupBox2.Controls.Add(textBoxAddName);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(label4);
			groupBox2.Location = new Point(12, 6);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(646, 658);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			// 
			// labelSelectedImg
			// 
			labelSelectedImg.AutoSize = true;
			labelSelectedImg.Location = new Point(247, 571);
			labelSelectedImg.Name = "labelSelectedImg";
			labelSelectedImg.Size = new Size(0, 15);
			labelSelectedImg.TabIndex = 12;
			// 
			// buttonSelectImg
			// 
			buttonSelectImg.Location = new Point(125, 567);
			buttonSelectImg.Name = "buttonSelectImg";
			buttonSelectImg.Size = new Size(116, 23);
			buttonSelectImg.TabIndex = 11;
			buttonSelectImg.Text = "Select";
			buttonSelectImg.UseVisualStyleBackColor = true;
			buttonSelectImg.Click += ButtonSelectImg_Click;
			// 
			// buttonAddPlant1
			// 
			buttonAddPlant1.Location = new Point(125, 606);
			buttonAddPlant1.Name = "buttonAddPlant1";
			buttonAddPlant1.Size = new Size(116, 46);
			buttonAddPlant1.TabIndex = 10;
			buttonAddPlant1.Text = "Add Plant";
			buttonAddPlant1.UseVisualStyleBackColor = true;
			buttonAddPlant1.Click += ButtonAddPlant1_Click;
			// 
			// labelImage
			// 
			labelImage.AutoSize = true;
			labelImage.Location = new Point(21, 571);
			labelImage.Name = "labelImage";
			labelImage.Size = new Size(74, 15);
			labelImage.TabIndex = 9;
			labelImage.Text = "Select Image";
			// 
			// textBoxAddHandling
			// 
			textBoxAddHandling.Location = new Point(125, 318);
			textBoxAddHandling.Multiline = true;
			textBoxAddHandling.Name = "textBoxAddHandling";
			textBoxAddHandling.Size = new Size(507, 242);
			textBoxAddHandling.TabIndex = 8;
			// 
			// textBoxAddDescription
			// 
			textBoxAddDescription.Location = new Point(125, 92);
			textBoxAddDescription.Multiline = true;
			textBoxAddDescription.Name = "textBoxAddDescription";
			textBoxAddDescription.Size = new Size(507, 216);
			textBoxAddDescription.TabIndex = 7;
			// 
			// textBoxAddLink
			// 
			textBoxAddLink.Location = new Point(125, 50);
			textBoxAddLink.Name = "textBoxAddLink";
			textBoxAddLink.Size = new Size(272, 23);
			textBoxAddLink.TabIndex = 6;
			// 
			// textBoxAddName
			// 
			textBoxAddName.Location = new Point(125, 16);
			textBoxAddName.Name = "textBoxAddName";
			textBoxAddName.Size = new Size(272, 23);
			textBoxAddName.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(19, 100);
			label1.Name = "label1";
			label1.Size = new Size(67, 15);
			label1.TabIndex = 2;
			label1.Text = "Description";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(19, 326);
			label2.Name = "label2";
			label2.Size = new Size(56, 15);
			label2.TabIndex = 4;
			label2.Text = "Handling";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(19, 58);
			label3.Name = "label3";
			label3.Size = new Size(29, 15);
			label3.TabIndex = 3;
			label3.Text = "Link";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(19, 24);
			label4.Name = "label4";
			label4.Size = new Size(39, 15);
			label4.TabIndex = 1;
			label4.Text = "Name";
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
			AddPlantTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage PlantTabPage;
		private TabPage AddPlantTabPage;
		private ListBox listBox1;
		private Label labelName;
		private Label labelLink;
		private Label labelDesc;
		private GroupBox groupBox1;
		private Label labelHandling;
		private GroupBox groupBox2;
		private Label labelImage;
		private TextBox textBoxAddHandling;
		private TextBox textBoxAddDescription;
		private TextBox textBoxAddLink;
		private TextBox textBoxAddName;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button buttonAddPlant1;
		private Label labelSelectedImg;
		private Button buttonSelectImg;
		private OpenFileDialog openFileDialog1;
		private Label labelDetailedInfo;
		private Label labelTitle;
		private PictureBox pictureBox1;
		private TextBox textBoxPlantName;
		private TextBox textBoxPlantHandling;
		private TextBox textBoxPlantDesc;
		private TextBox textBoxPlantLink;
		private PictureBox pictureBox2;
		private Button buttonDelPlant;
		private Button buttonEditPlant;
		private Button buttonAddPlant;
		private Button buttonSelectImage;
		private Label labelSelectedImage;
	}
}