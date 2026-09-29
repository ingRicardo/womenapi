using System.Collections.ObjectModel;

namespace WebWomen.Models
{
    public class CSharpKeywordModel<T>
    {
        public string Name { get; set; } = string.Empty;
        public List<T> Items { get; set; } = new();

        public CSharpKeywordModel() { }

        public CSharpKeywordModel(string name, IEnumerable<T> items)
        {
            Name = name;
            Items = items.ToList();
        }
    }
    
}
