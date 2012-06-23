using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace Animal_Motel
{
    public partial class MainForm : Form
    {
        //My variables
        int index = 0;
        double age = 0;
        bool showText = false;

        private AnimalFactory m_animalManager = new AnimalFactory();

        public MainForm()
        {
            InitializeComponent();

            //My Initialization
            InitializeGUI();

            UpdateGUI();
        }

        private void UpdateGUI()
        {
            EnableDisableSpecs();
        }

        private void InitializeGUI()
        {
            lstGender.DataSource = Enum.GetValues(typeof(GenderType)); //Gender
            lstCategory.DataSource = Enum.GetValues(typeof(CategoryType)); // Category of the Animals
        
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstCategory.Enabled == true)
            {
                ShowItems();

            }
        }

        private void chbAllAnimals_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAllAnimals.Checked == true)
            {
                lstAnimal.DataSource = Enum.GetValues(typeof(AllAnimals));
                lstCategory.Enabled = false;
               // UpdateCategoryList();
            }
            else
            {
               // lstCategory.SelectedIndex = 0;
                
                lstCategory.Enabled = true;
                lstAnimal.SelectedIndex = index;
                ShowItems();
            }
        }

        private void UpdateCategoryList()
        {
            
            if (lstAnimal.SelectedIndex == 0 || lstAnimal.SelectedIndex == 1 )
            {
                GetIndex();
                lstCategory.SelectedIndex = 0;
            }
            else if (lstAnimal.SelectedIndex == 2 || lstAnimal.SelectedIndex == 3)
            {
                GetIndex();
                lstCategory.SelectedIndex = 1;
            }
            else if (lstAnimal.SelectedIndex == 4 || lstAnimal.SelectedIndex == 5)
            {
                GetIndex();
                lstCategory.SelectedIndex = 2;
            }
            else if (lstAnimal.SelectedIndex == 6 || lstAnimal.SelectedIndex == 7)
            {
                GetIndex();
                lstCategory.SelectedIndex = 3;
            }
            else if (lstAnimal.SelectedIndex == 8 || lstAnimal.SelectedIndex == 9)
            {
                GetIndex();
                lstCategory.SelectedIndex = 4;
            }
        }

        private void GetIndex()
        {
            if (lstAnimal.SelectedIndex == 0 || lstAnimal.SelectedIndex == 2 || lstAnimal.SelectedIndex == 4 || lstAnimal.SelectedIndex == 6 || lstAnimal.SelectedIndex == 8)
            {
                index = 0;
            }
            else if (lstAnimal.SelectedIndex == 1 || lstAnimal.SelectedIndex == 3 || lstAnimal.SelectedIndex == 5 || lstAnimal.SelectedIndex == 7 || lstAnimal.SelectedIndex == 9)
            {
                index = 1;
            }
        }

        private void ShowItems()
        {
            if (lstCategory.SelectedIndex == 0)
            {
                lstAnimal.DataSource = Enum.GetValues(typeof(BirdSpecies));
            }
            else if (lstCategory.SelectedIndex == 1)
            {
                lstAnimal.DataSource = Enum.GetValues(typeof(InsectSpecies));
            }
            else if (lstCategory.SelectedIndex == 2)
            {
                lstAnimal.DataSource = Enum.GetValues(typeof(MammalSpecies));
            }
            else if (lstCategory.SelectedIndex == 3)
            {
                lstAnimal.DataSource = Enum.GetValues(typeof(MarineSpecies));
            }
            else
            {
                lstAnimal.DataSource = Enum.GetValues(typeof(ReptileSpecies));
            }
        }

        private void lstAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstCategory.Enabled == false)
            {
                UpdateCategoryList();
            }

            EnableDisableSpecs();
        }

        private void EnableDisableSpecs()
        {
            showText = false;
            grbSpec.Visible = true;
            grbSpec.Text = lstCategory.SelectedItem.ToString() + " Specifications";
            AllAnimals animalType = (AllAnimals)Enum.Parse(typeof(AllAnimals), lstAnimal.SelectedItem.ToString());
            chbSpec1.Checked = false;
            chbSpec2.Checked = false;
            switch (animalType)
            {
                case AllAnimals.Bee:          //Late binding
                    chbSpec1.Text = "Is Poisonous";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Honey Bee";
                    lblSpec1.Text = "Amount Of Honey/Year";
                    showText = true;
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.ButterFly:
                    chbSpec1.Text = "Is Poisonous";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "In Larval Phase";
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.Cow:          
                    chbSpec1.Text = "Is Pet";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Jersey Cow";
                    lblSpec1.Text = "Milk/Day";
                    DiasableTextSpecs2();
                    showText = true;
                    break;
                case AllAnimals.Dog:
                    chbSpec1.Text = "Is Pet";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    lblSpec2.Text = "No.Of Teeth";
                    lblSpec2.Visible = true;
                    txtSpec2.Visible = true;
                    chbSpec2.Text = "Under Quarantine";
                    lblSpec1.Text = "Quarantine Days";
                    showText = true;
                    break;
                case AllAnimals.Dolphine:
                    chbSpec1.Text = "Is Scary";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Can be Trained";
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.Lizard:
                    chbSpec1.Text = "Is Poisonous";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Is Chamelion";
                    DiasableTextSpecs2();      //Late binding
                    break;
                case AllAnimals.Ostrich:
                    chbSpec1.Text = "Can Fly";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Lay Eggs";
                    lblSpec1.Text = "No. Of Eggs";
                    showText = true;
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.Parrot:
                    chbSpec1.Text = "Can Fly";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Can Talk";
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.Shark:         
                    chbSpec1.Text = "Is Scary";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Is Dangerious";
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.Snake:
                    chbSpec1.Text = "Is Poisonous";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Is Cobra";
                    DiasableTextSpecs2();         //Late binding
                    break;

                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }
        }

        private void DiasableTextSpecs2()
        {

            lblSpec2.Visible = false;
            txtSpec2.Visible = false;
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            CategoryType category = (CategoryType)Enum.Parse(typeof(CategoryType), lstCategory.SelectedItem.ToString());
            AllAnimals animalType = (AllAnimals)Enum.Parse(typeof(AllAnimals), lstAnimal.SelectedItem.ToString());
            Animal animal = m_animalManager.CreateAnimal(category,animalType.ToString());
            if (animal != null)
            {
                animal.Name = txtName.Text;
                bool validAge = GetDouble(txtAge.Text, out age);
                animal.Age = age;
                GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), lstGender.SelectedItem.ToString());
                animal.Gender = gender;
                animal.AnimalType = animalType.ToString();
                animal.ExtraAnimalInfo = rtbImpInfo.Text;
                int spec1Value;
                bool txtSpec1Value = GetInt(txtSpec1.Text, out spec1Value);
                int spec2Value;
                bool txtSpec2Value = GetInt(txtSpec2.Text, out spec2Value);
                switch (animalType)
                {
                    case AllAnimals.Bee:
                        ((Bee)animal).IsPoisonous = chbSpec1.Checked;
                        ((Bee)animal).IsHoneyBee = chbSpec2.Checked;
                        ((Bee)animal).AmountOfHoneyPerMonth = spec1Value;
                        break;
                    case AllAnimals.ButterFly:
                        ((ButterFly)animal).IsPoisonous = chbSpec1.Checked;
                        ((ButterFly)animal).IsLarvalPhase = chbSpec2.Checked;
                        break;
                    case AllAnimals.Cow:
                        ((Cow)animal).IsPet = chbSpec1.Checked;
                        ((Cow)animal).IsJerseyCow = chbSpec2.Checked;
                        ((Cow)animal).AmountOfMilkPerDay = spec1Value;
                        break;
                    case AllAnimals.Dog:
                        ((Dog)animal).IsPet = chbSpec1.Checked;
                        ((Dog)animal).UnderQuarantine = chbSpec2.Checked;
                        ((Dog)animal).DaysQuarantine = spec1Value;
                        ((Dog)animal).NumberOfTeeth = spec2Value;
                        break;
                    case AllAnimals.Dolphine:
                        ((Dolphine)animal).IsScary = chbSpec1.Checked;
                        ((Dolphine)animal).CanBeTrained = chbSpec2.Checked;
                        break;
                    case AllAnimals.Lizard:
                        ((Lizard)animal).IsPoisonous = chbSpec1.Checked;
                        ((Lizard)animal).IsChamelian = chbSpec2.Checked;
                        break;
                    case AllAnimals.Ostrich:
                        ((Ostrich)animal).CanFly = chbSpec1.Checked;
                        ((Ostrich)animal).LayEggs = chbSpec2.Checked;
                        ((Ostrich)animal).NumberOfEggs = spec1Value;
                        break;
                    case AllAnimals.Parrot:
                        ((Parrot)animal).CanFly = chbSpec1.Checked;
                        ((Parrot)animal).CanTalk = chbSpec2.Checked;
                        break;
                    case AllAnimals.Shark:
                        ((Shark)animal).IsScary = chbSpec1.Checked;
                        ((Shark)animal).IsDangerous = chbSpec2.Checked;
                        break;
                    case AllAnimals.Snake:
                        ((Snake)animal).IsPoisonous = chbSpec1.Checked;
                        ((Snake)animal).IsCobra = chbSpec2.Checked;    
                        break;

                    default:
                        Debug.Assert(false, "To be completed!");
                        break;
                }
                m_animalManager.Add(animal);
                rtbSpecificData.Text = animal.GetAnimalSpecificData();
            }

            LoadAnimalData();
        }

        private void LoadAnimalData()
        {
            lsbData.DataSource = m_animalManager.GetAnimalDetailsListArray();
            lsbData.SelectedIndex = m_animalManager.Count - 1;
        }
        public static bool GetDouble(string stringToConvert, out double dblOutValue)
        {
            // parsing the string to check for whether value is double value or not
            bool isDouble = double.TryParse(stringToConvert, out dblOutValue);
            if (isDouble == true && dblOutValue > 0.0D)
            {
                // return true if value is a double
                return true;
            }
            // return false if the value is not validated as a double
            return false;

        }
        public static bool GetInt(string stringToConvert, out int intOutValue)
        {
            // parsing the string to check for whether value is double value or not
            bool isInt = Int32.TryParse(stringToConvert, out intOutValue);
            if (isInt == true && intOutValue > 0)
            {
                // return true if value is a double
                return true;
            }
            // return false if the value is not validated as a double
            return false;

        }

        private void chbSpec2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSpec2.Checked == true && showText == true)
            {
                lblSpec1.Visible = true;
                txtSpec1.Visible = true;
            }
            else
            {
                lblSpec1.Visible = false;
                txtSpec1.Visible = false;
            }
        }

        private void lsbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal animal = m_animalManager.GetAnimal(lsbData.SelectedIndex);
            rtbSpecificData.Text = animal.GetAnimalSpecificData();
        }

        private void btnAnimalPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pcImage.Image = new Bitmap(dlg.OpenFile());
            }

            dlg.Dispose();
        }


    }
}
