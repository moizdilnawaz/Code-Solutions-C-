public class Pair{
	public static int sockMerchant(int n, List<int> ar)
	{
        List<int> tempArray = new List<int>();
        int countOfPairs = 0;
        
        for(int i=0;i<n; i++){
            if(tempArray.Contains(ar[i]))
            {
                tempArray.Remove(ar[i]);
                countOfPairs++;
            }
            else{
                tempArray.Add(ar[i]);
            }
        }
        return countOfPairs;
	}

}