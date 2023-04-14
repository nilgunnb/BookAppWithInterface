

using BookWithInterface.Core.Models.BaseModels;

namespace BookWithInterface.Core.Models.MinorModels
{
    public class Book : BaseModel
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }
    }
}