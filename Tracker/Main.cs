using System;
using System.Collections;
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

    public partial class TrackerForm : Form
    {

        //Contains a list of all subjects and the data (topics->formulas) contained within them. 
        private BindingList<Subject> subjects;

        //The current selected item in their respecitve lists (can be null)
        Subject currentSubject;
        Topic currentTopic;
        Formula currentFormula;

        public TrackerForm()
        {
            InitializeComponent();

            subjects = new BindingList<Subject>();

            //display the name property of the subjects in the list of subjects
            listSubject.DisplayMember = "name";
            listSubject.DataSource = subjects;
            
        }

        private void TrackerForm_Load(object sender, EventArgs e)
        {
            //The bottom bar that tells you information.
            statusSay.Text = "Initialized";
        }

        
        //When a new item on the subject list is selected, update all other lists and show the first formula of the first topic
        private void listSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSubject = (Subject)listSubject.SelectedValue;

            if (currentSubject != null)
            {
                listTopic.DisplayMember = "name";
                listTopic.DataSource = currentSubject.topics;

                statusSay.Text = "Selected " + currentSubject.ToString();
            }
            else if (currentSubject == null)
            {
                listTopic.DataSource = null;
                statusSay.Text = "No subject to be selected";

            }

            listFormula.DataSource = null;
        }

        //Same principle as above method
        private void listTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTopic = (Topic)listTopic.SelectedValue;

            if (currentTopic != null)
            {
                listFormula.DataSource = currentTopic.formulas;

                statusSay.Text = "Selected " + currentTopic.ToString();
            }
            else if(currentTopic == null)
            {
                listFormula.DataSource = null;
                statusSay.Text = "No topic to be selected";
            }
        }

        //Same principle as above method
        private void listFormula_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFormula = (Formula)listFormula.SelectedValue;

            if (currentFormula != null)
            {
                propName.Text = currentFormula.name;
                propDescription.Text = currentFormula.description;
                propFormula.Text = currentFormula.formula;

                statusSay.Text = "Selected " + currentFormula.ToString();
            }
            else if(currentFormula == null)
            {
                propName.Text = "No Formula";
                propDescription.Text = "Can't describe nothing.";
                propFormula.Text = "Nothing";
                
                statusSay.Text = "No formula to be selected";
            }
        }

        //When the details of the formula are saved, update the details in the right panel
        private void propSave_Click(object sender, EventArgs e)
        {
            if(currentFormula != null)
            {
                currentFormula.formula = propFormula.Text;
                currentFormula.description = propDescription.Text;
            }
        }

        //Add or remove subjects in a new dialogue box
        private void subjectOptions_Click(object sender, EventArgs e)
        {
            ListEdit ld = new ListEdit(subjects, ListEdit.listType.Subject);
            ld.ShowDialog();

            if(ld.DialogResult == DialogResult.OK)
            {
                listSubject.DataSource = null;
                listSubject.DataSource = subjects;
            }
        }

        //Add or remove topics in a new dialogue box
        private void topicOptions_Click(object sender, EventArgs e)
        {
            currentSubject = (Subject)listSubject.SelectedValue;

            if (currentSubject != null)
            {
                ListEdit ld = new ListEdit(subjects, currentSubject, ListEdit.listType.Topic);
                ld.ShowDialog();

                if(ld.DialogResult == DialogResult.OK)
                {
                    listTopic.DataSource = null;
                    listTopic.DataSource = currentSubject.topics;

                    if(currentTopic == null && currentSubject.topics.Count > 0)
                    {
                        currentTopic = currentSubject.topics[0];
                    }
                }
                  
            }
            else
            {
                statusSay.Text = "Invalid Subject.";
            }

        }

        //Add or remove formulas in a new dialogue box
        private void formulaOptions_Click(object sender, EventArgs e)
        {
            currentSubject = (Subject)listSubject.SelectedValue;
            currentTopic = (Topic)listTopic.SelectedValue;

            if (currentSubject != null && currentTopic != null)
            {
                ListEdit ld = new ListEdit(subjects, currentSubject, currentTopic, ListEdit.listType.Formula);
                ld.ShowDialog();

                if(ld.DialogResult == DialogResult.OK)
                {
                    listFormula.DataSource = null;
                    listFormula.DataSource = currentTopic.formulas;
                }
            }
            else
            {
                statusSay.Text = "Invalid Subject or Topic";
            }
        }

        //The exit button on the navigation bar
        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
