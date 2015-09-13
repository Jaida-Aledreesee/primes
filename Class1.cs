using System;

public class checknumbers
{

    public Boolean checkNumber(int number)
    {
       

            int i;
            if (number == 1)
            {
                return false;

            }
            else if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0)
            {
                return false;
            }
            else
            {

                for (i = 3; i <= Math.Sqrt(number) + 1; i = i + 2)
                {

                    if (number % i == 0)
                    {

                        return false;
                     
                    }
                }

                if (i >= Math.Sqrt(number) + 1)
                {

                    return true;

                }
               
                return true;
               
            }
          
        }


    }


    