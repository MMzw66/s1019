﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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
        public ActionResult myview()
        {
            return View();

        }
        /// <summary>
        /// 欢迎页面 
        /// </summary>
        /// <returns></returns>
        public ActionResult Welcome()
        {
            var a = 100;
            var sum = 0;
            for (var i = 1; i <= a; i++)
            {
                sum += i;
            }

            ViewBag.sum = sum;
            return View();
        }

        /// <summary>
        /// 新闻列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List(int page=10)
        {
            string[] data = new string[] { 
                "新闻1XXXXXXXXXXXXXXXXXXXXXXXX",
                "新闻2XXXXXXXXXXXXXXXXXXXXXXXX",
                "新闻3XXXXXXXXXXXXXXXXXXXXXXXX",
                "新闻4XXXXXXXXXXXXXXXXXXXXXXXX",
                "新闻5XXXXXXXXXXXXXXXXXXXXXXXX"
               };

            ViewBag.data = data;
            ViewBag.Page = page;
            //ViewData["data"] = data;
            //ViewData.Model = data;
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        /// <summary>
        /// 添加新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// 保存新闻内容
        /// </summary>
        /// <returns></returns>
        public ActionResult Save(string title, string content)
        {
            ViewBag.Title = title;
            ViewBag.Content = content;
            return View();
        }
    }
}