string[] array = new string[] { "hello", "2", "world", ":-)" };
PrintArray(FilterArray(array));

string[] FilterArray(string[] array) {
    int countArray = 0;
    for (int i = 0; i < array.Length; i++) {
        if(array[i].Length <= 3) {
            countArray++;
        }
    }
    int count = 0;
    string[] result = new string[countArray];
    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length <= 3) {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}
