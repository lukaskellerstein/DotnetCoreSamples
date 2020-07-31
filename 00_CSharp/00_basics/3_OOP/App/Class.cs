namespace App
{

    class UIObject
    {
        // Private properties doesn't have to have a getter and setter
        string id;
        string name;
        int height;
        int width;

        // Protected or Public properties should have a getter and setter
        protected double x { get; set; }
        protected double y { get; set; }

        // Not-Allowed to be override
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

    class Box : UIObject
    {
        double margin { get; set; }
        double padding { get; set; }

        // OVERRIDING
        public override void ChangePosition((double x, double y) position)
        {
            this.x = position.x + this.padding;
            this.y = position.y + this.padding;

            // cannot access 
            // this.height = 4;
        }
    }


}