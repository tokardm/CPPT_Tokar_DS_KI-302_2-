package KI302.Tokar.Lab3;

/**
 * Class representing a trigger of a gun.
 * Provides functionality for managing the trigger material.
 */
public class Trigger {
    private String material; // The material of the trigger

    /**
     * Sets the material of the trigger.
     *
     * @param material The material to set.
     */
    public void SetMaterial(String material) {
        this.material = material;
    }

    /**
     * Gets the material of the trigger.
     *
     * @return The material of the trigger.
     */
    public String GetMaterial() {
        return material;
    }
}
