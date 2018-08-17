﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XDF.Core.Entity;
using XDF.Core.Helper.Ajax;
using XDF.DapperLambda;

namespace XDF.Web.Controllers
{
    /// <summary>
    /// 订单详情
    /// </summary>
    public class OrderDetail
    {
        /// <summary>
        ///  订单id
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
        public  string OrderCode { get; set; }
    }

    public class OrderController : BaseController
    {
        /// <summary>
        /// 获取订单详情
        /// </summary>
        /// <param name="orderCode">订单编号</param>
        /// <returns></returns>
        [HttpPost]
        public OrderDetail Get(string orderCode)
        {
            return new OrderDetail() { OrderCode=orderCode, OrderId = "1213arweqrwew", UserId = 100 };
        }
        [HttpPost]
        [Route("GetOrderDetail")]
        public OrderDetail GetOrderDetail(OrderDetail orderdetail)
        {
            return orderdetail;
        }
        [HttpGet]
        [Route("AddConfig")]
        public AjaxResultModel<List<ConfigEntity>> AddConfig()
        {
            var con = new SqlConnection("user id=db_whbmowner;data source=10.202.202.245;password=levitra5gt#;persist security info=True;initial catalog =BJ20140915;Connect Timeout=300");
            var res = con.QuerySet<ConfigEntity>().Where(m=>m.Id>=1).ToList();
            return AjaxResult.Success(res);
        }
    }
}