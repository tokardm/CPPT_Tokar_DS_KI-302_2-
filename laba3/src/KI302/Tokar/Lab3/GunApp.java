package KI302.Tokar.Lab3;

/**
 * Main application class for demonstrating the WaterGun functionality.
 */
public class GunApp {
    public static void main(String[] args) {
        WaterGun waterGun = new WaterGun();

        try {
            waterGun.Shoot();
            waterGun.Reload();
            waterGun.RefillWater();
            waterGun.Shoot();
            waterGun.SetBarrelCaliber(0.5);
            waterGun.SetTriggerMaterial("Plastic");
            waterGun.SetManufactureYear(2023);

            System.out.println("WaterGun Model: " + waterGun.GetModel());
            System.out.println("Barrel Caliber: " + waterGun.GetBarrelCaliber());
            System.out.println("Trigger Material: " + waterGun.GetTriggerMaterial());
            System.out.println("Manufacture Year: " + waterGun.GetManufactureYear());
            System.out.println("Water Level: " + waterGun.GetWaterLevel());

            waterGun.close_log();
        } finally {
            waterGun.shutdown();
        }
    }
}
