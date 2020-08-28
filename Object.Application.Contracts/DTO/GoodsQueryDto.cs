using System.ComponentModel.DataAnnotations;

namespace Object.Application.Contracts.DTO
{
    public class GoodsQueryDto
    {
        /// <summary>
        /// 门店代码
        /// </summary>
        public string CompId { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        [Required]
        public string Sptm { get; set; }
    }
}