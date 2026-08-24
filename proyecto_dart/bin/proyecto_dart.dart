void main() {
  List<List<int>> matriz = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9],
  ];

  int suma = 0;

  for (int y = 0; y < matriz[0].length; y++) {
    for (int x = 0; x < matriz.length; x++) {
      suma += matriz[x][y];
    }
  }

  print(suma);
}
