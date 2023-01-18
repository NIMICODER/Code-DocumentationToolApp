using System;

namespace Documents.Application
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.All)]
    public class DocumentAttribute : Attribute
    {
        public string _Description { get; set; }
        public string _Input { get; set; } = "N/A";
        public string _Output { get; set; } = "N/A";
        public DocumentAttribute(string description, string input = "N/A", string output = "N/A")
        {
            _Description = description;
            _Input = input;
            _Output = output;
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class EnumDescription : System.Attribute
    {
        private readonly string _description;

        public EnumDescription(string description)
        {
            _description = description;
        }

        public string Description
        {
            get { return _description; }
        }
    }

}
