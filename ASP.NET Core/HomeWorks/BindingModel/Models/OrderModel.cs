namespace BindingModel.Models
{
    public class OrderModel
    {
        public string First { get; set; } = null;
        public string Second { get; set; } = null; //чи  реба зануляти якщо не nullable тип??? 
        public double Count { get; set; } 

    }
}
