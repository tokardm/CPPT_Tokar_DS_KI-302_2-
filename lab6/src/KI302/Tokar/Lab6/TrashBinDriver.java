package KI302.Tokar.Lab6;

import java.util.Comparator;

/**
 * Програма-драйвер для тестування класу TrashBin.
 * 
 * <p>Демонструє використання класу TrashBin із параметризованими типами {@link Paper} і {@link Plastic}.</p>
 * 
 * @author Tokar
 * @version 1.0
 */
public class TrashBinDriver {

    /**
     * Конструктор за замовчуванням для класу TrashBinDriver.
     */
    public TrashBinDriver() {
        // Конструктор за замовчуванням
    }

    /**
     * Точка входу в програму.
     * 
     * @param args аргументи командного рядка (не використовуються)
     */
    public static void main(String[] args) {
        // Створення баків і виконання операцій
        TrashBin<Paper> paperBin = new TrashBin<>(Comparator.comparingInt(Paper::getWeight));
        paperBin.addItem(new Paper("A4", 100));
        paperBin.addItem(new Paper("A3", 200));
        paperBin.addItem(new Paper("Cardboard", 500));

        TrashBin<Plastic> plasticBin = new TrashBin<>(Comparator.comparingInt(Plastic::getQuantity));
        plasticBin.addItem(new Plastic("PET", 50));
        plasticBin.addItem(new Plastic("HDPE", 75));
        plasticBin.addItem(new Plastic("PVC", 30));

        System.out.println("Max in paperBin: " + paperBin.findMax());
        System.out.println("Max in plasticBin: " + plasticBin.findMax());
    }
}
