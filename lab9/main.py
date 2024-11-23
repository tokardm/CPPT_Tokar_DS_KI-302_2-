# Main.py
from lab9.Gun import Gun
from lab9.Watergun import WaterGun

def main():
    gun = Gun(ammo_capacity=5)
    print("Звичайний пістолет:")
    gun.shoot()
    gun.shoot()
    gun.reload()
    gun.shoot()
    
    print("\n")

    water_gun = WaterGun(water_capacity=3)
    print("Водяний пістолет:")
    water_gun.shoot()
    water_gun.shoot()
    water_gun.shoot()
    water_gun.shoot()
    water_gun.reload()
    water_gun.shoot()

if __name__ == "__main__":
    main()
