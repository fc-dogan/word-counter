# _Word Counter _

#### _C# Word Counter console application , March 06 2020_

#### By _**Fatma C. Dogan**_

## Description

A program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence

## Project Specifications

| Behavior | Input | Output |
|---|:---|:---:|
|The program gathers a word from user | cat | |
|The program gathers a sentences from user | I have a white cat | |
|The program checks how frequently the word appears in sentences | word: "cat" <br>sentence: "I have a white cat" | 1 |
|The program counts for full word matches only | word: "cat" <br>sentence: "I'm walking to the cathedral" | 0 |
|The program is not case sensitive | word: "the" <br>sentence: "The cat jumped over the wall" | 2 |
|The program ignores to punctuation |  word: "cat" <br>sentence: "I have a white cat." | 1 |



## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/fc-dogan/word-counter.git ```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} ```
* On Windows: ```word-counter```

_Download Manually:_

* Navigate to https://github.com/fc-dogan/word-counter.git
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "Pierre-s-Bakery".


_Note For Editors:_ 
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```
## Known Bugs

_No known bugs at this time._


## Technologies Used

* C#
* .Net Core 2.2


### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Fatma C. Dogan_**