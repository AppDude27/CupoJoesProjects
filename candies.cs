/*  n children have got m pieces of candy. They want to eat as much candy as they can, but each child must eat exactly 
 the same amount of candy as any other child. Determine how many pieces of candy will be eaten by all the children 
 together. Individual pieces of candy cannot be split. */
 
 //For example n=3 and m=10, the output should be 9
 //Each child can only eat 3 pieces of candy
 
 int candies(int n, int m) {
    
    int numOfCandies = 0;

    //If there are more children than candy, return 0
    if (n > m)
    {
        numOfCandies = 0;
        return numOfCandies;
    }
    
    //If # of Children and Candy are same, then return m candy
    else if (n == m)
    {
        numOfCandies = m;
        return numOfCandies;
    }
    
    //Divide the candy among the children
    else
    {
        //Divde up the candy, multiply it by the number of children
        numOfCandies = ((m/n) * n);
        return numOfCandies;
        
    }
    //Else 
    
}
