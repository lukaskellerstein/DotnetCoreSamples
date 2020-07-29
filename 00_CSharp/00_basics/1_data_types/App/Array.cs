namespace App
{

    static class MyArray
    {

        // ------------------------------------------------
        // ARRAY - has fixed length
        // ------------------------------------------------
        public static void Run()
        {

            // declaration
            int[] arr0 = new int[3];
            arr0[0] = 10;
            arr0[1] = 11;
            arr0[2] = 12;
            // is not possible, we have only 3 places in array
            arr0[3] = 13;

            // declaration with initialization
            int[] arr1 = { 1, 2, 3, 4, 5 };
            // is not possible, we have only 5 places in array
            arr1[5] = 15;


        }
    }



}