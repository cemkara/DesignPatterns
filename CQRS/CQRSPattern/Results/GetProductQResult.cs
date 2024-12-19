namespace CQRS.CQRSPattern.Results
{
    public class GetProductQResult
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
