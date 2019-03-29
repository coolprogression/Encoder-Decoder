using System;

class MainClass {
  public static void Main (string[] args) {
    
  
   Console.WriteLine(Encoding(0));
   Console.WriteLine(Decoding("00","00"));
  }

  /*   
    1) Adds 8192 to Given Value
    2) Converts Value to Binary/Unpack Bits
      
    3) Returns 4 Char Format/Encoded Hex Decimal
  */
   static string Encoding(int integ){

    integ = integ + 8192;
    ///0x3F80 1111111000000
   int upperbound = (integ & 0x3F80)<<1;

    //0x007F  0000000111111
    int lowerbound =  (integ & 0x007F);

   int result = upperbound + lowerbound;


   return result.ToString("X4");
  }


  /*   
    1) Converts String LB/HB into Bytes
    2) Returns Unencoded int
  */

  static int Decoding(String hb, String lb){
  
  
    byte lbn = Convert.ToByte(lb, 16);
    byte hbn = Convert.ToByte(hb, 16);

    //shifts Left 7 bits
    int result = ((int)(lbn + (hbn << 7))-8192);


    return result;

  }
}
