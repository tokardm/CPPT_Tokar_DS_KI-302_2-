class Gun:
    """
    Базовий клас Пістолет.
    """

    def __init__(self, ammo_capacity=10):
        """
        Ініціалізує пістолет з певною кількістю патронів.
        
        Параметри:
        ammo_capacity -- початкова кількість патронів у магазині (за замовчуванням 10)
        """
        self.ammo_capacity = ammo_capacity
        self.current_ammo = ammo_capacity

    def reload(self):
        """
        Перезаряджає пістолет до максимальної кількості патронів.
        """
        self.current_ammo = self.ammo_capacity
        print("Пістолет перезаряджено.")

    def shoot(self):
        """
        Робить один постріл, зменшуючи кількість патронів.
        """
        if self.current_ammo > 0:
            self.current_ammo -= 1
            print("Постріл! Залишилось патронів:", self.current_ammo)
        else:
            print("Немає патронів! Потрібна перезарядка.")
