using System.Collections.Generic;
using System.Linq;
using Walle.Components.Extensions;

namespace Walle.Components
{
    public class Propertites : List<Propertity>
    {
        public Propertites Set(Propertity item)
        {
            this.Add(item);
            return this;
        }

        public Propertites Set(string name, string value)
        {
            this.Add(name, value);
            return this;
        }

        public new Propertites Add(Propertity item)
        {
            this.Remove(item);
            base.Add(item);
            return this;
        }

        public Propertity this[string name]
        {
            get => this.FirstOrDefault(p => p.Name == name);
            set => this.Add(name, value.Value);
        }

        public bool Contains(string name)
        {
            return this.HasAny() && this.Any(p => p.Name == name);
        }

        public Propertites Add(string name, string value)
        {
            this.Remove(name);
            base.Add(Propertity.New(name, value));
            return this;
        }

        public new bool Remove(Propertity item)
        {
            var index = this.FindIndex(p => p.Name == item.Name);
            if (index >= 0)
            {
                base.RemoveAt(index);
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool Remove(string name)
        {
            var index = this.FindIndex(p => p.Name == name);
            if (index >= 0)
            {
                base.RemoveAt(index);
                return true;

            }
            else
            {
                return false;
            }
        }
    }

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
