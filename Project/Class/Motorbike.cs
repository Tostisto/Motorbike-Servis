namespace Project
{
    public class Motorbike
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }

        public Motorbike() { }

        public Motorbike(string name, int price, string description, string? image)
        {
            Name = name;
            Price = price;
            Description = description;
            Image = image;
        }

        public Motorbike(int Id, string Name, int Price, string description, string image)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Description = description;
            this.Image = image;
        }
    }
}
