import sys

def generate_matrix(size, filler):
    matrix = []

    for i in range(size):
        row = [" "] * i + [filler] * (size - i)  
        matrix.append(row)
    
    return matrix

def main():
    try:
        size = int(input("Введіть розмір квадратної матриці: "))
    except ValueError:
        print("Розмір матриці має бути цілим числом.")
        sys.exit(1)

    filler = input("Введіть символ-заповнювач: ")
    
    if len(filler) == 1:
        matrix = generate_matrix(size, filler)
        for row in matrix:
            print(" ".join(row))
    elif len(filler) == 0:
        print("Не введено символ-заповнювач")
        sys.exit(1)
    else:        
        print("Забагато символів-заповнювачів")
        sys.exit(1)

if __name__ == "__main__":
    main()

