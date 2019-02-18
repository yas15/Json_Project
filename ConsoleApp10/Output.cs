using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{

    public class Output
    {
        public OutputDrug[] drugs { get; set; }
    }

    public class OutputDrug
    {
        public string name { get; set; }
        public Suggesteddose[] suggestedDose { get; set; }
    }

    public class Suggesteddose
    {
        public string[] indications { get; set; }
        public Doseadministration[] doseAdministrations { get; set; }
    }

    public class Doseadministration
    {
        public string route { get; set; }
        public string method { get; set; }
        public Dos[] doses { get; set; }
    }

    public class Dos
    {
        public Ageband ageBand { get; set; }
        public Quantity quantity { get; set; }
        public Flags flags { get; set; }
    }

    public class Ageband
    {
        public Agelow ageLow { get; set; }
        public Agehigh ageHigh { get; set; }
    }

    public class Agelow
    {
        public int value { get; set; }
        public string unit { get; set; }
    }

    public class Agehigh
    {
        public int value { get; set; }
        public string unit { get; set; }
    }

    public class Quantity
    {
        public float value { get; set; }
        public string unit { get; set; }
    }

    public class Flags
    {
        public string frequency { get; set; }
    }

}

