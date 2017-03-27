/* Given an array of strings, return another array containing all of its longest strings.

Example

For inputArray = ["aba", "aa", "ad", "vcd", "aba"], the output should be
allLongestStrings(inputArray) = ["aba", "vcd", "aba"]. */



string[] allLongestStrings(string[] inputArray) {
    
    //Declare variables
    int letterCount = 0;
    int wordCount = 0;
    int counter = 0;
    
    //Arrays with length 1
    if (inputArray.Length <= 1)
    {
        return inputArray;
    }
    
    //Arrays with length > 1
    
    for (int i=1; i<inputArray.Length; i++)
    {
        string element1 = inputArray[i-1];
        string element2 = inputArray[i];

        //Check if e1 > e2
        if (element1.Length >= element2.Length)
        {
            //Make sure that greatest string length is saved
            if (element1.Length > letterCount)
            {
                //Save the newer bigger word
                letterCount = element1.Length;
            }

        }
        else //Element2's length is greater
        {
            if (element2.Length > letterCount)
            {
                letterCount = element2.Length;
            }
            
        }
    }
    
    //Now that we have the biggest word, we need to see how many there are
    for (int h=0;h<inputArray.Length;h++)
    {
        if (inputArray[h].Length == letterCount)
        {
            wordCount+= 1;
        }
    }
    
    //We have x number of words, make that the size of the new array
    string[] longestStrings = new string[wordCount];
    
    for (int j=0; j<inputArray.Length; j++)
    {
        if (inputArray[j].Length == letterCount)
        {
            longestStrings[counter] = inputArray[j];
            if (counter != wordCount)
            {
                counter++;    
            }
            
            
        }
        
    }
    

    return longestStrings;

}
