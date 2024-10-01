package KI302.Tokar.Lab2;

import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;


/**
 * A class representing a Gun with components such as Barrel, Trigger, and Calendar.
 */
public class Gun {
    private String model;
    private Barrel barrel;
    private Trigger trigger;
    private Calendar calendar;
    private PrintWriter logger;

    /**
     * Constructor with parameters.
     * @param model The model of the gun.
     * @param barrel The barrel of the gun.
     * @param trigger The trigger of the gun.
     * @param calendar The calendar (manufacturing date) of the gun.
     */
    public Gun(String model, Barrel barrel, Trigger trigger, Calendar calendar) {
        this.model = model;
        this.barrel = barrel;
        this.trigger = trigger;
        this.calendar = calendar;
        init_log();
        log("Gun initialized with model: " + model);
    }

    /**
     * Default constructor.
     * Creates a default gun with predefined model, barrel, trigger, and calendar.
     */
    public Gun() {
        this("Glock-17", new Barrel(9.0), new Trigger("Metal"), new Calendar(2024));
        init_log();
        log("Default Gun created with model: Glock-17");
    }

    /**
     * Initializes the logger for writing logs to a file.
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
     * @param message The message to be logged.
     */
    public void log(String message) {
        if (logger != null) {
            logger.println(message);
        }
    }

    /**
     * Simulates shooting the gun.
     */
    public void Shoot() {
        log("Gun fired.");
        System.out.println("Bang!");
    }

    /**
     * Simulates reloading the gun.
     */
    public void Reload() {
        log("Gun reloaded.");
        System.out.println("Reloading...");
    }

    /**
     * Sets the model of the gun.
     * @param model The new model of the gun.
     */
    public void SetModel(String model) {
        this.model = model;
        log("Model set to: " + model);
    }

    /**
     * Gets the model of the gun.
     * @return The model of the gun.
     */
    public String GetModel() {
        return model;
    }

    /**
     * Sets the caliber of the gun's barrel.
     * @param caliber The new caliber of the barrel.
     */
    public void SetBarrelCaliber(double caliber) {
        barrel.SetCaliber(caliber);
        log("Barrel caliber set to: " + caliber);
    }

    /**
     * Gets the caliber of the gun's barrel.
     * @return The caliber of the barrel.
     */
    public double GetBarrelCaliber() {
        return barrel.GetCaliber();
    }

    /**
     * Sets the material of the gun's trigger.
     * @param material The new material of the trigger.
     */
    public void SetTriggerMaterial(String material) {
        trigger.SetMaterial(material);
        log("Trigger material set to: " + material);
    }

    /**
     * Gets the material of the gun's trigger.
     * @return The material of the trigger.
     */
    public String GetTriggerMaterial() {
        return trigger.GetMaterial();
    }

    /**
     * Sets the manufacturing year of the gun.
     * @param year The new manufacturing year of the gun.
     */
    public void SetManufactureYear(int year) {
        calendar.SetYear(year);
        log("Manufacture year set to: " + year);
    }

    /**
     * Gets the manufacturing year of the gun.
     * @return The manufacturing year of the gun.
     */
    public int GetManufactureYear() {
        return calendar.GetYear();
    }

    /**
     * Properly closes the log file.
     */
    public void close_log() {
        if (logger != null) {
            logger.close();
        }
    }

    /**
     * Safely shuts down the gun's system and closes the log file.
     */
    public void shutdown() {
        try {
        } finally {
            close_log();
        }
    }
}

/**
 * A class representing the Barrel of the gun.
 */
class Barrel {
    private double caliber;

    /**
     * Constructor for Barrel.
     * @param caliber The caliber of the barrel.
     */
    public Barrel(double caliber) {
        this.caliber = caliber;
    }

    /**
     * Sets the caliber of the barrel.
     * @param caliber The new caliber of the barrel.
     */
    public void SetCaliber(double caliber) {
        this.caliber = caliber;
    }

    /**
     * Gets the caliber of the barrel.
     * @return The caliber of the barrel.
     */
    public double GetCaliber() {
        return caliber;
    }
}

/**
 * A class representing the Trigger of the gun.
 */
class Trigger {
    private String material;

    /**
     * Constructor for Trigger.
     * @param material The material of the trigger.
     */
    public Trigger(String material) {
        this.material = material;
    }

    /**
     * Sets the material of the trigger.
     * @param material The new material of the trigger.
     */
    public void SetMaterial(String material) {
        this.material = material;
    }

    /**
     * Gets the material of the trigger.
     * @return The material of the trigger.
     */
    public String GetMaterial() {
        return material;
    }
}

/**
 * A class representing the Calendar (manufacturing year) of the gun.
 */
class Calendar {
    private int year;

    /**
     * Constructor for Calendar.
     * @param year The manufacturing year of the gun.
     */
    public Calendar(int year) {
        this.year = year;
    }

    /**
     * Sets the manufacturing year.
     * @param year The new manufacturing year.
     */
    public void SetYear(int year) {
        this.year = year;
    }

    /**
     * Gets the manufacturing year.
     * @return The manufacturing year of the gun.
     */
    public int GetYear() {
        return year;
    }
}
