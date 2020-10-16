using System;

class MainClass {

  public static void verificaImpostor(int valor) {
    string convertido;
    int limite = 0;
    int individual;
    int total;
    bool verificador = true;
    int novoValor = 0;
    int j = 0;

    while (true) {

       total = 0;

      if (j == 0) {
        convertido = valor.ToString();
        limite = convertido.Length;

        for(int i = 0 ; i < limite ; i++) {                  
          individual = Convert.ToInt32(convertido[i])  - 48;
          total = total + (individual*individual);
          novoValor = total;
        }
      } else {    
          convertido = novoValor.ToString();
          limite = convertido.Length;
          novoValor = 0;

          for(int i = 0 ; i < limite ; i++) {
            individual = Convert.ToInt32(convertido[i]) - 48;
            total = total + (individual*individual);
            novoValor = total;
          }
    }
    
    Console.WriteLine(novoValor);
    
    if (total == 1) {
        verificador = false;
        break;
    }
    if (j > 30) {
      break;
    }
    j++;
  }

  if (verificador == false){
        Console.WriteLine("O número {0} é um impostor",valor);
      } else {
        Console.WriteLine("Número válido {0}",valor);
      }
}

  public static void Main () {
    int valor;

    Console.WriteLine("Digite um número inteiro:");
    valor = int.Parse(Console.ReadLine());

    verificaImpostor(valor);
  }
}