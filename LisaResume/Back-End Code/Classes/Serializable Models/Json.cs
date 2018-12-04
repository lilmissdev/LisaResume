
using System.Collections.Generic;

namespace LisaResume.Back_End_Code.Classes.Serializable_Classes
{
    public class RootLevel
    {
        public List<Rootobject> root { get; set; } = new List<Rootobject>();
    }

    public class Rootobject
    {
        public Rootofjson rootOfJson { get; set; }
    }

    public class Rootofjson
    {
        public Basics basics { get; set; }
        public Education education { get; set; }
        public string[] interests { get; set; }
        public Location location { get; set; }
        public Reference[] references { get; set; }
        public string[] skills { get; set; }
        public Volunteer volunteer { get; set; }
        public Work[] work { get; set; }
    }

    public class Basics
    {
        public string email { get; set; }
        public string label { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public object[] picture { get; set; }
        public string summary { get; set; }
        public string[] website { get; set; }
    }

    public class Education
    {
        public Element element { get; set; }
    }

    public class Element
    {
        public string area { get; set; }
        public string[] courses { get; set; }
        public string endDate { get; set; }
        public string gpa { get; set; }
        public string institution { get; set; }
        public string startDate { get; set; }
        public string website { get; set; }
    }

    public class Location
    {
        public string address { get; set; }
        public string city { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
        public string region { get; set; }
    }

    public class Volunteer
    {
        public Element1 element { get; set; }
    }

    public class Element1
    {
        public string endDate { get; set; }
        public string organization { get; set; }
        public string position { get; set; }
        public string startDate { get; set; }
        public string summary { get; set; }
        public string website { get; set; }
    }

    public class Reference
    {
        public string company { get; set; }
        public string contact { get; set; }
        public string name { get; set; }
        public string position { get; set; }
    }

    public class Work
    {
        public string company { get; set; }
        public string endDate { get; set; }
        public string position { get; set; }
        public string startDate { get; set; }
        public string summary { get; set; }
        public string website { get; set; }
    }

}