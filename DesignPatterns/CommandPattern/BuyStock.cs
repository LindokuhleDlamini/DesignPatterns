namespace DesignPatterns.CommandPattern
{
    public class BuyStock : IOrder
    {
        protected Stock _stock;

        public BuyStock(Stock stock)
        {
            _stock = stock;
        }

        public void Execute()
        {
            _stock.Buy();
        }
    }
}
