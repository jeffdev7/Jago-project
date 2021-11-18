using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIJago.Model.Enum
{
    public class EnumType
    {
        public EnumType(string text, string value)
        {
            Value = value;
            Text = text;
        }

        public EnumType(string text, Guid valueId)
        {
            Value = valueId.ToString();
            Text = text;
        }

        public string Value { get; private set; }
        public string Text { get; private set; }
    }
}
