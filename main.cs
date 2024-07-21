using System;

class GreenvilleRevenue {
// variable that creates the inital price of tickets.
 static int entranceFee = 25;
  public static void Main (string[] args) {

// create a method that will be called to open the program and display a banner. 
  GreenvilleMotto();

// use a while loop to display a set of prompts for the user to input information. while true, the program will endlessly loop until the user enters "2", which exits the program.
  while(true){// open while
    Console.WriteLine("Please enter the following number below from the following menu options:");
    Console.WriteLine("1. Calculate Greenville Revenue year-over-year");
    Console.WriteLine("2. Exit");

// create a variable called input to hold the users input in a stored location
    string input = Console.ReadLine();
// create logic for the while true loop. based on the user input a series of tasks will be completed
    if(input == "1"){
      TotalRevenue();
    }// end if input "1"
    else if(input == "2"){
      Console.WriteLine("Thanks for using the Greeville Revenue App, good-bye!");
      Console.ReadKey(); // obtain the next key pressed by the user. if the input = 2 the program exits.
      break;
    }// end else if input "2"
    else{
      Console.WriteLine("Invalid Choice. Try again.");
    } // end else error message
  }// close while
}// close main

// banner that opens with the program
static void GreenvilleMotto(){
  Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");
        Console.WriteLine();
}// end GreenvilleMotto method

// create a TotalRevenue method that gathers information about the prior years number of contestants and revenue, it then determines the current years revenue forecast based off of the prior years revenue. parse the user's input and set it to newly created variables
static void TotalRevenue(){
  int priorYearsContestants;

  int thisYearsContestants;

  while (true){
      Console.WriteLine("Enter the number of contestants from last year (0-30):");
      if (int.TryParse(Console.ReadLine(), out priorYearsContestants) && priorYearsContestants >= 0 && priorYearsContestants <= 30){
          break;
      }// end if
      else{
          Console.WriteLine("Invalid input. Enter a number between 0 and 30 ");
      }// end else
    }// end while
  while (true){
      Console.WriteLine("Enter the number of contestants for this year:");
      if (int.TryParse(Console.ReadLine(), out thisYearsContestants) && thisYearsContestants >= 0 && thisYearsContestants <= 30){
          break;
      }// end if
      else{
          Console.WriteLine("Invalid input. please enter a number between 0 and 30 ");
      }// end else
  }// end while

  // Calculate the revenue
  int revenue = thisYearsContestants * entranceFee;


 if (thisYearsContestants > priorYearsContestants * 2){
    Console.WriteLine("The Competition is bigger than ever!");
   
 }// end if
  else if (thisYearsContestants > priorYearsContestants){
    Console.WriteLine("The competition is more than twice as big this year!");;
  }// end else if
  else{
    Console.WriteLine("A tighter race this year! Come out and cast your vote!");
  }

  Console.WriteLine();
  Console.WriteLine("unit test passed");
  Console.WriteLine();
  // Display the motto again after calculation to loop throught the program until the user inputs "2"
  GreenvilleMotto();


  }// close RevenueTotal  
}// close GreenvilleRevenue