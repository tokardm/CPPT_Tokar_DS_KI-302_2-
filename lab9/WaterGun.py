# gun_package/water_gun.py

from lab9.Gun import Gun

class WaterGun(Gun):
    """
    Клас Водяний пістолет, що наслідується від класу Gun.
    """

    def __init__(self, water_capacity=10):
        """
        Ініціалізує водяний пістолет з певною кількістю води.
        
        Параметри:
        water_capacity -- початкова кількість води у резервуарі (за замовчуванням 10)
        """
        super().__init__(ammo_capacity=0)  # Водяний пістолет не має патронів
        self.water_capacity = water_capacity
        self.current_water = water_capacity

    def reload(self):
        """
        Перезаповнює водяний пістолет до максимальної кількості води.
        """
        self.current_water = self.water_capacity
        print("Водяний пістолет перезаповнено.")

    def shoot(self):
        """
        Робить один постріл водою, зменшуючи кількість води.
        """
        if self.current_water > 0:
            self.current_water -= 1
            print("Водяний постріл! Залишилось води:", self.current_water)
        else:
            print("Немає води! Потрібне перезаповнення.")
