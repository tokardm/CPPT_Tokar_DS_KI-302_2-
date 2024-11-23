package KI302.Tokar.Lab6;

/**
 * Клас Paper представляє тип даних "Папір" для TrashBin.
 */
public class Paper implements TrashItem {
    private String type;
    private int weight;

    public Paper(String type, int weight) {
        this.type = type;
        this.weight = weight;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public int getWeight() {
        return weight;
    }

    public void setWeight(int weight) {
        this.weight = weight;
    }

    @Override
    public void print() {
        System.out.println("Paper [type=" + type + ", weight=" + weight + "]");
    }

    @Override
    public String toString() {
        return "Paper [type=" + type + ", weight=" + weight + "]";
    }
}
