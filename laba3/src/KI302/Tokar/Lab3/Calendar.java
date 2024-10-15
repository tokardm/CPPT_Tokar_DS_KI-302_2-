package KI302.Tokar.Lab3;

/**
 * A class representing the manufacturing calendar (production year) of the gun.
 */
public class Calendar {
    private int year;

    public Calendar(int year) {
        this.year = year;
    }

    public void SetYear(int year) {
        this.year = year;
    }

    public int GetYear() {
        return year;
    }
}
