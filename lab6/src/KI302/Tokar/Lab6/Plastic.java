package KI302.Tokar.Lab6;

/**
 * Клас Plastic представляє тип даних "Пластик" для TrashBin.
 */
public class Plastic implements TrashItem {
    private String grade;
    private int quantity;

    public Plastic(String grade, int quantity) {
        this.grade = grade;
        this.quantity = quantity;
    }

    public String getGrade() {
        return grade;
    }

    public void setGrade(String grade) {
        this.grade = grade;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    @Override
    public void print() {
        System.out.println("Plastic [grade=" + grade + ", quantity=" + quantity + "]");
    }

    @Override
    public String toString() {
        return "Plastic [grade=" + grade + ", quantity=" + quantity + "]";
    }
}
