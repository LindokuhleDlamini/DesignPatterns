namespace DesignPatterns.CommandPattern
{
    public class SellStock : IOrder
    {
        protected Stock _stock;

        public SellStock(Stock stock)
        {
            _stock = stock;
        }

        public void Execute()
        {
            _stock.Sell();
        }
    }
}
