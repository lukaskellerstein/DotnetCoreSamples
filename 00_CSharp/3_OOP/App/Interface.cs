namespace App
{
    interface IPositionable
    {
        void ChangePosition(double x, double y);
    }

    class UIObject2 : IPositionable
    {
        string id { get; set; }

        string name { get; set; }

        int height { get; set; }
        int width { get; set; }

        protected double x { get; set; }
        protected double y { get; set; }

        // Implements method from interface
        public void ChangePosition(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Overloaded method
        // Allowed to be override 
        public virtual void ChangePosition((double x, double y) position)
        {
            this.x = position.x;
            this.y = position.y;
        }

    }
}