package KI302.Tokar.Lab6;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

/**
 * Параметризований клас, що реалізує предметну область "Бак для сміття".
 * @param <T> тип елементів у баку
 */
public class TrashBin<T> {
    private List<T> items;
    private Comparator<T> comparator;

    /**
     * Конструктор за замовчуванням для класу TrashBin.
     * @param comparator компаратор для порівняння елементів
     */
    public TrashBin(Comparator<T> comparator) {
        this.items = new ArrayList<>();
        this.comparator = comparator;
    }

    /**
     * Додає елемент у бак.
     * @param item елемент для додавання
     */
    public void addItem(T item) {
        items.add(item);
        System.out.println("Added: " + item);
    }

    /**
     * Видаляє елемент з бака.
     * @param item елемент для видалення
     */
    public void removeItem(T item) {
        items.remove(item);
        System.out.println("Removed: " + item);
    }

    /**
     * Повертає мінімальний елемент у баку.
     * @return мінімальний елемент
     */
    public T findMin() {
        return items.stream().min(comparator).orElse(null);
    }

    /**
     * Повертає максимальний елемент у баку.
     * @return максимальний елемент
     */
    public T findMax() {
        return items.stream().max(comparator).orElse(null);
    }
}
