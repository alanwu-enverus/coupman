using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using webapi.Entities;

namespace webapi.Models.Coupon
{
    public class CouponRequest
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        [EnumDataType(typeof(OfferType))]
        public string OfferType { get; set; }
        public string OfferValue { get; set; }

        public bool IsSomeConditionApply { get; set; } = true;
        public bool IsNotValidWithOtherPromotion { get; set; } = true;
        public string CustomCondition { get; set; }
        public List<CategoryMessage> CouponCategories { get; set; } = new List<CategoryMessage>();
        public List<CityMessage> CouponCities { get; set; } = new List<CityMessage>();
        [DataType(DataType.Date)]
        public string StartDate { get; set; }
        [DataType(DataType.Date)]
        public string EndDate { get; set; }
    }
}