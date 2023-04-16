namespace Serialize_deserialize
{
    internal class OrderItem
    {
        private int _id;
        public int Id { get { return _id; } set { if (value > 0) { _id = value; } } }
        public Prouduct product { get; set; }
        private int _count;

        public int Count
        {
            get { return _count; }
            set { if (value > 0) { _count = value; } }
        }
        private int _totalprice;
        public int TotalPrice { get { return _totalprice; } set { if (value > 0) { _totalprice = value; } } }





    }
}
