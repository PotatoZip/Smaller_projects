#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>
#include <windows.h>
#define ROWS 20
#define COLUMNS 40

int board[ROWS][COLUMNS], x, y, temp_y, head, tail, fruits, fruit_x, fruit_y, chr, direction, game_over = 0, score;

void snake_initialization() {
    for(int i = 0; i < ROWS; i++) {
        for(int j = 0; j < COLUMNS; j++) {
            board[i][j] = 0;
        }
    }

    x = ROWS/2;
    y = COLUMNS/2;
    temp_y = y;
    head = 5;
    tail = 1;
    fruits = 0;
    direction = 'd';
    score = 0;

    for(int i = 0; i < head; i++) {
        temp_y++;
        board[x][temp_y - head] = i + 1;
    }
}

int getch_noblock() {
    if(_kbhit())
        return _getch();
    else
        return -1;
}

void movement() {
    chr = getch_noblock();
    chr = tolower(chr);

    if(((chr == 'd' || chr == 'a') || (chr == 'w' || chr == 's')) && abs(direction - chr) > 5) {
        direction = chr;
    }
    if(direction == 'd') {
        y++;
        if(board[x][y] != 0 && board[x][y] != -1) {
            is_game_over();
        }
        if(y == COLUMNS) {
            y = 0;
        }
        if(board[x][y] == -1) {
            fruits = 0;
            tail -= 1;
            score++;
        }
        head++;
        board[x][y] = head;
    }
    if(direction == 'a') {
        y--;
        if(board[x][y] != 0 && board[x][y] != -1) {
            is_game_over();
        }
        if(y == -1) {
            y = COLUMNS - 1;
        }
        if(board[x][y] == -1) {
            fruits = 0;
            tail -= 1;
            score++;
        }
        head++;
        board[x][y] = head;
    }
    if(direction == 'w') {
        x--;
        if(board[x][y] != 0 && board[x][y] != -1) {
            is_game_over();
        }
        if(x == -1) {
            x = ROWS - 1;
        }
        if(board[x][y] == -1) {
            fruits = 0;
            tail -= 1;
            score++;
        }
        head++;
        board[x][y] = head;
    }
    if(direction == 's') {
        x++;
        if(board[x][y] != 0 && board[x][y] != -1) {
            is_game_over();
        }
        if(x == ROWS) {
            x = 0;
        }
        if(board[x][y] == -1) {
            fruits = 0;
            tail -= 1;
            score++;
        }
        head++;
        board[x][y] = head;
    }
}

void screen_reset() {
    HANDLE hOUt;
    COORD position;
    hOUt = GetStdHandle(STD_OUTPUT_HANDLE);
    position.X = 0;
    position.Y = 0;
    SetConsoleCursorPosition(hOUt, position);
}

void draw_board() {
    for(int i = 0; i < ROWS; i++) {
        for(int j = 0; j < COLUMNS; j++) {
            if(i == 0 && j == 0) {
                printf("%c", 201);
            }
            else if(j == COLUMNS - 1 && i == 0) {
                printf("%c", 187);
            }
            else if(j == 0 && i == ROWS - 1) {
                printf("%c", 200);
            }
            else if(i == ROWS - 1 && j == COLUMNS - 1) {
                printf("%c", 188);
            }
            else if(j == 0 || j == COLUMNS - 1) {
                printf("%c", 186);
            } 
            else if(i == 0 || i == ROWS - 1) {
                printf("%c", 205);
            }
            else if(board[i][j] == 0) {
                printf(" ");
            }
            else if(board[i][j] > 0 && board[i][j] != head) {
                printf("%c", 176);
            }
            else if(board[i][j] == head) {
                printf("%c", 178);
            }
            else if(board[i][j] == -1) {
                printf("F");
            }
            
        }
        printf("\n");
    }
    printf("\nYour score: %d", score);
}

void fruit_generator() {
    srand(time(NULL));
    fruit_x = 1 + rand() % (ROWS - 2);
    fruit_y = 1 + rand() % (COLUMNS - 2);

    if(fruits == 0 && board[fruit_x][fruit_y] == 0) {
        board[fruit_x][fruit_y] = -1;
        fruits = 1;     
    }
}

void tail_update() {
    for(int i = 0; i < ROWS; i++) {
        for(int j = 0; j < COLUMNS; j++) {
            if(board[i][j] == tail) {
                board[i][j] = 0;
            }
        }
    }
    tail++;
}

void is_game_over() {
    printf("\a");
    Sleep(1500);
    system("Cls");
    printf("You looooooooooose!\n");
    printf("Your score is sooooo low: %d\n", score);
    game_over = 1;
}

int main() {

    snake_initialization();
    while(!game_over) {
        draw_board();
        screen_reset();
        fruit_generator();
        movement();
        tail_update();
        Sleep(99);
    }
    
    getch();
    return 0;
}