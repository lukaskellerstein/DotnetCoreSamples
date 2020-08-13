namespace App
{
    public class KustoDataObj
    {

        public KustoDataObj(long prId, string prTitle, long buildId, long trId, string trContent, double percentile)
        {
            this.PrId = prId;
            this.PrTitle = prTitle;
            this.BuildId = buildId;
            this.TrId = trId;
            this.TrContent = trContent;
            this.Percentile = percentile;
        }

        public long PrId
        {
            get; set;
        }

        public string PrTitle
        {
            get; set;
        }

        public long BuildId
        {
            get; set;
        }

        public long TrId
        {
            get; set;
        }

        public string TrContent
        {
            get; set;
        }

        public double Percentile
        {
            get; set;
        }
    }

}