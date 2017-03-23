//The following program takes a list of statues and checks how many statues are needed
// to complete the range. For example [2,3,6,8], between 2-8, if we have 2,3,6,8, we
// are missing statues 4,5 and 7. My program will output 3 statues that are missing.

int makeArrayConsecutive2(int[] statues) {

    int statuesNeeded=0, statueA, statueB, difference;
    
    //Sorting the statues from smallest to largest
    Array.Sort(statues);
  
    for (int i=0; i < statues.Length-1; i++)
    {
        int count = 0;
        //Grab first two elements
        statueA = statues[i];
        statueB = statues[i+1];
        //Get the difference of the first and second elements
        difference = statueB - statueA;
        
        //If the difference is only 1, no additional statues needed
        if (difference != 1)
        {
            //3-2 = 1 OK
            //3-1 = 2 1 statue needed
            //6-3 = 3 2 statues needed
            //6-2 = 4 3 statues needed
            //...
            //Formula is n-1
            count = difference - 1;
            statuesNeeded += count;
        }
        
    }
    
    
    return statuesNeeded;
    
}
