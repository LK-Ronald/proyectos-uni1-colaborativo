import 'dart:async';

void main() {
  List<int> enteros = [3, 4, 76, 4, 23, 35, 65, 67, 87, 23];

  int x = 1;
  bool fueEncontrado = false;
  int indice = 0;

  for (int i = 0; i < enteros.length; i++) {
    if (enteros[i] == x) {
      fueEncontrado = true;
      indice = i;
    }
  }

  fueEncontrado
      ? print('Fue encontrado en el indice $indice')
      : print('No se encontro el numero $x');
}
