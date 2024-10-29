package KI302.Tokar.Lab5;

import java.io.*;
import java.util.Scanner;
import static java.lang.System.out;

/**
 * Виняток <code>CalcException</code> сигналізує про помилки при обчисленні виразу.
 */
class CalcException extends ArithmeticException {
    /**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	public CalcException() {}
    /**
     * Конструктор для класу <code>CalcException</code>.
     * @param cause опис винятку
     */
    public CalcException(String cause) {
        super(cause);
    }
}

/**
 * Клас <code>Equations</code> містить метод для обчислення виразу y=sin(3x-5)/ctg(2x).
 */
class Equations {
    /**
     * Метод обчислення виразу y=sin(3x-5)/ctg(2x).
     * @param x вхідне значення
     * @return результат обчислення
     * @throws CalcException якщо x призводить до недопустимого значення котангенса або синуса
     */
    public double calculate(double x) throws CalcException {
        double y;
        try {
            y = Math.sin(3 * x - 5) / (1 / Math.tan(2 * x));
            if (Double.isNaN(y) || Double.isInfinite(y)) {
                throw new ArithmeticException();
            }
        } catch (ArithmeticException ex) {
            throw new CalcException("Exception reason: Invalid value for x in the calculation.");
        }
        return y;
    }
}

/**
 * Клас <code>CalcWithFileIO</code> реалізує методи читання/запису результатів у текстовому та двійковому форматах.
 */
class CalcWithFileIO extends Equations {
    private double result;

    /**
     * Обчислює значення виразу y=sin(3x-5)/ctg(2x) і зберігає результат.
     * @param x вхідне значення
     * @return результат обчислення
     * @throws CalcException при виникненні помилок обчислення
     */
    public double calculate(double x) throws CalcException {
        return result = super.calculate(x);
    }

    /**
     * Повертає результат обчислення.
     * @return результат обчислення
     */
    public double getResult() {
        return result;
    }

    /**
     * Записує результат у текстовий файл.
     * @param fileName ім'я файлу
     * @throws FileNotFoundException якщо файл не знайдено
     */
    public void writeResultToTextFile(String fileName) throws FileNotFoundException {
        try (PrintWriter writer = new PrintWriter(fileName)) {
            writer.printf("%f", result);
        }
    }

    /**
     * Зчитує результат із текстового файлу.
     * @param fileName ім'я файлу
     * @throws FileNotFoundException якщо файл не знайдено
     */
    public void readResultFromTextFile(String fileName) throws FileNotFoundException {
        try (Scanner scanner = new Scanner(new File(fileName))) {
            result = scanner.nextDouble();
        }
    }

    /**
     * Записує результат у бінарний файл.
     * @param fileName ім'я файлу
     * @throws IOException якщо виникає помилка запису
     */
    public void writeResultToBinaryFile(String fileName) throws IOException {
        try (DataOutputStream output = new DataOutputStream(new FileOutputStream(fileName))) {
            output.writeDouble(result);
        }
    }

    /**
     * Зчитує результат із бінарного файлу.
     * @param fileName ім'я файлу
     * @throws IOException якщо виникає помилка читання
     */
    public void readResultFromBinaryFile(String fileName) throws IOException {
        try (DataInputStream input = new DataInputStream(new FileInputStream(fileName))) {
            result = input.readDouble();
        }
    }
}

/**
 * Конструктор за замовчуванням для класу <code>EquationsApp</code>.
 */
public class EquationsApp {
    /**
     * Головний метод, який читає введення, виконує обчислення та записує результат у файл.
     * @param args аргументи командного рядка
     */
    public static void main(String[] args) {
        try {
            out.print("Enter file name: ");
            Scanner in = new Scanner(System.in);
            String fName = in.nextLine();

            CalcWithFileIO calculator = new CalcWithFileIO();
            out.print("Enter X: ");
            double x = in.nextDouble();

            // Виконання обчислення та запис результату у текстовий файл
            calculator.calculate(x);
            calculator.writeResultToTextFile(fName);
            out.println("Результат записано у текстовий файл.");

            // Зчитування результату з текстового файлу та виведення
            calculator.readResultFromTextFile(fName);
            out.println("Зчитано результат з текстового файлу: " + calculator.getResult());

            // Запис результату у бінарний файл
            calculator.writeResultToBinaryFile("binaryResult.bin");
            out.println("Результат записано у бінарний файл.");

            // Зчитування результату з бінарного файлу та виведення
            calculator.readResultFromBinaryFile("binaryResult.bin");
            out.println("Зчитано результат з бінарного файлу: " + calculator.getResult());

            in.close(); // Закриваємо сканер
        } catch (FileNotFoundException ex) {
            out.print("Exception reason: Perhaps wrong file path");
        } catch (IOException ex) {
            out.print("IOException: " + ex.getMessage());
        } catch (CalcException ex) {
            out.print("CalcException: " + ex.getMessage());
        }
    }
}
