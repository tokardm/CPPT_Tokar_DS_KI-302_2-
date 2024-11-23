import math
import os
import struct
import sys

def calculate_y(x):
    try:
        numerator = math.sin(3 * x - 5)
        denominator = 1 / math.tan(2 * x) 
        y = numerator / denominator
    except ZeroDivisionError:
        return "Помилка: Ділення на нуль у функції."  
    return y

def write_result_text(file_name, result):
    with open(file_name, 'w', encoding='utf-8') as f:
        f.write(str(result))

def write_result_binary(file_name, result):
    if isinstance(result, str):
        with open(file_name, 'wb') as f:
            f.write(result.encode('utf-8'))
    else:
        with open(file_name, 'wb') as f:
            f.write(struct.pack('f', result))

def read_result_text(file_name):
    if os.path.exists(file_name):
        with open(file_name, 'r', encoding='utf-8') as f:
            return f.read()
    else:
        print(f"Файл {file_name} не знайдено.")
        sys.exit(1)

def read_result_binary(file_name):
    if os.path.exists(file_name):
        with open(file_name, 'rb') as f:
            content = f.read()
            try:
                result = struct.unpack('f', content)[0]
                return result
            except:
                return content.decode('utf-8')
    else:
        print(f"Файл {file_name} не знайдено.")
        sys.exit(1)

def main():
    try:
        x = float(input("Введіть значення x: "))
        result = calculate_y(x)
        print(f"Результат обчислення: {result}")

        write_result_text("result.txt", result)
        write_result_binary("result.bin", result)

        print(f"Результат з текстового файлу: {read_result_text('result.txt')}")
        print(f"Результат з двійкового файлу: {read_result_binary('result.bin')}")
    
    except ValueError:
        print("Помилка: Введене значення повинно бути числом.")
        sys.exit(1)

if __name__ == "__main__":
    main()

