import java.util.*;
public class Longseq
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
int num=s.nextInt();
int a[]=new int[num];
int count=1;
int b[]=new int[num];
for(int i=0;i<num;i++)
{
a[i]=s.nextInt();
}
Arrays.sort(a);
for(int i=0;i<num-1;i++)
{
if(Math.abs(a[i]-a[i+1])==1)
{
count++;
}
}
System.out.print(count);
}
}
 
																							