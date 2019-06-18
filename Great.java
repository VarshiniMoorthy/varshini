import java.util.*;
public class Great
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
int num=s.nextInt();
int temp;
int a[]=new int[num];
for(int i=0;i<num;i++)
{
a[i]=s.nextInt();
}
for(int i=0;i<num-1;i++)
{
temp=a[i+1];
for(int j=i+1;j<num;j++)
{
if(a[j]>temp)
temp=a[j];
}
a[i]=temp;
}
a[num-1]=-1;
for(int i=0;i<num;i++)
{
System.out.println(a[i]);
}
}
}