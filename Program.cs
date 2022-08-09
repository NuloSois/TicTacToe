// See https://aka.ms/new-console-template for more information

namespace TicTactToe
{
class Program
{
    
static void Main() 
{

string botInput = "?";

Console.WriteLine("(P1)Do you wanna play as X or O ?");
string? Input = Console.ReadLine();


if (Input == "X" ^ Input == "O" && Input is not null)
{
    if (Input == "X")
    {botInput =  "O";}
    else
    {botInput = "X";}
    
string[] i = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

Console.WriteLine("The Model goes as following:");

void Model()
{
Console.WriteLine(@$"
      {i[1]}  / {i[2]}  / {i[3]} 
   _____/____/____
    {i[4]}  / {i[5]}  / {i[6]}
______/____/____
  {i[7]}  / {i[8]}  / {i[9]}  
    /    /   
    ");
}
Model();
Console.ReadLine();
string winCon = "Unknown";
string Winner = "Unknown";
int TurnCount = 5;
while (TurnCount > 0 && winCon=="Unknown")
{
    Console.WriteLine("Select your position");
    int io = Convert.ToInt16(Console.ReadLine());
    if (i[io] == botInput)
    {}
    else
    {i[io] = Input;}

    Random rnd1 = new Random();
    Random rnd2 = new Random(); //2nd Iteration of Random 
    int index = rnd1.Next(i.Length);
    if (i[index] == i[io])         //guarantees that the code will not substitute player-selected spaces
    {index = rnd2.Next(i.Length);  //re-gerates another value for the oponent until it is a valid value
    i[index] = botInput;          
    } 
    else    
    {i[index] = botInput;}
    TurnCount--;
    if (i[1] == i[2] && i[2] == i[3]) {winCon = "Horizontal Up Rows"; if(i[1]==Input) {Winner=Input;}else{Winner=botInput;}} 
    if (i[4] == i[5] && i[5] == i[6]) {winCon = "Horizontal Middle Rows"; if(i[4]==Input) {Winner=Input;}else{Winner=botInput;}}
    if (i[7] == i[8] && i[8] == i[9]) {winCon = "Horizontal Lower Rows"; if(i[7]==Input) {Winner=Input;}else{Winner=botInput;}}
    if (i[1] == i[4] && i[4] == i[7]) {winCon = "Vertical Left Column"; if(i[1]==Input) {Winner=Input;}else{Winner=botInput;}}
    if (i[2] == i[5] && i[5] == i[8]) {winCon = "Vertical Middle Column"; if(i[2]==Input) {Winner=Input;}else{Winner=botInput;}}
    if (i[3] == i[6] && i[6] == i[9]) {winCon = "Vertical Right Column"; if(i[3]==Input) {Winner=Input;}else{Winner=botInput;}} 
    if (i[1] == i[5] && i[5] == i[9]) {winCon = "Descending Diagonal"; if(i[1]==Input) {Winner=Input;}else{Winner=botInput;}} 
    if (i[3] == i[5] && i[5] == i[7]) {winCon = "Ascending Diagonal"; if(i[3]==Input) {Winner=Input;}else{Winner=botInput;}}
      
    Model(); 
    Console.ReadLine();
    }

    
    Console.WriteLine($"{Winner} Won by {winCon} Case"); //End Splash Message
}

Console.ReadLine();
Console.WriteLine("Wanna Play Again ? Y/N");
string? YN = Console.ReadLine();

switch(YN)
{
case "Y":
Main();
break;
case "N":

break;
}


}
}
}