import java.util.*;
public class aabb
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
String str=s.nextLine();
String str1=s.nextLine();
int j=0;
int count=0,cou=0;
for(int i=0;i<str.length()-1;i++)
{
if(str.charAt(i)==str1.charAt(j)&&str.charAt(i+1)==str1.charAt(j))
{
count++;
}
else if(str.charAt(i)==str1.charAt(j))
{
cou++;
}
}
if(count==1)
System.out.println("Yes");
else if(count>1)
System.out.println("No");
else if(cou>=2)
System.out.println("No");
else if(cou==1)
System.out.println("Yes");
}
}