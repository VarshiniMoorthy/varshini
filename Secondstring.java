import java.util.*;
public class Secondstring
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
String str1=s.nextLine();
String str2=s.nextLine();
String str3="";
int flag=0;
String str1new[]=str1.split(" ");
char ch[]=str2.toCharArray();
for(int i=0;i<ch.length;i++)
{
for(int j=0;j<str1new.length;j++)
{
if(ch[i]==str1new[j].charAt(0))
{
str3=str3+str1new[j];
}
}
}
System.out.print(str3 +" ");
}
}
