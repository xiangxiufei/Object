namespace Object.Application.Contracts.DTO
{
    public class GoodsDto
    {
        /// <summary>
        /// 商品代码
        /// </summary>
        public string Spdm { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Spmc { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        public string Sptm { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
    }
}