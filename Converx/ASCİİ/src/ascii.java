import java.util.ArrayList;

public class ascii {	
		private ArrayList<String> ascii = new ArrayList<String>();
		
		public void addAscii(String item) {
			ascii.add(item);

		}
		
		public void showList() {
			System.out.println("You have " + ascii.size()  + " ASCII Codes in your entry");
			System.out.println();
			for(int i = 0; i< ascii.size(); i++) {
				System.out.println("The ASCII code " + (i+1) + " =  " + ascii.get(i));
				
				
			}
		}
		
		public String getAscii(int a) {
			if(a-1<0) return "wrong number";
			else return ascii.get(a-1);
		}
		
		public int getLength() {
			return ascii.size();
		}
		
		public void removeAll() {
				ascii.removeAll(ascii);
			
		}
		
		
	}

class Charkeeper {	
	private ArrayList<String> Charkeeper = new ArrayList<String>();
	
	public void addChar(String item) {
		Charkeeper.add(item);

	}
	
	public void showList() {
		System.out.println("You have " + Charkeeper.size()  + " characters in your entry");
		System.out.println();
		for(int i = 0; i< Charkeeper.size(); i++) {
			System.out.println("The letter " + (i+1) + " =  " + Charkeeper.get(i));
			
			
		}
	}
	
	public String getChar(int a) {
		if(a-1<0) return "wrong number";
		else return Charkeeper.get(a-1);
	}
	
	public int getLength() {
		return Charkeeper.size();
	}
	
	public void removeAll() {
		Charkeeper.removeAll(Charkeeper);
	
}
	
	
	
	
}


