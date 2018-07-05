# Word Counter

#### Epicodus C#: Independent Code Review #1 07/04/2018

#### By Matt Smith

## Description

A program that checks how frequently a word appears in a given string. The program will check for instances of only the complete word and return a count of how many instances of that complete word occur within a subsequent inputted string.


### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Program stores the inputted key word and an inputted string to be compared**|  "bang" "bang" |  |
| **Program converts both key and comparative strings to lower to avoid case sensitivity**|  "BANG" "bang" | "**bang**" == "**bang**" |
| **Program recognizes punctuation and does not match**|  "were" "we're" | "**were**" =//= "**we're**" |
| **Program disregards and does not tally words that contain the keyword addended or otherwise different from inputted form of keyword**| "bang" "she bangs" | keyword (**bang**) =//= (**bangs**) |
| **Program continues to the end of the string after encountering an initial instance of the key word and records all separate subsequent instances**| "chitty chitty bang bang" | keyword "**bang**" = "**bang**, **bang**" |
| **When program reaches end of character array, it returns the number of keyword instances as an integer**| "chitty chitty bang bang" | Result: 2 |

## Setup/Contribution Requirements

1. Follow the instructions for downloading C#, .NET Core 1.1 and Mono from: https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c
1. Clone the repo at https://github.com/MattSmithereens/WordCount
1. Make a new branch
1. Commit and push your changes
1. Create a PR

## Technologies Used

* .NET Core 1.1 SDK
* .NET runtime
* Mono
* MicroSoft Visual Studio
* learnhowtoprogram

## Links

* Github Repository: https://github.com/MattSmithereens/WordCount

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Matt Smith**
