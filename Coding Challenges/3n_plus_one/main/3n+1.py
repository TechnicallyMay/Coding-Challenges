def find_cycle_length(value):
    length = 0
    solved = False
    while not solved:
        length += 1
        if value == 1:
            solved = True
        elif value % 2 == 0:
            value /= 2
        else:
            value = (value * 3) + 1
    return length

def find_max_length(i, j):
    max = 0
    for i in range(i, j):
        cycle_length = find_cycle_length(i)
        if cycle_length > max:
            max = cycle_length
    return max

def get_inputs():
    inputs = []
    with open("input.txt", "r") as f:
        for line in f:
            inputs.append(line.replace("\n", ""))
    return [input.split() for input in inputs]


for pair in get_inputs():
    i = int(pair[0])
    j = int(pair[1])
    print(i, j, find_max_length(i, j))
