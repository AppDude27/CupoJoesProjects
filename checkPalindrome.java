//This program checks if the string being inputted is a palindrome

boolean checkPalindrome(String inputString) {

    int backwardsChecker = inputString.length()-1;
    
    for (int i=0; i <= inputString.length()-1; i++)
    {
        //Compare the ith letter with the ith-1 letter
        if (inputString.charAt(i) != inputString.charAt(backwardsChecker))
        {
            return false;
        }
        
        backwardsChecker -= 1;
    }
    
    return true;
    

}
