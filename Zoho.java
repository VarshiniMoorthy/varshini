import java.util.*;

import java.lang.*;

public class Zoho

{

public static void main(String args[])

{

Scanner s=new Scanner(System.in);

String str=s.nextLine();
String str1="";
String news="";
for(int i=str.length()-1;i>=0;i--)
{
str1=str1+str.charAt(i);
}
System.out.print(str1);
int i=0;
int j=0;
while(i<=str.length()-1&&j<=str1.length()-1)
{
if(str.charAt(i)==str1.charAt(j))
{

news=news+str.charAt(i);
i++;
j++;
}

 else if(str.charAt(i)!=str1.charAt(j))
{
i++;
j++;
}
}
System.out.print(news);
}
}

