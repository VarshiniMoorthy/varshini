import java.util.*;
public class Palindrome
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
String str=s.nextLine();
int odd=0;
int count=0;
String res="";
for(int i=0;i<str.length();i++)
{
count=1;
for(int j=i+1;j<str.length();j++)
{
if(str.charAt(i)==str.charAt(j))
{
count++;
}
}
if(!res.contains(Character.toString(str.charAt(i))))
{
res=res+str.charAt(i);
if(count%2!=0)
odd++;
}
}
if(odd>1)
System.out.print("no");
else
System.out.print("yes");
}
}