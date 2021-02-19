using System;
using System.Collections.Generic;
using System.Text;

namespace Walle.Components.Models
{
    public class Propertity
    {
        public Propertity()
        {

        }
        public Propertity(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        public Propertity(string name, string value, string desc)
        {
            this.Name = name;
            this.Value = value;
            this.Description = desc;
        }

        public static Propertity New(string name, string value)
        {
            return new Propertity(name, value);
        }

        public static Propertity New(string name, string value, string desc)
        {
            return new Propertity(name, value, desc);
        }


        public string Name { get; set; } = string.Empty;

        public string Value { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<Propertity> SubPropertities { get; set; } = new List<Propertity>();
    }
}
