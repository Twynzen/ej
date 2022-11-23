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

int[] myArray = {1,2,2,4,5,6,7,8,8,8};
static void Main() {
  			int count = 0;
  for(int i = 0; i< myArray.Lenght; i++){
  	foreach(var j in myArray){
		if(j == myArray[i+1]){
		  count +=1;
			if(j == myArray[i+count]){	
			  	  count +=1;
			}
		}
	}
  
  }

}