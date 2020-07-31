using System;
using System.Collections.Generic;

namespace App
{


    abstract class Asset
    {
        string Uid { get; set; }

        public string Ticker { get; set; }

        public Asset(string ticker)
        {
            this.Uid = Guid.NewGuid().ToString();
            this.Ticker = ticker;
        }


    }


    class Future : Asset
    {

        public List<(string contractMonth, DateTime date, double price)> HistData { get; set; }

        public Future(string ticker) : base(ticker)
        {
        }

    }


    class Stock : Asset
    {

        public string Sector { get; set; }
        public string Industry { get; set; }

        public List<(DateTime date, double price)> HistData { get; set; }


        public Stock(string ticker, string sector, string industry) : base(ticker)
        {
            this.Sector = sector;
            this.Industry = industry;
        }
    }







}