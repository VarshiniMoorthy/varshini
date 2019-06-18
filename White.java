import java.util.*;
public class White
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
String str1=s.nextLine();
char ch[]=str1.toCharArray();
int j=ch.length-1;
for(int i=j;i>=0;i--)
{
if(ch[i]!=' ')
{
ch[j--]=ch[i];
}
}
while(j>=0)
ch[j--]=' ';
System.out.print(ch);
}
}