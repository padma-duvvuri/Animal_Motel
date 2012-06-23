//File: MainForm.cs
//Name: Padma Priya Duvvuri
//Date: 24/06/2012

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
        double age;
        string name;
        bool showText = false;

        //Creating an instance of animalFactory
        private AnimalFactory m_animalManager = new AnimalFactory();

        public MainForm()
        {
            InitializeComponent();

            //My Initializations
            InitializeGUI();
            UpdateGUI();
        }

        /// <summary>
        /// To enable fields and labels of special information groupbox
        /// </summary>
        private void UpdateGUI()
        {
            EnableDisableSpecs();
        }

        /// <summary>
        /// My initialization to bind the enums gender and category to list boxes of the GUI
        /// </summary>
        private void InitializeGUI()
        {
            lstGender.DataSource = Enum.GetValues(typeof(GenderType)); //Gender
            lstCategory.DataSource = Enum.GetValues(typeof(CategoryType)); // Category of the Animals
        
        }

        /// <summary>
        /// Event handler for SelectedIndexChanged event of Category listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstCategory.Enabled == true)
            {
                ShowItems(); //to update animal species listbox
            }
        }

        /// <summary>
        /// Event handler for CheckedChanged event of all animals enabling check box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbAllAnimals_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAllAnimals.Checked == true)
            {
                lstAnimal.DataSource = Enum.GetValues(typeof(AllAnimals)); //show all animals
                lstCategory.Enabled = false; //disable the category listbox
            }
            else
            {
                //if all animals checkbox is unchecked enable the categrory listbox
                lstCategory.Enabled = true;
                lstAnimal.SelectedIndex = index;
                ShowItems(); //update the animal species list box
            }
        }

        /// <summary>
        /// Depening on the index selected in the animal listbox when all animals are shows i.e. all 
        /// animals check box is checked update the category index
        /// </summary>
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

        /// <summary>
        /// To retrieve back to unchecked status of all animlas this method sets the index 
        /// according to the item that the user has selected when all animals are shown
        /// </summary>
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

        /// <summary>
        /// To display the animals types in the animal list box according to the user selected
        /// category
        /// </summary>
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

        /// <summary>
        /// Event handler for SelectedIndexChanged event of Animal listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstCategory.Enabled == false)
            {
                UpdateCategoryList(); // to update the category
            }

            EnableDisableSpecs(); // to enable or disable the extra information fields
        }

        /// <summary>
        /// This method enables, disables or updates the fields of the extra information groupbox
        /// according to the species that user has selected.
        /// </summary>
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
                case AllAnimals.Bee:          //Update special info according to Bees
                    chbSpec1.Text = "Is Poisonous";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Honey Bee";
                    lblSpec1.Text = "Amount Of Honey/Year";
                    showText = true;
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.ButterFly:         //Update special info according to ButterFly
                    chbSpec1.Text = "Is Poisonous";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "In Larval Phase";
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.Cow:         //Update special info according to Cows          
                    chbSpec1.Text = "Is Pet";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Jersey Cow";
                    lblSpec1.Text = "Milk/Day";
                    DiasableTextSpecs2();
                    showText = true;
                    break;
                case AllAnimals.Dog:         //Update special info according to Dogs
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
                case AllAnimals.Dolphine:         //Update special info according to Dolphines
                    chbSpec1.Text = "Is Scary";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Can be Trained";
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.Lizard:         //Update special info according to Lizards
                    chbSpec1.Text = "Is Poisonous";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Is Chamelion";
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.Ostrich:         //Update special info according to Ostrich
                    chbSpec1.Text = "Can Fly";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Lay Eggs";
                    lblSpec1.Text = "No. Of Eggs";
                    showText = true;
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.Parrot:         //Update special info according to Parrot
                    chbSpec1.Text = "Can Fly";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Can Talk";
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.Shark:          //Update special info according to Shark        
                    chbSpec1.Text = "Is Scary";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Is Dangerious";
                    DiasableTextSpecs2();
                    break;
                case AllAnimals.Snake:         //Update special info according to Snake
                    chbSpec1.Text = "Is Poisonous";
                    chbSpec2.Visible = true;
                    chbSpec1.Visible = true;
                    chbSpec2.Text = "Is Cobra";
                    DiasableTextSpecs2();         
                    break;

                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }
        }

        /// <summary>
        /// More GUI specific fieds that are present in the extra info
        /// </summary>
        private void DiasableTextSpecs2()
        {
            lblSpec2.Visible = false;
            txtSpec2.Visible = false;
        }

        /// <summary>
        /// Event handler for Click event of addAnimal Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            //validate the inputs
            bool inputOK = ValidateUserInput();
            //update lables if input is validated
            if (!inputOK)
            {
                return;
            }
                //set the category selected by the user
                CategoryType category = (CategoryType)Enum.Parse(typeof(CategoryType), lstCategory.SelectedItem.ToString());
                //set the animal species selected by the user
                AllAnimals animalType = (AllAnimals)Enum.Parse(typeof(AllAnimals), lstAnimal.SelectedItem.ToString());
                //create animal object
                Animal animal = m_animalManager.CreateAnimal(category, animalType.ToString());

                if (animal != null)
                {
                    //set the user input
                    animal.Name = name;
                    animal.Age = age;
                    GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), lstGender.SelectedItem.ToString());
                    animal.Gender = gender;
                    animal.AnimalType = animalType.ToString();
                    animal.ExtraAnimalInfo = rtbImpInfo.Text;
                    int spec1Value;
                    bool txtSpec1Value = InputUtility.GetInteger(txtSpec1.Text, out spec1Value);
                    int spec2Value;
                    bool txtSpec2Value = InputUtility.GetInteger(txtSpec2.Text, out spec2Value);
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
           

            LoadAnimalData(); // to update the listboxes to show the final details
        }

        /// <summary>
        /// This method validates the user input i.e name of the animal and age
        /// </summary>n
        /// <returns>true if valid input is provided other wise shows a message box</returns>
        private bool ValidateUserInput()
        {
            //boolean variables
            bool validAge = InputUtility.GetDouble(txtAge.Text,out age);
            bool validName = InputUtility.CheckString(txtName.Text);
            //if any of the inputs are not valid alert the user
            if (!validName)
            {
                MessageBox.Show("Name can not be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if (!validAge)
            {
                MessageBox.Show("Enter valid age", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Focus();
                return false;
            }
            name = txtName.Text;
            return true;
        }

        /// <summary>
        /// To update the details to show the animal details added by the user
        /// </summary>
        private void LoadAnimalData()
        {
            lsbData.DataSource = m_animalManager.GetAnimalDetailsListArray();
            lsbData.SelectedIndex = m_animalManager.Count - 1;
        }

        /// <summary>
        /// Event handler for CheckedChanged event of Specifications textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Event handler for SelectedIndexChanged event of lstData listbox 
        /// which shows animal normal data provided by the user alont with the additional
        /// specifications in the specific data rich text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal animal = m_animalManager.GetAnimal(lsbData.SelectedIndex);
            rtbSpecificData.Text = animal.GetAnimalSpecificData();
        }

        /// <summary>
        /// Event handler for Click event to load animal photo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>The user will be only able to load the image, this image is not stored in
        /// this verson.</remarks>
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

        /// <summary>
        /// Event handler for the formClosing event of the MainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //show message box to check whether user wants to close the form
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //close the form only if the user clicks on Yes button of the messagebox.
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }

    }
}
