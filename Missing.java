import java.util.*;
public class Missing
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
int n=s.nextInt();
int a[]=new int[n];
int diff=0;
int b=0;
for(int i=0;i<n;i++)
{
a[i]=s.nextInt();
}
Arrays.sort(a);
for(int i=0;i<n;i++)
{
if(a[i]>0)
{
diff=a[i+1]-a[i];
if(diff!=1)
{
b=a[i];
break;
}
}
else 
{
b=a[n-1];
}
}
System.out.println(b+1);
}
}
