package KI302.Tokar.Lab3;

/**
 * Class representing a barrel of a gun.
 * Provides functionality for managing the barrel caliber.
 */
public class Barrel {
    private double caliber; // The caliber of the barrel

    /**
     * Sets the caliber of the barrel.
     *
     * @param caliber The caliber to set.
     */
    public void SetCaliber(double caliber) {
        this.caliber = caliber;
    }

    /**
     * Gets the caliber of the barrel.
     *
     * @return The caliber of the barrel.
     */
    public double GetCaliber() {
        return caliber;
    }
}
