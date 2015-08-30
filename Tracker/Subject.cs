﻿using System;
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

        public override string ToString()
        {
            return name;
        }
    }

    public class Topic
    {
        private string name;
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

        public override string ToString()
        {
            return name;
        }
    }

    public class Formula
    {
        private string name;
        private Topic topic;
        private Subject subject;

        public Formula(string name, Topic parent,Subject grandparent)
        {
            this.name = name;
            this.topic = parent;
            this.subject = grandparent;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
