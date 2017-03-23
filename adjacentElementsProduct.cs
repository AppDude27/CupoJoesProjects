//Given an array of integers, this looks at each adjacent pair and
//returns the largest product

int adjacentElementsProduct(int[] inputArray) {

int firstNumber, secondNumber, product, solution = -1000000;
    
    for (int i=0; i<inputArray.Length-1 ;i++)
    {
        firstNumber = inputArray[i];
        secondNumber = inputArray[i+1];
        
        product = firstNumber * secondNumber;
        Console.WriteLine("Comparing " + product + " and " + solution);
        
        if (product >= solution)
        {
        solution = product;
        }
        


    }
    
    return solution;

}
