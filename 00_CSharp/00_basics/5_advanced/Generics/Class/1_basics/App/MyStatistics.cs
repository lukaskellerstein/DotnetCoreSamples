using System.Linq;

namespace App
{

    static class AssetStatisticsFactory<T> where T : Asset
    {

        private static AssetStatistics<T> StatsForAsset(T asset)
        {
            if (asset is Future)
            {
                return new FutureStatistics(asset as Future) as AssetStatistics<T>;
            }
            else if (asset is Stock)
            {
                return new StockStatistics(asset as Stock) as AssetStatistics<T>;
            }
            else
            {
                return null;
            }
        }

        public static (double count, double avg, double stdDev) Get(T asset)
        {
            var stats = StatsForAsset(asset);
            return (stats.GetCount(), stats.GetAvg(), stats.GetStdDev());
        }

    }


    abstract class AssetStatistics<T> where T : Asset
    {
        protected T Asset { get; set; }

        public AssetStatistics(T asset)
        {
            this.Asset = asset;
        }

        // public double GetCount()
        // {
        //     return this.Asset.HistData.Length;
        // }
        public abstract double GetCount();
        public abstract double GetAvg();
        public abstract double GetStdDev();

    }


    class FutureStatistics : AssetStatistics<Future>
    {

        public FutureStatistics(Future asset) : base(asset)
        {
        }

        public override double GetCount()
        {
            return this.Asset.HistData.Count;
        }
        public override double GetAvg()
        {
            // for simplification ignore contract Months
            var prices = from x in this.Asset.HistData select x.price;
            return prices.Average();
        }

        public override double GetStdDev()
        {
            // for simplification ignore contract Months
            var prices = from x in this.Asset.HistData select x.price;
            return prices.StandardDeviation();
        }


    }

    class StockStatistics : AssetStatistics<Stock>
    {

        public StockStatistics(Stock asset) : base(asset)
        {
        }

        public override double GetCount()
        {
            return this.Asset.HistData.Count;
        }
        public override double GetAvg()
        {
            var prices = from x in this.Asset.HistData select x.price;
            return prices.Average();
        }

        public override double GetStdDev()
        {
            var prices = from x in this.Asset.HistData select x.price;
            return prices.StandardDeviation();
        }

    }

}