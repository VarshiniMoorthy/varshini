import java.util.*;
public class Seconds
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);

String str1=s.nextLine();
int num=s.nextInt();
String b="";
String str2[]=str1.split(" ");
String a=str2[num];
char ch[]=a.toCharArray();
for(int j=ch.length-1;j>=0;j--)
{
b=b+ch[j];
}
System.out.print(b);
}
}