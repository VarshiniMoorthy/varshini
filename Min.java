import java.util.*;
public class Min
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
int num=s.nextInt();
int a[]=new int[num];
int b[]=new int[num];
int temp;
for(int i=0;i<num;i++)
{
a[i]=s.nextInt();
}
for(int i=0;i<num;i++)
{
for(int j=i+1;j<num;j++)
{
if(a[i]<a[j])
{
temp=a[i];
a[i]=a[j];
a[j]=temp;
}
}
}
for(int i=0;i<num-1;i++)
{
b[i]=a[i]-a[i+1];
}
for(int i=0;i<num;i++)
{
for(int j=i+1;j<num-1;j++)
{
if(b[i]>b[j])
{
temp=b[i];
b[i]=b[j];
b[j]=temp;
}
}
System.out.println(b[i]);
}
System.out.println(b[0]);
}
}