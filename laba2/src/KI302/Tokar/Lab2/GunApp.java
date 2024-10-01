package KI302.Tokar.Lab2;

public class GunApp {
    public static void main(String[] args) {
        Gun gun = new Gun();

        try {
            gun.Shoot();
            gun.Reload();
            gun.SetBarrelCaliber(7.62);
            gun.SetTriggerMaterial("Steel");
            gun.SetManufactureYear(2022);

            System.out.println("Gun Model: " + gun.GetModel());
            System.out.println("Barrel Caliber: " + gun.GetBarrelCaliber());
            System.out.println("Trigger Material: " + gun.GetTriggerMaterial());
            System.out.println("Manufacture Year: " + gun.GetManufactureYear());

            gun.close_log();
        } finally {
            gun.shutdown();
        }
    }
}
