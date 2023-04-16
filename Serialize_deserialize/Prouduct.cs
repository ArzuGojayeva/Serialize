namespace Serialize_deserialize
{
    internal class Prouduct
    {
        private  string _name;
        private int _price;
        private int _id;
        public int Id{ get; set; }
        public string Name { get { return _name; } set { if (value.Length > 2) { _name = value; } } }
        public int Price { get { return _price; } set { if (value > 0) { _price = value; } } }
    }
}
