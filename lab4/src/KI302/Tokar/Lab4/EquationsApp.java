package KI302.Tokar.Lab4;

import java.util.Scanner;
import java.io.*;
import static java.lang.System.out;

/**
 * Class <code>EquationsApp</code> Implements driver for the Equations class.
 * It calculates the expression y=sin(3x-5)/ctg(2x) and writes the result to a file.
 * @author Tokar Dmytro
 * @version 1.0
 */
public class EquationsApp {
    
    /**
     * Default constructor for the <code>EquationsApp</code> class.
     * Initializes the application without any parameters.
     */
    public EquationsApp() {
        // Default constructor
    }

    /**
     * Main method that reads input, performs calculation, and writes the result to a file.
     * @param args command line arguments
     */
    public static void main(String[] args) {
        try {
            out.print("Enter file name: ");
            Scanner in = new Scanner(System.in);
            String fName = in.nextLine();
            PrintWriter fout = new PrintWriter(new File(fName));
            
            try {
                try {
                    Equations eq = new Equations();
                    out.print("Enter X: ");
                    double x = in.nextDouble();
                    fout.print(eq.calculate(x));
                } finally {
                    // Ensure file resources are released
                    fout.flush();
                    fout.close();
                }
            } catch (CalcException ex) {
                // Handle calculation exceptions
                out.print(ex.getMessage());
            }
        } catch (FileNotFoundException ex) {
            // Handle file-related exceptions
            out.print("Exception reason: Perhaps wrong file path");
        }
    }
}

/**
 * Class <code>CalcException</code> handles exceptions for mathematical calculations.
 * @author [Your Name]
 * @version 1.0
 */
class CalcException extends ArithmeticException {
    public CalcException() {}
    
    /**
     * Constructor for the <code>CalcException</code> class.
     * @param cause the description of the exception
     */
    public CalcException(String cause) {
        super(cause);
    }
}

/**
 * Class <code>Equations</code> contains the method to calculate the expression y=sin(3x-5)/ctg(2x).
 * @author [Your Name]
 * @version 1.0
 */
class Equations {
    
    /**
     * Method calculates y=sin(3x-5)/ctg(2x) expression.
     * @param x Input value for the expression.
     * @return The calculated result.
     * @throws CalcException if x leads to an illegal value for cotangent or sine.
     */
    public double calculate(double x) throws CalcException {
        double y;
        try {
            // Calculate expression y=sin(3x - 5) / ctg(2x)
            y = Math.sin(3 * x - 5) / (1 / Math.tan(2 * x));
            
            // Check for invalid results
            if (Double.isNaN(y) || Double.isInfinite(y)) {
                throw new ArithmeticException();
            }
        } catch (ArithmeticException ex) {
            throw new CalcException("Exception reason: Invalid value for x in the calculation.");
        }
        return y;
    }
}