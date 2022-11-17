# Imports go at the top
from microbit import *

while True:
    pin1.write_digital(1)
    
    reading = pin2.read_analog()
    number = int(reading / 50)
    display.show(str(number))
