import java.util.*;

import java.lang.*;

public class Oddplaces

{

public static void main(String args[])

{

Scanner s=new Scanner(System.in);

String str=s.nextLine();


String str1="";

int count=0;


char ch[]=str.toCharArray();

for(int i=0;i<ch.length;i++)

{

count=0;

String g="";

for(int j=0;j<ch.length;j++)

{

if(ch[i]==ch[j])

{

count++;


}


}

g=g+ch[i];

if(!str1.contains(g)&&count%2!=0)

str1=str1+ch[i];

}

System.out.print(str1);

}

}