import java.util.*;
public class DivisibleBy
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
int a=s.nextInt();
int b=s.nextInt();
int k=s.nextInt();
int count=0;
for(int i=a;i<b;i++)
{
if(i%k==0)
{
count++;
}
}
System.out.println(count);
}
}
