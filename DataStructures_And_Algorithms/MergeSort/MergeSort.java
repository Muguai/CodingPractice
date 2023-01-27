public class MergeSort {
    public static void sort(int[] array) {
        if (array.length <= 1) {
            return;
        }

        int middle = array.length / 2;
        int[] left = new int[middle];
        int[] right = new int[array.length - middle];

        for (int i = 0; i < middle; i++) {
            left[i] = array[i];
        }
        for (int i = middle; i < array.length; i++) {
            right[i - middle] = array[i];
        }

        sort(left);
        sort(right);

        merge(array, left, right);
    }

    private static void merge(int[] array, int[] left, int[] right) {
        int leftIndex = 0;
        int rightIndex = 0;
        int arrayIndex = 0;

        while (leftIndex < left.length && rightIndex < right.length) {
            if (left[leftIndex] < right[rightIndex]) {
                array[arrayIndex] = left[leftIndex];
                leftIndex++;
            } else {
                array[arrayIndex] = right[rightIndex];
                rightIndex++;
            }
            arrayIndex++;
        }

        while (leftIndex < left.length) {
            array[arrayIndex] = left[leftIndex];
            leftIndex++;
            arrayIndex++;
        }

        while (rightIndex < right.length) {
            array[arrayIndex] = right[rightIndex];
            rightIndex++;
            arrayIndex++;
        }
    }
}