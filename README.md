# Scrabble Score

#### By Andy Grossberg

## Description
A program for a player to enter their word from the game Scrabble and generate their estimated Score.
Note this is the score for the letters only and does not include the values of the squares where they have placed their tiles.

## Rules ********************************************************************

* Recreate the game Rock, Paper, Scissors. For anyone who has never played it, here are the rules:

* It is played by 2 people. Each person chooses "Rock", "Paper", or "Scissors" by forming a shape with their hand.

* They choose at the same time, so that each person doesn't know what the other person has picked.

* If one person chooses "Rock" and the other person picks "Scissors" then "Rock" wins. It's a game of combinations:
  - Rock v. Scissors = Rock wins
  - Rock v. Paper = Paper wins  
  - Paper v. Scissors = Scissors wins

* If both people choose the same thing, then it is a draw and nobody wins.

* Write a method that can handle the different combinations of plays and make sure to write specs for all possible combination of plays. Your method should take 2 inputs - one for each player's choice. It should return "Player 1" if the first input wins, "Player 2" if the second input wins, and "Draw" if nobody wins.

* Start by considering all possible inputs and outputs. Then choose the simplest input/output values and use them to write your first spec. Write all specs in english first, and then translate them into test methods and make them pass, one by one. Don't start coding until you've written your english specs, and don't start building the MVC website until all your specs are passing and your method is done.

* Then, build a website, styled with CSS, where someone can go to play your game. Make sure you include a README for this project and create a Git repository for it.

* Bonus points: Find a way to get the computer to randomly select a 'play' and make your website into a one player game. We don't yet know how to test something that's random, so it's okay to skip writing a spec for that part. Or, you could expand the rules of your game to include 3 players. Make sure to write specs for that before coding. You must understand your goal clearly before you can figure out how to get there.

## Specifications

* Create a PlayerOne string var set to "Rock".

* Create a PlayerTwo string var set to "Rock".

* Check if PlayerOne == PlayerTwo. If so output "It's a Tie!" to REPL.

* Change PlayerOne to "Paper".

* Check if PlayerOne == PlayerTwo. If NOT output "Player One wins!" to REPL.

* Change PlayerOne to "Scissors".

* Check if PlayerOne == PlayerTwo. If NOT output "Player Two wins!" to REPL.

* Using the following combined game logic, check all of the following states of PlayerOne against PlayerTwo.
  - if PlayerOne is "Rock" and PlayerTwo is "Rock" output "It's a tie!" to REPL
  - if PlayerOne is "Rock" and PlayerTwo is "Paper" output "Player Two wins!" to REPL
  - if PlayerOne is "Rock" and PlayerTwo is "Scissors" output "Player One wins!" to REPL
  - if PlayerOne is "Paper" and PlayerTwo is "Rock" output "Player One wins!" to REPL
  - if PlayerOne is "Paper" and PlayerTwo is "Paper" output "It's a tie!" to REPL
  - if PlayerOne is "Paper" and PlayerTwo is "Scissors" output "Player Two wins!" to REPL
  - if PlayerOne is "Scissors" and PlayerTwo is "Rock" output "Player One wins!" to REPL
  - if PlayerOne is "Scissors" and PlayerTwo is "Paper" output "Player Two wins!" to REPL
  - if PlayerOne is "Scissors" and PlayerTwo is "Scissors" output "It's a tie!" to REPL

* Take input of "Rock", "Paper", or "Scissors" from Player One

* With PlayerTwo still set as "Rock", run the game logic to find out if the Player One is a winner.

* Take input of "Rock", "Paper", or "Scissors" from Player two

* Run the game logic to see who is the winner.

* Create a PlayerTest Object with an ID, instances array, name, and currentMove.

* Add Getters, and Setters.

* Create a "Player One" instance

* Set Player One currentMove to "Rock"

* Create a "Player Two" instance.  

* Set Player Two currentMove to "Rock"

* Add a static Method to check moves provided by Player One and Player Two that returns either "Player One", "Player Two", or "Draw" depending on the game logic stated above.

* Create an View called Index.cshtml as a title screen.

* Get a move from Player One via a form and output it to the Console.

* Set Player Two to "Rock", "Paper", and "Scissors" in turn, checking each against Player One's move and outputting the result to the Console.
  - EXPECTED INPUT: "Rock" (and PlayerTwo is set to "Rock")
  - EXPECTED OUTPUT: "Draw" to Console
  - EXPECTED INPUT: "Rock" (and PlayerTwo is set to "Paper")
  - EXPECTED OUTPUT: "Player Two" to Console
  - EXPECTED INPUT: "Rock" (and PlayerTwo is set to "Scissors")
  - EXPECTED OUTPUT: "Player One" to Console
  - EXPECTED INPUT: "Paper" (and PlayerTwo is set to "Rock")
  - EXPECTED OUTPUT: "Player One" to Console
  - EXPECTED INPUT: "Paper" (and PlayerTwo is set to "Paper")
  - EXPECTED OUTPUT: "Draw" to Console
  - EXPECTED INPUT: "Paper" (and PlayerTwo is set to "Scissors")
  - EXPECTED OUTPUT: "Player Two" to Console
  - EXPECTED INPUT: "Scissors" (and PlayerTwo is set to "Rock")
  - EXPECTED OUTPUT: "Player Two" to Console
  - EXPECTED INPUT: "Scissors" (and PlayerTwo is set to "Paper")
  - EXPECTED OUTPUT: "Player One" to Console
  - EXPECTED INPUT: "Scissors" (and PlayerTwo is set to "Scissors")
  - EXPECTED OUTPUT: "Draw" to Console

* Take input from Player Two via a form on Index.cshtml.

* Run the input from both players through the game logic with outputs to the Console

* Run the input from both players through the game logic with outputs to a Results.cshtml page.

* Validate inputs as only "Rock", "Paper", or "Scissors".

* Modify the results from the Object into an actual sentence to send to the Results page.

* Refactor code as needed. <--

**IF TIME PERMITS:**

* Create an instance of the Player Object called Computer

* Repeat all the tests of Player Two but on the Computer object instead

* Have the Computer Player choose a random move from "Rock", "Paper" or "Scissors".

* Have the Computer choose a move based on VERY light AI.

* Refactor code as needed.

## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/agro23/RockPaperScissors.git'.
* Run the command 'dotnet restore' to download the necessary packages.
* Run the command 'dotnet build' to build to build the app.
* Run the command 'dotnet run' to run the server on localhost.
* Use your preferred web browser to navigate to localhost:5000

## Support and contact details

* Contact the author at andy.grossberg@gmail.com

## Technologies Used

* C#
* Asp .NET Core 1.1 MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Andy Grossberg

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
