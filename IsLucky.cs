/* Ticket numbers usually consist of an even number of digits. A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the second half.

Given a ticket number n, determine if it's lucky or not.

Example

For n = 1230, the output should be
isLucky(n) = true;
For n = 239017, the output should be
isLucky(n) = false. */




bool isLucky(int n) {
    
    int sumA=0, sumB=0, numOfDigits = n.ToString().Length;
    string myValue = n.ToString();
    Console.WriteLine(numOfDigits);
    
    //Get the length of the string, divide it by 2
    //First half is from 0 to Length/2
    
    //Loop through the first half of the string
    for (int i=0; i < numOfDigits/2; i++)
    {
        
        sumA = sumA + Convert.ToInt32(myValue[i]);
    }
    
        //Append the result to sum1
    
    //Loop through the second hald of the string
    //Second half of string is from numOfDigits.Length/2 to Length
    for (int j=numOfDigits/2; j<numOfDigits; j++)
    {
        sumB = sumB + Convert.ToInt32(myValue[j]);
    }
    
        //Append the result to sum2
    
    //Compare the sums of both sides to see if they are equal
    if (sumA == sumB)
    {
        return true;
    }
    else
    {
        return false;
    }
    
}
