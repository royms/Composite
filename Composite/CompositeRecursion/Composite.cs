﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : Component
    {

        IList<Component> childs = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.name);
            //foreach (Component c in childs)
            //{
            //    c.Draw(space + "    ");
            //}
        }

        public override bool IsBinary()
        {
            if (childs.Count == 1 || childs.Count > 2)
            {
                return false;
            }
            return true;
        }
    }
}
