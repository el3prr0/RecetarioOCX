using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class sqlParameters
    {
        string value;
        string parameterName;

        public string Value { get => value; set => this.value = value; }
        public string ParameterName { get => parameterName; set => parameterName = value; }
    }
}
