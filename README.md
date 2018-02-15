# Scrabble Score

#### By Andy Grossberg

## Description
A program for a player to enter their word from the game Scrabble and generate their estimated Score.
Note this is the score for the letters only and does not include the values of the squares where they have placed their tiles.

## Rules

Make a website that takes a word and returns the Scrabble score for that word.

Make sure to start with your specs, and that you include a README for this project and create a Git repository for it.

Here are the values of letters in Scrabble:

- A, E, I, O, U, L, N, R, S, T:      1
- D, G                        :      2
- B, C, M, P                  :      3
- F, H, V, W, Y               :      4
- K                           :      5
- J, X                        :      8
- Q, Z                        :      10

If you get this far, you've done great! Don't worry about getting to the rest of the projects by the end of the day.

## Specifications

* Take input of a letter from User via REPL, output it to Console
- EXPECTED INPUT: "A"
- EXPECTED OUTPUT: "A"

* Run the program logic on the Letter in REPL, output the results to the console.
- EXPECTED INPUT: "A"
- EXPECTED OUTPUT: "1"
- EXPECTED INPUT: "Z"
- EXPECTED OUTPUT: "10"

* Take input of a word from User via REPL, output it to Console
- EXPECTED INPUT: "APPLE"
- EXPECTED OUTPUT: "APPLE"

* Do not accept input that contains characters other than the alphabet via REGEX.

* Convert input to uppercase.

* Run the program logic on the word via a loop in REPL, output results to the console.
- EXPECTED INPUT: "A"
- EXPECTED OUTPUT: "The letter A is worth: 1."
- EXPECTED INPUT: "Z"
- EXPECTED OUTPUT: "The letter A is worth: 10"

* Create a Model Word Object with an ID, instances array, name, and currentScore. (this will allow for future words to be compared...)

* Add Getters, and Setters as needed.

* Create a MyWord instance in the HomeController. <---

* Set MyWord to "Test".

* Add a static Method to perform the program logic as tested in REPL.

* Create a View called Index.cshtml as a title screen.

* Test the View Controller to make sure the View() Index works.

* Get a Word from the user via a form and output it to the Console.

* Set MyWord.name to various Letter combination words and test the logic.
  - EXPECTED INPUT: "APPLE"
  - EXPECTED OUTPUT: "That word is worth 8 points!" to Console
  - EXPECTED INPUT: "ENZYME"
  - EXPECTED OUTPUT: "That word is worth 20 points!" to Console
  - etc.

* Take input from the user via a form on Index.cshtml.

* Test the View Controller to make sure the View() Index works when passing its model from the form to the page.

* Run the input from the user through the program logic with output to a Results.cshtml page.

* Test the View Controller to make sure the View() Results works when passing its model from the form to the page.

* Validate inputs by converting it all to upper case.

* Refactor code as needed.

## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/agro23/ScrabbleScore.git'.
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
