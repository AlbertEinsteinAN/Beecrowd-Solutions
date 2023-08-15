import java.util.Scanner;

public class Main
{
	public static void main(String[] args)
	{
		Scanner sc = new Scanner(System.in);
		
		double r = sc.nextDouble();
		double a = r * r * 3.14159;
		
		System.out.printf("A=%.4f\n", a);
	}
}
