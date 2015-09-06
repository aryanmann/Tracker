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
        public enum listType { Subject, Topic, Formula };
        private listType type;

        private BindingList<Subject> subjects;
        private Subject selectedSubject;
        private Topic selectedTopic;

        public ListEdit(BindingList<Subject> sb, Subject selSub, Topic selTop, listType t)
        {
            type = t;
            subjects = sb;

            selectedSubject = selSub;
            selectedTopic = selTop;

            InitializeComponent();
        }

        public ListEdit(BindingList<Subject> sb, Subject selSub, listType t)
        {
            type = t;
            subjects = sb;

            selectedSubject = selSub;
            selectedTopic = null;

            InitializeComponent();
        }

        public ListEdit(BindingList<Subject> sb, listType t)
        {
            type = t;
            subjects = sb;

            selectedSubject = null;
            selectedTopic = null;

            InitializeComponent();
        }

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
        
        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemList.SelectedValue != null)
            {
                itemName.Text = itemList.SelectedValue.ToString();
                statusSay.Text = itemList.SelectedValue.ToString();
            }
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            if (itemList.SelectedValue != null)
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
        }

        private void ListEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
