import java.util.*;
public class A3
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
String str=s.nextLine();
char ch[]=str.toCharArray();
int count=0;
String g="";
for(int i=0;i<ch.length;i++)
{
count=0;
String temp="";
for(int j=i;j<ch.length;j++)
{
if(i==0)
{
if(ch[i]==ch[j])
{
count++;
temp=temp+ch[i];
}
else
{
break;
}
}
else if(ch[i]!=ch[i-1])
{
if(ch[i]==ch[j])
{
count++;
temp=temp+ch[i];
}
}
}
if(!g.contains(temp))
{
g=g+temp.charAt(0);
System.out.print(temp.charAt(0)+""+count);
}
}
}
}