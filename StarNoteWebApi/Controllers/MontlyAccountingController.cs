﻿using StarNoteWebApi.DataAccess;
using StarNoteWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StarNoteWebApi.Controllers
{
    [Authorize]
    public class MontlyAccountingController : ApiController
    {
        IDAO dao;
        MontlyAccountingController()
        {
            dao = DAOBase.GetDAO();
        }
        [HttpGet]
        public List<MontlyAccountingModel> GetMontlySales(string date)
        {
            List<MontlyAccountingModel> MontlySales = new List<MontlyAccountingModel>();
            MontlySales = dao.Montlysalesfill(date);
            return MontlySales;
        }
        [HttpGet]
        public List<MontlyAccountingModel> GetMontlyPurchase(string date)
        {
            List<MontlyAccountingModel> MontlyPurchase = new List<MontlyAccountingModel>();
            MontlyPurchase = dao.Montlypurchasefill(date);
            return MontlyPurchase;
        }
        [HttpGet]
        public List<DataPoint> GetSalesChart(string date)
        {
            List<DataPoint> SalesChart = new List<DataPoint>();
            SalesChart = dao.Loadsaleschartaccounting(date);
            return SalesChart;
        }
        [HttpGet]
        public List<DataPoint> GetPurchaseChart(string date)
        {
            List<DataPoint> PurchaseChart = new List<DataPoint>();
            PurchaseChart = dao.loadpurchasechartsaccounting(date);
            return PurchaseChart;
        }
        [HttpGet]
        public List<DataPoint> GetPurchasePie(string date)
        {
            List<DataPoint> Purchasepie = new List<DataPoint>();
            Purchasepie = dao.loadpurchasepiesaccounting(date);
            return Purchasepie;
        }
        [HttpGet]
        public List<DataPoint> GetSalesPie(string date)
        {
            List<DataPoint> Salespie = new List<DataPoint>();
            Salespie = dao.Loadsalespiesaccounting(date);
            return Salespie;
        }

    }
}
