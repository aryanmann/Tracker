using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker
{
    public class Subject
    {
        public string name { get; set; }
        public BindingList<Topic> topics;

        public Subject(string name)
        {
            this.name = name;
            topics = new BindingList<Topic>();
        }

        public void addTopic(Topic t)
        {
            topics.Add(t);
        }
        public void addTopic(string name)
        {
            Topic t = new Topic(name, this);
            topics.Add(t);
        }
        public void addTopic()
        {
            Topic t = new Topic("Empty Topic", this);
            topics.Add(t);
        }

        public void deleteTopic(Topic t)
        {
            topics.Remove(t);
        }

        public override string ToString()
        {
            return name;
        }
    }

    public class Topic
    {
        public string name;
        private Subject subject;
        public BindingList<Formula> formulas;

        public Topic(string name, Subject parent)
        {
            this.name = name;
            this.subject = parent;
            formulas = new BindingList<Formula>();
        }

        public void addFormula(Formula f)
        {
            formulas.Add(f);
        }
        public void addFormula(string name)
        {
            Formula f = new Formula(name, this, this.subject);
            formulas.Add(f);
        }
        public void addFormula()
        {
            Formula f = new Formula("Empty Formula", this, this.subject);
            formulas.Add(f);
        }

        public void deleteFormula(Formula f)
        {
            formulas.Remove(f);
        }

        public override string ToString()
        {
            return name;
        }
    }
   
    public class Formula
    {
        private Topic topic;
        private Subject subject;
        
        public string name { get; set; }
        
        public string formula { get; set; }
        public string description { get; set; }

        public Formula(string name, Topic top, Subject sub)
        {
            this.name = name;
            this.topic = top;

            this.subject = sub;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
