import java.util.*;

public class Sumk
{

public static void main(String args[])

{

Scanner s=new Scanner(System.in);

int n=s.nextInt();

int su=0;
int count=1;
int a[]=new int[n];
for(int i=0;i<n;i++)
{
a[i]=s.nextInt();
}
int k=s.nextInt();
for(int i=0;i<n;i++)
{
int sum=0;
count=1;
for(int j=i;j<n;j++)
{
if(count<=k)
{
sum=sum+a[j];
count++;
}
}
if(sum>su)
{
su=sum;
}
}
System.out.print(su);
}
}