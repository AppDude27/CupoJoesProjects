//The following program takes in a two digit number and returns the sum of its digits
//For example, if my input is 12, the output should be 3, because 2+1 = 3

int addTwoDigits(int n) {
    
    int sum, digit1, digit2;
    
    //Get first number = 12/10 = 1
    digit1 = n/10;
    Console.WriteLine(digit1);
    //Get second number = 12%10 = 2
    digit2 = n%10;
    Console.WriteLine(digit2);
    sum = digit1 + digit2;
    
    
    return sum;

}
