#Get Input
def get_input():
    inputs = []
    with open("input.txt", "r") as f:
        for line in f:
            line = line.replace("\n", "")
            if line != "0 0":
                inputs.append(line)

    return inputs

#Clean input
def clean_input(values):
    output = []
    for value in values:
        split_value = value.split()
        try:
            clean = [int(split_value[0])]
            clean.append([int(value) for value in split_value[1]])
        except ValueError:
            print("Invalid Input")
        output.append(clean)

    return output


class Number():

    def __init__(self, digit, rules, shape):
        self.digit = digit
        self.rules = rules
        self.size = shape
        self.shape = []
        self.make_shape()

    #Read rules
    def make_shape(self):
        vertical_lines = []
        for i in range((self.size * 2) + 3):
            self.shape.append([" "] * (self.size + 2))
        vertical_digits = []
        for digit in self.rules:
            #horizontal
            horizontal = self.make_horizontal(digit)
            if digit == 0:
                self.shape[0] = horizontal
            elif digit == 3:
                self.shape[-1] = horizontal
            elif digit == 6:
                self.shape[len(self.shape) // 2] = horizontal
            #vertical
            elif digit == 1 or digit == 5:
                top = [digit for digit in self.rules if digit == 1 or digit == 5]
                for i in range(1, len(self.shape) // 2):
                    self.shape[i] = self.make_vertical(top)
            else:
                bottom = [digit for digit in self.rules if digit == 2 or digit == 4]
                for i in range((len(self.shape) // 2) + 1, len(self.shape) - 1):
                    self.shape[i] = self.make_vertical(bottom)

    def make_horizontal(self, digit):
        line = [" "]
        for i in range(self.size):
            line.append("-")
        line.append(" ")
        return line

    def make_vertical(self, digits):
        line = [" "] * (self.size + 2)
        for digit in digits:
            if digit in [4, 5]:
                line[0] = "|"
            elif digit in [1, 2]:
                line[-1] = "|"
        return line


#Give rules for generating shape of number
numbers = [
    [0, 1, 2, 3, 4, 5],
    [1, 2],
    [0, 1, 6, 4, 3],
    [0, 1, 2, 3, 6],
    [1, 2, 5, 6],
    [0, 2, 3, 5, 6],
    [0, 2, 3, 4, 5, 6],
    [0, 1, 2],
    [0, 1, 2, 3, 4, 5, 6],
    [0, 1, 2, 3, 5, 6]
]

for input in clean_input(get_input()):
    size = input[0]
    to_print = []
    for int in input[1]:
        to_print.append(Number(int, numbers[int], size))
    big_number = []
    for i in range((size * 2) + 3):
        lines = []
        for number in to_print:
            lines.append(number.shape[i])
        big_number.append([char for line in lines for char in line])

    for row in big_number:
        for char in row:
            print(char, end="")
        print()
