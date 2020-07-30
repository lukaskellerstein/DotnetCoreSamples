using System.Collections.Generic;

namespace App
{


    interface ILenghtable<T>
    {

        double GetLength(T item);
    }


    class MyList<T>
    {



        void Sort(T coll)
        {

            T checkType = default(T);

            if (checkType is string)
            {
            }


        }
    }
}