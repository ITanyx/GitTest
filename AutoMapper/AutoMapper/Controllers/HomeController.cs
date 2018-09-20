using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoMapper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ContentResult Content()
        {
            ////普通转换 字段相同，不区分大小写
            //OrdinaryTransfer();

            ////特殊转换 字段不对应 设置映射
            //SpecialTransfer();

            Mapper.Initialize(cfg => cfg.CreateMap<UrbanTransportationFeeInfo, TPPPlanningApplyOrdersCostsInformationModel>());

            UrbanTransportationFeeInfo urbanTransportationFee = new UrbanTransportationFeeInfo()
            {
                CostsInfoID = Guid.NewGuid().ToString("N"),
                CurrencyCode = "CN",
                CurrencySymbol = "￥",
                EstimatedPrice = "100.23",
                HighestPrice = "1245.2",
                ReferencePrice = "765.235",
                TripCostType = "TripCostType",
                ChildList = new List<UrbanTransportationChildInfo>()
            };
            urbanTransportationFee.ChildList.Add(new UrbanTransportationChildInfo()
            {
                CostCode = "GoTrip",
                CurrencyCode = "CN",
                CurrencySymbol = "￥",
                EstimatedPrice = "50",
                HighestPrice = "52.23",
                ReferencePrice = "30.23"
            });

            TPPPlanningApplyOrdersCostsInformationModel ordersCostsInformationModel = null;
            ordersCostsInformationModel = Mapper.Map<UrbanTransportationFeeInfo, TPPPlanningApplyOrdersCostsInformationModel>(urbanTransportationFee);
            //ordersCostsInformationModel.TravelInfoID = travelCostInfo.TravelInfoId;
            //costsInformationModelList.Add(ordersCostsInformationModel);

            return Content("1");
        }

        private OrderDto OrdinaryTransfer()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Order, OrderDto>());
            Order order = new Order()
            {
                Id = 123,
                Name = "哈哈哈",
                Age = 100
            };
            OrderDto dto = Mapper.Map<OrderDto>(order);
            return dto;
        }

        private OrderDto SpecialTransfer()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Order, OrderDto>().ForMember(l => l.Age_Dto, p =>
            {
                p.MapFrom(s => s.Age);
            }));
            Order order = new Order()
            {
                Id = 123,
                Name = "哈哈哈",
                Age = 100
            };
            OrderDto dto = Mapper.Map<OrderDto>(order);
            return dto;
        }
    }

    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class OrderDto
    {
        public int Id { get; set; }

        public string name { get; set; }

        public int Age_Dto { get; set; }
    }

    /// <summary>
    /// 跨城市交通费信息类
    /// </summary>
    public class UrbanTransportationFeeInfo
    {
        /// <summary>
        /// CostsInfoID
        /// </summary>
        public string CostsInfoID { get; set; }

        /// <summary>
        /// TripCostType
        /// </summary>
        public string TripCostType { get; set; }

        /// <summary>
        /// 参考价
        /// </summary>
        public string ReferencePrice { get; set; }

        /// <summary>
        /// 预估金额
        /// </summary>
        public string EstimatedPrice { get; set; }

        /// <summary>
        /// 最高价格
        /// </summary>
        public string HighestPrice { get; set; }

        /// <summary>
        /// 费用币种
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 币种符号
        /// </summary>
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// 跨城市交通费子项集合
        /// </summary>
        public List<UrbanTransportationChildInfo> ChildList { get; set; }
    }

    /// <summary>
    /// 跨城市交通费子项信息类
    /// </summary>
    public class UrbanTransportationChildInfo
    {
        /// <summary>
        /// 费用子项编码 GoTrip ：去程，ReturnTrip：返程
        /// </summary>
        public string CostCode { get; set; }

        /// <summary>
        /// 参考价
        /// </summary>
        public string ReferencePrice { get; set; }

        /// <summary>
        /// 预估金额
        /// </summary>
        public string EstimatedPrice { get; set; }

        /// <summary>
        /// 最高价格
        /// </summary>
        public string HighestPrice { get; set; }

        /// <summary>
        /// 费用币种
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 币种符号
        /// </summary>
        public string CurrencySymbol { get; set; }
    }

    public class TPPPlanningApplyOrdersCostsInformationModel
    {
        public string CostsInfoID
        {
            get;
            set;
        }

        public string TravelInfoID
        {
            get;
            set;
        }

        public string TripCostType
        {
            get;
            set;
        }

        public string TripCostTypeName
        {
            get;
            set;
        }

        public decimal StandardPrice
        {
            get;
            set;
        }

        public decimal HighestPrice
        {
            get;
            set;
        }

        public decimal EstimatedPrice
        {
            get;
            set;
        }

        public string Detail
        {
            get;
            set;
        }

        public short Duration
        {
            get;
            set;
        }

        public string CurrencyCode
        {
            get;
            set;
        }
    }
}