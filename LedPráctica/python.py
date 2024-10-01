#By RodoIsAlnum

import tkinter as tk
import serial

port = 'COM3'
baudrate = 9600

ard = serial.Serial(port, baudrate)

def turnOnLed():
    ard.write(bytes("b", 'utf-8'))
    print("Led ON")

def turnOffLed():
    ard.write(bytes("a", 'utf-8'))
    print("Led Off")

window = tk.Tk()
window.title("Arduino test app")

btnOn = tk.Button(window, text="Turn on LED", command=turnOnLed)
btnOn.pack(pady=10)

btnOff = tk.Button(window, text="Turn off LED", command=turnOffLed)
btnOff.pack(pady=10)

window.mainloop()
