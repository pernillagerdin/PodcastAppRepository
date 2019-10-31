using System;
using System.Linq;
using System.Windows.Forms;
using PodcasstApp.BLL;

namespace PodcastApp
{
    public partial class PodcastAppGUI : Form
    {
        public string CategoryToChange;
        public PodcastAppGUI()
        {
            InitializeComponent();
            onLoadFillCategoryList()
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblUppdateringsfrekvens_Click(object sender, EventArgs e)
        {

        }

        private void lvPodcastList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            if (Validation.CharacterInputLengthValidation(tbCategory.Text))
            {
                if (!Validation.CategoryExistValidation(tbCategory.Text))
                {
                    //MessageBox.Show("Category successfully added!", "Success", MessageBoxButtons.OK);
                    string category = tbCategory.Text;
                    XML_FileAccess.AddToCategoryXMLFile(category);
                    onLoadFillCategoryList();
                    tbCategory.Clear();
                }
                else
                {
                    MessageBox.Show("Category already exists.", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Input. \nHas to be between 3-30 characters long \nand cannot contain any numbers and cannot \n start with a white space.", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            if (tbCategory.Text.Length == 0 || Validation.CategoryExistValidation(tbCategory.Text))
            {
                // MessageBox.Show("Category successfully removed.", "Success", MessageBoxButtons.OK);
                string category = tbCategory.Text;
                XML_FileAccess.RemoveFromCategoryXMLFile(category);
                onLoadFillCategoryList();
                tbCategory.Clear();
            }
            else
            {
                MessageBox.Show("The input does not correnspomd with an existing category.", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            string newCategory = tbCategory.Text;
            XML_FileAccess.ChangeCategoriItem(CategoryToChange, newCategory);

            onLoadFillCategoryList();
            tbCategory.Clear();
        }

        private void lvCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCategoryList.SelectedItems.Count > 0)
            {
                tbCategory.Clear();
                ListViewItem listViewItem = lvCategoryList.SelectedItems[0];
                tbCategory.Text = listViewItem.Text;
                CategoryToChange = listViewItem.Text;
            }
        }

        private void onLoadFillCategoryList()
        {
            lvCategoryList.Clear();
            foreach (string title in XML_FileAccess.LoadCategoryXMLFile())
            {
                lvCategoryList.Items.Add(title);
            }
                
        }
        
    }
}
