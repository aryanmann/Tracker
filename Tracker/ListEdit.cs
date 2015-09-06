using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracker
{
    public partial class ListEdit : Form
    {
        //The same form changes behaviour with respect to the type it was called with.

        public enum listType { Subject, Topic, Formula };
        private listType type;

        //Takes the main subject list and the current selected items as class constructor arguments.
        private BindingList<Subject> subjects;
        private Subject selectedSubject;
        private Topic selectedTopic;

        //For calling this for a list of formulas (as they need both selected subject and topic)
        public ListEdit(BindingList<Subject> sb, Subject selSub, Topic selTop, listType t)
        {
            type = t;
            subjects = sb;

            selectedSubject = selSub;
            selectedTopic = selTop;

            InitializeComponent();
        }

        //For calling this for a list of formulas (as they need onlu selected subject)
        public ListEdit(BindingList<Subject> sb, Subject selSub, listType t)
        {
            type = t;
            subjects = sb;

            selectedSubject = selSub;
            selectedTopic = null;

            InitializeComponent();
        }

        //For calling this for a list of subjects
        public ListEdit(BindingList<Subject> sb, listType t)
        {
            type = t;
            subjects = sb;

            selectedSubject = null;
            selectedTopic = null;

            InitializeComponent();
        }

        //Sets up all the buttons/lists/names according to the type that was selected
        private void ListEdit_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case listType.Subject:

                    leTitle.Text = "Subject Options";
                    itemList.DataSource = subjects;
                    addToList.Text = "Add Subject";
                    removeFromList.Text = "Remove Subject";

                    break;
                case listType.Topic:

                    leTitle.Text = "Topic Options";
                    itemList.DataSource = selectedSubject.topics;
                    addToList.Text = "Add Topic";
                    removeFromList.Text = "Remove Topic";

                    break;
                case listType.Formula:

                    leTitle.Text = "Formula Options";
                    itemList.DataSource = selectedTopic.formulas;
                    addToList.Text = "Add Formula";
                    removeFromList.Text = "Remove Formula";

                    break;
            }
        }

        //When an item is added to the list
        private void addToList_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case listType.Subject:
                    subjects.Add(new Subject("Empty Subject"));
                    itemName.Text = subjects.Last<Subject>().name;
                    break;
                case listType.Topic:
                    selectedSubject.addTopic();
                    itemName.Text = selectedSubject.topics.Last<Topic>().name;
                    break;
                case listType.Formula:
                    selectedTopic.addFormula();
                    itemName.Text = selectedTopic.formulas.Last<Formula>().name;
                    break;
            }
        }

        //Remove the selected item from the list
        private void removeFromList_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case listType.Subject:
                    subjects.Remove((Subject)itemList.SelectedValue);
                    break;
                case listType.Topic:
                    selectedSubject.deleteTopic((Topic)itemList.SelectedValue);
                    break;
                case listType.Formula:
                    selectedTopic.deleteFormula((Formula)itemList.SelectedValue);
                    break;
            }
        }
        
        //When the selected item is changed i.e new item is selected
        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemList.SelectedValue != null)
            {
                itemName.Text = itemList.SelectedValue.ToString();
                statusSay.Text = itemList.SelectedValue.ToString();
            }
        }

        //Save the name of the item in the list
        private void saveItem_Click(object sender, EventArgs e)
        {
            if (itemList.SelectedValue != null && String.IsNullOrEmpty(itemName.Text) == false)
            {
                switch (type)
                {
                    case listType.Subject:
                        Subject temp = (Subject)itemList.SelectedValue;
                        temp.name = itemName.Text;

                        itemList.DataSource = null;
                        itemList.DataSource = subjects;
                        break;
                    case listType.Topic:
                        Topic tamp = (Topic)itemList.SelectedValue;
                        tamp.name = itemName.Text;

                        itemList.DataSource = null;
                        itemList.DataSource = selectedSubject.topics;
                        break;
                    case listType.Formula:
                        Formula timp = (Formula)itemList.SelectedValue;
                        timp.name = itemName.Text;

                        itemList.DataSource = null;
                        itemList.DataSource = selectedTopic.formulas;
                        break;
                }
            }
            else
            {
                statusSay.Text = "Invalid name or selection.";
            }
        }

        //Give a OK when the form is closed so that we know no error occured
        private void ListEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
