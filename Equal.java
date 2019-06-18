import java.util.*;
public class Equal
{
public static void main(String args[])
{
Scanner s=new Scanner(System.in);
int num1=s.nextInt();
int num2=s.nextInt();
if((num1^num2)==0)
{
System.out.println("equal");
}
else
{
System.out.println("nont equal");
}
}
}