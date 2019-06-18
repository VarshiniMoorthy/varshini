import java.util.*;
import java.io.*;
public class Mul
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
int num=s.nextInt();
int arr[]=new int[num];
for(int i=0;i<num;i++)
{
arr[i]=s.nextInt();
}
Arrays.sort(arr);
int b=arr[num-1]*arr[num-2];
System.out.println(b);
}
}