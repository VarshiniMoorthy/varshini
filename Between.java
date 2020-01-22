import java.util.*;
public class Between
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
int num=s.nextInt();
int count=0;
int a[]=new int[num];
for(int i=0;i<num;i++)
{
a[i]=s.nextInt();
}
for(int i=0;i<num;i++)
{
for(int j=i+i;j<num;j++)
{
if(a[i]==1&&a[j]==1)
{
count++;
}
}
}
System.out.print(count);
}
}
