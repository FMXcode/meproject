using System;

namespace meproject
{
    class group
    {
        public
        int name;
        int yeur;
        int noumber;


        vid GetX(string  name, int  yeur, int  noumber)
        {
            ref name = name;
            ref yeur = yeur;
            ref noumber = noumber;

        }
        
       int SetX()
        {
            return name;
            return yeur;
            return noumber;
        }



    }
    class Program
    { 
        static void Main(string[] args)
        { 
            
            group A = new group();
            GetX(A);
            SetX(a);

        }
    }
}
