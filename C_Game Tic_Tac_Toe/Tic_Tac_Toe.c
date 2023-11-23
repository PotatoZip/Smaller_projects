#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>
#include <windows.h>

char map[9] = {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};

//Functions declaration
int check_draw();
int check_if_won(char ch);
void select_game_mode();
void reset_map();
void print_board();
void print_logo();
void single_mode();
void multi_mode();

int main() {
    srand(time(NULL));
    
    select_game_mode();

    getch();

    return 0;
}

void select_game_mode() {
    char ans_mode;
    char ans_next;
    while(1) {
        print_logo();
        printf("Select game mode\nSingleplayer [s]\nMultiplayer [m]\n");
        scanf(" %c", &ans_mode);

        if(ans_mode == 's') {
            single_mode();
        }
        else if(ans_mode == 'm') {
            multi_mode();
        }
        else {
            printf("Wrong input\n");
            Sleep(1000);
            system("cls");
     
        }
        printf("\nReady for the next game? [Y/N]\n");
        if(scanf(" %c", &ans_next) == 1) {
            if (ans_next == 'Y' || ans_next == 'y') {
                system("cls");
                reset_map();
                continue;
            }
            else {
                printf("\nSee you later!\n");
                break;
            }
        }
    }
}

void reset_map() {
    for (int i = 0; i < 9; i++) {
        map[i] = ' ';
    }
}

void print_logo() {
    printf("___________ __         ___________               ___________            \n");
    printf("\\__    ___/|__| ____   \\__    ___/____    ____   \\__    ___/___   ____  \n");
        printf("  |    |   |  |/ ___\\    |    |  \\__  \\ _/ ___\\    |    | /  _ \\_/ __ \\ \n");
    printf("  |    |   |  \\  \\___    |    |   / __ \\\\  \\___    |    |(  <_> )  ___/ \n");
    printf("  |____|   |__|\\___  >   |____|  (____  /\\___  >   |____| \\____/ \\___  >\n");
    printf("                   \\/                 \\/     \\/                      \\/ \n\n\n");
}

void print_board() {
    system("cls");
    printf("   |   |   \n");
    printf(" %c | %c | %c \n", map[0], map[1], map[2]);
    printf("___|___|___\n");
    printf("   |   |   \n");
    printf(" %c | %c | %c \n", map[3], map[4], map[5]);
    printf("___|___|___\n");
    printf("   |   |   \n");
    printf(" %c | %c | %c \n", map[6], map[7], map[8]);
    printf("   |   |   \n\n");
}

int check_if_won(char ch) {
    if(map[0] == ch && map[1] == ch && map[2] == ch) return 1;
    else if(map[3] == ch && map[4] == ch && map[5] == ch) return 1;
    else if(map[6] == ch && map[7] == ch && map[8] == ch) return 1;
    else if(map[0] == ch && map[3] == ch && map[6] == ch) return 1;
    else if(map[1] == ch && map[4] == ch && map[7] == ch) return 1;
    else if(map[2] == ch && map[5] == ch && map[8] == ch) return 1;
    else if(map[0] == ch && map[4] == ch && map[8] == ch) return 1;
    else if(map[2] == ch && map[4] == ch && map[6] == ch) return 1;
    else return 0;
}

int check_draw() {
    for(int i = 0; i < 9; i++) {
        if(map[i] == ' ') {
            return 0;
        }
    }
    return 1;
}

void single_mode() {
    while(1) {
        int position;

        while(1) {
            print_board();
            printf("[0][1][2]\n[3][4][5]\n[6][7][8]\nWhere do you want to enter X?\n");
            if(scanf("%d", &position) == 1) {
                if(map[position] != ' ' || position < 0 || position > 8) {
                    continue;
                }
                map[position] = 'X';
                break;
            }
            else {
                while(getchar() != '\n');
            }
        }

        if(check_if_won('X') == 1) {
            print_board();
            printf("Congrats, You won!\n");
            break;
        }
        
        if(check_draw() == 1) {
            print_board();
            printf("Draw!\n");
            break;
        }

        while(1) {
            int rand_position = rand() % 9;
            if(map[rand_position] != ' ')
                continue;
            map[rand_position] = 'O';
            break;
        }

        if(check_if_won('O') == 1) {
                print_board();
                printf("You lost!\n");
                break;
            }
        
        if(check_draw() == 1) {
            print_board();
            printf("Draw!\n");
            break;
        }
    }

}

void multi_mode() {
    while(1) {
        int position;
        
        while(1) {
            print_board();
            printf("[0][1][2]\n[3][4][5]\n[6][7][8]\nWhere do you want to enter X?\n");
            if(scanf("%d", &position) == 1) {
                if(map[position] != ' ' || position < 0 || position > 8) {
                    continue;
                }
                map[position] = 'X';
                break;
            }
            else {
                while(getchar() != '\n');
            }
        }

        if(check_if_won('X') == 1) {
            print_board();
            printf("Congrats Player 1, You won!\n");
            break;
        }
        
        if(check_draw() == 1) {
            print_board();
            printf("Draw!\n");
            break;
        }

        while(1) {
            print_board();
            printf("[0][1][2]\n[3][4][5]\n[6][7][8]\nWhere do you want to enter O?\n");
            if(scanf("%d", &position) == 1) {
                if(map[position] != ' ' || position < 0 || position > 8) {
                    continue;
                }
                map[position] = 'O';
                break;
            }
            else {
                while(getchar() != '\n');
            }
        }
        
        if(check_if_won('O') == 1) {
            print_board();
            printf("Congrats Player 2, You won!\n");
            break;
        }

        if(check_draw() == 1) {
            print_board();
            printf("Draw!\n");
            break;
        }

    }

}