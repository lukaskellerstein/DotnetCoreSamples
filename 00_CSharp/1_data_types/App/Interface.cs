namespace App
{

    static class MyInterface
    {
        public static void Run()
        {

            // IN C# it only make sense to use it 
            // for CLASSES as inheritance
            // we cannot instantiante interface
            // so it cannot be used as immutable object 
            // as in typescript

            // PersonDTO var1 = { id = "aaaa", name = "weird", role: "asfasf" };
            // var var2 = <PersonDTO>{ id = "aaaa", name = "weird", role = "asfasf" };
            // var var3 = { id: "aaaa", name: "weird", role: "asfasf" };
        }

    }

    interface IMovable
    {
        int x { get; set; }
        int y { get; set; }
    }

    interface ISizeable
    {
        int height { get; set; }
        int width { get; set; }
    }

    interface PersonDTO
    {
        string id { get; set; }
        string name { get; set; }
        string role { get; set; }
    }
}