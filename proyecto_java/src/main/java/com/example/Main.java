package com.example;

public class Main {
    public static void main(String[] args) {

        int[][] matriz = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
        };

        String mostrarMatriz = "";

        int[] temporal = matriz[0];
        matriz[0] = matriz[2];
        matriz[2] = temporal;

        for (int x = 0; x < matriz.length; x++) {
            for (int y = 0; y < matriz[x].length; y++) {
                mostrarMatriz = mostrarMatriz + " " + matriz[x][y];
            }
            mostrarMatriz = mostrarMatriz + "\n";
        }

        System.out.println(mostrarMatriz);

    }
}