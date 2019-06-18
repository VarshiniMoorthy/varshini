import java.util.*;
public class Max
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
int house=s.nextInt();
int money=s.nextInt();
int amount=0;
int a[]=new int[house];
for(int i=0;i<house;i++)
{
a[i]=i+1;
}
for(int j=0;j<=house;j++)
{
if(a[j]%2!=0)
amount=amount+money;
}
System.out.println(amount);
}
}