import java.util.ArrayList;
import java.util.Scanner;

public class MAÝN {
		private static ascii asciiKeeper = new ascii();
		private static Charkeeper charkeeper = new Charkeeper();
		public ArrayList<String> charCoder= new ArrayList<String>();
		private static Scanner scanner = new Scanner(System.in);
		
		
 public static void main(String[] args) {
	 String entry = scanner.nextLine();
	 System.out.println("Length = " + entry.split(" ").length );
	 for(int i = 0; i<entry.split(" ").length; i++) {
		 System.out.println();
		 System.out.println("All processes for word  " + entry.split(" ")[i] );
		 System.out.println();
	 StringCollector(entry.split(" ")[i]);
	 charkeeper.showList();
	 converterToAscii();
	 asciiKeeper.showList();
	 converterToString();
	 CompoundOfAsciiCodes();
	 asciiKeeper.removeAll();
	 charkeeper.removeAll();

	 }
			
	 
}
 
public static void StringCollector(String a){
	for(int i = 0; i<a.length(); i++) {
		
		String letter = String.valueOf(a.charAt(i));
		charkeeper.addChar(letter);
		
	}
}

public static void converterToAscii() {
	System.out.println();
	for(int i = 1; i<=charkeeper.getLength(); i++) {
		int asciiCode = (int)charkeeper.getChar(i).charAt(0);
		String asciiString = String.valueOf(asciiCode);
		asciiKeeper.addAscii(asciiString);
	}
	
}

public static void converterToString() {
	System.out.println();
	for(int i= 1; i<=asciiKeeper.getLength(); i++) {
		int convertedtoIntfromAscii = Integer.parseInt(asciiKeeper.getAscii(i));
		char convertedAscii = (char)convertedtoIntfromAscii;
		System.out.print(convertedAscii);
	}
}

public static void CompoundOfAsciiCodes() {
	System.out.print(" = ");
	for(int i= 1; i<=asciiKeeper.getLength(); i++) {
		System.out.print(asciiKeeper.getAscii(i));
	}
	System.out.println();
}
 
 

}
