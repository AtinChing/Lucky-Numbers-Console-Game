import os
directory_in_str = os.path.abspath(os.path.dirname(__file__)) + "\\"
directory = os.fsencode(directory_in_str)
num = 0
for file in os.listdir(directory):
    filename = os.fsdecode(file)
    if filename.endswith(".cs"):
        f = open(directory_in_str + filename, "r")
        for line in f:
            num += 1
print(num)



