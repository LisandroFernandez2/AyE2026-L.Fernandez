bool recursiva (int n)
{
   
    if (n == 0)
    {
        
        return false;
    }
    else
    {
        recursiva(n - 1);
        Console.WriteLine(n);
        return true;
    }
    
}
recursiva(10);

bool recursiva2(int n)
{
    
    if (n == 0)
    {
        
        return false;
    }
    else
    {
       
        Console.WriteLine("¡Hola mundo!");
        recursiva2(n - 1);
        return true;
    }
}
recursiva2(5);
bool recursiva3(int n)
{
   
    if (n > 20)
    {
      
        return false;
    }
    else
    {
       
        Console.WriteLine(n);
        recursiva3(n + 2);
        return true;
    }
}
recursiva3(2);
bool recursiva4(int n)
{
    if (n > 70)
    {
        return false;
    }
    else
    {
        Console.WriteLine(n);
        recursiva4(n + 7);
        return true;
    }
}
recursiva4(7);
bool recursiva5 (int n)
{

}
recursiva5(1);