namespace App
{

    abstract class UIObjectBase
    {
        // Private properties doesn't have to have a getter and setter
        string id;
        string name;
        int height;
        int width;

        // Protected or Public properties should have a getter and setter
        protected double x { get; set; }
        // we should NOT allow acces public property directly, we should use getter and setter
        public double y;

        public void ChangePosition(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void ChangePosition((double x, double y) position);

    }

    class Box1 : UIObjectBase
    {
        double margin { get; set; }
        double padding { get; set; }

        // OVERRIDING
        public override void ChangePosition((double x, double y) position)
        {
            this.x = position.x;
            this.y = position.y;
        }

    }


}