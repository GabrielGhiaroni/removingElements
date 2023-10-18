  public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
          int tamanhoNovoArray = (arr.Length + 1) / 2;
          
          object[] novoArray = new object[tamanhoNovoArray];

          int novoIndex = 0;

          for (int i = 0; i < arr.Length; i += 2)
          {
              novoArray[novoIndex] = arr[i];
              novoIndex++;
          }

          return novoArray;
        }
    }
