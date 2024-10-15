package KI302.Tokar.Lab3;

import java.util.GregorianCalendar;

/**
 * Class representing a water gun, which is a specific type of gun.
 * It extends the Gun class.
 */
public class WaterGun extends Gun {
    private static int waterLevel;

    /**
     * Constructor for WaterGun.
     * @param model The model of the water gun.
     * @param barrel The barrel of the water gun.
     * @param trigger The trigger of the water gun.
     * @param calendar The calendar (manufacturing date) of the water gun.
     * @param waterLevel The initial water level.
     */
    public WaterGun(String model, Barrel barrel, Trigger trigger, GregorianCalendar calendar, int waterLevel) {
        super(model, barrel, trigger, calendar);
        WaterGun.waterLevel = waterLevel;
        log("WaterGun initialized with water level: " + waterLevel);
    }

    /**
     * Default constructor for WaterGun.
     */
    public WaterGun() {
        this("Super Soaker", new Barrel(), new Trigger(), new GregorianCalendar(2024, waterLevel, waterLevel), 100);
        log("Default WaterGun created with model: Super Soaker");
    }


    /**
     * Shoot water if there's enough water in the reservoir.
     */
    @Override
    public void Shoot() {
        if (HasWater()) {
            waterLevel -= 10; // Assume each shot uses 10 units of water
            log("WaterGun fired. Water level: " + waterLevel);
            System.out.println("Splash!");
        } else {
            log("WaterGun has no water.");
            System.out.println("No water!");
        }
    }

    /**
     * Refill the water gun.
     */
    @Override
    public void RefillWater() {
        waterLevel = 100; // Refill to full capacity
        log("WaterGun refilled to full capacity.");
        System.out.println("Water gun refilled.");
    }

    /**
     * Check if the water gun has water.
     * @return true if the water level is above 0, false otherwise.
     */
    @Override
    public boolean HasWater() {
        return waterLevel > 0;
    }

    /**
     * Get the current water level of the gun.
     * @return The current water level.
     */
    public int GetWaterLevel() {
        return waterLevel;
    }

    /**
     * Set the water level of the gun.
     * @param waterLevel The new water level.
     */
    public void SetWaterLevel(int waterLevel) {
        WaterGun.waterLevel = waterLevel;
        log("Water level set to: " + waterLevel);
    }

	@Override
	public void Shoot1() {
		// TODO Auto-generated method stub
		
	}
}
