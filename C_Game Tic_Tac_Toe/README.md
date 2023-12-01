# Tic-Tac-Toe Console Game

This is a simple console-based Tic-Tac-Toe game implemented in C. The game has single-player and multi-player mode allowing users to play against computer or to challange your friend.  

## Installation

To use this project clone the repository and compile the code using:

```bash
gcc Tic_tac_toe -o Tic_tac_toe.c
```
Then you can simply run the program by using following command in project directory:

```bash
./Tic_tac_toe
```

## Usage

When the programm starts the player has choice oof single-mode by entering 's' or multi-mode by entering 'm'.
Regardless of the mode selected a game board in the form of a grid with 9 squares will be displayed and below it a diagram numbering the individual boxes:
```
   |   |
   |   |
___|___|___
   |   |
   |   |
___|___|___
   |   |
   |   |
   |   |

[0][1][2]
[3][4][5]
[6][7][8]
```

Single-mode:

In this mode the program will be asking you to enter number of the box that you want to fill with "X".
In the next step a computer will select its box and will fill it with "O".
This pattern will continue until a win or a draw.

Multi-mode:

This mode is similar to the previous one except that instead of the computer's turn the second player is asked to select a box.

Winning and draw:

In order to win a game players must create horizontal, vertical or transverse line of 3 "X" or 3 "O". If after the 9th round failed to form a line, the game ends in a draw.

After the game is over, the program asks the user whether to restart the game or not. You can agree by entering "Y".

## Future development

- Make better AI for computer
- Change console into some better GUI

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate. 

## License

This project is licensed under the [MIT](https://choosealicense.com/licenses/mit/) license, feel free to use it.