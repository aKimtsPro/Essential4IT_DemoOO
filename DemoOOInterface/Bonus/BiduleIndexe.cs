namespace DemoOOInterface;

public class BiduleIndexe
{
    public string this[int a]
    {
        get
        {
            string rslt = "";
            for (int i = 0; i < a; i++)
            {
                rslt += 'a';
            }

            return rslt;
        }
        // set
        // {
        //     
        // }
    }
}