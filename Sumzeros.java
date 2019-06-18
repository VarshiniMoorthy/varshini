import java.util.*;
public class Sumzeros
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
int num=s.nextInt();
int a[]=new int[num];
int sum=0;
for(int i=0;i<num;i++)
{
sum=sum+a[i];
}
for(int i=0;i<num;i++)
{
if(a[i]==0)
{
flag=1;
}
}
if(flag==1)
{
System.out.print("true");
}
else if(sum==0||