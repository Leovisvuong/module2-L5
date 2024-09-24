// // Q1-if_statements
// // var declaration
// int valueA,valueB;
// // part 1
// valueA = int.Parse(Console.ReadLine());
// valueB = int.Parse(Console.ReadLine());
// if(valueA == valueB) Console.WriteLine("YES");
// else Console.WriteLine("NO");

// // part 2
// valueA = int.Parse(Console.ReadLine());
// valueB = int.Parse(Console.ReadLine());
// if(valueA > valueB) Console.WriteLine("YES");
// else Console.WriteLine("NO");

// // part 3
// valueA = int.Parse(Console.ReadLine());
// valueB = int.Parse(Console.ReadLine());
// if(valueA < valueB) Console.WriteLine("YES");
// else Console.WriteLine("NO");

// // part 4
// valueA = int.Parse(Console.ReadLine());
// valueB = int.Parse(Console.ReadLine());
// if(valueA != valueB) Console.WriteLine("YES");
// else Console.WriteLine("NO");

// // part 5
// valueA = int.Parse(Console.ReadLine());
// valueB = int.Parse(Console.ReadLine());
// if(valueA >= valueB) Console.WriteLine("YES");
// else Console.WriteLine("NO");

// // part 6
// valueA = int.Parse(Console.ReadLine());
// valueB = int.Parse(Console.ReadLine());
// if(valueA <= valueB) Console.WriteLine("YES");
// else Console.WriteLine("NO");

// // part 7
// Console.Write("3+13=");
// valueA = int.Parse(Console.ReadLine());
// if(valueA == 16) Console.WriteLine("YOUR ANSWER IS TRUE!");
// else Console.WriteLine("YOUR ANSWER IS FALSE! 3+13=16!");

// // part 8
// Console.Write("Enter your age: ");
// valueA = int.Parse(Console.ReadLine());
// if(valueA >= 18) Console.WriteLine("You're old enough to vote!");
// else Console.WriteLine("Sorry, you're so young to vote!");

// // part 9
// Console.Write("Enter enemy health from 0 to 100: ");
// valueA = int.Parse(Console.ReadLine());
// if(valueA == 100) Console.WriteLine("The enemy is still at full health!");
// else if(valueA >= 75) Console.WriteLine("The enemy has over three quarters of its health left.");
// else if(valueA >= 50) Console.WriteLine("The enemy has over half of its health left.");
// else if(valueA >= 25) Console.WriteLine("The enemy has over quarter of its health left.");
// else if(valueA > 0) Console.WriteLine("The enemy has less than quarter of its health left.");
// else Console.WriteLine("The enemy is defeated.");

// // part 10
// Console.Write("Enter your age: ");
// valueA = int.Parse(Console.ReadLine());
// if(valueA < 18) Console.WriteLine("Congratulation! You're eligible for discount.");
// else Console.WriteLine("Sorry, you're not eligible for discount.");



// // Q1-break/continue_statements
// // part 1
// for(int i=1;i<=10;i++){
//     if(i==5) continue;
//     Console.Write(i+" ");
// }
// Console.Write("\n");

// // part 2
// for(int i=1;i<=10;i++){
//     if(i==7) break;
//     Console.Write(i+" ");
// }
// Console.Write("\n");

// // part 3
// for(int i=1;i<=20;i++){
//     if(i%2 == 1 || i == 10) continue;
//     Console.Write(i+" ");
// }
// Console.Write("\n");

// // part 4
// List<string> fruits = new List<string> {"lemon","durian","avocado","coconut","pear","apple","banana","watermelon","cucumber"};
// foreach(string i in fruits){
//     if(i == "apple") Console.WriteLine("Apple found!");
// }

// // part 5
// int counter = 10;
// for(int i=1;i<=100;i++){
//     if(counter > 0){
//         counter--;
//         continue;
//     }
//     else{
//         counter = 10;
//         Console.Write(i+" ");
//     }
// }
// Console.Write("\n");

// // part 6
// List<string> alphabet = new List<string> {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
// foreach(string i in alphabet){
//     if(i == "E") continue;
//     Console.Write(i+" ");
// }
// Console.Write("\n");

// // part 7
// bool isPrime(int inputValue){
//     if(inputValue < 3) return true;
//     for(int j = 2; j <= Math.Sqrt(inputValue); j++){
//         if(inputValue % j == 0) return false;
//     }
//     return true;
// }
// for(int i = 1; i <= 50; i++){
//     if(isPrime(i)) Console.Write(i+" ");
// }
// Console.Write("\n");

// // part 8
// for(int i=1;i<=10;i++){
//     if(i==3) continue;
//     Console.Write(i+" ");
// }
// Console.Write("\n");

// // part 9
// List<int> numbers = new List<int> {1,4,2,23,6,23,0,22,-12,6,1233,7,88,93,2334,100,20,-930,-2,5,-10,-20};
// foreach(int i in numbers){
//     if(i == 20){
//         Console.WriteLine(numbers.IndexOf(i));
//         break;
//     }
// }

// // part 10
// foreach(string i in fruits){
//     if(i != "banana") Console.WriteLine(i+" ");
// }
// Console.Write("\n");



// // Q1-extra
// // part 11
// using System.Runtime.InteropServices;

// Console.Write("Enter the monthly sales: ");
// float monthlySales = int.Parse(Console.ReadLine());
// float commission;
// commission = monthlySales/20;
// if(commission >= 500) commission *= 2;
// Console.WriteLine("Commission earned: $" + commission);

// // part 12
// Random randomNumber = new Random();
// int firstNumber = randomNumber.Next(0,100);
// int secondNumber = randomNumber.Next(0,100);
// Console.Write("Enter the sum of " + firstNumber + " and " + secondNumber + ": ");
// int userInput = int.Parse(Console.ReadLine());
// if(userInput == firstNumber + secondNumber) Console.WriteLine("Correct!");
// else Console.WriteLine("Wrong!");

// // part 13
// Console.Write("Enter student's marks: ");
// userInput = int.Parse(Console.ReadLine());
// string grade;
// string comment = "";
// switch(userInput){
//     case >=85:
//         grade = "A+";
//         comment = "Excellent!";
//         break;
//     case >=80:
//         grade = "A";
//         comment = "Well Done.";
//         break;
//     case >=75:
//         grade = "B+";
//         break;
//     case >=70:
//         grade = "B";
//         break;
//     case >=65:
//         grade = "C+";
//         break;
//     case >=60:
//         grade = "C";
//         break;
//     case >=55:
//         grade = "D+";
//         break;
//     case >=50:
//         grade = "D";
//         break;
//     case <50:
//         grade = "F";
//         comment = "See me.";
//         break;
// }
// Console.WriteLine("Grade: " + grade + "\nComment: " + comment);

// // part 14
// bool sees_player;
// int dist_from_player;
// Console.Write("sees_player = ");
// sees_player =bool.Parse(Console.ReadLine());
// Console.Write("dist_from_player = ");
// dist_from_player = int.Parse(Console.ReadLine());
// if(sees_player = false){
//     Console.Write("he will wait.");
// }
// else{
//     switch(dist_from_player){
//         case <2:
//             Console.Write("he will attack.");
//             break;
//         case <5:
//             Console.Write("he will advance");
//             break;
//         case >4:
//             Console.Write("he will wait.");
//             break;
//     }
// }



// Q2-switch_case
// question 1
int inputNumber = int.Parse(Console.ReadLine());
string outputString = "three";
switch(inputNumber){
    case 1:
        outputString = "one";
        break;
    case 2:
        outputString = "two";
        break;
}
Console.WriteLine(outputString);

// question 2
Console.Write("Enter your choice (1,2,3): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("warrior");
        break;
    case 2:
        Console.WriteLine("mage");
        break;
    case 3:
        Console.WriteLine("archer");
        break;
    case >3:
        Console.WriteLine("There is no character with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no character with number " + inputNumber);
        break;
}

// question 3
Console.Write("Enter your choice (1,2,3,4): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("north");
        break;
    case 2:
        Console.WriteLine("south");
        break;
    case 3:
        Console.WriteLine("east");
        break;
    case 4:
        Console.WriteLine("west");
        break;
    case >4:
        Console.WriteLine("There is no direction with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no direction with number " + inputNumber);
        break;
}

// question 4
Console.Write("Enter your choice (1-7): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("monday");
        break;
    case 2:
        Console.WriteLine("tuesday");
        break;
    case 3:
        Console.WriteLine("wednesday");
        break;
    case 4:
        Console.WriteLine("thursday");
        break;
    case 5:
        Console.WriteLine("friday");
        break;
    case 6:
        Console.WriteLine("saturday");
        break;
    case 7:
        Console.WriteLine("sunday");
        break;
    case >7:
        Console.WriteLine("There is no day of week with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no day of week with number " + inputNumber);
        break;
}

// question 5
Console.Write("Enter your choice (1,2,3,4): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("sword");
        break;
    case 2:
        Console.WriteLine("bow");
        break;
    case 3:
        Console.WriteLine("staff");
        break;
    case 4:
        Console.WriteLine("axe");
        break;
    case >3:
        Console.WriteLine("There is no weapon with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no weapon with number " + inputNumber);
        break;
}

// question 6
Console.Write("Enter your choice (1-5): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("fire");
        break;
    case 2:
        Console.WriteLine("water");
        break;
    case 3:
        Console.WriteLine("earth");
        break;
    case 4:
        Console.WriteLine("air");
        break;
    case 5:
        Console.WriteLine("lightning");
        break;
    case >5:
        Console.WriteLine("There is no magic with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no magic with number " + inputNumber);
        break;
}

// question 7-24
Console.Write("Enter your choice (1,2,3,4): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("start game");
        break;
    case 2:
        Console.WriteLine("options");
        break;
    case 3:
        Console.WriteLine("load game");
        break;
    case 4:
        Console.WriteLine("exit");
        break;
    case >4:
        Console.WriteLine("There is no option in menu with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no option in menu with number " + inputNumber);
        break;
}

// question 8-21
Console.Write("Enter your choice (1,2,3): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("talk");
        break;
    case 2:
        Console.WriteLine("trade");
        break;
    case 3:
        Console.WriteLine("quest");
        break;
    case >3:
        Console.WriteLine("There is no interaction with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no interaction with number " + inputNumber);
        break;
}

// question 9
Console.Write("Albert Einstein's most famous formula is (...)\n1.v=s/t\n2.tan(a)cot(a)=1\n3.e=mc^2\n4.1+1=2\n5.(c)=0\nEnter your choice (1-5): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 3:
        Console.WriteLine("Correct!");
        break;
    case >5:
        Console.WriteLine("There is no option with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no option with number " + inputNumber);
        break;
    case <6:
        Console.WriteLine("wrong, the answer is 3!");
        break;
}



// question 10
Console.Write("Enter your choice (1,2,3,4): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("Hello!");
        break;
    case 2:
        Console.WriteLine("Get out!!!");
        break;
    case 3:
        Console.WriteLine("Welcome.");
        break;
    case 4:
        Console.WriteLine("Bye!");
        break;
    case >4:
        Console.WriteLine("There is no dialogue with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no dialogue with number " + inputNumber);
        break;
}



// question 11
Console.Write("Enter your choice (1,2,3): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("potion");
        break;
    case 2:
        Console.WriteLine("weapon");
        break;
    case 3:
        Console.WriteLine("armor");
        break;
    case >3:
        Console.WriteLine("There is no choice with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no choice with number " + inputNumber);
        break;
}

// question 12-22
Console.Write("Enter your choice (1-5): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("sea");
        break;
    case 2:
        Console.WriteLine("mountain");
        break;
    case 3:
        Console.WriteLine("hill");
        break;
    case 4:
        Console.WriteLine("desert");
        break;
    case 5:
        Console.WriteLine("forest");
        break;
    case >5:
        Console.WriteLine("There is no choice with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no choice with number " + inputNumber);
        break;
}

// question 13-23
Console.Write("Enter your choice (1,2,3,4): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("25%");
        break;
    case 2:
        Console.WriteLine("50%");
        break;
    case 3:
        Console.WriteLine("75%");
        break;
    case 4:
        Console.WriteLine("100%");
        break;
    case >4:
        Console.WriteLine("There is no choice with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no choice with number " + inputNumber);
        break;
}

// question 14
Console.Write("Enter your choice (1,2,3): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("health potion");
        break;
    case 2:
        Console.WriteLine("mana potion");
        break;
    case 3:
        Console.WriteLine("stamina potion");
        break;
    case >3:
        Console.WriteLine("There is no choice with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no choice with number " + inputNumber);
        break;
}

// question 15
Console.Write("Enter your choice (1-4): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("left");
        break;
    case 2:
        Console.WriteLine("right");
        break;
    case 3:
        Console.WriteLine("jump");
        break;
    case 4:
        Console.WriteLine("crouch");
        break;
    case >4:
        Console.WriteLine("There is no choice with number " + inputNumber);
        break;
    case <1:
        Console.WriteLine("There is no choice with number " + inputNumber);
        break;
}

// question 16
Console.Write("Enter your choice (1-4): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("iron");
        break;
    case 2:
        Console.WriteLine("steel");
        break;
    case 3:
        Console.WriteLine("gold");
        break;
    case 4:
        Console.WriteLine("diamond");
        break;
}

// question 17
Console.Write("Enter your choice (1-4): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("fire");
        break;
    case 2:
        Console.WriteLine("water");
        break;
    case 3:
        Console.WriteLine("earth");
        break;
    case 4:
        Console.WriteLine("air");
        break;
}

// question 18
Console.Write("Enter your choice (1-4): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("strength");
        break;
    case 2:
        Console.WriteLine("agility");
        break;
    case 3:
        Console.WriteLine("intelligence");
        break;
    case 4:
        Console.WriteLine("vitality");
        break;
}

// question 19
Console.Write("What is the most famous Edison's invention?\n1.Bulb\n2.Lightning rod\n3.Audio\nEnter your choice (1-3): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("Correct!");
        break;
    case >1:
        Console.WriteLine("Wrong!");
        break;
}

// question 20
Console.Write("Enter your choice (1-4): ");
inputNumber = int.Parse(Console.ReadLine());
switch(inputNumber){
    case 1:
        Console.WriteLine("herb");
        break;
    case 2:
        Console.WriteLine("mushroom");
        break;
    case 3:
        Console.WriteLine("flower");
        break;
    case 4:
        Console.WriteLine("crystal");
        break;
}

// Q3-scope
////////////////////Part 1////////////////////

//There are scope realted errors in the code. Fix the scope related errors in the code.


// Imagine you're in a fantasy adventure game
Console.WriteLine("You're on a quest to find a hidden treasure deep in the forest.");
Console.WriteLine("You stumble upon an ancient cave with mysterious inscriptions.");

// remove var to here
int health = 100;
int energy = 50;
int treasureChestGold = 1000;

// Enter the cave to explore
Console.WriteLine("\nYou enter the dark cave, your heart pounding with excitement.");

// Start a new block for inside the cave
{
    // Explore the cave and find the treasure chest
    Console.WriteLine("\nYou stumble upon an old treasure chest, hidden beneath rubble!");
    Console.WriteLine("Your eyes widen as you uncover the gleaming gold coins inside.");
    Console.WriteLine("You found " + treasureChestGold + " gold coins!");
}

// Attempt to access the treasure chest gold outside the cave
// This will result in a compilation error because treasureChestGold is out of scope here
// Console.WriteLine("You count your gold coins outside the cave: " + treasureChestGold);

// Continue your adventure
Console.WriteLine("\nWith your newfound wealth, you continue your journey deeper into the forest.");
Console.WriteLine("Your health: " + health);
Console.WriteLine("Your energy: " + energy);
Console.WriteLine(treasureChestGold); // This will result in a compilation error because treasureChestGold is out of scope here













//////////////////Part 2////////////////////


// There are scope-related errors in the code. Fix the scope-related errors in the code.

// Imagine you're a detective investigating a mysterious crime scene
Console.WriteLine("You arrive at the crime scene, a dimly lit alleyway shrouded in mystery.");
Console.WriteLine("Your keen eyes scan the surroundings for any clues.");

// Declare variables for evidence found at the crime scene
string evidence1;
string evidence2;

// remove var to here
string fingerprint = "Unknown";

// Begin your investigation
Console.WriteLine("\nYou start gathering evidence, carefully collecting any clues left behind.");

// Start a new block for searching the crime scene
{
    // Investigate further and find a torn piece of cloth
    Console.WriteLine("\nYou discover a torn piece of cloth with a mysterious symbol.");
    Console.WriteLine("Your heart races as you realize its significance: " + fingerprint);
    // Store the discovered evidence
    evidence1 = "Torn cloth with mysterious symbol";
    evidence2 = "Unknown";
}

// Attempt to access the fingerprint variable outside the crime scene
// This will result in a compilation error because fingerprint is out of scope here
Console.WriteLine("You carefully analyze the fingerprint: " + fingerprint);

// Continue your investigation
Console.WriteLine("\nWith the evidence collected, you piece together the puzzle of the crime.");













/////////////////Part 3////////////////////

// There are scope-related errors in the code. Fix the scope-related errors in the code.

// Imagine you're a scientist conducting experiments in a laboratory
Console.WriteLine("You step into the laboratory, surrounded by rows of sophisticated equipment and bubbling beakers.");
Console.WriteLine("Your mission is to uncover the secrets of a mysterious substance.");

// Declare variables for lab experiment results
double result1;
double result2;

// remove var here
double concentration = 0.5;

// Begin your experiment
Console.WriteLine("\nYou set up your equipment and prepare to conduct the experiment.");

// Start a new block for conducting the experiment
{
    // Perform the experiment and observe the first result
    Console.WriteLine("\nYou conduct the first experiment and observe the results.");
    result1 = concentration * 10;
    // Store the first experiment result
    result2 = result1 / 2;
    Console.WriteLine("Result 1: " + result1);
}

// Attempt to access the concentration variable outside the experiment block
// This will result in a compilation error because concentration is out of scope here
Console.WriteLine("You analyze the concentration of the substance: " + concentration);

// Continue your experiments
Console.WriteLine("\nWith the first results obtained, you continue your experiments to unravel the mystery.");



