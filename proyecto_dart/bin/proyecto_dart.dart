void main() {
  List<int> enteros = [3, 4, 76, 4, 23, 35, 65, 67, 87, 23];

  for (int i = 0; i < enteros.length; i++) {
    if (enteros[i] % 2 != 0) {
      enteros[i] = 0;
    }
  }
  for (int i in enteros) {
    print(i);
  }
}
