import java.io.*;
import java.util.*;

public class Lab1TokarKI302 {

    public static void main(String[] args) throws FileNotFoundException {
        int nRows;
        char[][] matrix;
        String filler;
        Scanner scanner = new Scanner(System.in);
        File dataFile = new File("matrix.txt");
        PrintWriter writer = new PrintWriter(dataFile);

        System.out.print("Введіть розмір квадратної матриці: ");
        nRows = scanner.nextInt();
        scanner.nextLine();

        if (nRows <= 0) {
            System.out.println("Помилка: розмір має бути додатним цілим числом.");
            return;
        }

        matrix = new char[nRows][nRows];

        System.out.print("Введіть символ-заповнювач: ");
        filler = scanner.nextLine();

        if (filler.length() != 1) {
            System.out.println("Помилка: необхідно ввести один символ.");
            return;
        }

        char fillChar = filler.charAt(0);

        for (int i = 0; i < nRows; i++) {
            for (int j = 0; j < nRows; j++) {
                if (j < i) {
                    matrix[i][j] = ' ';
                } else {
                    matrix[i][j] = fillChar;
                }
            }
        }
        
        for (int i = 0; i < nRows; i++) {
            for (int j = 0; j < nRows; j++) {
                System.out.print(matrix[i][j] + " ");
                writer.print(matrix[i][j] + " ");
            }
            System.out.println();
            writer.println();
        }

        writer.flush();
        writer.close();
    }
}
