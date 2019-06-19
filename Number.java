import java.util.*;
public class Number
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
int n=s.nextInt();
int a[]=new int[n];
String str="";
String str1="";
for(int i=0;i<n;i++)
{
a[i]=s.nextInt();
}
for(int i=0;i<n;i++)
{
str=str+Integer.toString(a[i]);
}
int num=Integer.parseInt(str);
num=num+1;
str1=str1+Integer.toString(num);
for(int i=0;i<n;i++)
{
System.out.print(str1.charAt(i));
}
}
}