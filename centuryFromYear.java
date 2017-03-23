//This code takes in a year and returns the century it is from

int centuryFromYear(int year) {

    int century = 0;
    
    
    if ((year % 100) != 0)
    {
        century = (year / 100) + 1;
    }
    
    else
    {
        century = (year/100);
    }
    
    return century;
    
}
