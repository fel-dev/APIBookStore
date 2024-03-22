using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

// This class is used to represent the Book model in the application. It contains the properties of the book such as Id, BookName, Price, Category, and Author. The Id property is decorated with the BsonId attribute to specify that it is the primary key of the document. The BsonRepresentation attribute is used to specify the representation of the Id property in the database. The BookName, Category, and Author properties are decorated with the BsonElement attribute to specify the name of the properties in the database. The Price property is used to store the price of the book.

namespace APIBookStore.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("Name")]
        public string BookName { get; set; } = null!;
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;
        public string Author { get; set; } = null!;
    }
}
