from tkinter import *
#from tkinter import messagebox  (not nessesary)
import math

equation_text = ""
first_part = ""

def create_button(num, lambda_fun):
    new_button = Button(frame, text = num, width = 5, height = 2, font = 20, command = lambda: lambda_fun(num))
    return new_button

#Adding functionality for buttons from 0 to 9
def button(btn):
    global equation_text
    global first_part

    if '.' in first_part and btn == '.':
        return
    
    equation_text += str(btn)
    first_part += str(btn)
    equation_label.set(equation_text)

#Adding functionality for other buttons
def result(btn):
    global equation_text
    global first_part

    if btn == "C":
        first_part = ""
        equation_text = ""
        equation_label.set("")
        return
    
    try:
        if (first_part[-1] == "+") or (first_part[-1] == "-") or (first_part[-1] == "/") or (first_part[-1] == "*"):
            first_part = first_part[1:-2]
        elif (first_part[0] == "m") and (first_part[10] == "m"):
            first_part = first_part[10:-1]
    except:
        pass

    try:
        equals = str(eval(first_part))
        equation_label.set(equals)

        if btn == "=":
            equation_label.set("")
            first_part = equals
            show() 
        elif btn == "+":
            first_part = "(" + first_part + ")+"
            equation_text = ""
        elif btn == "-":
            first_part = "(" + first_part + ")-"
            equation_text = ""
        elif btn == "x":
            first_part = "(" + first_part + ")*"
            equation_text = ""
        elif btn == "÷":
            first_part = "(" + first_part + ")/"
            equation_text = ""
        elif btn == "+/-":
            first_part = "(-1)*(" + first_part + ")"
            show()
        elif btn == "%":
            equals += "/100"
            equation_label.set(equals)
            exuation_text = equals
        elif btn == "√":
            first_part = "math.sqrt(" + equation_text + ")"
            show()
    except:
        pass

#Displaying label text
def show():
    global first_part
    global equation_text
    equals = str(eval(first_part))
    equation_label.set(equals)
    equation_text = equals
    equation_label.set(equals)

#Reset values
def clear():
    global equation_text
    equation_text = ""
    equation_label.set("")
    
#Window definement
window = Tk()
window.geometry("280x350")
icon = PhotoImage(file = "1489.png")
window.iconphoto(True, icon)
window.title("Calculator")
window.configure(background = "#424949")

equation_label = StringVar()
label = Label(window, textvariable = equation_label, width = 35, height = 3, font = ('consolas'), relief = SUNKEN, bd = 5)
label.pack(side="top", padx = 10, pady = 10)

frame = Frame(window)
frame.pack()

for i in range(5):
    frame.grid_rowconfigure(i, weight=1)
for i in range(4):
    frame.grid_columnconfigure(i, weight=1)
    
#Create Buttons
create_button(0, button).grid(row = 4, column = 0, sticky="nsew")
create_button(1, button).grid(row = 3, column = 0, sticky="nsew")
create_button(2, button).grid(row = 3, column = 1, sticky="nsew")
create_button(3, button).grid(row = 3, column = 2, sticky="nsew")
create_button(4, button).grid(row = 2, column = 0, sticky="nsew")
create_button(5, button).grid(row = 2, column = 1, sticky="nsew")
create_button(6, button).grid(row = 2, column = 2, sticky="nsew")
create_button(7, button).grid(row = 1, column = 0, sticky="nsew")
create_button(8, button).grid(row = 1, column = 1, sticky="nsew")
create_button(9, button).grid(row = 1, column = 2, sticky="nsew")
create_button(".", button).grid(row = 4, column = 1)
create_button("=", result).grid(row = 4, column = 2)
create_button("C", result).grid(row = 0, column = 0)
create_button("%", result).grid(row = 0, column = 1)
create_button("√", result).grid(row = 0, column = 2)
create_button("+", result).grid(row = 4, column = 3)
create_button("-", result).grid(row = 3, column = 3)
create_button("÷", result).grid(row = 1, column = 3)
create_button("x", result).grid(row = 2, column = 3)
create_button("+/-", result).grid(row = 0, column = 3)

window.mainloop()
