//This program takes an integer and returns the largest possible number based on that input.
//For example, if I input 2, then the largest number is 99.

int largestNumber(int n) {
    
    //9 * 1 = 9
    //9 * 11 = 99
    //9 * 111 = 999
    
    int solution;
    
    
    if (n == 1)
    {
        solution = 9;
    }
    
    else if (n < 1)
    {
        solution = 0;
    }
    
    else
    {
        string nines = "";
    
        for (int i=0; i < n; i++)
        {
            nines += "9";
        }
        
        solution = Int32.Parse(nines);
        
    }
    
    return solution;

}
