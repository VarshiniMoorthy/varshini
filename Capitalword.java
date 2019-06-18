import java.util.*;
public class Capitalword
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
String str=s.nextLine();
String str1[]=str.split(" ");
String a;
for(int i=0;i<str1.length;i++)
{
a=Character.toString(str1[i].charAt(0));
System.out.print(a.toUpperCase()+str1[i].substring(1)+" ");
}
}
}