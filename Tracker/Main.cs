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
        private BindingList<Subject> subjects;

        Formula currentSelection;
        public TrackerForm()
        {
            InitializeComponent();
        }

        private void TrackerForm_Load(object sender, EventArgs e)
        {
            subjects = new BindingList<Subject>();

            Subject Physics = new Subject("Physics");
            Physics.addTopic("Magnets");
            Physics.topics[0].addFormula("Magnetic Field in a solenoid.");
            Physics.topics[0].addFormula("Magnetic FIeld in a circular loop");
            subjects.Add(Physics);

            Subject Maths = new Subject("Maths");
            Maths.addTopic("Integration");
            Maths.topics[0].addFormula("(a+b)^2");
            subjects.Add(Maths);

            listSubject.DisplayMember = "name";
            listSubject.DataSource = subjects;

        }

        private void listSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject temp = (Subject)listSubject.SelectedValue;

            listTopic.DisplayMember = "name";
            listTopic.DataSource = temp.topics;

        }

        private void listTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            Topic t = (Topic)listTopic.SelectedValue; 

            listFormula.DataSource = t.formulas;
        }

        private void listFormula_SelectedIndexChanged(object sender, EventArgs e)
        {
            Formula f = (Formula)listFormula.SelectedValue;
            currentSelection = f;

            propName.Text = currentSelection.name;
            propDescription.Text = currentSelection.description;
            propFormula.Text = currentSelection.formula;

        }

        private void propSave_Click(object sender, EventArgs e)
        {
            if(currentSelection != null)
            {
                currentSelection.formula = propFormula.Text;
                currentSelection.description = propDescription.Text;
            }
        }
    }
}
