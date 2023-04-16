namespace Serialize_deserialize
{
    internal class Order
    {
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		public List<OrderItem>orderItems { get; set; }

	}
}
