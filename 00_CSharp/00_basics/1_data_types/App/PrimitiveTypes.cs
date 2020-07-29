
namespace App
{

    static class PrimitiveTypes
    {
        public static void Run()
        {
            // -------------------------------------
            // Typed variable
            // -------------------------------------

            // Boolean
            bool bool1 = true;

            // INTEGER ***************************
            int num1 = 5;

            // DOUBLE vs. DECIMAL ****************
            double d1 = 0.555;
            decimal d2 = 0.555m;

            // STRING ****************************
            string str1 = "AAAA";

            // string interpolation
            string str2 = $"Some text: {str1}";

            // Search string
            string str3 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin tellus tortor, sodales non tristique nec, condimentum non purus. Cras mollis leo justo, vitae vehicula risus interdum a. Sed luctus iaculis ligula. Mauris eget pellentesque ante, ut aliquet urna. In egestas justo sit amet sapien consectetur pretium. Integer lacinia convallis porta. Aenean quis elementum nunc. Mauris at diam lobortis, porta augue nec, tincidunt quam. Nunc tempor vitae metus vitae imperdiet. Maecenas quis dolor ullamcorper, congue magna quis, hendrerit lacus. Vivamus sapien risus, rutrum et porttitor nec, sollicitudin vel lectus. Aliquam sagittis nisi a magna suscipit, eget commodo ipsum ullamcorper. Sed vitae mi non urna euismod hendrerit.";
            var res1 = str3.IndexOf("dolor");

            // Upper, Lower
            var res2 = str3.ToUpper();
            var res3 = str3.ToLower();

            // Index string
            var res4 = str3[10];

            // CHAR ******************************
            char ch1 = 'O';





            // -------------------------------------
            // Dynamic type variable
            // -------------------------------------
            var aaa0 = true;
            var aaa1 = 5;
            var aaa2 = 0.555;
            var aaa3 = 0.555;
            var aaa4 = "abcd";
            var aaa5 = 'O';


            // -------------------------------------
            // Constants
            // -------------------------------------

            const int c1 = 5;
            const string t1 = "text1";
            const bool b1 = false;
        }
    }

}