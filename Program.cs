using BagrutClass24q4;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BusStation[] stArr = new BusStation[3];
        stArr[0] = new BusStation(1, new int[] { 2, 5, 3 }, 3);
        stArr[1] = new BusStation(2, new int[] { 1, 2, 3,4 }, 4);
        stArr[2] = new BusStation(3, new int[] { 7, 2, 3, 4, 5 }, 5);

        Node<int> busLst = AllStations(stArr);
        Console.WriteLine(busLst);
    }
    

    //סעיף ב
    public static Node<int> AllStations(BusStation[] stArr)
    {

        Node<int> busLst = new Node<int>(0);//יוצרים חוליה תותבת שתוסר בסיום
        Node<int> last = busLst;
        int[] firstStnArr = stArr[0].GetArr();
        int bussesAmount = stArr[0].GetAmount();
        bool stoppingAll;

        for (int i = 0; i < bussesAmount; i++)
        {
            stoppingAll=true;
            for (int j = 1; j < stArr.Length; j++)
            {
                //Console.WriteLine(firstStnArr[i]);
                if (!stArr[j].IsStopping(firstStnArr[i]))
                    stoppingAll=false;
            }
            if (stoppingAll)
            {
                last.SetNext(new Node<int>(firstStnArr[i]));
                last = last.GetNext();
                Console.WriteLine(busLst);
            }
        }
        busLst = busLst.GetNext();
        return busLst;
    }
}

public class BusStation

{
    private int num;
    private int[] arr;
    private int amount;
        
        public BusStation(int num, int[] arr, int amount)
    {
        this.num = num;
        this.arr = arr;
        this.amount = amount;
    }
    //סעיף א
    public bool IsStopping(int n)
    {
        for (int i = 0; i < this.amount; i++)
        {
            if (this.arr[i] == n)
            {
                return true;
            }
        }
        return false;
    }

    public int[] GetArr()
    {
        return this.arr;
    }

    internal int GetAmount()
    {
        return this.amount;
    }
}