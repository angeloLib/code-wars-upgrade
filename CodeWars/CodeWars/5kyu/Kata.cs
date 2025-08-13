namespace CodeWars._5kyu;
/*
 * Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
 */
public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        return arr.Where(x => x != 0) 
            .Concat(arr.Where(x => x == 0)) 
            .ToArray();                     
    }
}