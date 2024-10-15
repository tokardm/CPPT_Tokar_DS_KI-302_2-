package KI302.Tokar.Lab3;

import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.GregorianCalendar;

/**
 * Abstract class representing a generic gun.
 * Provides basic functionality for shooting, reloading, and logging.
 */
public abstract class Gun {
    protected String model;             // The model of the gun
    protected Barrel barrel;             // The barrel of the gun
    protected Trigger trigger;           // The trigger of the gun
    protected GregorianCalendar calendar; // The calendar for manufacturing year
    protected PrintWriter logger;        // Logger for logging actions

    /**
     * Constructor to initialize a Gun object with specified parameters.
     *
     * @param model The model of the gun.
     * @param barrel The barrel of the gun.
     * @param trigger The trigger of the gun.
     * @param calendar The calendar representing the manufacturing year.
     */
    public Gun(String model, Barrel barrel, Trigger trigger, GregorianCalendar calendar) {
        this.model = model;
        this.barrel = barrel;
        this.trigger = trigger;
        this.calendar = calendar;
        init_log();
        log("Gun initialized with model: " + model);
    }

    /**
     * Abstract method for shooting functionality.
     * Each subclass must implement its own shooting behavior.
     */
    public abstract void Shoot1();

    /**
     * Initializes the logger for logging actions.
     */
    private void init_log() {
        try {
            logger = new PrintWriter(new FileWriter("log.txt", true), true);
        } catch (IOException e) {
            System.err.println("Error initializing logger: " + e.getMessage());
        }
    }

    /**
     * Logs a message to the log file.
     *
     * @param message The message to log.
     */
    public void log(String message) {
        if (logger != null) {
            logger.println(message);
        }
    }

    /**
     * Abstract method for shooting functionality.
     * Each subclass must implement its own shooting behavior.
     */
    public abstract void Shoot();

    /**
     * Reloads the gun and logs the action.
     */
    public void Reload() {
        log("Gun reloaded.");
        System.out.println("Reloading...");
    }

    /**
     * Sets the model of the gun and logs the action.
     *
     * @param model The model to set.
     */
    public void SetModel(String model) {
        this.model = model;
        log("Model set to: " + model);
    }

    /**
     * Gets the model of the gun.
     *
     * @return The model of the gun.
     */
    public String GetModel() {
        return model;
    }

    /**
     * Sets the barrel caliber and logs the action.
     *
     * @param caliber The caliber to set.
     */
    public void SetBarrelCaliber(double caliber) {
        barrel.SetCaliber(caliber);
        log("Barrel caliber set to: " + caliber);
    }

    /**
     * Gets the barrel caliber.
     *
     * @return The caliber of the barrel.
     */
    public double GetBarrelCaliber() {
        return barrel.GetCaliber();
    }

    /**
     * Sets the trigger material and logs the action.
     *
     * @param material The material to set.
     */
    public void SetTriggerMaterial(String material) {
        trigger.SetMaterial(material);
        log("Trigger material set to: " + material);
    }

    /**
     * Gets the trigger material.
     *
     * @return The material of the trigger.
     */
    public String GetTriggerMaterial() {
        return trigger.GetMaterial();
    }

    /**
     * Sets the manufacture year and logs the action.
     *
     * @param year The year to set.
     */
    public void SetManufactureYear(int year) {
        calendar.set(GregorianCalendar.YEAR, year);  // Sets the manufacturing year
        log("Manufacture year set to: " + year);
    }

    /**
     * Gets the manufacture year.
     *
     * @return The manufacture year.
     */
    public int GetManufactureYear() {
        return calendar.get(GregorianCalendar.YEAR);  // Gets the manufacturing year
    }

    /**
     * Properly closes the logger.
     */
    public void close_log() {
        if (logger != null) {
            logger.close();
            log("Logger closed.");
        }
    }

    /**
     * Safely shuts down the logger.
     */
    public void shutdown() {
        try {
            close_log();  // Closes the logger
        } catch (Exception e) {
            System.err.println("Error during shutdown: " + e.getMessage());
        }
    }

    /**
     * Refills the water gun and logs the action.
     */
    public void RefillWater() {
        log("Water gun refilled.");
    }

    /**
     * Checks if the water gun has water.
     *
     * @return true if the water level is above 0, false otherwise.
     */
    public boolean HasWater() {
        log("Checked if water gun has water.");
        return false;  // Replace with actual water check logic
    }
}
