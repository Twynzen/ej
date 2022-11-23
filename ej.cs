static void Main1() {
    var num = myArray.Max();
  	System.Console.WriteLine(num);
}

static void Main2() {
    int numMax = myArray.Max();
 	int count = 0;
  	for (int i = 1; i <= numMax; i++){
	  	
	  	foreach (var j in myArray){
		   if(i == j){
			  count+=1;  
		  } 		  
		}
	  	string text = new string('*',count);
		System.Console.WriteLine(
		i+": "+text
		);
	  
		 count = 0; 
		 
	}
}