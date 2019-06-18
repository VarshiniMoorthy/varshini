import java.util.*;
public class Number
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
/*for(int i=0;i<num;i++)
{
for(int j=0;j<num;j++)
{
if(a[i]%2==0)
{
temp=a[i];
a[i]=a[j];
a[j]=temp;
}
}
}*/
for(int i=0;i<num;i++)
{
for(int j=0;j<num;j++)
{
if(a[i]%2!=0)
{
temp=a[i];
a[i]=a[j];
a[j]=temp;
}
}
}
for(int i=0;i<num;i++)
{
System.out.println(a[i]);
}
}
}
