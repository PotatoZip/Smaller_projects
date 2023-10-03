from tkinter import *
#from tkinter import messagebox  (not nessesary)
import math

equation_text = ""
first_part = ""

def button(btn):
    global equation_text
    global first_part

    if '.' in first_part and btn == '.':
        return
    
    equation_text += str(btn)
    first_part += str(btn)
    equation_label.set(equation_text)

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
    
def show():
    global first_part
    global equation_text
    equals = str(eval(first_part))
    equation_label.set(equals)
    equation_text = equals
    equation_label.set(equals)

def clear():
    global equation_text
    equation_text = ""
    equation_label.set("")
    

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

button0 = Button(frame, text = 0, width = 5, height = 2, font = 20, command = lambda: button(0))
button0.grid(row = 4, column = 0, sticky="nsew")
button1 = Button(frame, text = 1, width = 5, height = 2, font = 20, command = lambda: button(1))
button1.grid(row = 3, column = 0, sticky="nsew")
button2 = Button(frame, text = 2, width = 5, height = 2, font = 20, command = lambda: button(2))
button2.grid(row = 3, column = 1, sticky="nsew")
button3 = Button(frame, text = 3, width = 5, height = 2, font = 20, command = lambda: button(3))
button3.grid(row = 3, column = 2, sticky="nsew")
button4 = Button(frame, text = 4, width = 5, height = 2, font = 20, command = lambda: button(4))
button4.grid(row = 2, column = 0, sticky="nsew")
button5 = Button(frame, text = 5, width = 5, height = 2, font = 20, command = lambda: button(5))
button5.grid(row = 2, column = 1, sticky="nsew")
button6 = Button(frame, text = 6, width = 5, height = 2, font = 20, command = lambda: button(6))
button6.grid(row = 2, column = 2, sticky="nsew")
button7 = Button(frame, text = 7, width = 5, height = 2, font = 20, command = lambda: button(7))
button7.grid(row = 1, column = 0, sticky="nsew")
button8 = Button(frame, text = 8, width = 5, height = 2, font = 20, command = lambda: button(8))
button8.grid(row = 1, column = 1, sticky="nsew")
button9 = Button(frame, text = 9, width = 5, height = 2, font = 20, command = lambda: button(9))
button9.grid(row = 1, column = 2, sticky="nsew")
button_dot = Button(frame, text = '.', width = 5, height = 2, font = 20, command = lambda: button('.'))
button_dot.grid(row = 4, column = 1)
button_equals = Button(frame, text = '=', width = 5, height = 2, font = 20, command = lambda: result('='))
button_equals.grid(row = 4, column = 2)
button_clear = Button(frame, text = 'C', width = 5, height = 2, font = 20, command = lambda: result('C'))
button_clear.grid(row = 0, column = 0)
button_percent = Button(frame, text = '%', width = 5, height = 2, font = 20, command = lambda: result('%'))
button_percent.grid(row = 0, column = 1)
button_root = Button(frame, text = '√', width = 5, height = 2, font = 20, command = lambda: result('√'))
button_root.grid(row = 0, column = 2)
button_plus = Button(frame, text = '+', width = 5, height = 2, font = 20, command = lambda: result('+'))
button_plus.grid(row = 4, column = 3)
button_minus = Button(frame, text = '-', width = 5, height = 2, font = 20, command = lambda: result('-'))
button_minus.grid(row = 3, column = 3)
button_divide = Button(frame, text = '÷', width = 5, height = 2, font = 20, command = lambda: result('÷'))
button_divide.grid(row = 1, column = 3)
button_multi = Button(frame, text = 'x', width = 5, height = 2, font = 20, command = lambda: result('x'))
button_multi.grid(row = 2, column = 3)
button_plus_minus = Button(frame, text = '+/-', width = 5, height = 2, font = 20, command = lambda: result('+/-'))
button_plus_minus.grid(row = 0, column = 3)

for i in range(5):
    frame.grid_rowconfigure(i, weight=1)
for i in range(4):
    frame.grid_columnconfigure(i, weight=1)

window.mainloop()
